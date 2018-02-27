using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MJ_SmartLoRaWANNodeConfigTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                    returnStr += ' ';
                }
            }
            return returnStr;
        }

        private static byte[] strToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        private void texfirewareversion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialportlist.SelectedIndex = serialportlist.Items.IndexOf("-请选择端口-");
            comboxactivatymethod.SelectedIndex = comboxactivatymethod.Items.IndexOf("OTAA");
            comboxnodetype.SelectedIndex = comboxnodetype.Items.IndexOf("Class A");
            if (comboxnodetype.SelectedIndex == comboxnodetype.Items.IndexOf("Class A"))
            {
                abpactivaty.Enabled = false;
            }
            else
            {
                otaaactivaty.Enabled = false;
            }
            texboxsendcnt.Text = Convert.ToString(0);
            texboxreceivecnt.Text = Convert.ToString(0);
            if(texfirewareversion.Text != "设备未连接")
            {
                simulatecomunication.Enabled = true;
            }
            else
            {
                simulatecomunication.Enabled = false;
            }
            
        }

        private void comboxactivatymethod_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void comboxactivatymethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxactivatymethod.SelectedIndex == comboxactivatymethod.Items.IndexOf("OTAA"))
            {
                abpactivaty.Enabled = false;
                otaaactivaty.Enabled = true;
            }
            if (comboxactivatymethod.SelectedIndex == comboxactivatymethod.Items.IndexOf("ABP"))
            {
                otaaactivaty.Enabled = false;
                abpactivaty.Enabled = true;
            }
        }

        private void comlist_MouseClick(object sender, MouseEventArgs e)
        {
            SerialPort com = new SerialPort("COM1");

            string[] portlist = SerialPort.GetPortNames();
            for (int i = 0; i < portlist.Length; i++)
            {
                if (-1 == serialportlist.FindString(portlist[i]))
                {
                    serialportlist.Items.Add(portlist[i]);
                }
                if (i == 0)
                {
                    serialportlist.Text = portlist[i];
                }
            }

            //System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            serialportlist.Show();
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string stringreceived;

            //System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            try
            {
                stringreceived = serialPort.ReadLine();
                //cmd = System.Text.Encoding.ASCII.GetBytes(strcmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();
                simulatecomunication.Enabled = false;
                return;
            }
            if(stringreceived == null)
            {
                return;
            }
            //stringreceived = stringreceived.Insert(stringreceived.Length, "\r\n");
            richtexboxreceive.Text += stringreceived;
            richtexboxreceive.Text += "\r\n";
            if (stringreceived.IndexOf("VERSION") >= 0)
            {
                stringreceived = stringreceived.Remove(0, 3);
                texfirewareversion.Text = stringreceived;
                simulatecomunication.Enabled = true;
            }
            string[] sArray = stringreceived.Split(new char[1] { ',' });
            int stringcnt = 0;
            foreach (string str in sArray)
            {
                stringcnt++;
                //int indexofcl;
                //indexofcl = str.IndexOf("\r\n");
                //if (indexofcl >= 0)
                //{
                //    str.Remove(indexofcl,2);
                //}
                //richtexboxreceive.Text += str;
                //richtexboxreceive.Text += "\r\n";
                //richtexboxreceive.Text += str.Length.ToString();
                //richtexboxreceive.Text += "\r\n";
            }
            if ((stringcnt == 5) && (sArray[0] == "OK") && (sArray[1].Length == 2) && (sArray[2].Length == 2) && (sArray[3].Length == 2) && (sArray[4].Length == 2))
            {
                textBoxstartchannel.Text = byteToHexStr(strToToHexByte(sArray[1]));
                texboxendchannel.Text = byteToHexStr(strToToHexByte(sArray[2]));
                switch (sArray[3])
                {
                    case "00":
                        comboxnodetype.SelectedIndex = 0;
                        break;
                    case "02":
                        comboxnodetype.SelectedIndex = 2;
                        break;
                    default:
                        break;

                }
                string activatymethod = sArray[4];
                switch (activatymethod)
                {
                    case "01":
                        comboxactivatymethod.SelectedIndex = 1;
                        break;
                    case "02":
                        comboxactivatymethod.SelectedIndex = 2;
                        break;
                    default:
                        break;

                }
            }
            if ((stringcnt == 3) && (sArray[0] == "OK") && (sArray[1].Length == 16) && (sArray[2].Length == 16))
            {
                texboxdeviceeui.Text = byteToHexStr(strToToHexByte(sArray[1]));
                texboxappeui.Text = byteToHexStr(strToToHexByte(sArray[2]));
            }

            if ((stringcnt == 5) && (sArray[0] == "OK") && (sArray[1].Length == 8) && (sArray[2].Length == 8) && (sArray[3].Length == 8) && (sArray[4].Length == 8))
            {
                texboxnetid.Text = byteToHexStr(strToToHexByte(sArray[1]));
                texboxdevaddress.Text = byteToHexStr(strToToHexByte(sArray[2]));
                //texboxnwkkey.Text = byteToHexStr(strToToHexByte(sArray[3]));
                //texboxappkey.Text = byteToHexStr(strToToHexByte(sArray[4].Remove(8,2)));
            }
            if ((sArray[0] == "EV_TXCOMPLETE") && (sArray[1] != "00"))
            {
                int inttexboxreceivecnt = Convert.ToInt32(texboxreceivecnt.Text);
                inttexboxreceivecnt++;
                texboxreceivecnt.Text = Convert.ToString(inttexboxreceivecnt);
            }
            /*if (stringreceived.IndexOf("EV_TXCOMPLETE") >= 0)
            {
                stringreceived = stringreceived.Remove(0, "EV_TXCOMPLETE,".Length);
                if (stringreceived.IndexOf("00") < 0)
                {
                    int inttexboxreceivecnt = Convert.ToInt32(texboxreceivecnt.Text);
                    inttexboxreceivecnt++;
                    texboxreceivecnt.Text = Convert.ToString(inttexboxreceivecnt);
                }
            }*/
            if (stringreceived.IndexOf("EV_RXCOMPLETE") >= 0)
            {
                int inttexboxreceivecnt = Convert.ToInt32(texboxreceivecnt.Text);
                inttexboxreceivecnt++;
                texboxreceivecnt.Text = Convert.ToString(inttexboxreceivecnt);
            }
        }

        private void setglobalparameter()
        {
            string simulatesendstring = null;

            simulatesendstring = "ATG=";
            string hexstartchannel = textBoxstartchannel.Text.Replace(" " ,"");
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, hexstartchannel);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, ",");

            string hexendchannel = texboxendchannel.Text.Replace(" " ,"");
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, hexendchannel);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, ",");

            string hexnodetype;
            switch (comboxnodetype.Text)
            {
                case "Class A":
                    hexnodetype = "00";
                    simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, hexnodetype);
                    break;
                case "Class C":
                    hexnodetype = "02";
                    simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, hexnodetype);
                    break;
                default:
                    hexnodetype = "00";
                    break;
            }
            
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, "\r\n");
            byte[] syncbyte = Enumerable.Repeat((byte)0xff, 10).ToArray();
            byte[] datatosend;
            byte[] cmdbyte;

            syncbyte[9] = 0x55;
            cmdbyte = null;
            datatosend = null;
            cmdbyte = new byte[256 * 4];
            datatosend = new byte[256 * 4];
            Array.Copy(syncbyte, datatosend, syncbyte.Length);
            cmdbyte = System.Text.Encoding.Default.GetBytes(simulatesendstring);
            Array.Copy(cmdbyte, 0, datatosend, syncbyte.Length, cmdbyte.Length);
            try
            {
                serialPort.Write(syncbyte, 0, syncbyte.Length);
                serialPort.Write(cmdbyte, 0, cmdbyte.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();
                simulatecomunication.Enabled = false;
                return;
            }
            richtexboxreceive.Text += simulatesendstring;
        }
        private void getdeviceinfo()
        {
            byte[] syncbyte = Enumerable.Repeat((byte)0xff, 10).ToArray();
            byte[] datatosend;
            byte[] cmdbyte;

            if (!serialPort.IsOpen)
            {
                return ;
            }

            syncbyte[9] = 0x55;

            cmdbyte = null;
            datatosend = null;
            cmdbyte = new byte[256 * 4];
            datatosend = new byte[256 * 4];
            Array.Copy(syncbyte, datatosend, syncbyte.Length);
            cmdbyte = System.Text.Encoding.Default.GetBytes("AT\r\n");
            richtexboxreceive.Text += "AT\r\n";
            Array.Copy(cmdbyte, 0, datatosend, syncbyte.Length, cmdbyte.Length);
            try
            {
                serialPort.Write(syncbyte, 0, syncbyte.Length);
                serialPort.Write(cmdbyte, 0, cmdbyte.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();
                simulatecomunication.Enabled = false;
                return;
            }
            System.Threading.Thread.Sleep(200);
            cmdbyte = null;
            datatosend = null;
            cmdbyte = new byte[256 * 4];
            datatosend = new byte[256 * 4];
            Array.Copy(syncbyte, datatosend, syncbyte.Length);
            cmdbyte = System.Text.Encoding.Default.GetBytes("ATV?\r");
            richtexboxreceive.Text += "ATV?\r";
            Array.Copy(cmdbyte, 0, datatosend, syncbyte.Length, cmdbyte.Length);
            try
            {
                serialPort.Write(datatosend, 0, datatosend.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();
                simulatecomunication.Enabled = false;
                return;
            }
            System.Threading.Thread.Sleep(200);
            cmdbyte = null;
            datatosend = null;
            cmdbyte = new byte[256 * 4];
            datatosend = new byte[256 * 4];
            Array.Copy(syncbyte, datatosend, syncbyte.Length);
            cmdbyte = System.Text.Encoding.Default.GetBytes("ATG?\r");
            richtexboxreceive.Text += "ATG?\r";
            Array.Copy(cmdbyte, 0, datatosend, syncbyte.Length, cmdbyte.Length);
            try
            {
                serialPort.Write(syncbyte, 0, syncbyte.Length);
                serialPort.Write(cmdbyte, 0, cmdbyte.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();
                simulatecomunication.Enabled = false;
                return;
            }
            System.Threading.Thread.Sleep(200);
            cmdbyte = null;
            datatosend = null;
            cmdbyte = new byte[256 * 4];
            datatosend = new byte[256 * 4];
            Array.Copy(syncbyte, datatosend, syncbyte.Length);
            cmdbyte = System.Text.Encoding.Default.GetBytes("ATJ?\r");
            richtexboxreceive.Text += "ATJ?\r";
            Array.Copy(cmdbyte, 0, datatosend, syncbyte.Length, cmdbyte.Length);
            try
            {
                serialPort.Write(syncbyte, 0, syncbyte.Length);
                serialPort.Write(cmdbyte, 0, cmdbyte.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();
                simulatecomunication.Enabled = false;
                return;
            }
            System.Threading.Thread.Sleep(200);
            cmdbyte = null;
            datatosend = null;
            cmdbyte = new byte[256 * 4];
            datatosend = new byte[256 * 4];
            Array.Copy(syncbyte, datatosend, syncbyte.Length);
            cmdbyte = System.Text.Encoding.Default.GetBytes("ATS?\r\n");
            richtexboxreceive.Text += "ATS?\r\n";
            Array.Copy(cmdbyte, 0, datatosend, syncbyte.Length, cmdbyte.Length);
            try
            {
                serialPort.Write(syncbyte, 0, syncbyte.Length);
                serialPort.Write(cmdbyte, 0, cmdbyte.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();
                simulatecomunication.Enabled = false;
                return;
            }

        }

        private void serialportlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void connect_MouseClick(object sender, MouseEventArgs e)
        {
            //if (texfirewareversion.Text != "设备未连接")
            if(serialPort.IsOpen == true)
            {
                simulatecomunication.Enabled = true;
                getdeviceinfo();
            }
            else
            {
                simulatecomunication.Enabled = false;
                if (serialportlist.SelectedItem == null)
                    return;
                if (serialportlist.Text != "-请选择端口-")
                {
                    serialPort.PortName = serialportlist.SelectedItem.ToString();
                    serialPort.BaudRate = 115200;
                    serialPort.DataBits = 8;
                    serialPort.StopBits = StopBits.One;
                    serialPort.Parity = Parity.None;
                    serialPort.NewLine = "\r\n";
                    try
                    {
                        serialPort.Open();
                        if (serialPort.IsOpen)
                        {
                            simulatecomunication.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        serialPort.Close();
                        simulatecomunication.Enabled = false;
                        return;
                    }
                    getdeviceinfo();
                }
            }
        }

        private void richtexboxreceive_TextChanged(object sender, EventArgs e)
        {
            richtexboxreceive.SelectionStart = richtexboxreceive.Text.Length; //Set the current caret position at the end
            richtexboxreceive.ScrollToCaret(); //Now scroll it automatically
        }

        private void checkboxhex_CheckedChanged(object sender, EventArgs e)
        {
            byte[] simulatesendbyte = null;
            string simulatesendstring = null;

            if (checkboxhex.Checked == true)
            {
                simulatesendbyte = System.Text.Encoding.Default.GetBytes(richtexboxsend.Text);
                simulatesendstring = byteToHexStr(simulatesendbyte);
                richtexboxsend.Text = simulatesendstring;
            }
            else
            {

                simulatesendbyte = strToToHexByte(richtexboxsend.Text);
                simulatesendstring = System.Text.Encoding.Default.GetString(simulatesendbyte);
                richtexboxsend.Text = simulatesendstring;
            }
        }

        private void serialportlist_SelectionChangeCommitted(object sender, EventArgs e)
        {
            serialPort.Close();
            if (serialportlist.SelectedItem == null)
                return;
            if (serialportlist.Text != "-请选择端口-")
            {
                serialPort.PortName = serialportlist.SelectedItem.ToString();
                serialPort.BaudRate = 115200;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Parity = Parity.None;
                serialPort.NewLine = "\r\n";
                try
                {
                    serialPort.Open();
                    if (serialPort.IsOpen)
                    {
                        //serialPort.WriteLine("fdsa");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    serialPort.Close();
                    simulatecomunication.Enabled = false;
                    return;
                }
                getdeviceinfo();
            }
        }

        private void senddata_MouseClick(object sender, MouseEventArgs e)
        {
            byte[] simulatesendbyte = null;
            string simulatesendstring = null;
            string simulatesenddata = null;

            if (checkboxconfirm.Checked)
            {
                simulatesendstring = "ATT1,";
            }
            else
            {
                simulatesendstring = "ATT0,";
            }

            int inttexboxport = Convert.ToInt32(texboxport.Text);
            byte[] hexbytes = BitConverter.GetBytes(inttexboxport);
            string hexport = byteToHexStr(hexbytes);
            hexport = hexport.Replace(" ", "");
            hexport = hexport.Replace("00", "");
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, hexport);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, ",");

            if (checkboxhex.Checked == true)
            {
                simulatesenddata = richtexboxsend.Text;
                simulatesenddata = simulatesenddata.Replace(" ", "");
            }
            else
            {

                simulatesendbyte = System.Text.Encoding.Default.GetBytes(richtexboxsend.Text);
                simulatesenddata = byteToHexStr(simulatesendbyte);
                simulatesenddata = simulatesenddata.Replace(" ", "");
            }

            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, simulatesenddata);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, "\r\n");
            richtexboxreceive.Text += simulatesendstring;
            byte[] syncbyte = Enumerable.Repeat((byte)0xff, 25).ToArray();
            byte[] datatosend;
            byte[] cmdbyte;

            syncbyte[24] = 0x55;
            cmdbyte = null;
            datatosend = null;
            cmdbyte = new byte[256 * 4];
            datatosend = new byte[256 * 4];
            Array.Copy(syncbyte, datatosend, syncbyte.Length);
            cmdbyte = System.Text.Encoding.Default.GetBytes(simulatesendstring);
            Array.Copy(cmdbyte, 0, datatosend, syncbyte.Length, cmdbyte.Length);
            try
            {
                serialPort.Write(datatosend, 0, datatosend.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();
                simulatecomunication.Enabled = false;
                return;
            }
            int inttexboxsendcnt = Convert.ToInt32(texboxsendcnt.Text);
            inttexboxsendcnt++;
            texboxsendcnt.Text = Convert.ToString(inttexboxsendcnt);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            richtexboxreceive.Clear();
            texboxsendcnt.Text = Convert.ToString(0);
            texboxreceivecnt.Text = Convert.ToString(0);
        }

        private void factoryreset_Click(object sender, EventArgs e)
        {
            byte[] syncbyte = Enumerable.Repeat((byte)0xff, 25).ToArray();
            byte[] datatosend;
            byte[] cmdbyte;

            if (!serialPort.IsOpen)
            {
                return ;
            }

            syncbyte[24] = 0x55;

            cmdbyte = null;
            datatosend = null;
            cmdbyte = new byte[256 * 4];
            datatosend = new byte[256 * 4];
            Array.Copy(syncbyte, datatosend, syncbyte.Length);
            cmdbyte = System.Text.Encoding.Default.GetBytes("AT&F\r\n");
            richtexboxreceive.Text += "AT&F\r\n";
            Array.Copy(cmdbyte, 0, datatosend, syncbyte.Length, cmdbyte.Length);
            try
            {
                serialPort.Write(datatosend,0,datatosend.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();
                simulatecomunication.Enabled = false;
                return;
            }
        }

        private void otaaconfigwrite_Click(object sender, EventArgs e)
        {
            byte[] simulatesendbyte = null;
            string simulatesendstring = null;
            //string simulatesenddata = null;

            simulatesendstring = "ATJ=";
            simulatesendbyte = strToToHexByte(texboxdeviceeui.Text);
            texboxdeviceeui.Text = byteToHexStr(simulatesendbyte);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, texboxdeviceeui.Text);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, ",");
            simulatesendbyte = strToToHexByte(texboxappeui.Text);
            texboxappeui.Text = byteToHexStr(simulatesendbyte);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, texboxappeui.Text);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, ",");
            simulatesendbyte = strToToHexByte(texboxdevicekey.Text);
            texboxdevicekey.Text = byteToHexStr(simulatesendbyte);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, texboxdevicekey.Text);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, "\r\n");
            simulatesendstring = simulatesendstring.Replace(" ", "");
            richtexboxreceive.Text += simulatesendstring;
            byte[] syncbyte = Enumerable.Repeat((byte)0xff, 10).ToArray();
            byte[] datatosend;
            byte[] cmdbyte;

            syncbyte[9] = 0x55;
            cmdbyte = null;
            datatosend = null;
            cmdbyte = new byte[256 * 4];
            datatosend = new byte[256 * 4];
            Array.Copy(syncbyte, datatosend, syncbyte.Length);
            cmdbyte = System.Text.Encoding.Default.GetBytes(simulatesendstring);
            Array.Copy(cmdbyte, 0, datatosend, syncbyte.Length, cmdbyte.Length);
            try
            {
                serialPort.Write(datatosend, 0, datatosend.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();
                simulatecomunication.Enabled = false;
                return;
            }
            System.Threading.Thread.Sleep(100);
            setglobalparameter();
        }

        private void abpconfigwrite_Click(object sender, EventArgs e)
        {
            byte[] simulatesendbyte = null;
            string simulatesendstring = null;
            //string simulatesenddata = null;

            simulatesendstring = "ATS=";
            simulatesendbyte = strToToHexByte(texboxnetid.Text);
            texboxnetid.Text = byteToHexStr(simulatesendbyte);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, texboxnetid.Text);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, ",");

            simulatesendbyte = strToToHexByte(texboxdevaddress.Text);
            texboxdevaddress.Text = byteToHexStr(simulatesendbyte);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, texboxdevaddress.Text);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, ",");

            simulatesendbyte = strToToHexByte(texboxnwkkey.Text);
            texboxnwkkey.Text = byteToHexStr(simulatesendbyte);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, texboxnwkkey.Text);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, ",");

            simulatesendbyte = strToToHexByte(texboxappkey.Text);
            texboxappkey.Text = byteToHexStr(simulatesendbyte);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, texboxappkey.Text);
            simulatesendstring = simulatesendstring.Insert(simulatesendstring.Length, "\r\n");
            simulatesendstring = simulatesendstring.Replace(" ", "");
            richtexboxreceive.Text += simulatesendstring;
            byte[] syncbyte = Enumerable.Repeat((byte)0xff, 10).ToArray();
            byte[] datatosend;
            byte[] cmdbyte;

            syncbyte[9] = 0x55;
            cmdbyte = null;
            datatosend = null;
            cmdbyte = new byte[256 * 4];
            datatosend = new byte[256 * 4];
            Array.Copy(syncbyte, datatosend, syncbyte.Length);
            cmdbyte = System.Text.Encoding.Default.GetBytes(simulatesendstring);
            Array.Copy(cmdbyte, 0, datatosend, syncbyte.Length, cmdbyte.Length);
            try
            {
                serialPort.Write(datatosend, 0, datatosend.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();
                simulatecomunication.Enabled = false;
                return;
            }
            System.Threading.Thread.Sleep(100);
            setglobalparameter();
        }

        private void disconnect_MouseClick(object sender, MouseEventArgs e)
        {
            serialPort.Close();
            texfirewareversion.Text = "设备未连接";
            if (texfirewareversion.Text != "设备未连接")
            {
                simulatecomunication.Enabled = true;
            }
            else
            {
                simulatecomunication.Enabled = false;
            }
        }

        private void reset_MouseClick(object sender, MouseEventArgs e)
        {
            byte[] syncbyte = Enumerable.Repeat((byte)0xff, 25).ToArray();
            byte[] datatosend;
            byte[] cmdbyte;

            if (!serialPort.IsOpen)
            {
                return;
            }

            syncbyte[24] = 0x55;

            cmdbyte = null;
            datatosend = null;
            cmdbyte = new byte[256 * 4];
            datatosend = new byte[256 * 4];
            Array.Copy(syncbyte, datatosend, syncbyte.Length);
            cmdbyte = System.Text.Encoding.Default.GetBytes("ATZ\r\n");
            richtexboxreceive.Text += "ATZ\r\n";
            Array.Copy(cmdbyte, 0, datatosend, syncbyte.Length, cmdbyte.Length);
            try
            {
                serialPort.Write(datatosend, 0, datatosend.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();
                simulatecomunication.Enabled = false;
                return;
            }
        }
    }
}

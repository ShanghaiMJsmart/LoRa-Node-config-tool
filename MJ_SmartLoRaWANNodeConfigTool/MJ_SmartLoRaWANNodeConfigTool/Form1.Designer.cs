namespace MJ_SmartLoRaWANNodeConfigTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.device = new System.Windows.Forms.GroupBox();
            this.comboxactivatymethod = new System.Windows.Forms.ComboBox();
            this.buttonactivat = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.factoryreset = new System.Windows.Forms.Button();
            this.texfirewareversion = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.serialportlist = new System.Windows.Forms.ComboBox();
            this.GlobaleParameter = new System.Windows.Forms.GroupBox();
            this.comboxnodetype = new System.Windows.Forms.ComboBox();
            this.texboxtimer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texboxendchannel = new System.Windows.Forms.TextBox();
            this.endchannel = new System.Windows.Forms.Label();
            this.nodetype = new System.Windows.Forms.Label();
            this.textBoxstartchannel = new System.Windows.Forms.TextBox();
            this.channelstart = new System.Windows.Forms.Label();
            this.otaaactivaty = new System.Windows.Forms.GroupBox();
            this.otaaconfigwrite = new System.Windows.Forms.Button();
            this.texboxdevicekey = new System.Windows.Forms.TextBox();
            this.texboxappeui = new System.Windows.Forms.TextBox();
            this.texboxdeviceeui = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.abpactivaty = new System.Windows.Forms.GroupBox();
            this.abpconfigwrite = new System.Windows.Forms.Button();
            this.texboxappkey = new System.Windows.Forms.TextBox();
            this.texboxnetid = new System.Windows.Forms.TextBox();
            this.texboxdevaddress = new System.Windows.Forms.TextBox();
            this.texboxnwkkey = new System.Windows.Forms.TextBox();
            this.appkey = new System.Windows.Forms.Label();
            this.nwkkey = new System.Windows.Forms.Label();
            this.devaddress = new System.Windows.Forms.Label();
            this.netid = new System.Windows.Forms.Label();
            this.simulatecomunication = new System.Windows.Forms.GroupBox();
            this.labeltxlen = new System.Windows.Forms.Label();
            this.textBoxtxlen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.texboxport = new System.Windows.Forms.TextBox();
            this.texboxreceivecnt = new System.Windows.Forms.TextBox();
            this.texboxsendcnt = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richtexboxreceive = new System.Windows.Forms.RichTextBox();
            this.richtexboxsend = new System.Windows.Forms.RichTextBox();
            this.checkboxhex = new System.Windows.Forms.CheckBox();
            this.checkboxconfirm = new System.Windows.Forms.CheckBox();
            this.senddata = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.device.SuspendLayout();
            this.GlobaleParameter.SuspendLayout();
            this.otaaactivaty.SuspendLayout();
            this.abpactivaty.SuspendLayout();
            this.simulatecomunication.SuspendLayout();
            this.SuspendLayout();
            // 
            // device
            // 
            this.device.Controls.Add(this.comboxactivatymethod);
            this.device.Controls.Add(this.buttonactivat);
            this.device.Controls.Add(this.disconnect);
            this.device.Controls.Add(this.reset);
            this.device.Controls.Add(this.factoryreset);
            this.device.Controls.Add(this.texfirewareversion);
            this.device.Controls.Add(this.connect);
            this.device.Controls.Add(this.serialportlist);
            this.device.Location = new System.Drawing.Point(12, 0);
            this.device.Name = "device";
            this.device.Size = new System.Drawing.Size(390, 102);
            this.device.TabIndex = 0;
            this.device.TabStop = false;
            this.device.Text = "连接设备";
            // 
            // comboxactivatymethod
            // 
            this.comboxactivatymethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboxactivatymethod.FormattingEnabled = true;
            this.comboxactivatymethod.Items.AddRange(new object[] {
            "-激活方式-",
            "OTAA",
            "ABP"});
            this.comboxactivatymethod.Location = new System.Drawing.Point(6, 75);
            this.comboxactivatymethod.Name = "comboxactivatymethod";
            this.comboxactivatymethod.Size = new System.Drawing.Size(92, 20);
            this.comboxactivatymethod.TabIndex = 9;
            this.comboxactivatymethod.SelectedIndexChanged += new System.EventHandler(this.comboxactivatymethod_SelectedIndexChanged_1);
            this.comboxactivatymethod.SelectionChangeCommitted += new System.EventHandler(this.comboxactivatymethod_SelectionChangeCommitted_1);
            // 
            // buttonactivat
            // 
            this.buttonactivat.Location = new System.Drawing.Point(247, 44);
            this.buttonactivat.Name = "buttonactivat";
            this.buttonactivat.Size = new System.Drawing.Size(132, 23);
            this.buttonactivat.TabIndex = 8;
            this.buttonactivat.Text = "激活入网";
            this.buttonactivat.UseVisualStyleBackColor = true;
            this.buttonactivat.Click += new System.EventHandler(this.buttonactivat_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(247, 17);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(132, 23);
            this.disconnect.TabIndex = 6;
            this.disconnect.Text = "断开连接";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.disconnect_MouseClick);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(247, 73);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(132, 23);
            this.reset.TabIndex = 5;
            this.reset.Text = "复位设备";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reset_MouseClick);
            // 
            // factoryreset
            // 
            this.factoryreset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factoryreset.Location = new System.Drawing.Point(104, 73);
            this.factoryreset.Name = "factoryreset";
            this.factoryreset.Size = new System.Drawing.Size(124, 23);
            this.factoryreset.TabIndex = 4;
            this.factoryreset.Text = "恢复出厂设置";
            this.factoryreset.UseVisualStyleBackColor = true;
            this.factoryreset.Click += new System.EventHandler(this.factoryreset_Click);
            // 
            // texfirewareversion
            // 
            this.texfirewareversion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texfirewareversion.Enabled = false;
            this.texfirewareversion.Location = new System.Drawing.Point(6, 46);
            this.texfirewareversion.Name = "texfirewareversion";
            this.texfirewareversion.Size = new System.Drawing.Size(222, 21);
            this.texfirewareversion.TabIndex = 3;
            this.texfirewareversion.Text = "设备未连接";
            this.texfirewareversion.TextChanged += new System.EventHandler(this.texfirewareversion_TextChanged);
            // 
            // connect
            // 
            this.connect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connect.Location = new System.Drawing.Point(104, 17);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(124, 23);
            this.connect.TabIndex = 1;
            this.connect.Text = "读取参数";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.connect_MouseClick);
            // 
            // serialportlist
            // 
            this.serialportlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.serialportlist.FormattingEnabled = true;
            this.serialportlist.Items.AddRange(new object[] {
            "-选择端口-"});
            this.serialportlist.Location = new System.Drawing.Point(6, 17);
            this.serialportlist.Name = "serialportlist";
            this.serialportlist.Size = new System.Drawing.Size(92, 20);
            this.serialportlist.TabIndex = 0;
            this.serialportlist.SelectedIndexChanged += new System.EventHandler(this.serialportlist_SelectedIndexChanged);
            this.serialportlist.SelectionChangeCommitted += new System.EventHandler(this.serialportlist_SelectionChangeCommitted);
            this.serialportlist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comlist_MouseClick);
            // 
            // GlobaleParameter
            // 
            this.GlobaleParameter.Controls.Add(this.comboxnodetype);
            this.GlobaleParameter.Controls.Add(this.texboxtimer);
            this.GlobaleParameter.Controls.Add(this.label4);
            this.GlobaleParameter.Controls.Add(this.texboxendchannel);
            this.GlobaleParameter.Controls.Add(this.endchannel);
            this.GlobaleParameter.Controls.Add(this.nodetype);
            this.GlobaleParameter.Controls.Add(this.textBoxstartchannel);
            this.GlobaleParameter.Controls.Add(this.channelstart);
            this.GlobaleParameter.Location = new System.Drawing.Point(12, 119);
            this.GlobaleParameter.Name = "GlobaleParameter";
            this.GlobaleParameter.Size = new System.Drawing.Size(390, 67);
            this.GlobaleParameter.TabIndex = 1;
            this.GlobaleParameter.TabStop = false;
            this.GlobaleParameter.Text = "全局参数";
            // 
            // comboxnodetype
            // 
            this.comboxnodetype.FormattingEnabled = true;
            this.comboxnodetype.Items.AddRange(new object[] {
            "Class A",
            "Class C"});
            this.comboxnodetype.Location = new System.Drawing.Point(65, 13);
            this.comboxnodetype.Name = "comboxnodetype";
            this.comboxnodetype.Size = new System.Drawing.Size(122, 20);
            this.comboxnodetype.TabIndex = 10;
            this.comboxnodetype.SelectedIndexChanged += new System.EventHandler(this.comboxnodetype_SelectedIndexChanged);
            // 
            // texboxtimer
            // 
            this.texboxtimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxtimer.Location = new System.Drawing.Point(252, 13);
            this.texboxtimer.Name = "texboxtimer";
            this.texboxtimer.Size = new System.Drawing.Size(127, 21);
            this.texboxtimer.TabIndex = 9;
            this.texboxtimer.Text = "60";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "唤醒周期";
            // 
            // texboxendchannel
            // 
            this.texboxendchannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxendchannel.Location = new System.Drawing.Point(252, 39);
            this.texboxendchannel.Name = "texboxendchannel";
            this.texboxendchannel.Size = new System.Drawing.Size(127, 21);
            this.texboxendchannel.TabIndex = 5;
            this.texboxendchannel.Text = "04";
            // 
            // endchannel
            // 
            this.endchannel.AutoSize = true;
            this.endchannel.Location = new System.Drawing.Point(193, 42);
            this.endchannel.Name = "endchannel";
            this.endchannel.Size = new System.Drawing.Size(53, 12);
            this.endchannel.TabIndex = 4;
            this.endchannel.Text = "信道个数";
            // 
            // nodetype
            // 
            this.nodetype.AutoSize = true;
            this.nodetype.Location = new System.Drawing.Point(6, 17);
            this.nodetype.Name = "nodetype";
            this.nodetype.Size = new System.Drawing.Size(53, 12);
            this.nodetype.TabIndex = 3;
            this.nodetype.Text = "节点类型";
            // 
            // textBoxstartchannel
            // 
            this.textBoxstartchannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxstartchannel.Location = new System.Drawing.Point(65, 39);
            this.textBoxstartchannel.Name = "textBoxstartchannel";
            this.textBoxstartchannel.Size = new System.Drawing.Size(122, 21);
            this.textBoxstartchannel.TabIndex = 2;
            this.textBoxstartchannel.Text = "00";
            // 
            // channelstart
            // 
            this.channelstart.AutoSize = true;
            this.channelstart.Location = new System.Drawing.Point(6, 42);
            this.channelstart.Name = "channelstart";
            this.channelstart.Size = new System.Drawing.Size(53, 12);
            this.channelstart.TabIndex = 1;
            this.channelstart.Text = "起始信道";
            // 
            // otaaactivaty
            // 
            this.otaaactivaty.Controls.Add(this.otaaconfigwrite);
            this.otaaactivaty.Controls.Add(this.texboxdevicekey);
            this.otaaactivaty.Controls.Add(this.texboxappeui);
            this.otaaactivaty.Controls.Add(this.texboxdeviceeui);
            this.otaaactivaty.Controls.Add(this.label3);
            this.otaaactivaty.Controls.Add(this.label2);
            this.otaaactivaty.Controls.Add(this.label1);
            this.otaaactivaty.Location = new System.Drawing.Point(12, 204);
            this.otaaactivaty.Name = "otaaactivaty";
            this.otaaactivaty.Size = new System.Drawing.Size(390, 125);
            this.otaaactivaty.TabIndex = 2;
            this.otaaactivaty.TabStop = false;
            this.otaaactivaty.Text = "OTAA激活";
            // 
            // otaaconfigwrite
            // 
            this.otaaconfigwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.otaaconfigwrite.Location = new System.Drawing.Point(173, 95);
            this.otaaconfigwrite.Name = "otaaconfigwrite";
            this.otaaconfigwrite.Size = new System.Drawing.Size(206, 23);
            this.otaaconfigwrite.TabIndex = 6;
            this.otaaconfigwrite.Text = "写入参数";
            this.otaaconfigwrite.UseVisualStyleBackColor = true;
            this.otaaconfigwrite.Click += new System.EventHandler(this.otaaconfigwrite_Click);
            // 
            // texboxdevicekey
            // 
            this.texboxdevicekey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxdevicekey.Location = new System.Drawing.Point(88, 68);
            this.texboxdevicekey.Name = "texboxdevicekey";
            this.texboxdevicekey.Size = new System.Drawing.Size(291, 21);
            this.texboxdevicekey.TabIndex = 5;
            this.texboxdevicekey.Text = "2B 7E 15 16 28 AE D2 A6 AB F7 15 88 09 CF 4F 3C";
            // 
            // texboxappeui
            // 
            this.texboxappeui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxappeui.Location = new System.Drawing.Point(88, 41);
            this.texboxappeui.Name = "texboxappeui";
            this.texboxappeui.Size = new System.Drawing.Size(291, 21);
            this.texboxappeui.TabIndex = 4;
            this.texboxappeui.Text = "6D 65 64 6F 4D 2D 4A 4D ";
            // 
            // texboxdeviceeui
            // 
            this.texboxdeviceeui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxdeviceeui.Location = new System.Drawing.Point(87, 14);
            this.texboxdeviceeui.Name = "texboxdeviceeui";
            this.texboxdeviceeui.Size = new System.Drawing.Size(292, 21);
            this.texboxdeviceeui.TabIndex = 3;
            this.texboxdeviceeui.Text = "FF FF FF FF FF FF FF 00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "设备 KEY";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "应用 EUI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备 EUI";
            // 
            // abpactivaty
            // 
            this.abpactivaty.Controls.Add(this.abpconfigwrite);
            this.abpactivaty.Controls.Add(this.texboxappkey);
            this.abpactivaty.Controls.Add(this.texboxnetid);
            this.abpactivaty.Controls.Add(this.texboxdevaddress);
            this.abpactivaty.Controls.Add(this.texboxnwkkey);
            this.abpactivaty.Controls.Add(this.appkey);
            this.abpactivaty.Controls.Add(this.nwkkey);
            this.abpactivaty.Controls.Add(this.devaddress);
            this.abpactivaty.Controls.Add(this.netid);
            this.abpactivaty.Location = new System.Drawing.Point(12, 346);
            this.abpactivaty.Name = "abpactivaty";
            this.abpactivaty.Size = new System.Drawing.Size(390, 166);
            this.abpactivaty.TabIndex = 3;
            this.abpactivaty.TabStop = false;
            this.abpactivaty.Text = "ABP激活";
            // 
            // abpconfigwrite
            // 
            this.abpconfigwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.abpconfigwrite.Location = new System.Drawing.Point(174, 125);
            this.abpconfigwrite.Name = "abpconfigwrite";
            this.abpconfigwrite.Size = new System.Drawing.Size(205, 23);
            this.abpconfigwrite.TabIndex = 8;
            this.abpconfigwrite.Text = "写入参数";
            this.abpconfigwrite.UseVisualStyleBackColor = true;
            this.abpconfigwrite.Click += new System.EventHandler(this.abpconfigwrite_Click);
            // 
            // texboxappkey
            // 
            this.texboxappkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxappkey.Location = new System.Drawing.Point(88, 98);
            this.texboxappkey.Name = "texboxappkey";
            this.texboxappkey.Size = new System.Drawing.Size(291, 21);
            this.texboxappkey.TabIndex = 7;
            this.texboxappkey.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF";
            // 
            // texboxnetid
            // 
            this.texboxnetid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxnetid.Location = new System.Drawing.Point(88, 17);
            this.texboxnetid.Name = "texboxnetid";
            this.texboxnetid.Size = new System.Drawing.Size(291, 21);
            this.texboxnetid.TabIndex = 6;
            this.texboxnetid.Text = "01 00 00 02";
            // 
            // texboxdevaddress
            // 
            this.texboxdevaddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxdevaddress.Location = new System.Drawing.Point(88, 44);
            this.texboxdevaddress.Name = "texboxdevaddress";
            this.texboxdevaddress.Size = new System.Drawing.Size(291, 21);
            this.texboxdevaddress.TabIndex = 5;
            this.texboxdevaddress.Text = "05 A4 9F EC";
            // 
            // texboxnwkkey
            // 
            this.texboxnwkkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxnwkkey.Location = new System.Drawing.Point(88, 71);
            this.texboxnwkkey.Name = "texboxnwkkey";
            this.texboxnwkkey.Size = new System.Drawing.Size(291, 21);
            this.texboxnwkkey.TabIndex = 4;
            this.texboxnwkkey.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF";
            // 
            // appkey
            // 
            this.appkey.AutoSize = true;
            this.appkey.Location = new System.Drawing.Point(6, 101);
            this.appkey.Name = "appkey";
            this.appkey.Size = new System.Drawing.Size(53, 12);
            this.appkey.TabIndex = 3;
            this.appkey.Text = "应用 KEY";
            // 
            // nwkkey
            // 
            this.nwkkey.AutoSize = true;
            this.nwkkey.Location = new System.Drawing.Point(6, 74);
            this.nwkkey.Name = "nwkkey";
            this.nwkkey.Size = new System.Drawing.Size(53, 12);
            this.nwkkey.TabIndex = 2;
            this.nwkkey.Text = "网络 KEY";
            // 
            // devaddress
            // 
            this.devaddress.AutoSize = true;
            this.devaddress.Location = new System.Drawing.Point(6, 47);
            this.devaddress.Name = "devaddress";
            this.devaddress.Size = new System.Drawing.Size(59, 12);
            this.devaddress.TabIndex = 1;
            this.devaddress.Text = "网络 地址";
            // 
            // netid
            // 
            this.netid.AutoSize = true;
            this.netid.Location = new System.Drawing.Point(6, 20);
            this.netid.Name = "netid";
            this.netid.Size = new System.Drawing.Size(47, 12);
            this.netid.TabIndex = 0;
            this.netid.Text = "网络 ID";
            // 
            // simulatecomunication
            // 
            this.simulatecomunication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simulatecomunication.Controls.Add(this.labeltxlen);
            this.simulatecomunication.Controls.Add(this.textBoxtxlen);
            this.simulatecomunication.Controls.Add(this.label7);
            this.simulatecomunication.Controls.Add(this.texboxport);
            this.simulatecomunication.Controls.Add(this.texboxreceivecnt);
            this.simulatecomunication.Controls.Add(this.texboxsendcnt);
            this.simulatecomunication.Controls.Add(this.clear);
            this.simulatecomunication.Controls.Add(this.label6);
            this.simulatecomunication.Controls.Add(this.label5);
            this.simulatecomunication.Controls.Add(this.richtexboxreceive);
            this.simulatecomunication.Controls.Add(this.richtexboxsend);
            this.simulatecomunication.Controls.Add(this.checkboxhex);
            this.simulatecomunication.Controls.Add(this.checkboxconfirm);
            this.simulatecomunication.Controls.Add(this.senddata);
            this.simulatecomunication.Location = new System.Drawing.Point(408, 0);
            this.simulatecomunication.Name = "simulatecomunication";
            this.simulatecomunication.Size = new System.Drawing.Size(406, 508);
            this.simulatecomunication.TabIndex = 4;
            this.simulatecomunication.TabStop = false;
            this.simulatecomunication.Text = "模拟通信";
            // 
            // labeltxlen
            // 
            this.labeltxlen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltxlen.AutoSize = true;
            this.labeltxlen.Location = new System.Drawing.Point(318, 15);
            this.labeltxlen.Name = "labeltxlen";
            this.labeltxlen.Size = new System.Drawing.Size(29, 12);
            this.labeltxlen.TabIndex = 13;
            this.labeltxlen.Text = "长度";
            // 
            // textBoxtxlen
            // 
            this.textBoxtxlen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxtxlen.Enabled = false;
            this.textBoxtxlen.Location = new System.Drawing.Point(353, 12);
            this.textBoxtxlen.Name = "textBoxtxlen";
            this.textBoxtxlen.Size = new System.Drawing.Size(39, 21);
            this.textBoxtxlen.TabIndex = 12;
            this.textBoxtxlen.Text = "5";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "端口";
            // 
            // texboxport
            // 
            this.texboxport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxport.Location = new System.Drawing.Point(353, 81);
            this.texboxport.Name = "texboxport";
            this.texboxport.Size = new System.Drawing.Size(40, 21);
            this.texboxport.TabIndex = 10;
            this.texboxport.Text = "2";
            // 
            // texboxreceivecnt
            // 
            this.texboxreceivecnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxreceivecnt.Enabled = false;
            this.texboxreceivecnt.Location = new System.Drawing.Point(286, 480);
            this.texboxreceivecnt.Name = "texboxreceivecnt";
            this.texboxreceivecnt.Size = new System.Drawing.Size(51, 21);
            this.texboxreceivecnt.TabIndex = 9;
            // 
            // texboxsendcnt
            // 
            this.texboxsendcnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxsendcnt.Enabled = false;
            this.texboxsendcnt.Location = new System.Drawing.Point(173, 480);
            this.texboxsendcnt.Name = "texboxsendcnt";
            this.texboxsendcnt.Size = new System.Drawing.Size(56, 21);
            this.texboxsendcnt.TabIndex = 8;
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.Location = new System.Drawing.Point(352, 478);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(43, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "清零";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "接收计数";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "发送计数";
            // 
            // richtexboxreceive
            // 
            this.richtexboxreceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtexboxreceive.Location = new System.Drawing.Point(6, 133);
            this.richtexboxreceive.Name = "richtexboxreceive";
            this.richtexboxreceive.Size = new System.Drawing.Size(389, 341);
            this.richtexboxreceive.TabIndex = 4;
            this.richtexboxreceive.Text = "";
            this.richtexboxreceive.TextChanged += new System.EventHandler(this.richtexboxreceive_TextChanged);
            // 
            // richtexboxsend
            // 
            this.richtexboxsend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtexboxsend.Location = new System.Drawing.Point(6, 24);
            this.richtexboxsend.Name = "richtexboxsend";
            this.richtexboxsend.Size = new System.Drawing.Size(297, 103);
            this.richtexboxsend.TabIndex = 3;
            this.richtexboxsend.Text = "hello";
            this.richtexboxsend.TextChanged += new System.EventHandler(this.richtexboxsend_TextChanged);
            // 
            // checkboxhex
            // 
            this.checkboxhex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxhex.AutoSize = true;
            this.checkboxhex.Location = new System.Drawing.Point(320, 37);
            this.checkboxhex.Name = "checkboxhex";
            this.checkboxhex.Size = new System.Drawing.Size(72, 16);
            this.checkboxhex.TabIndex = 2;
            this.checkboxhex.Text = "十六进制";
            this.checkboxhex.UseVisualStyleBackColor = true;
            this.checkboxhex.CheckedChanged += new System.EventHandler(this.checkboxhex_CheckedChanged);
            // 
            // checkboxconfirm
            // 
            this.checkboxconfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxconfirm.AutoSize = true;
            this.checkboxconfirm.Location = new System.Drawing.Point(320, 59);
            this.checkboxconfirm.Name = "checkboxconfirm";
            this.checkboxconfirm.Size = new System.Drawing.Size(72, 16);
            this.checkboxconfirm.TabIndex = 1;
            this.checkboxconfirm.Text = "需要确认";
            this.checkboxconfirm.UseVisualStyleBackColor = true;
            // 
            // senddata
            // 
            this.senddata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.senddata.Location = new System.Drawing.Point(320, 104);
            this.senddata.Name = "senddata";
            this.senddata.Size = new System.Drawing.Size(75, 23);
            this.senddata.TabIndex = 0;
            this.senddata.Text = "发送";
            this.senddata.UseVisualStyleBackColor = true;
            this.senddata.MouseClick += new System.Windows.Forms.MouseEventHandler(this.senddata_MouseClick);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 520);
            this.Controls.Add(this.simulatecomunication);
            this.Controls.Add(this.abpactivaty);
            this.Controls.Add(this.otaaactivaty);
            this.Controls.Add(this.GlobaleParameter);
            this.Controls.Add(this.device);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.device.ResumeLayout(false);
            this.device.PerformLayout();
            this.GlobaleParameter.ResumeLayout(false);
            this.GlobaleParameter.PerformLayout();
            this.otaaactivaty.ResumeLayout(false);
            this.otaaactivaty.PerformLayout();
            this.abpactivaty.ResumeLayout(false);
            this.abpactivaty.PerformLayout();
            this.simulatecomunication.ResumeLayout(false);
            this.simulatecomunication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox device;
        private System.Windows.Forms.TextBox texfirewareversion;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ComboBox serialportlist;
        private System.Windows.Forms.GroupBox GlobaleParameter;
        private System.Windows.Forms.TextBox texboxendchannel;
        private System.Windows.Forms.Label endchannel;
        private System.Windows.Forms.Label nodetype;
        private System.Windows.Forms.TextBox textBoxstartchannel;
        private System.Windows.Forms.Label channelstart;
        private System.Windows.Forms.GroupBox otaaactivaty;
        private System.Windows.Forms.TextBox texboxdevicekey;
        private System.Windows.Forms.TextBox texboxappeui;
        private System.Windows.Forms.TextBox texboxdeviceeui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox abpactivaty;
        private System.Windows.Forms.TextBox texboxappkey;
        private System.Windows.Forms.TextBox texboxnetid;
        private System.Windows.Forms.TextBox texboxdevaddress;
        private System.Windows.Forms.TextBox texboxnwkkey;
        private System.Windows.Forms.Label appkey;
        private System.Windows.Forms.Label nwkkey;
        private System.Windows.Forms.Label devaddress;
        private System.Windows.Forms.Label netid;
        private System.Windows.Forms.TextBox texboxtimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button factoryreset;
        private System.Windows.Forms.GroupBox simulatecomunication;
        private System.Windows.Forms.TextBox texboxreceivecnt;
        private System.Windows.Forms.TextBox texboxsendcnt;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richtexboxreceive;
        private System.Windows.Forms.RichTextBox richtexboxsend;
        private System.Windows.Forms.CheckBox checkboxhex;
        private System.Windows.Forms.CheckBox checkboxconfirm;
        private System.Windows.Forms.Button senddata;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button otaaconfigwrite;
        private System.Windows.Forms.Button abpconfigwrite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texboxport;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button buttonactivat;
        private System.Windows.Forms.ComboBox comboxactivatymethod;
        private System.Windows.Forms.ComboBox comboxnodetype;
        private System.Windows.Forms.Label labeltxlen;
        private System.Windows.Forms.TextBox textBoxtxlen;
    }
}


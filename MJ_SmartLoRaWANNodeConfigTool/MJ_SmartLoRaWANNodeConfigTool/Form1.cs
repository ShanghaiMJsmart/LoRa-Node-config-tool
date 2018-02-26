using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MJ_SmartLoRaWANNodeConfigTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void texfirewareversion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comlist.SelectedIndex = comlist.Items.IndexOf("-请选择端口-");
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
    }
}

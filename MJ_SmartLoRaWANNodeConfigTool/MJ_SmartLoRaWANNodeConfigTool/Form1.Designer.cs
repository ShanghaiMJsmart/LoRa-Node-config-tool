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
            this.device = new System.Windows.Forms.GroupBox();
            this.texfirewareversion = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.comlist = new System.Windows.Forms.ComboBox();
            this.GlobaleParameter = new System.Windows.Forms.GroupBox();
            this.comboxactivatymethod = new System.Windows.Forms.ComboBox();
            this.activatymethod = new System.Windows.Forms.Label();
            this.texboxendchannel = new System.Windows.Forms.TextBox();
            this.endchannel = new System.Windows.Forms.Label();
            this.nodetype = new System.Windows.Forms.Label();
            this.textBoxstartchannel = new System.Windows.Forms.TextBox();
            this.channelstart = new System.Windows.Forms.Label();
            this.comboxnodetype = new System.Windows.Forms.ComboBox();
            this.otaaactivaty = new System.Windows.Forms.GroupBox();
            this.texboxdevicekey = new System.Windows.Forms.TextBox();
            this.texboxappeui = new System.Windows.Forms.TextBox();
            this.texboxdeviceeui = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.abpactivaty = new System.Windows.Forms.GroupBox();
            this.texboxappkey = new System.Windows.Forms.TextBox();
            this.texboxnetid = new System.Windows.Forms.TextBox();
            this.texboxdevaddress = new System.Windows.Forms.TextBox();
            this.texboxnwkkey = new System.Windows.Forms.TextBox();
            this.appkey = new System.Windows.Forms.Label();
            this.nwkkey = new System.Windows.Forms.Label();
            this.devaddress = new System.Windows.Forms.Label();
            this.netid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texboxtimer = new System.Windows.Forms.TextBox();
            this.factoryreset = new System.Windows.Forms.Button();
            this.simulatecomunication = new System.Windows.Forms.GroupBox();
            this.senddate = new System.Windows.Forms.Button();
            this.checkboxconfirm = new System.Windows.Forms.CheckBox();
            this.checkboxhex = new System.Windows.Forms.CheckBox();
            this.richtexboxsend = new System.Windows.Forms.RichTextBox();
            this.richtexboxreceive = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.texboxsendcnt = new System.Windows.Forms.TextBox();
            this.texboxreceivecnt = new System.Windows.Forms.TextBox();
            this.device.SuspendLayout();
            this.GlobaleParameter.SuspendLayout();
            this.otaaactivaty.SuspendLayout();
            this.abpactivaty.SuspendLayout();
            this.simulatecomunication.SuspendLayout();
            this.SuspendLayout();
            // 
            // device
            // 
            this.device.Controls.Add(this.factoryreset);
            this.device.Controls.Add(this.texfirewareversion);
            this.device.Controls.Add(this.connect);
            this.device.Controls.Add(this.comlist);
            this.device.Location = new System.Drawing.Point(12, 0);
            this.device.Name = "device";
            this.device.Size = new System.Drawing.Size(304, 102);
            this.device.TabIndex = 0;
            this.device.TabStop = false;
            this.device.Text = "连接设备";
            // 
            // texfirewareversion
            // 
            this.texfirewareversion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texfirewareversion.Enabled = false;
            this.texfirewareversion.Location = new System.Drawing.Point(6, 46);
            this.texfirewareversion.Name = "texfirewareversion";
            this.texfirewareversion.Size = new System.Drawing.Size(287, 21);
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
            this.connect.Size = new System.Drawing.Size(189, 23);
            this.connect.TabIndex = 1;
            this.connect.Text = "刷新连接";
            this.connect.UseVisualStyleBackColor = true;
            // 
            // comlist
            // 
            this.comlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comlist.FormattingEnabled = true;
            this.comlist.Items.AddRange(new object[] {
            "-请选择端口-"});
            this.comlist.Location = new System.Drawing.Point(6, 17);
            this.comlist.Name = "comlist";
            this.comlist.Size = new System.Drawing.Size(92, 20);
            this.comlist.TabIndex = 0;
            // 
            // GlobaleParameter
            // 
            this.GlobaleParameter.Controls.Add(this.texboxtimer);
            this.GlobaleParameter.Controls.Add(this.label4);
            this.GlobaleParameter.Controls.Add(this.comboxactivatymethod);
            this.GlobaleParameter.Controls.Add(this.activatymethod);
            this.GlobaleParameter.Controls.Add(this.texboxendchannel);
            this.GlobaleParameter.Controls.Add(this.endchannel);
            this.GlobaleParameter.Controls.Add(this.nodetype);
            this.GlobaleParameter.Controls.Add(this.textBoxstartchannel);
            this.GlobaleParameter.Controls.Add(this.channelstart);
            this.GlobaleParameter.Controls.Add(this.comboxnodetype);
            this.GlobaleParameter.Location = new System.Drawing.Point(12, 119);
            this.GlobaleParameter.Name = "GlobaleParameter";
            this.GlobaleParameter.Size = new System.Drawing.Size(304, 148);
            this.GlobaleParameter.TabIndex = 1;
            this.GlobaleParameter.TabStop = false;
            this.GlobaleParameter.Text = "全局参数";
            // 
            // comboxactivatymethod
            // 
            this.comboxactivatymethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboxactivatymethod.FormattingEnabled = true;
            this.comboxactivatymethod.Items.AddRange(new object[] {
            "OTAA",
            "ABP"});
            this.comboxactivatymethod.Location = new System.Drawing.Point(87, 93);
            this.comboxactivatymethod.Name = "comboxactivatymethod";
            this.comboxactivatymethod.Size = new System.Drawing.Size(206, 20);
            this.comboxactivatymethod.TabIndex = 7;
            this.comboxactivatymethod.SelectedIndexChanged += new System.EventHandler(this.comboxactivatymethod_SelectedIndexChanged);
            this.comboxactivatymethod.SelectionChangeCommitted += new System.EventHandler(this.comboxactivatymethod_SelectionChangeCommitted);
            // 
            // activatymethod
            // 
            this.activatymethod.AutoSize = true;
            this.activatymethod.Location = new System.Drawing.Point(6, 96);
            this.activatymethod.Name = "activatymethod";
            this.activatymethod.Size = new System.Drawing.Size(53, 12);
            this.activatymethod.TabIndex = 6;
            this.activatymethod.Text = "激活方式";
            // 
            // texboxendchannel
            // 
            this.texboxendchannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxendchannel.Location = new System.Drawing.Point(87, 66);
            this.texboxendchannel.Name = "texboxendchannel";
            this.texboxendchannel.Size = new System.Drawing.Size(206, 21);
            this.texboxendchannel.TabIndex = 5;
            this.texboxendchannel.Text = "4";
            // 
            // endchannel
            // 
            this.endchannel.AutoSize = true;
            this.endchannel.Location = new System.Drawing.Point(6, 69);
            this.endchannel.Name = "endchannel";
            this.endchannel.Size = new System.Drawing.Size(53, 12);
            this.endchannel.TabIndex = 4;
            this.endchannel.Text = "结束信道";
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
            this.textBoxstartchannel.Location = new System.Drawing.Point(87, 39);
            this.textBoxstartchannel.Name = "textBoxstartchannel";
            this.textBoxstartchannel.Size = new System.Drawing.Size(206, 21);
            this.textBoxstartchannel.TabIndex = 2;
            this.textBoxstartchannel.Text = "0";
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
            // comboxnodetype
            // 
            this.comboxnodetype.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboxnodetype.FormattingEnabled = true;
            this.comboxnodetype.Items.AddRange(new object[] {
            "Class A",
            "Class C"});
            this.comboxnodetype.Location = new System.Drawing.Point(87, 14);
            this.comboxnodetype.Name = "comboxnodetype";
            this.comboxnodetype.Size = new System.Drawing.Size(206, 20);
            this.comboxnodetype.TabIndex = 0;
            // 
            // otaaactivaty
            // 
            this.otaaactivaty.Controls.Add(this.texboxdevicekey);
            this.otaaactivaty.Controls.Add(this.texboxappeui);
            this.otaaactivaty.Controls.Add(this.texboxdeviceeui);
            this.otaaactivaty.Controls.Add(this.label3);
            this.otaaactivaty.Controls.Add(this.label2);
            this.otaaactivaty.Controls.Add(this.label1);
            this.otaaactivaty.Location = new System.Drawing.Point(12, 273);
            this.otaaactivaty.Name = "otaaactivaty";
            this.otaaactivaty.Size = new System.Drawing.Size(304, 96);
            this.otaaactivaty.TabIndex = 2;
            this.otaaactivaty.TabStop = false;
            this.otaaactivaty.Text = "OTAA激活";
            // 
            // texboxdevicekey
            // 
            this.texboxdevicekey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxdevicekey.Location = new System.Drawing.Point(88, 68);
            this.texboxdevicekey.Name = "texboxdevicekey";
            this.texboxdevicekey.Size = new System.Drawing.Size(205, 21);
            this.texboxdevicekey.TabIndex = 5;
            // 
            // texboxappeui
            // 
            this.texboxappeui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxappeui.Location = new System.Drawing.Point(88, 41);
            this.texboxappeui.Name = "texboxappeui";
            this.texboxappeui.Size = new System.Drawing.Size(205, 21);
            this.texboxappeui.TabIndex = 4;
            // 
            // texboxdeviceeui
            // 
            this.texboxdeviceeui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxdeviceeui.Location = new System.Drawing.Point(87, 14);
            this.texboxdeviceeui.Name = "texboxdeviceeui";
            this.texboxdeviceeui.Size = new System.Drawing.Size(206, 21);
            this.texboxdeviceeui.TabIndex = 3;
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
            this.abpactivaty.Controls.Add(this.texboxappkey);
            this.abpactivaty.Controls.Add(this.texboxnetid);
            this.abpactivaty.Controls.Add(this.texboxdevaddress);
            this.abpactivaty.Controls.Add(this.texboxnwkkey);
            this.abpactivaty.Controls.Add(this.appkey);
            this.abpactivaty.Controls.Add(this.nwkkey);
            this.abpactivaty.Controls.Add(this.devaddress);
            this.abpactivaty.Controls.Add(this.netid);
            this.abpactivaty.Location = new System.Drawing.Point(12, 375);
            this.abpactivaty.Name = "abpactivaty";
            this.abpactivaty.Size = new System.Drawing.Size(304, 126);
            this.abpactivaty.TabIndex = 3;
            this.abpactivaty.TabStop = false;
            this.abpactivaty.Text = "ABP激活";
            // 
            // texboxappkey
            // 
            this.texboxappkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxappkey.Location = new System.Drawing.Point(88, 98);
            this.texboxappkey.Name = "texboxappkey";
            this.texboxappkey.Size = new System.Drawing.Size(205, 21);
            this.texboxappkey.TabIndex = 7;
            // 
            // texboxnetid
            // 
            this.texboxnetid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxnetid.Location = new System.Drawing.Point(88, 17);
            this.texboxnetid.Name = "texboxnetid";
            this.texboxnetid.Size = new System.Drawing.Size(205, 21);
            this.texboxnetid.TabIndex = 6;
            // 
            // texboxdevaddress
            // 
            this.texboxdevaddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxdevaddress.Location = new System.Drawing.Point(88, 44);
            this.texboxdevaddress.Name = "texboxdevaddress";
            this.texboxdevaddress.Size = new System.Drawing.Size(205, 21);
            this.texboxdevaddress.TabIndex = 5;
            // 
            // texboxnwkkey
            // 
            this.texboxnwkkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxnwkkey.Location = new System.Drawing.Point(88, 71);
            this.texboxnwkkey.Name = "texboxnwkkey";
            this.texboxnwkkey.Size = new System.Drawing.Size(205, 21);
            this.texboxnwkkey.TabIndex = 4;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "唤醒周期";
            // 
            // texboxtimer
            // 
            this.texboxtimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxtimer.Location = new System.Drawing.Point(87, 119);
            this.texboxtimer.Name = "texboxtimer";
            this.texboxtimer.Size = new System.Drawing.Size(206, 21);
            this.texboxtimer.TabIndex = 9;
            this.texboxtimer.Text = "60";
            // 
            // factoryreset
            // 
            this.factoryreset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factoryreset.Location = new System.Drawing.Point(6, 73);
            this.factoryreset.Name = "factoryreset";
            this.factoryreset.Size = new System.Drawing.Size(287, 23);
            this.factoryreset.TabIndex = 4;
            this.factoryreset.Text = "恢复出厂设置";
            this.factoryreset.UseVisualStyleBackColor = true;
            // 
            // simulatecomunication
            // 
            this.simulatecomunication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simulatecomunication.Controls.Add(this.texboxreceivecnt);
            this.simulatecomunication.Controls.Add(this.texboxsendcnt);
            this.simulatecomunication.Controls.Add(this.button1);
            this.simulatecomunication.Controls.Add(this.label6);
            this.simulatecomunication.Controls.Add(this.label5);
            this.simulatecomunication.Controls.Add(this.richtexboxreceive);
            this.simulatecomunication.Controls.Add(this.richtexboxsend);
            this.simulatecomunication.Controls.Add(this.checkboxhex);
            this.simulatecomunication.Controls.Add(this.checkboxconfirm);
            this.simulatecomunication.Controls.Add(this.senddate);
            this.simulatecomunication.Location = new System.Drawing.Point(336, 0);
            this.simulatecomunication.Name = "simulatecomunication";
            this.simulatecomunication.Size = new System.Drawing.Size(289, 501);
            this.simulatecomunication.TabIndex = 4;
            this.simulatecomunication.TabStop = false;
            this.simulatecomunication.Text = "模拟通信";
            // 
            // senddate
            // 
            this.senddate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.senddate.Location = new System.Drawing.Point(203, 68);
            this.senddate.Name = "senddate";
            this.senddate.Size = new System.Drawing.Size(75, 23);
            this.senddate.TabIndex = 0;
            this.senddate.Text = "发送";
            this.senddate.UseVisualStyleBackColor = true;
            // 
            // checkboxconfirm
            // 
            this.checkboxconfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxconfirm.AutoSize = true;
            this.checkboxconfirm.Location = new System.Drawing.Point(203, 46);
            this.checkboxconfirm.Name = "checkboxconfirm";
            this.checkboxconfirm.Size = new System.Drawing.Size(72, 16);
            this.checkboxconfirm.TabIndex = 1;
            this.checkboxconfirm.Text = "需要确认";
            this.checkboxconfirm.UseVisualStyleBackColor = true;
            // 
            // checkboxhex
            // 
            this.checkboxhex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxhex.AutoSize = true;
            this.checkboxhex.Location = new System.Drawing.Point(203, 24);
            this.checkboxhex.Name = "checkboxhex";
            this.checkboxhex.Size = new System.Drawing.Size(72, 16);
            this.checkboxhex.TabIndex = 2;
            this.checkboxhex.Text = "十六进制";
            this.checkboxhex.UseVisualStyleBackColor = true;
            // 
            // richtexboxsend
            // 
            this.richtexboxsend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtexboxsend.Location = new System.Drawing.Point(3, 24);
            this.richtexboxsend.Name = "richtexboxsend";
            this.richtexboxsend.Size = new System.Drawing.Size(183, 103);
            this.richtexboxsend.TabIndex = 3;
            this.richtexboxsend.Text = "";
            // 
            // richtexboxreceive
            // 
            this.richtexboxreceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtexboxreceive.Enabled = false;
            this.richtexboxreceive.Location = new System.Drawing.Point(3, 133);
            this.richtexboxreceive.Name = "richtexboxreceive";
            this.richtexboxreceive.Size = new System.Drawing.Size(275, 334);
            this.richtexboxreceive.TabIndex = 4;
            this.richtexboxreceive.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "发送计数";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "接收计数";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(235, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "清零";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // texboxsendcnt
            // 
            this.texboxsendcnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxsendcnt.Enabled = false;
            this.texboxsendcnt.Location = new System.Drawing.Point(56, 473);
            this.texboxsendcnt.Name = "texboxsendcnt";
            this.texboxsendcnt.Size = new System.Drawing.Size(56, 21);
            this.texboxsendcnt.TabIndex = 8;
            // 
            // texboxreceivecnt
            // 
            this.texboxreceivecnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.texboxreceivecnt.Enabled = false;
            this.texboxreceivecnt.Location = new System.Drawing.Point(169, 473);
            this.texboxreceivecnt.Name = "texboxreceivecnt";
            this.texboxreceivecnt.Size = new System.Drawing.Size(51, 21);
            this.texboxreceivecnt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 509);
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
        private System.Windows.Forms.ComboBox comlist;
        private System.Windows.Forms.GroupBox GlobaleParameter;
        private System.Windows.Forms.ComboBox comboxactivatymethod;
        private System.Windows.Forms.Label activatymethod;
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
        private System.Windows.Forms.ComboBox comboxnodetype;
        private System.Windows.Forms.TextBox texboxtimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button factoryreset;
        private System.Windows.Forms.GroupBox simulatecomunication;
        private System.Windows.Forms.TextBox texboxreceivecnt;
        private System.Windows.Forms.TextBox texboxsendcnt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richtexboxreceive;
        private System.Windows.Forms.RichTextBox richtexboxsend;
        private System.Windows.Forms.CheckBox checkboxhex;
        private System.Windows.Forms.CheckBox checkboxconfirm;
        private System.Windows.Forms.Button senddate;
    }
}


﻿namespace Server_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStripServerSelection = new System.Windows.Forms.StatusStrip();
            this.statuslabelServerSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.networkusagebox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.computernamebox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.serviceStatus = new System.Windows.Forms.Label();
            this.localipaddressbox = new System.Windows.Forms.TextBox();
            this.publicipaddressbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.currentPing = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentApplicationSelection = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cpuUsageBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.showhideperf_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newServerWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameServerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideGamePanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label18 = new System.Windows.Forms.Label();
            this.statusStripForm = new System.Windows.Forms.StatusStrip();
            this.currentUptimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pingTimer = new System.Windows.Forms.Timer(this.components);
            this.ConnectivityCheck_Timer = new System.Windows.Forms.Timer(this.components);
            this.showhidesplit = new System.Windows.Forms.Button();
            this.PerformanceInformationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStripServerSelection.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStripForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Server Manager Toolkit";
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(2, 67);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.statusStripServerSelection);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.splitContainer1.Panel2.ContextMenuStrip = this.contextMenuStrip1;
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Panel2.Controls.Add(this.label17);
            this.splitContainer1.Panel2.Controls.Add(this.networkusagebox);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.computernamebox);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.serviceStatus);
            this.splitContainer1.Panel2.Controls.Add(this.localipaddressbox);
            this.splitContainer1.Panel2.Controls.Add(this.publicipaddressbox);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.currentPing);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.currentApplicationSelection);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(802, 349);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::Server_Manager.Properties.Resources.mumble_banner;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(4, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 51);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Enter += new System.EventHandler(this.MurmurServerMouseEnter);
            this.button3.Leave += new System.EventHandler(this.ReturnToCurrentServerName);
            this.button3.MouseEnter += new System.EventHandler(this.MurmurServerMouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.ReturnToCurrentServerName);
            this.button3.MouseHover += new System.EventHandler(this.MurmurServerMouseEnter);
            // 
            // statusStripServerSelection
            // 
            this.statusStripServerSelection.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripServerSelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabelServerSelection});
            this.statusStripServerSelection.Location = new System.Drawing.Point(0, 327);
            this.statusStripServerSelection.Name = "statusStripServerSelection";
            this.statusStripServerSelection.Size = new System.Drawing.Size(110, 22);
            this.statusStripServerSelection.TabIndex = 2;
            this.statusStripServerSelection.Text = "statusStrip2";
            // 
            // statuslabelServerSelection
            // 
            this.statuslabelServerSelection.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabelServerSelection.ForeColor = System.Drawing.Color.White;
            this.statuslabelServerSelection.Name = "statuslabelServerSelection";
            this.statuslabelServerSelection.Size = new System.Drawing.Size(95, 17);
            this.statuslabelServerSelection.Spring = true;
            this.statuslabelServerSelection.Text = "Project Zomboid";
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundImage = global::Server_Manager.Properties.Resources.killingfloor2button;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(4, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 51);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseEnter += new System.EventHandler(this.KillingFloor2MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.ReturnToCurrentServerName);
            this.button2.MouseHover += new System.EventHandler(this.KillingFloor2MouseEnter);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = global::Server_Manager.Properties.Resources.projectzomboidbutton;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 51);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseEnter += new System.EventHandler(this.ProjectZomboidMouseEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 26);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.testToolStripMenuItem.Text = "Restart Application";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(90, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 18);
            this.label16.TabIndex = 29;
            this.label16.Text = "0/32";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 15);
            this.label17.TabIndex = 28;
            this.label17.Text = "Players Online:";
            // 
            // networkusagebox
            // 
            this.networkusagebox.Location = new System.Drawing.Point(157, 159);
            this.networkusagebox.Name = "networkusagebox";
            this.networkusagebox.ReadOnly = true;
            this.networkusagebox.Size = new System.Drawing.Size(126, 20);
            this.networkusagebox.TabIndex = 26;
            this.networkusagebox.Click += new System.EventHandler(this.SelectAll_NetworkUsageBox);
            this.networkusagebox.DoubleClick += new System.EventHandler(this.DoNothing);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "Current Network Usage:";
            // 
            // computernamebox
            // 
            this.computernamebox.Location = new System.Drawing.Point(157, 81);
            this.computernamebox.Name = "computernamebox";
            this.computernamebox.ReadOnly = true;
            this.computernamebox.Size = new System.Drawing.Size(126, 20);
            this.computernamebox.TabIndex = 13;
            this.computernamebox.Click += new System.EventHandler(this.SelectAll_ComputerName);
            this.computernamebox.DoubleClick += new System.EventHandler(this.DoNothing);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Computer Name:";
            // 
            // serviceStatus
            // 
            this.serviceStatus.AutoSize = true;
            this.serviceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceStatus.Location = new System.Drawing.Point(88, 25);
            this.serviceStatus.Name = "serviceStatus";
            this.serviceStatus.Size = new System.Drawing.Size(168, 15);
            this.serviceStatus.TabIndex = 10;
            this.serviceStatus.Text = "Started - Stopped - Restarting";
            // 
            // localipaddressbox
            // 
            this.localipaddressbox.Location = new System.Drawing.Point(157, 133);
            this.localipaddressbox.Name = "localipaddressbox";
            this.localipaddressbox.ReadOnly = true;
            this.localipaddressbox.Size = new System.Drawing.Size(126, 20);
            this.localipaddressbox.TabIndex = 9;
            this.localipaddressbox.Click += new System.EventHandler(this.SelectAll_LocalipAddressBox);
            this.localipaddressbox.DoubleClick += new System.EventHandler(this.DoNothing);
            // 
            // publicipaddressbox
            // 
            this.publicipaddressbox.Location = new System.Drawing.Point(157, 107);
            this.publicipaddressbox.Name = "publicipaddressbox";
            this.publicipaddressbox.ReadOnly = true;
            this.publicipaddressbox.Size = new System.Drawing.Size(126, 20);
            this.publicipaddressbox.TabIndex = 8;
            this.publicipaddressbox.Click += new System.EventHandler(this.SelectAll_PublicIP);
            this.publicipaddressbox.DoubleClick += new System.EventHandler(this.DoNothing);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Current Local IP Address(s):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Current Public IP Address:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(326, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Setup Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Service Status:";
            // 
            // currentPing
            // 
            this.currentPing.AutoSize = true;
            this.currentPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPing.Location = new System.Drawing.Point(6, 40);
            this.currentPing.Name = "currentPing";
            this.currentPing.Size = new System.Drawing.Size(132, 15);
            this.currentPing.TabIndex = 3;
            this.currentPing.Text = "Current Ping: Pinging...";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Online Avalability: (Thumbs Up, Thumbs Down)";
            // 
            // currentApplicationSelection
            // 
            this.currentApplicationSelection.AutoSize = true;
            this.currentApplicationSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentApplicationSelection.Location = new System.Drawing.Point(3, 4);
            this.currentApplicationSelection.Name = "currentApplicationSelection";
            this.currentApplicationSelection.Size = new System.Drawing.Size(283, 25);
            this.currentApplicationSelection.TabIndex = 0;
            this.currentApplicationSelection.Text = "Evil Lurks [DedicatedBox]";
            // 
            // splitContainer2
            // 
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(-1, 208);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.textBox6);
            this.splitContainer2.Panel1.Controls.Add(this.label14);
            this.splitContainer2.Panel1.Controls.Add(this.cpuUsageBox);
            this.splitContainer2.Panel1.Controls.Add(this.textBox7);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.textBox5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.showhideperf_button);
            this.splitContainer2.Size = new System.Drawing.Size(689, 138);
            this.splitContainer2.SplitterDistance = 105;
            this.splitContainer2.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(270, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Performance";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(404, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 15);
            this.label13.TabIndex = 39;
            this.label13.Text = "Main Disk Usage:";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(513, 55);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(424, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 15);
            this.label14.TabIndex = 37;
            this.label14.Text = "Power Usage:";
            // 
            // cpuUsageBox
            // 
            this.cpuUsageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cpuUsageBox.Location = new System.Drawing.Point(96, 29);
            this.cpuUsageBox.Name = "cpuUsageBox";
            this.cpuUsageBox.ReadOnly = true;
            this.cpuUsageBox.Size = new System.Drawing.Size(100, 20);
            this.cpuUsageBox.TabIndex = 32;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(513, 29);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "CPU Usage:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "Ram Used:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox5.Location = new System.Drawing.Point(96, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 34;
            // 
            // showhideperf_button
            // 
            this.showhideperf_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showhideperf_button.Location = new System.Drawing.Point(0, 10);
            this.showhideperf_button.Name = "showhideperf_button";
            this.showhideperf_button.Size = new System.Drawing.Size(689, 19);
            this.showhideperf_button.TabIndex = 30;
            this.showhideperf_button.Text = "Hide Performance Information";
            this.showhideperf_button.UseVisualStyleBackColor = true;
            this.showhideperf_button.Click += new System.EventHandler(this.ShowHidePerfButton);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newServerWizardToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownClosed += new System.EventHandler(this.file_DropDownClosed);
            this.fileToolStripMenuItem.DropDownOpened += new System.EventHandler(this.file_ChangeColor);
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.file_ChangeColor);
            this.fileToolStripMenuItem.EnabledChanged += new System.EventHandler(this.file_ChangeColor);
            this.fileToolStripMenuItem.MouseEnter += new System.EventHandler(this.file_ChangeColor);
            this.fileToolStripMenuItem.MouseHover += new System.EventHandler(this.file_DropDownClosed);
            // 
            // newServerWizardToolStripMenuItem
            // 
            this.newServerWizardToolStripMenuItem.Name = "newServerWizardToolStripMenuItem";
            this.newServerWizardToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newServerWizardToolStripMenuItem.Text = "New Server Wizard";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.DropDownClosed += new System.EventHandler(this.edit_DropDownClosed);
            this.editToolStripMenuItem.DropDownOpened += new System.EventHandler(this.edit_ChangeColor);
            this.editToolStripMenuItem.Click += new System.EventHandler(this.edit_ChangeColor);
            this.editToolStripMenuItem.MouseEnter += new System.EventHandler(this.edit_ChangeColor);
            this.editToolStripMenuItem.MouseHover += new System.EventHandler(this.edit_DropDownClosed);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationSettingsToolStripMenuItem,
            this.gameServerSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.DropDownClosed += new System.EventHandler(this.settings_DropDownClosed);
            this.settingsToolStripMenuItem.DropDownOpened += new System.EventHandler(this.settings_ChangeColor);
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settings_ChangeColor);
            this.settingsToolStripMenuItem.MouseEnter += new System.EventHandler(this.settings_ChangeColor);
            this.settingsToolStripMenuItem.MouseHover += new System.EventHandler(this.settings_DropDownClosed);
            // 
            // applicationSettingsToolStripMenuItem
            // 
            this.applicationSettingsToolStripMenuItem.Name = "applicationSettingsToolStripMenuItem";
            this.applicationSettingsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.applicationSettingsToolStripMenuItem.Text = "Application Settings";
            // 
            // gameServerSettingsToolStripMenuItem
            // 
            this.gameServerSettingsToolStripMenuItem.Name = "gameServerSettingsToolStripMenuItem";
            this.gameServerSettingsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gameServerSettingsToolStripMenuItem.Text = "Game Server Settings";
            this.gameServerSettingsToolStripMenuItem.Click += new System.EventHandler(this.GameServerSettings_Clicked);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideGamePanelToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.DropDownClosed += new System.EventHandler(this.view_DropDownClosed);
            this.viewToolStripMenuItem.DropDownOpened += new System.EventHandler(this.view_ChangeColor);
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.view_ChangeColor);
            this.viewToolStripMenuItem.MouseEnter += new System.EventHandler(this.view_ChangeColor);
            this.viewToolStripMenuItem.MouseHover += new System.EventHandler(this.view_DropDownClosed);
            // 
            // showHideGamePanelToolStripMenuItem
            // 
            this.showHideGamePanelToolStripMenuItem.Name = "showHideGamePanelToolStripMenuItem";
            this.showHideGamePanelToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.showHideGamePanelToolStripMenuItem.Text = "Switch to Minimalist View";
            this.showHideGamePanelToolStripMenuItem.Click += new System.EventHandler(this.MinimalistView_Clicked);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.DropDownClosed += new System.EventHandler(this.help_DropDownClosed);
            this.helpToolStripMenuItem.DropDownOpened += new System.EventHandler(this.help_ChangeColor);
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.help_ChangeColor);
            this.helpToolStripMenuItem.MouseEnter += new System.EventHandler(this.help_ChangeColor);
            this.helpToolStripMenuItem.MouseHover += new System.EventHandler(this.help_DropDownClosed);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 52);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(804, 13);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 60;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(-1, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Click to Show / Hide";
            // 
            // statusStripForm
            // 
            this.statusStripForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUptimeLabel});
            this.statusStripForm.Location = new System.Drawing.Point(0, 415);
            this.statusStripForm.Name = "statusStripForm";
            this.statusStripForm.Size = new System.Drawing.Size(804, 22);
            this.statusStripForm.TabIndex = 6;
            this.statusStripForm.Text = "statusStrip1";
            // 
            // currentUptimeLabel
            // 
            this.currentUptimeLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.currentUptimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentUptimeLabel.Name = "currentUptimeLabel";
            this.currentUptimeLabel.Size = new System.Drawing.Size(134, 17);
            this.currentUptimeLabel.Text = "Gathering Information...";
            // 
            // pingTimer
            // 
            this.pingTimer.Enabled = true;
            this.pingTimer.Interval = 1500;
            this.pingTimer.Tick += new System.EventHandler(this.ping_timer);
            // 
            // ConnectivityCheck_Timer
            // 
            this.ConnectivityCheck_Timer.Enabled = true;
            this.ConnectivityCheck_Timer.Interval = 1500;
            this.ConnectivityCheck_Timer.Tick += new System.EventHandler(this.ConnectivityCheck_tick);
            // 
            // showhidesplit
            // 
            this.showhidesplit.BackgroundImage = global::Server_Manager.Properties.Resources.menucollapseright;
            this.showhidesplit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showhidesplit.Location = new System.Drawing.Point(102, 28);
            this.showhidesplit.Name = "showhidesplit";
            this.showhidesplit.Size = new System.Drawing.Size(21, 22);
            this.showhidesplit.TabIndex = 4;
            this.showhidesplit.UseVisualStyleBackColor = true;
            this.showhidesplit.Click += new System.EventHandler(this.OpenClosesplitcontainer);
            // 
            // PerformanceInformationTimer
            // 
            this.PerformanceInformationTimer.Enabled = true;
            this.PerformanceInformationTimer.Interval = 1000;
            this.PerformanceInformationTimer.Tick += new System.EventHandler(this.Performance_tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(804, 437);
            this.Controls.Add(this.statusStripForm);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.showhidesplit);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "-=Game Server Manager=-";
            this.Load += new System.EventHandler(this.LoadForm);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStripServerSelection.ResumeLayout(false);
            this.statusStripServerSelection.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripForm.ResumeLayout(false);
            this.statusStripForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label currentApplicationSelection;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newServerWizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameServerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox localipaddressbox;
        private System.Windows.Forms.TextBox publicipaddressbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentPing;
        private System.Windows.Forms.Label serviceStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox computernamebox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.StatusStrip statusStripServerSelection;
        private System.Windows.Forms.ToolStripStatusLabel statuslabelServerSelection;
        private System.Windows.Forms.TextBox networkusagebox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button showhidesplit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button showhideperf_button;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.StatusStrip statusStripForm;
        private System.Windows.Forms.ToolStripStatusLabel currentUptimeLabel;
        private System.Windows.Forms.Timer pingTimer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cpuUsageBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideGamePanelToolStripMenuItem;
        private System.Windows.Forms.Timer ConnectivityCheck_Timer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Timer PerformanceInformationTimer;
    }
}

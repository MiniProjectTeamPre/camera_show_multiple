namespace camera_show {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frameHeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Frame_height = new System.Windows.Forms.ToolStripMenuItem();
            this.frameWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Frame_width = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processTimeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Process_timeout_ = new System.Windows.Forms.ToolStripMenuItem();
            this.processRoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Process_roi_ = new System.Windows.Forms.ToolStripMenuItem();
            this.processScaleLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Process_scale_limit_ = new System.Windows.Forms.ToolStripMenuItem();
            this.processScaleNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Process_scale_next_ = new System.Windows.Forms.ToolStripMenuItem();
            this.processAutoFocusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctms_autoFocusTrue = new System.Windows.Forms.ToolStripMenuItem();
            this.ctms_autoFocusFalse = new System.Windows.Forms.ToolStripMenuItem();
            this.addStepComparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configLeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config_cam1 = new System.Windows.Forms.ToolStripMenuItem();
            this.config_cam2 = new System.Windows.Forms.ToolStripMenuItem();
            this.config_cam3 = new System.Windows.Forms.ToolStripMenuItem();
            this.config_cam4 = new System.Windows.Forms.ToolStripMenuItem();
            this.config_cam5 = new System.Windows.Forms.ToolStripMenuItem();
            this.config_cam6 = new System.Windows.Forms.ToolStripMenuItem();
            this.config_cam7 = new System.Windows.Forms.ToolStripMenuItem();
            this.config_cam8 = new System.Windows.Forms.ToolStripMenuItem();
            this.config_cam9 = new System.Windows.Forms.ToolStripMenuItem();
            this.config_cam10 = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headInHeadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.head_in_head = new System.Windows.Forms.ToolStripMenuItem();
            this.numHeadInHeadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Num_head_in_head = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_aktiveForm = new System.Windows.Forms.Timer(this.components);
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v202202ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGammaAddressInCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctms_setGammaAddressCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.ctms_propertySetting = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 237);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCameraToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.setDebugToolStripMenuItem,
            this.setPortToolStripMenuItem,
            this.frameToolStripMenuItem,
            this.processToolStripMenuItem,
            this.addStepComparToolStripMenuItem,
            this.configLeToolStripMenuItem,
            this.headInHeadToolStripMenuItem,
            this.numHeadInHeadToolStripMenuItem,
            this.setGammaAddressInCSVToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 290);
            // 
            // setCameraToolStripMenuItem
            // 
            this.setCameraToolStripMenuItem.Name = "setCameraToolStripMenuItem";
            this.setCameraToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.setCameraToolStripMenuItem.Text = "set camera";
            this.setCameraToolStripMenuItem.Click += new System.EventHandler(this.setCameraToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // setDebugToolStripMenuItem
            // 
            this.setDebugToolStripMenuItem.Name = "setDebugToolStripMenuItem";
            this.setDebugToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.setDebugToolStripMenuItem.Text = "set debug";
            this.setDebugToolStripMenuItem.Click += new System.EventHandler(this.setDebugToolStripMenuItem_Click);
            // 
            // setPortToolStripMenuItem
            // 
            this.setPortToolStripMenuItem.Name = "setPortToolStripMenuItem";
            this.setPortToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.setPortToolStripMenuItem.Text = "set port";
            this.setPortToolStripMenuItem.Click += new System.EventHandler(this.setPortToolStripMenuItem_Click);
            // 
            // frameToolStripMenuItem
            // 
            this.frameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frameHeightToolStripMenuItem,
            this.frameWidthToolStripMenuItem});
            this.frameToolStripMenuItem.Name = "frameToolStripMenuItem";
            this.frameToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.frameToolStripMenuItem.Text = "frame";
            // 
            // frameHeightToolStripMenuItem
            // 
            this.frameHeightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Frame_height});
            this.frameHeightToolStripMenuItem.Name = "frameHeightToolStripMenuItem";
            this.frameHeightToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.frameHeightToolStripMenuItem.Text = "frame height";
            // 
            // Frame_height
            // 
            this.Frame_height.Name = "Frame_height";
            this.Frame_height.Size = new System.Drawing.Size(92, 22);
            this.Frame_height.Text = "800";
            this.Frame_height.Click += new System.EventHandler(this.Frame_height_Click);
            // 
            // frameWidthToolStripMenuItem
            // 
            this.frameWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Frame_width});
            this.frameWidthToolStripMenuItem.Name = "frameWidthToolStripMenuItem";
            this.frameWidthToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.frameWidthToolStripMenuItem.Text = "frame width";
            // 
            // Frame_width
            // 
            this.Frame_width.Name = "Frame_width";
            this.Frame_width.Size = new System.Drawing.Size(92, 22);
            this.Frame_width.Text = "600";
            this.Frame_width.Click += new System.EventHandler(this.Frame_width_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processTimeoutToolStripMenuItem,
            this.processRoiToolStripMenuItem,
            this.processScaleLimitToolStripMenuItem,
            this.processScaleNextToolStripMenuItem,
            this.processAutoFocusToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.processToolStripMenuItem.Text = "process";
            // 
            // processTimeoutToolStripMenuItem
            // 
            this.processTimeoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Process_timeout_});
            this.processTimeoutToolStripMenuItem.Name = "processTimeoutToolStripMenuItem";
            this.processTimeoutToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.processTimeoutToolStripMenuItem.Text = "process timeout";
            // 
            // Process_timeout_
            // 
            this.Process_timeout_.Name = "Process_timeout_";
            this.Process_timeout_.Size = new System.Drawing.Size(92, 22);
            this.Process_timeout_.Text = "500";
            this.Process_timeout_.Click += new System.EventHandler(this.Process_timeout__Click);
            // 
            // processRoiToolStripMenuItem
            // 
            this.processRoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Process_roi_});
            this.processRoiToolStripMenuItem.Name = "processRoiToolStripMenuItem";
            this.processRoiToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.processRoiToolStripMenuItem.Text = "process roi";
            // 
            // Process_roi_
            // 
            this.Process_roi_.Name = "Process_roi_";
            this.Process_roi_.Size = new System.Drawing.Size(86, 22);
            this.Process_roi_.Text = "10";
            this.Process_roi_.Click += new System.EventHandler(this.Process_roi__Click);
            // 
            // processScaleLimitToolStripMenuItem
            // 
            this.processScaleLimitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Process_scale_limit_});
            this.processScaleLimitToolStripMenuItem.Name = "processScaleLimitToolStripMenuItem";
            this.processScaleLimitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.processScaleLimitToolStripMenuItem.Text = "process scale limit";
            // 
            // Process_scale_limit_
            // 
            this.Process_scale_limit_.Name = "Process_scale_limit_";
            this.Process_scale_limit_.Size = new System.Drawing.Size(86, 22);
            this.Process_scale_limit_.Text = "40";
            this.Process_scale_limit_.Click += new System.EventHandler(this.Process_scale_limit__Click);
            // 
            // processScaleNextToolStripMenuItem
            // 
            this.processScaleNextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Process_scale_next_});
            this.processScaleNextToolStripMenuItem.Name = "processScaleNextToolStripMenuItem";
            this.processScaleNextToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.processScaleNextToolStripMenuItem.Text = "process scale next";
            // 
            // Process_scale_next_
            // 
            this.Process_scale_next_.Name = "Process_scale_next_";
            this.Process_scale_next_.Size = new System.Drawing.Size(80, 22);
            this.Process_scale_next_.Text = "2";
            this.Process_scale_next_.Click += new System.EventHandler(this.Process_scale_next__Click);
            // 
            // processAutoFocusToolStripMenuItem
            // 
            this.processAutoFocusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctms_autoFocusTrue,
            this.ctms_autoFocusFalse});
            this.processAutoFocusToolStripMenuItem.Name = "processAutoFocusToolStripMenuItem";
            this.processAutoFocusToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.processAutoFocusToolStripMenuItem.Text = "Process Auto Focus";
            // 
            // ctms_autoFocusTrue
            // 
            this.ctms_autoFocusTrue.Checked = true;
            this.ctms_autoFocusTrue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctms_autoFocusTrue.Name = "ctms_autoFocusTrue";
            this.ctms_autoFocusTrue.Size = new System.Drawing.Size(100, 22);
            this.ctms_autoFocusTrue.Text = "True";
            this.ctms_autoFocusTrue.Click += new System.EventHandler(this.ctms_autoFocusTrue_Click);
            // 
            // ctms_autoFocusFalse
            // 
            this.ctms_autoFocusFalse.Name = "ctms_autoFocusFalse";
            this.ctms_autoFocusFalse.Size = new System.Drawing.Size(100, 22);
            this.ctms_autoFocusFalse.Text = "False";
            this.ctms_autoFocusFalse.Click += new System.EventHandler(this.ctms_autoFocusFalse_Click);
            // 
            // addStepComparToolStripMenuItem
            // 
            this.addStepComparToolStripMenuItem.Name = "addStepComparToolStripMenuItem";
            this.addStepComparToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.addStepComparToolStripMenuItem.Text = "add step compar";
            this.addStepComparToolStripMenuItem.Click += new System.EventHandler(this.addStepComparToolStripMenuItem_Click);
            // 
            // configLeToolStripMenuItem
            // 
            this.configLeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.config_cam1,
            this.config_cam2,
            this.config_cam3,
            this.config_cam4,
            this.config_cam5,
            this.config_cam6,
            this.config_cam7,
            this.config_cam8,
            this.config_cam9,
            this.config_cam10,
            this.runToolStripMenuItem});
            this.configLeToolStripMenuItem.Name = "configLeToolStripMenuItem";
            this.configLeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.configLeToolStripMenuItem.Text = "config length cam";
            // 
            // config_cam1
            // 
            this.config_cam1.CheckOnClick = true;
            this.config_cam1.Name = "config_cam1";
            this.config_cam1.Size = new System.Drawing.Size(92, 22);
            this.config_cam1.Text = "1";
            // 
            // config_cam2
            // 
            this.config_cam2.CheckOnClick = true;
            this.config_cam2.Name = "config_cam2";
            this.config_cam2.Size = new System.Drawing.Size(92, 22);
            this.config_cam2.Text = "2";
            // 
            // config_cam3
            // 
            this.config_cam3.CheckOnClick = true;
            this.config_cam3.Name = "config_cam3";
            this.config_cam3.Size = new System.Drawing.Size(92, 22);
            this.config_cam3.Text = "3";
            // 
            // config_cam4
            // 
            this.config_cam4.CheckOnClick = true;
            this.config_cam4.Name = "config_cam4";
            this.config_cam4.Size = new System.Drawing.Size(92, 22);
            this.config_cam4.Text = "4";
            // 
            // config_cam5
            // 
            this.config_cam5.CheckOnClick = true;
            this.config_cam5.Name = "config_cam5";
            this.config_cam5.Size = new System.Drawing.Size(92, 22);
            this.config_cam5.Text = "5";
            // 
            // config_cam6
            // 
            this.config_cam6.CheckOnClick = true;
            this.config_cam6.Name = "config_cam6";
            this.config_cam6.Size = new System.Drawing.Size(92, 22);
            this.config_cam6.Text = "6";
            // 
            // config_cam7
            // 
            this.config_cam7.CheckOnClick = true;
            this.config_cam7.Name = "config_cam7";
            this.config_cam7.Size = new System.Drawing.Size(92, 22);
            this.config_cam7.Text = "7";
            // 
            // config_cam8
            // 
            this.config_cam8.CheckOnClick = true;
            this.config_cam8.Name = "config_cam8";
            this.config_cam8.Size = new System.Drawing.Size(92, 22);
            this.config_cam8.Text = "8";
            // 
            // config_cam9
            // 
            this.config_cam9.CheckOnClick = true;
            this.config_cam9.Name = "config_cam9";
            this.config_cam9.Size = new System.Drawing.Size(92, 22);
            this.config_cam9.Text = "9";
            // 
            // config_cam10
            // 
            this.config_cam10.CheckOnClick = true;
            this.config_cam10.Name = "config_cam10";
            this.config_cam10.Size = new System.Drawing.Size(92, 22);
            this.config_cam10.Text = "10";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.runToolStripMenuItem.Text = "run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // headInHeadToolStripMenuItem
            // 
            this.headInHeadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.head_in_head});
            this.headInHeadToolStripMenuItem.Name = "headInHeadToolStripMenuItem";
            this.headInHeadToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.headInHeadToolStripMenuItem.Text = "head in head";
            // 
            // head_in_head
            // 
            this.head_in_head.Name = "head_in_head";
            this.head_in_head.Size = new System.Drawing.Size(80, 22);
            this.head_in_head.Text = "1";
            this.head_in_head.Click += new System.EventHandler(this.head_in_head_Click);
            // 
            // numHeadInHeadToolStripMenuItem
            // 
            this.numHeadInHeadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Num_head_in_head});
            this.numHeadInHeadToolStripMenuItem.Name = "numHeadInHeadToolStripMenuItem";
            this.numHeadInHeadToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.numHeadInHeadToolStripMenuItem.Text = "num head in head";
            // 
            // Num_head_in_head
            // 
            this.Num_head_in_head.Name = "Num_head_in_head";
            this.Num_head_in_head.Size = new System.Drawing.Size(80, 22);
            this.Num_head_in_head.Text = "1";
            this.Num_head_in_head.Click += new System.EventHandler(this.Num_head_in_head_Click);
            // 
            // tm_aktiveForm
            // 
            this.tm_aktiveForm.Interval = 5000;
            this.tm_aktiveForm.Tick += new System.EventHandler(this.tm_aktiveForm_Tick);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v202202ToolStripMenuItem});
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // v202202ToolStripMenuItem
            // 
            this.v202202ToolStripMenuItem.Name = "v202202ToolStripMenuItem";
            this.v202202ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.v202202ToolStripMenuItem.Text = "V2022.02";
            // 
            // setGammaAddressInCSVToolStripMenuItem
            // 
            this.setGammaAddressInCSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctms_setGammaAddressCsv,
            this.ctms_propertySetting});
            this.setGammaAddressInCSVToolStripMenuItem.Name = "setGammaAddressInCSVToolStripMenuItem";
            this.setGammaAddressInCSVToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.setGammaAddressInCSVToolStripMenuItem.Text = "Set Gamma (Address in CSV)";
            // 
            // ctms_setGammaAddressCsv
            // 
            this.ctms_setGammaAddressCsv.Name = "ctms_setGammaAddressCsv";
            this.ctms_setGammaAddressCsv.Size = new System.Drawing.Size(180, 22);
            this.ctms_setGammaAddressCsv.Text = "100";
            this.ctms_setGammaAddressCsv.Click += new System.EventHandler(this.ctms_setGammaAddressCsv_Click);
            // 
            // ctms_propertySetting
            // 
            this.ctms_propertySetting.Name = "ctms_propertySetting";
            this.ctms_propertySetting.Size = new System.Drawing.Size(180, 22);
            this.ctms_propertySetting.Text = "Property Setting";
            this.ctms_propertySetting.Click += new System.EventHandler(this.ctms_propertySetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(274, 247);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDebugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStepComparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configLeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frameHeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Frame_height;
        private System.Windows.Forms.ToolStripMenuItem frameWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Frame_width;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processTimeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processRoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processScaleLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Process_timeout_;
        private System.Windows.Forms.ToolStripMenuItem Process_roi_;
        private System.Windows.Forms.ToolStripMenuItem Process_scale_limit_;
        private System.Windows.Forms.ToolStripMenuItem processScaleNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Process_scale_next_;
        private System.Windows.Forms.ToolStripMenuItem config_cam1;
        private System.Windows.Forms.ToolStripMenuItem config_cam2;
        private System.Windows.Forms.ToolStripMenuItem config_cam3;
        private System.Windows.Forms.ToolStripMenuItem config_cam4;
        private System.Windows.Forms.ToolStripMenuItem config_cam5;
        private System.Windows.Forms.ToolStripMenuItem config_cam6;
        private System.Windows.Forms.ToolStripMenuItem config_cam7;
        private System.Windows.Forms.ToolStripMenuItem config_cam8;
        private System.Windows.Forms.ToolStripMenuItem config_cam9;
        private System.Windows.Forms.ToolStripMenuItem config_cam10;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headInHeadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem head_in_head;
        private System.Windows.Forms.ToolStripMenuItem numHeadInHeadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Num_head_in_head;
        private System.Windows.Forms.Timer tm_aktiveForm;
        private System.Windows.Forms.ToolStripMenuItem processAutoFocusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctms_autoFocusTrue;
        private System.Windows.Forms.ToolStripMenuItem ctms_autoFocusFalse;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v202202ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGammaAddressInCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctms_setGammaAddressCsv;
        private System.Windows.Forms.ToolStripMenuItem ctms_propertySetting;
    }
}


namespace WindowsFormsApplication1
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
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDeviceList = new System.Windows.Forms.ComboBox();
            this.btnStartAll = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbCmdList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.erver = new System.Windows.Forms.Label();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStopSession = new System.Windows.Forms.Button();
            this.btnRecordSession = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLaunchBLEServer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbConsole
            // 
            this.tbConsole.Location = new System.Drawing.Point(13, 361);
            this.tbConsole.Margin = new System.Windows.Forms.Padding(4);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.Size = new System.Drawing.Size(326, 133);
            this.tbConsole.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Process Status";
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(348, 63);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 263);
            this.tabControl1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbDeviceList);
            this.panel2.Controls.Add(this.btnStartAll);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.cbCmdList);
            this.panel2.Location = new System.Drawing.Point(18, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 99);
            this.panel2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(125, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Command";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(35, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Device List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Device Connection";
            // 
            // cbDeviceList
            // 
            this.cbDeviceList.FormattingEnabled = true;
            this.cbDeviceList.Location = new System.Drawing.Point(25, 51);
            this.cbDeviceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDeviceList.Name = "cbDeviceList";
            this.cbDeviceList.Size = new System.Drawing.Size(95, 24);
            this.cbDeviceList.TabIndex = 1;
            // 
            // btnStartAll
            // 
            this.btnStartAll.Location = new System.Drawing.Point(232, 53);
            this.btnStartAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartAll.Name = "btnStartAll";
            this.btnStartAll.Size = new System.Drawing.Size(81, 36);
            this.btnStartAll.TabIndex = 9;
            this.btnStartAll.Text = "Start All";
            this.btnStartAll.UseVisualStyleBackColor = true;
            this.btnStartAll.Click += new System.EventHandler(this.btnStartAll_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(232, 20);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 36);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbCmdList
            // 
            this.cbCmdList.FormattingEnabled = true;
            this.cbCmdList.Items.AddRange(new object[] {
            "gsr",
            "acc",
            "bvp",
            "ibi",
            "tmp"});
            this.cbCmdList.Location = new System.Drawing.Point(126, 51);
            this.cbCmdList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCmdList.Name = "cbCmdList";
            this.cbCmdList.Size = new System.Drawing.Size(70, 24);
            this.cbCmdList.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.erver);
            this.panel1.Controls.Add(this.tbServerIP);
            this.panel1.Controls.Add(this.tbServerPort);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Location = new System.Drawing.Point(15, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 76);
            this.panel1.TabIndex = 15;
            // 
            // erver
            // 
            this.erver.AutoSize = true;
            this.erver.Location = new System.Drawing.Point(82, 0);
            this.erver.Name = "erver";
            this.erver.Size = new System.Drawing.Size(115, 17);
            this.erver.TabIndex = 13;
            this.erver.Text = "Server End Point";
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(25, 39);
            this.tbServerIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(95, 22);
            this.tbServerIP.TabIndex = 5;
            this.tbServerIP.Text = "127.0.0.1";
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(126, 39);
            this.tbServerPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(70, 22);
            this.tbServerPort.TabIndex = 6;
            this.tbServerPort.Text = "28000";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(232, 36);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(81, 29);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnConnect.UseCompatibleTextRendering = true;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnStopSession);
            this.panel3.Controls.Add(this.btnRecordSession);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(18, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 76);
            this.panel3.TabIndex = 17;
            // 
            // btnStopSession
            // 
            this.btnStopSession.Location = new System.Drawing.Point(225, 31);
            this.btnStopSession.Name = "btnStopSession";
            this.btnStopSession.Size = new System.Drawing.Size(81, 30);
            this.btnStopSession.TabIndex = 20;
            this.btnStopSession.Text = "Stop";
            this.btnStopSession.UseVisualStyleBackColor = true;
            this.btnStopSession.Click += new System.EventHandler(this.btnStopSession_Click);
            // 
            // btnRecordSession
            // 
            this.btnRecordSession.Location = new System.Drawing.Point(19, 32);
            this.btnRecordSession.Name = "btnRecordSession";
            this.btnRecordSession.Size = new System.Drawing.Size(81, 29);
            this.btnRecordSession.TabIndex = 19;
            this.btnRecordSession.Text = "Record";
            this.btnRecordSession.UseVisualStyleBackColor = true;
            this.btnRecordSession.Click += new System.EventHandler(this.btnRecordSession_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Session";
            // 
            // btnLaunchBLEServer
            // 
            this.btnLaunchBLEServer.Location = new System.Drawing.Point(43, 12);
            this.btnLaunchBLEServer.Name = "btnLaunchBLEServer";
            this.btnLaunchBLEServer.Size = new System.Drawing.Size(255, 45);
            this.btnLaunchBLEServer.TabIndex = 18;
            this.btnLaunchBLEServer.Text = "Launch BLE Server";
            this.btnLaunchBLEServer.UseVisualStyleBackColor = true;
            this.btnLaunchBLEServer.Click += new System.EventHandler(this.btnLaunchBLEServer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(699, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 263);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 699);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLaunchBLEServer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbConsole);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDeviceList;
        private System.Windows.Forms.Button btnStartAll;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbCmdList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label erver;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStopSession;
        private System.Windows.Forms.Button btnRecordSession;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLaunchBLEServer;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}


namespace ClassTestUDPClient
{
    partial class Client
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBoxHistory = new System.Windows.Forms.TextBox();
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.txtBoxServerPortNo = new System.Windows.Forms.TextBox();
            this.txtBoxIpAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnectServer = new System.Windows.Forms.Button();
            this.txtBoxClientPortNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(363, 268);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBoxHistory
            // 
            this.txtBoxHistory.Location = new System.Drawing.Point(120, 82);
            this.txtBoxHistory.Multiline = true;
            this.txtBoxHistory.Name = "txtBoxHistory";
            this.txtBoxHistory.Size = new System.Drawing.Size(212, 143);
            this.txtBoxHistory.TabIndex = 16;
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.Location = new System.Drawing.Point(120, 270);
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(212, 20);
            this.txtBoxMessage.TabIndex = 15;
            // 
            // txtBoxServerPortNo
            // 
            this.txtBoxServerPortNo.Location = new System.Drawing.Point(120, 46);
            this.txtBoxServerPortNo.Name = "txtBoxServerPortNo";
            this.txtBoxServerPortNo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxServerPortNo.TabIndex = 14;
            this.txtBoxServerPortNo.Text = "45000";
            // 
            // txtBoxIpAddress
            // 
            this.txtBoxIpAddress.Location = new System.Drawing.Point(120, 12);
            this.txtBoxIpAddress.Name = "txtBoxIpAddress";
            this.txtBoxIpAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIpAddress.TabIndex = 13;
            this.txtBoxIpAddress.Text = "192.168.59.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "History";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Server Port No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server IPAddress";
            // 
            // btnConnectServer
            // 
            this.btnConnectServer.Location = new System.Drawing.Point(240, 44);
            this.btnConnectServer.Name = "btnConnectServer";
            this.btnConnectServer.Size = new System.Drawing.Size(98, 23);
            this.btnConnectServer.TabIndex = 18;
            this.btnConnectServer.Text = "Connect Server";
            this.btnConnectServer.UseVisualStyleBackColor = true;
            this.btnConnectServer.Click += new System.EventHandler(this.btnConnectServer_Click);
            // 
            // txtBoxClientPortNo
            // 
            this.txtBoxClientPortNo.Location = new System.Drawing.Point(343, 6);
            this.txtBoxClientPortNo.Name = "txtBoxClientPortNo";
            this.txtBoxClientPortNo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxClientPortNo.TabIndex = 20;
            this.txtBoxClientPortNo.Text = "54000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Client Port No";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 345);
            this.Controls.Add(this.txtBoxClientPortNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConnectServer);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBoxHistory);
            this.Controls.Add(this.txtBoxMessage);
            this.Controls.Add(this.txtBoxServerPortNo);
            this.Controls.Add(this.txtBoxIpAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtBoxHistory;
        private System.Windows.Forms.TextBox txtBoxMessage;
        private System.Windows.Forms.TextBox txtBoxServerPortNo;
        private System.Windows.Forms.TextBox txtBoxIpAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnectServer;
        private System.Windows.Forms.TextBox txtBoxClientPortNo;
        private System.Windows.Forms.Label label5;
    }
}


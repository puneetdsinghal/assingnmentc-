
namespace NetworkScannerHome
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
            this.maskedTextBoxIP = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSubnetMask = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Check_Status = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheckPort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listPort = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBoxIP
            // 
            this.maskedTextBoxIP.Location = new System.Drawing.Point(123, 53);
            this.maskedTextBoxIP.Mask = "000.000.000.000";
            this.maskedTextBoxIP.Name = "maskedTextBoxIP";
            this.maskedTextBoxIP.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxIP.TabIndex = 0;
            this.maskedTextBoxIP.Text = "010011020188";
            this.maskedTextBoxIP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxIP_MaskInputRejected);
            this.maskedTextBoxIP.Enter += new System.EventHandler(this.maskedTextBoxIP_Enter);
            this.maskedTextBoxIP.Leave += new System.EventHandler(this.maskedTextBoxIP_Leave);
            // 
            // maskedTextBoxSubnetMask
            // 
            this.maskedTextBoxSubnetMask.Location = new System.Drawing.Point(331, 53);
            this.maskedTextBoxSubnetMask.Mask = "000.000.000.000";
            this.maskedTextBoxSubnetMask.Name = "maskedTextBoxSubnetMask";
            this.maskedTextBoxSubnetMask.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSubnetMask.TabIndex = 1;
            this.maskedTextBoxSubnetMask.Text = "255255255000";
            this.maskedTextBoxSubnetMask.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxSubnetMask_MaskInputRejected);
            this.maskedTextBoxSubnetMask.Enter += new System.EventHandler(this.maskedTextBoxSubnetMask_Enter);
            this.maskedTextBoxSubnetMask.Leave += new System.EventHandler(this.maskedTextBoxSubnetMask_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subnet Mask";
            // 
            // button_Check_Status
            // 
            this.button_Check_Status.Location = new System.Drawing.Point(203, 131);
            this.button_Check_Status.Name = "button_Check_Status";
            this.button_Check_Status.Size = new System.Drawing.Size(111, 23);
            this.button_Check_Status.TabIndex = 4;
            this.button_Check_Status.Text = "Check Status";
            this.button_Check_Status.UseVisualStyleBackColor = true;
            this.button_Check_Status.Click += new System.EventHandler(this.button_Check_Status_Click);
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(34, 220);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(189, 95);
            this.listResult.TabIndex = 5;
            this.listResult.SelectedIndexChanged += new System.EventHandler(this.listResult_SelectedIndexChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(261, 250);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "label3";
            // 
            // btnCheckPort
            // 
            this.btnCheckPort.Location = new System.Drawing.Point(344, 245);
            this.btnCheckPort.Name = "btnCheckPort";
            this.btnCheckPort.Size = new System.Drawing.Size(75, 23);
            this.btnCheckPort.TabIndex = 7;
            this.btnCheckPort.Text = "Check Port";
            this.btnCheckPort.UseVisualStyleBackColor = true;
            this.btnCheckPort.Click += new System.EventHandler(this.btnCheckPort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select IP to know port";
            // 
            // listPort
            // 
            this.listPort.FormattingEnabled = true;
            this.listPort.Location = new System.Drawing.Point(462, 220);
            this.listPort.Name = "listPort";
            this.listPort.Size = new System.Drawing.Size(165, 56);
            this.listPort.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Active ports";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheckPort);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.button_Check_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxSubnetMask);
            this.Controls.Add(this.maskedTextBoxIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxIP;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSubnetMask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Check_Status;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCheckPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listPort;
        private System.Windows.Forms.Label label4;
    }
}


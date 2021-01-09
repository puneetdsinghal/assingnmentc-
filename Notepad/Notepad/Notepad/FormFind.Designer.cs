namespace Notepad
{
    partial class FormFind
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
            this.lblFindWhat = new System.Windows.Forms.Label();
            this.txtBoxFindNext = new System.Windows.Forms.TextBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnDown = new System.Windows.Forms.RadioButton();
            this.radioBtnUp = new System.Windows.Forms.RadioButton();
            this.chkBoxMatchCase = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFindWhat
            // 
            this.lblFindWhat.AutoSize = true;
            this.lblFindWhat.Location = new System.Drawing.Point(12, 9);
            this.lblFindWhat.Name = "lblFindWhat";
            this.lblFindWhat.Size = new System.Drawing.Size(59, 13);
            this.lblFindWhat.TabIndex = 0;
            this.lblFindWhat.Text = "Find What:";
            // 
            // txtBoxFindNext
            // 
            this.txtBoxFindNext.Location = new System.Drawing.Point(77, 6);
            this.txtBoxFindNext.Name = "txtBoxFindNext";
            this.txtBoxFindNext.Size = new System.Drawing.Size(161, 20);
            this.txtBoxFindNext.TabIndex = 1;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(249, 6);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 2;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 35);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnDown);
            this.groupBox1.Controls.Add(this.radioBtnUp);
            this.groupBox1.Location = new System.Drawing.Point(153, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 46);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // radioBtnDown
            // 
            this.radioBtnDown.AutoSize = true;
            this.radioBtnDown.Location = new System.Drawing.Point(51, 16);
            this.radioBtnDown.Name = "radioBtnDown";
            this.radioBtnDown.Size = new System.Drawing.Size(53, 17);
            this.radioBtnDown.TabIndex = 1;
            this.radioBtnDown.TabStop = true;
            this.radioBtnDown.Text = "Down";
            this.radioBtnDown.UseVisualStyleBackColor = true;
            this.radioBtnDown.CheckedChanged += new System.EventHandler(this.radioBtnDown_CheckedChanged);
            // 
            // radioBtnUp
            // 
            this.radioBtnUp.AutoSize = true;
            this.radioBtnUp.Location = new System.Drawing.Point(6, 16);
            this.radioBtnUp.Name = "radioBtnUp";
            this.radioBtnUp.Size = new System.Drawing.Size(39, 17);
            this.radioBtnUp.TabIndex = 0;
            this.radioBtnUp.TabStop = true;
            this.radioBtnUp.Text = "Up";
            this.radioBtnUp.UseVisualStyleBackColor = true;
            this.radioBtnUp.CheckedChanged += new System.EventHandler(this.radioBtnUp_CheckedChanged);
            // 
            // chkBoxMatchCase
            // 
            this.chkBoxMatchCase.AutoSize = true;
            this.chkBoxMatchCase.Location = new System.Drawing.Point(15, 93);
            this.chkBoxMatchCase.Name = "chkBoxMatchCase";
            this.chkBoxMatchCase.Size = new System.Drawing.Size(83, 17);
            this.chkBoxMatchCase.TabIndex = 5;
            this.chkBoxMatchCase.Text = "Match Case";
            this.chkBoxMatchCase.UseVisualStyleBackColor = true;
            this.chkBoxMatchCase.CheckedChanged += new System.EventHandler(this.chkBoxMatchCase_CheckedChanged);
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 135);
            this.Controls.Add(this.chkBoxMatchCase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtBoxFindNext);
            this.Controls.Add(this.lblFindWhat);
            this.Name = "FormFind";
            this.Text = "Find";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFindWhat;
        private System.Windows.Forms.TextBox txtBoxFindNext;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnDown;
        private System.Windows.Forms.RadioButton radioBtnUp;
        private System.Windows.Forms.CheckBox chkBoxMatchCase;
    }
}
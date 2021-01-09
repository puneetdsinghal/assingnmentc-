using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FormFind : Form
    {
        public string strFind;
        public bool findDirection;
        public bool findMatchCase;
        

        public FormFind()
        {
            InitializeComponent();
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            strFind = txtBoxFindNext.Text;
            //punNotepad objpunNotepad = new punNotepad();
            this.Close();

           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            strFind = "";
            this.Close();
        }

        private void radioBtnUp_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnUp.Checked == true)
                findDirection = true; 

        }

        private void radioBtnDown_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnDown.Checked == true)
                findDirection = false;
        }

        private void chkBoxMatchCase_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxMatchCase.Checked == true)
                findMatchCase = true;
            else
                findMatchCase = false;

        }
    }
}

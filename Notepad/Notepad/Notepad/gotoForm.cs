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
    public partial class gotoForm : Form
    {
        public int lineNumber;
       // RichTextBox richText;
        public gotoForm()
        {
            InitializeComponent();
            
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBoxLineNumber.Text, out lineNumber))
            {
                MessageBox.Show("enter integer");
            }
            else
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lineNumber = 0;
            this.Close();
        }

        private void gotoForm_Load(object sender, EventArgs e)
        {

        }
    }
}

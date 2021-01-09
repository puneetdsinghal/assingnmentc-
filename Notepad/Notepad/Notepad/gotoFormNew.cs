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
    public partial class gotoFormNew : Form
    {
        RichTextBox richText;

        public gotoFormNew(RichTextBox R)
        {
            InitializeComponent();
            richText = R;
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            int line = Int32.Parse(txtBoxLineNumber.Text);
            richText.SelectionStart = richText.GetFirstCharIndexFromLine(line - 1);
            richText.ScrollToCaret();
            this.Close();
        }
    }
}

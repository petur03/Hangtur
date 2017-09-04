using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangtur
{
    public partial class InputForm : Form
    {
        public InputForm(String title)
        {
            InitializeComponent();
            Text = title;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public String Input
        {
            get { return input.Text; }
        }

        private void Key_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                Ok_Click(null, null);
            } else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Cancel_Click(null, null);
            }
        }
    }
}

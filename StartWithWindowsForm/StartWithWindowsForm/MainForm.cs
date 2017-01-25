using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartWithWindowsForm
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 5)
            {
                Font ft = tbName.Font;
                Font newFont = new Font(ft.FontFamily, ft.Size, FontStyle.Underline);
                tbName.Font = newFont;
                tbName.ForeColor = Color.Red;
            }
            else
            {
                Font ft = tbName.Font;
                Font newFont = new Font(ft.FontFamily, ft.Size, FontStyle.Regular);
                tbName.Font = newFont;
                tbName.ForeColor = Color.Black;
            }
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            NameForm fr = new NameForm(tbName.Text);
            if (fr.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("You close name form", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

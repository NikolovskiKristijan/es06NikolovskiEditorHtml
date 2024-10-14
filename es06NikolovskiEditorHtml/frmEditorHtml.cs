using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es06NikolovskiEditorHtml
{
    public partial class frmEditorHtml : Form
    {
        public frmEditorHtml()
        {
            InitializeComponent();
        }

        private void frmEditorHtml_Load(object sender, EventArgs e)
        {
            txtHTML.MaxLength = 200;//32767;
            pgbChar.Maximum = txtHTML.MaxLength;
            visualizzaNchar();
        }

        private void visualizzaNchar()
        {
            lblChar.Text = "Numero Caratteri " + txtHTML.TextLength +
                "/" + txtHTML.MaxLength;
        }

        private void nuovoToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nuovo ToolBar");
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Nuovo Menu");
            //webBrowserHTML.Navigate("http://www.vallauri.edu");
        }

        private void txtHTML_TextChanged(object sender, EventArgs e)
        {
            pgbChar.Value = txtHTML.TextLength;
            visualizzaNchar();
        }

        private void tabControlHTML_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Name == "tabPageWeb")
                webBrowserHTML.DocumentText = txtHTML.Text;
        }
    }
}

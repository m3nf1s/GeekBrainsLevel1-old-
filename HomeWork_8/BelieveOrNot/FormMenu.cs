using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelieveOrNot
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonGame_Click(object sender, EventArgs e)
        {
            FormGame fg = new FormGame();
            this.Hide();
            fg.ShowDialog();
            this.Show();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BOY","God of War 4");
        }

        private void buttonEditor_Click(object sender, EventArgs e)
        {
            FormEditor fe = new FormEditor();
            this.Hide();
            fe.ShowDialog();
            this.Show();
        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            FormConverter fc = new FormConverter();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }
    }
}

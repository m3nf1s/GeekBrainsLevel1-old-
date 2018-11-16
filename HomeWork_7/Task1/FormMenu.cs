using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonMenuDoubler_Click(object sender, EventArgs e)
        {
            FormGame fg = new FormGame();
            this.Hide();
            fg.ShowDialog();
            this.Show();

        }

        private void buttonMenuGuessTheButton_Click(object sender, EventArgs e)
        {
            FormGuessTheNumber formGuessTheNumber = new FormGuessTheNumber();
            this.Hide();
            formGuessTheNumber.ShowDialog();
            this.Show();
        }

        private void buttonVacation_Click(object sender, EventArgs e)
        {
            FormVacation fv = new FormVacation();
            this.Hide();
            fv.ShowDialog();
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

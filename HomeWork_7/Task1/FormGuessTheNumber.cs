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
    public partial class FormGuessTheNumber : Form
    {
        private int number;
        private int count = 0;
        public FormGuessTheNumber()
        {
            InitializeComponent();
            MessageBox.Show("Компьютер загадал число от 1 до 100.\nВам необходимо его отгадать.");
            buttonApply.Enabled = false;
            textBox1.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonApply_Click(object sender, EventArgs e)
        {
            Win();
            MoreOrLess();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            number = rnd.Next(1, 101);
            buttonApply.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Text = "";
            labelHelp.Text = "А ты не плох ;)";
            labelCount.Text = "0";
        }

        private void Win()
        {
            try
            {
                if (number == int.Parse(textBox1.Text))
                {
                    textBox1.Enabled = false;
                    buttonApply.Enabled = false;
                    labelHelp.Text = "В точку";
                    MessageBox.Show("Вы угадали :)");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void MoreOrLess()
        {
            try
            {
                if (number > int.Parse(textBox1.Text))
                {
                    labelHelp.Text = "Число больше";
                    ++count;
                    labelCount.Text = count.ToString();
                }

                if (number < int.Parse(textBox1.Text))
                {
                    labelHelp.Text = "Число меньше";
                    ++count;
                    labelCount.Text = count.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Win();
                MoreOrLess();
            }
        }

    }
}

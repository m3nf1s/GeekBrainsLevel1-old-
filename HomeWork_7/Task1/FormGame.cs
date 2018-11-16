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
    public partial class FormGame : Form
    {
        Doubler dlb = null;
        Stack<string> stack = new Stack<string>();
        public FormGame()
        {
            InitializeComponent();
            MessageBox.Show("Компьютер загадал число от 1 до 100.\nВам необходимо его достичь за минимальное количество шагов.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddButton.Enabled = false;
            MultiButton.Enabled = false;
            ResetButton.Enabled = false;
            CancelButton.Enabled = false;
        }
        /*-----Кнопки-----*/
        private void AddButton_Click(object sender, EventArgs e)
        {
            labelCurrent.Text = dlb.Add().ToString();
            labelCount.Text = dlb.AddCount().ToString();
            ResetButton.Enabled = true;
            CancelButton.Enabled = true;
            ButtonsFalse();
            stack.Push("Add");
        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            labelCurrent.Text = dlb.Multi().ToString();
            labelCount.Text = dlb.AddCount().ToString();
            ResetButton.Enabled = true;
            CancelButton.Enabled = true;
            ButtonsFalse();
            stack.Push("Multi");
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            dlb.Buffer = dlb.Current;
            labelCurrent.Text = dlb.Reset().ToString();
            labelCount.Text = dlb.AddCount().ToString();
            stack.Push("Reset");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (stack.Peek() == "Add")
            {
                --dlb.Current;
                --dlb.Count;
                labelCount.Text = dlb.Count.ToString();
                labelCurrent.Text = dlb.Current.ToString();
                stack.Pop();
            }
            else if (stack.Peek() == "Multi")
            {
                dlb.Current /= 2;
                --dlb.Count;
                labelCount.Text = dlb.Count.ToString();
                labelCurrent.Text = dlb.Current.ToString();
                stack.Pop();
            }
            else if (stack.Peek() == "Reset")
            {
                dlb.Current = dlb.Buffer;
                --dlb.Count;
                labelCount.Text = dlb.Count.ToString();
                labelCurrent.Text = dlb.Current.ToString();
                stack.Pop();
            }
            CancelButton.Enabled = false;
        }

        /*-----Меню-----*/

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlb = new Doubler(10,51);
            labelCurrent.Text = dlb.Current.ToString();
            labelFinish.Text = dlb.Finish.ToString();
            labelMinCount.Text = dlb.MinCoint.ToString();
            labelCount.Text = dlb.Count.ToString();
            ButtonsTrue();
            MessageBox.Show($"Вам нужно достигнуть за {dlb.MinCoint} шагов число {dlb.Finish}");
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlb = new Doubler(51, 126);
            labelCurrent.Text = dlb.Current.ToString();
            labelFinish.Text = dlb.Finish.ToString();
            labelMinCount.Text = dlb.MinCoint.ToString();
            labelCount.Text = dlb.Count.ToString();
            ButtonsTrue();
            MessageBox.Show($"Вам нужно достигнуть за {dlb.MinCoint} шагов число {dlb.Finish}");
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlb = new Doubler(126, 251);
            labelCurrent.Text = dlb.Current.ToString();
            labelFinish.Text = dlb.Finish.ToString();
            labelMinCount.Text = dlb.MinCoint.ToString();
            labelCount.Text = dlb.Count.ToString();
            ButtonsTrue();
            MessageBox.Show($"Вам нужно достигнуть за {dlb.MinCoint} шагов число {dlb.Finish}");
        }

        private void ExitMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GeekUniversity\n Деревянко Андрей\n version 0.4 (с) 2018");
        }

        /*-----Вспомогательные методы-----*/
        private void ButtonsFalse()
        {
            if (dlb.Current == dlb.Finish)
            {
                AddButton.Enabled = false;
                MultiButton.Enabled = false;
                ResetButton.Enabled = false;
                CancelButton.Enabled = false;
                MessageBox.Show("Поздравляю, вы выйграли! :)");
            }
            if (dlb.Current > dlb.Finish)
            {
                AddButton.Enabled = false;
                MultiButton.Enabled = false;
                ResetButton.Enabled = false;
                CancelButton.Enabled = false;
                MessageBox.Show("Вы проиграли :(");
            }
        }

        private void ButtonsTrue()
        {
            AddButton.Enabled = true;
            MultiButton.Enabled = true;
            ResetButton.Enabled = false;
            CancelButton.Enabled = false;
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVersion fv = new FormVersion();
            fv.ShowDialog();
        }
    }
}

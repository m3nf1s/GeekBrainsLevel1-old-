using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelieveOrNot
{
    public partial class FormGame : Form
    {
        ArrayOfQuestions database;
        private int correct;
        private int count;
        BindingSource bindingSource = new BindingSource();
        public FormGame()
        {
            InitializeComponent();
            ButtonFalse();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.XML|*.XML";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new ArrayOfQuestions(openFileDialog.FileName);
                this.Text = openFileDialog.SafeFileName;
                database.Load();
                ButtinTrue();;
                textBoxQuestion.Text = database[0].Text;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            if (database[count].Answer == checkBox.Checked) correct++;
            count++;
            if(count != database.Count) textBoxQuestion.Text = database[count].Text;
            if (count == database.Count)
            {
                ButtonFalse();
                MessageBox.Show($"correct {correct}");
            }
        }

        private void ButtonFalse()
        {
            textBoxQuestion.Enabled = false;
            checkBox.Enabled = false;
            buttonNext.Enabled = false;
        }

        private void ButtinTrue()
        {
            textBoxQuestion.Enabled = true;
            checkBox.Enabled = true;
            buttonNext.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

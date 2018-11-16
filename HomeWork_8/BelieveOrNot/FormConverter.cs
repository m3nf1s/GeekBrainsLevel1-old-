using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace BelieveOrNot
{
    public partial class FormConverter : Form
    {
        ArrayOfStudents database;
        public FormConverter()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "*.CSV|*.CSV";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadDatabase(openFileDialog.FileName);
                }

                labelFileName.Text = openFileDialog.SafeFileName;
                MessageBox.Show("Файл загружен");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        void LoadDatabase(string filename)
        {
            database = new ArrayOfStudents(filename);
            this.Text = filename;
            database.Load();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "*.XML|*.XML|Все файлы(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database?.Save(saveFileDialog.FileName);
                MessageBox.Show("Файл переконвертирован");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormEditor : Form
    {
        ArrayOfQuestions database;
        BindingSource bindingSource = new BindingSource();
        public FormEditor()
        {
            InitializeComponent();

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "*.XML|*.XML|Все файлы(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new ArrayOfQuestions(saveFileDialog.FileName);
                this.Text = saveFileDialog.FileName;
                bindingSource.DataSource = database;
                bindingSource.DataMember = "List";
                textBoxQuestionEdit.DataBindings.Add("Text", bindingSource, "Text");
                checkBoxTrueOrFalse.DataBindings.Add("Checked", bindingSource, "Answer");
                bindingNavigator1.BindingSource = bindingSource;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.XML|*.XML";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadDatabase(openFileDialog.FileName);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
                database?.Save();
        }

        void LoadDatabase(string filename)
        {
            database = new ArrayOfQuestions(filename);
            this.Text = filename;
            database.Load();
            bindingSource.DataSource = database;
            bindingSource.DataMember = "List";
            textBoxQuestionEdit.DataBindings.Add("Text", bindingSource, "Text");
            checkBoxTrueOrFalse.DataBindings.Add("Checked", bindingSource, "Answer");
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

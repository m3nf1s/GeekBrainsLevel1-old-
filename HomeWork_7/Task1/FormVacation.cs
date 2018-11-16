using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task1
{
    public partial class FormVacation : Form
    {
        public FormVacation()
        {
            InitializeComponent();
        }

        private void FormVacation_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Завяление на отпуск");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string s = File.ReadAllText("shablon.txt");

            Element[] mass = new Element[8] {new Element("name1",textBoxCompany.Text),
                new Element("name2",textBoxDirector.Text),
                new Element("name3",textBoxPost.Text),
                new Element("name4",textBoxFrom.Text),
                new Element("name5",textBoxName.Text),
                new Element("data1",dateTimePickerToDate.Text),
                new Element("data2",dateTimePickerFromFate.Text),
                new Element("data3",dateTimePickerCurrentDate.Text),

            };

            foreach (var el in mass)
            {
                Regex reg = new Regex("<" + el.tag + ">");
                s = reg.Replace(s, el.str);
            }

            textBoxMain.Text = s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class FormVersion : Form
    {
        public FormVersion()
        {
            InitializeComponent();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Version.txt");
                textBox1.Text = sr.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                sr?.Close();
            }
        }
    }
}

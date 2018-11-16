using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BelieveOrNot
{
    class ArrayOfStudents
    {
        List<Student> list;
        string filename;

        public List<Student> List
        {
            get => list;
            set => list = value;
        }

        public string Filename
        {
            get => filename;
            set => filename = value;
        }

        public ArrayOfStudents()
        {
        }

        public ArrayOfStudents(string filename)
        {
            this.Filename = filename;
            list = new List<Student>();
        }


        public void Add(string firstName, string lastName, string univercity, string faculty, string department, int age, int course, int group, string city)
        {
            list.Add(new Student(filename,lastName, univercity,faculty,department,age,course,group,city));
        }

        public void Remove(int index)
        {
            try
            {
                list.RemoveAt(index);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public Student this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public void Save(string exFileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            Stream str = new FileStream(exFileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(str, list);
            str.Close();
        }

        public void Load()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filename, Encoding.GetEncoding(1251));
                while (!sr.EndOfStream)
                {
                    try
                    {
                        string[] s = sr.ReadLine().Split(';');
                        // Добавляем в список новый экземпляр класса Student
                        list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);

                    }
                }
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

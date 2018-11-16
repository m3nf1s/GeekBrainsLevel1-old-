using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BelieveOrNot
{
    class ArrayOfQuestions
    {
        List<Question> list;
        string filename;

        public List<Question> List
        {
            get => list;
            set => list = value;
        }

        public string Filename
        {
            get => filename;
            set => filename = value;
        }

        public int Count
        {
            get => list.Count;
        }

        public ArrayOfQuestions()
        {
        }

        public ArrayOfQuestions(string filename)
        {
            this.Filename = filename;
            list = new List<Question>();
        }

        public void Add(string text, bool answer)
        {
            list.Add(new Question(text,answer));
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

        public Question this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            Stream str = new FileStream(filename,FileMode.Create,FileAccess.Write);
            xmlSerializer.Serialize(str,list);
            str.Close();
        }

        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            Stream str = new FileStream(filename, FileMode.Open,FileAccess.Read);
            list = (List<Question>)xmlSerializer.Deserialize(str);
            str.Close();
        }
    }
}

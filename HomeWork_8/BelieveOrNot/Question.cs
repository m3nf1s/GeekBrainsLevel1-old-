using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelieveOrNot
{
    [Serializable]
    public class Question
    {
        string text;
        bool answer;

        public string Text
        {
            get => text;
            set => text = value;
        }

        public bool Answer
        {
            get => answer;
            set => answer = value;
        }

        public Question()
        {
        }

        public Question(string text, bool answer)
        {
            this.Text = text;
            this.Answer = answer;
        }
    }
}

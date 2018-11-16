using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Doubler
    {
        int current;
        int finish;
        private int count;
        private int minCount;
        private int buffer;

        public Doubler(int min, int max)
        {
            Random rnd = new Random();
            current = 1;
            Finish = rnd.Next (min,max);
            Count = 0;
            int buff = Finish;
            while (buff != 1)
            {
                if (buff % 2 == 0)
                {
                    buff /= 2;
                    ++minCount;
                }
                else
                {
                    --buff;
                    ++minCount;
                }
            }
        }

        public int Buffer
        {
            get => buffer;
            set => buffer = value;
        }
        public int Current
        {
            get { return current; }
            set { current = value;}
        }

        public int Finish
        {
            get { return finish;}
            set { finish = value;}
        }

        public int Count
        {
            get => count;
            set => count = value;
        }

        public int MinCoint
        {
            get => minCount;
        }

        public int AddCount() => ++Count;

        public int Add() => ++Current; 

        public int Multi() => Current *= 2;

        public int Reset() => Current = 1;
    }
}

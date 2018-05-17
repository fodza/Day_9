using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    class Test
    {
        //public, private

        public int skaitlis;

        private int Privatais1;

        public int Get()
        {
            return Privatais1;

        }

        public void Set(int value)
        {
            if (value != 0)

            {
                Privatais1 = value;
            }

            else

            {

                Privatais1 = 1;
            }

        }
        public int Saskaitisana(int a, int b)
        {
            return a + b;
        }

        public void Izvade()
        {
            Console.WriteLine("test!");
        }
    }
}

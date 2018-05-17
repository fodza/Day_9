using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Test TestaObjekts = new Test();
            //Massina/ford = new Masina(); 
            int rezultats = TestaObjekts.Saskaitisana(3, 7);

            Test TestaObjekts2 = new Test();

            TestaObjekts.skaitlis = 3;
            TestaObjekts2.skaitlis = 6;
            Console.WriteLine("Izvade no TestaObjekts: " + TestaObjekts.skaitlis);
            Console.WriteLine("Izvade no TestaObjekts2: " + TestaObjekts2.skaitlis);


            TestaObjekts.Izvade();
            Console.WriteLine("Izvade no klases: " + rezultats);
            Console.ReadLine();
        }
        
    }
}

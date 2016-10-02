using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = 35; i<88; i++)
            {
                if ((i %7 == 1)||(i % 7==2)||(i%7==5))
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.ReadKey();
        }
    }
}

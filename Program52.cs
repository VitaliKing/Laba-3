using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 1;
            for (int i = 0; i<4; i++)
            {
                for (int a = 0; a<4; a++)
                {
                    Console.Write("{0} ", z);
                    z++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

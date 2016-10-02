using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 1;
            int c;
            while (a > 0)
            {
                Console.WriteLine("На складе {0} ящиков", a);
                Console.WriteLine("Сколько вам нужно ящиков : ");
                c = int.Parse(Console.ReadLine());
                if (c > a)
                {
                 Console.WriteLine("Нету такого количества ящиков");
                }
                else
                {
                    a = a - c;
                    Console.WriteLine("Машина {0} отправлена",b);
                    Console.WriteLine("На складе осталось {0} ящиков", a);
                    b++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Все ящики отправлены");
            }
            Console.ReadKey();

        }
    }
}

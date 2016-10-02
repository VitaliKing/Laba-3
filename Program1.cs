using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i<=n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Сумма числе n равна {0}", sum);
            Console.ReadKey();
        }
    }
}

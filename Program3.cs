using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int minAge = 1000;
            int maxAge = 0;
            int sum = 0; //общая сумма
            int average = 0; //среднее ариф
            Console.Write("Введите количество человек, посетивших спортзал:");
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i <amount; i++)
            {
                Console.Write("Введите возраст {0}-го посетителя: ", i+1);
                int age = int.Parse(Console.ReadLine()); //возраст каждого
                if (age < minAge)
                {
                    minAge = age;
                }
                if (age>maxAge)
                {
                    maxAge = age;
                
                }
                sum += age;
            }
            average = sum / amount;
            Console.WriteLine("Возраст самого старшего посетителя: {0};", maxAge);
            Console.WriteLine("Возраст самого младшего посетителя: {0};", minAge);
            Console.WriteLine("Средний возраст посетителей: {0};", average);
            Console.ReadKey();
        }
    }
}

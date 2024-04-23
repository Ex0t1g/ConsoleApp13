using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            WriteLine("Заданеи 1");
            int[] numbers = Enumerable.Range(0, 10).ToArray();


            var query = from num in numbers
                        where num % 2 == 0
                        select num;


            WriteLine("Числа, которые производят остаток 0 после деления на 2:");
            foreach (var num in query)
            {
                Write(num + " ");
            }

            //Задание 2

            WriteLine("Заданеи 2");
            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            var query2 = from num in numbers2
                         where num >= 1 && num <= 11 && (num % 2 != 0 || num % 3 == 0)
                         select num;
            WriteLine("Числа в диапазоне от 1 до 11:");
            foreach (var num in query)
            {
                Write(num + " ");
            }
            //Задание 3
            WriteLine("Заданеи 3");
            int[] numbers3 = { 3, 2, 4, 5, 6, 8, 9 };


            var query3 = from num in numbers3.Select((value, index) => new { Value = value, Index = index })
                         select new { Number = num.Value, SqrNo = num.Value * num.Value };

            foreach (var item in query3)
            {
                WriteLine($"{{Number = {item.Number}, SqrNo = {item.SqrNo}}}");
            }


            //Задание 4
            WriteLine("Заданеи 4");
            int[] numbers4 = { 5, 9, 5, 1, 5, 9 };

            var query4 = from num in numbers4
                         group num by num into numGroup
                         select new { Number = numGroup.Key, Frequency = numGroup.Count() };

            WriteLine("Число и частота:");
            foreach (var item in query4)
            {
                WriteLine($"Номер {item.Number} появляется {item.Frequency} раз{(item.Frequency > 1 ? "а" : "")}");

            }
        }

    }
}

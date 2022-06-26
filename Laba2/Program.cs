using System;
using System.Collections.Generic;

namespace lab2_Pla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для разложения камней с разными массами на 2 кучки с минимальной разницей в сумме масс");
            Console.WriteLine("Введите кол-во камней");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите массу камней {n} раз:");
            var list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            list.Sort();
            list.Reverse();              // 1  2  2  1 1 2 2 1
            var list1 = new List<int>(); // 15 13 11 9 7 5 3 1 
            var list2 = new List<int>(); // 0  1  2  3 4 5 6 7
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0)
                {
                    if (i % 3 == 2)
                    {
                        list2.Add(list[i]);
                    }
                    else
                    {
                        list1.Add(list[i]);
                    }
                }

                if (i % 2 == 1)
                {
                    if (i % 3 == 0)
                    {
                        list1.Add(list[i]);
                    }
                    else
                    {
                        list2.Add(list[i]);
                    }
                }
            }
            Console.WriteLine("Первая кучка:");
            for (int i = 0; i < list1.Count; i++)
                Console.Write(list1[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Вторая кучка:");
            for (int i = 0; i < list2.Count; i++)
                Console.Write(list2[i] + " ");
            Console.WriteLine();
            int sum1 = 0;
            foreach (int i in list1) sum1 += i;
            int sum2 = 0;
            foreach (int i in list2) sum2 += i;
            Console.WriteLine("Разница между ними:");
            Console.WriteLine(Math.Max(sum1, sum2) - Math.Min(sum1, sum2));
            Console.ReadLine();
        }
    }
}

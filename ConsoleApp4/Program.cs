using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            MinMax();
            Console.WriteLine("----------------------------");
            MergeLists();
            Console.ReadLine();
        }

        //Большее меньшее число
        public static void MinMax() 
        {

          Console.WriteLine("Большее меньшее число");
          int[] arr = new int[] { 2,4,1,4,5};

          int max = 0;
          int min = arr[0];

            for (int i =0; i<arr.Length; i++) 
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                else 
                if (min>arr[i]) 
                {
                    min = arr[i];
                }
                
            }

            Console.WriteLine("min - {0}\nmax - {1}",min, max);
        }

        //Соединение списков
        public static void MergeLists() 
        {
            Console.WriteLine("Соединение списков");
            List<int> l1 = new List<int>() { 1, 2, 4 };
            List<int> l2 = new List<int>() { 1, 3, 4 };

            var res = l1.Concat(l2).ToList().OrderBy(n=>n);
            
            foreach (var item in res) 
            {
                Console.Write(item+", ");
            }
        }
    }
}

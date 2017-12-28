using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module12dz
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int secondMax = 0;
            List<int> numbers = new List<int>();
            const int sizeNumbers = 15;
            const int minValue = 1;
            const int maxValue = 25;
            Random rand = new Random();
            int sum = 0;

            for(int i = 0;i<sizeNumbers;i++)
            {
                numbers.Add(rand.Next(minValue,maxValue));
                numbers.Sort();
            }

            foreach(int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            foreach(int num in numbers)
            { 
                if(num > max)
                {
                    secondMax = max;
                    max = num;
                }
                if(num%2 == 0)
                {
                    sum += num;
                }
            }


            Console.WriteLine("Максимальное число : {0}", numbers.Max());
            Console.WriteLine("Второе после максимального число : {0}", secondMax);
            Console.WriteLine("Сумма всех четных элементов: {0}", sum);

            Console.ReadLine();
        }
    }
}

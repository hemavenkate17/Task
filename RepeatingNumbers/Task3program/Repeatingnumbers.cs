using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepeatingNumbers
{
    class Repeatingnumbers
    {
        List<int> InputNumbers()
        {
            List<int> numbers = new List<int>();
            int n;
            Console.WriteLine("Enter the numbers");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                numbers.Add(n);
            } while (n > 0);
            return numbers;
        }

        void RepeatedNumbers()
        {

            List<int> numbers = InputNumbers();
            List<int> rep = new List<int>();
            var result = numbers.GroupBy(i => i);
            foreach (var i in result)
            {
                if (i.Count() > 1)
                {
                    rep.Add(i.Key);
                }
            }
            if (rep.Count > 1)
            {
                Console.WriteLine("The Reapeating numbers are");
                foreach (var item in rep)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                Console.WriteLine("There is no repeated number");
            }

        }

         static void Main(string[] args)
            {
                new Repeatingnumbers().RepeatedNumbers();
            }

      
    }
}

    
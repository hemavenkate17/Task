using System;
using System.Collections.Generic;
using System.Text;

namespace Divisibleby7
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] n = new int[10];
            Console.WriteLine("Enter the numbers");

            for (int i = 0; i < n.Length; i++)
            {

                n[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The numbers divisble by 7 are:");

            foreach (var item in n)
            {
                if (item % 7 == 0)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
}

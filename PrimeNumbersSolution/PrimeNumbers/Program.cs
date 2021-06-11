using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    class program
    {
        public static void Main()
        {
            int num, i, temp, min, max;



            Console.Write("Enter the minimum value ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter maximum value ");
            max = Convert.ToInt32(Console.ReadLine());

            if (max > min)
            {
                Console.Write("The prime numbers between {0} and {1} are : \n", min, max);
                for (num = min; num <= max; num++)
                {
                    temp = 0;

                    for (i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            temp++;
                            break;
                        }
                    }

                    if (temp == 0 && num != 1)
                        Console.Write("{0} ", num);
                }
            }
            else
            {
                Console.WriteLine("Invalid Entry");


            }
        }
    }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3program
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

        void SortGivenNumbers()
        {
          
            List<int> myNumbers = InputNumbers();
            List<int> rep = new List<int>();
            var result = myNumbers.GroupBy(i => i);
            foreach (var i in result)
            {
                if (i.Count() > 1)
                {
                    rep.Add(i.Key);
                }
            }
            try
            {
                if (myNumbers != null)
                {
                    myNumbers.Sort();
                    foreach (var item in myNumbers)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("The collection is empty");
                }
            }
           
            catch (Exception e)
            {
                Console.WriteLine("Cannot sort. Sorry");
            }
        }

        static void Main(string[] args)
        {
            new Repeatingnumbers().SortGivenNumbers();
        }


    }
}



using System;
using System.Linq;

namespace ecard
{
    class Program
    {
       

        public static string reverse(string number)
        {
            string output = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                output += number[i];
            }
            return output;
        }
        public static string SumAndMultiply(string number)
        {
            int num_convert, mul, sum = 0, even_sum = 0, odd_sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                char v = number[i];
                num_convert = (int)Char.GetNumericValue(v);
                if ((i + 1) % 2 == 0)
                {
                    mul = num_convert * 2;
                    if (mul >= 10)
                    {
                        while (mul> 0)
                        {
                            int n = mul % 10;
                            even_sum += n;
                            mul= mul / 10;
                        }
                    }
                    else
                        even_sum += mul;
                }
                else
                {
                    odd_sum += num_convert;
                }
                sum = even_sum + odd_sum;
            }
            return Convert.ToString(sum);
        }
     public static string validcheck(string number)
        {
           int number = Convert.ToInt32(sum);
            if (number % 10 == 0)
                return "Valid Card";
            else
                return "Please verify correct number";
        }
        public static void Main(string[] args)
        {
            
                Console.WriteLine("Please enter the Card Number");
                string Cardnumber = Console.ReadLine();
                if (Cardnumber.Length == 16)
                {
                Cardnumber = reverse(Cardnumber);
                Console.WriteLine(Cardnumber);
                string sum = SumAndMultiply(Cardnumber);
                Console.WriteLine(sum);
                string mod = validcheck(sum);
                Console.WriteLine(mod);
            }
                else
                    Console.WriteLine("card length should be 16");
            
        }
}


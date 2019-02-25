using System;
using System.Text;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            string number1 = number.ToString();


            StringBuilder sb = new StringBuilder(number1);
            for (int i = number1.Length - 1; i > 0; i--)
            {
                if (sb[i] > sb[i - 1])
                {
                    char temp = sb[i];
                    sb[i] = sb[i - 1];
                    sb[i - 1] = temp;


                }
                else { return null; }
                number1 = sb.ToString();
                number = Convert.ToInt32(number1);
                break;

            }
            if (number < 0)
            {
                return null;
            }


                return number;
            throw new NotImplementedException();
            throw new ArgumentNullException();
            throw new ArgumentException();
            throw new ArgumentOutOfRangeException();
           
        }
        public static void Main()
        {
            var result = NextBiggerThan(76);
            Console.WriteLine(result);
        }
    }
}
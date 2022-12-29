using System;
using System.Linq;

namespace Am1
{
    public static class Program
    {
        public static void Main()
        {
            int num1,
                num2;
            Console.WriteLine("Enter the first number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            num2 = int.Parse(Console.ReadLine());

            for (int a = num1; a <= num2; a++)
            {
                int counter = 0;
                for (int j = 2; j <= a / 2; j++)
                {
                    if (a % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0 && a != 1)
                {
                    Console.WriteLine("{0}", a);

                }

            }
        }
    }
}
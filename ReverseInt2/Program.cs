using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInt
{
    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {

                Console.WriteLine("Please provide input number");

                int input = int.Parse(Console.ReadLine());
                int backUp = input;
                int remainder, reverse = 0;

                while (input > 0)
                {
                    remainder = input % 10;
                    reverse = reverse * 10 + remainder;
                    input = input / 10;

                }

                Console.WriteLine($"{backUp} Reverse number is {reverse}");

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();


        }
    }

}

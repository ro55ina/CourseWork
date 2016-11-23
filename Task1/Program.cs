using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Convert last 4 digits of your faculty number in binary, octal and hexadecimal numeral systems.

            int FacNumber = 1017;

            string binary = Convert.ToString(FacNumber, 2);
            string octal = Convert.ToString(FacNumber, 8);
            string hexadecimal = Convert.ToString(FacNumber, 16);

            Console.WriteLine("Your faculty number 1017 in binary is: " + binary);
            Console.WriteLine("Your faculty number 1017 in octal is: " + octal);
            Console.WriteLine("Your faculty number 1017 in hexadecimal is: " + hexadecimal);

            Console.ReadKey(true);

        }
    }
}

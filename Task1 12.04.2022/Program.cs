using System;

namespace Task1_12._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Reqem daxil edin");
            int num = Convert.ToInt16(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Reqem cuttur");
            }
            else
            {
                Console.WriteLine("Reqem tekdir");
            }

            

        }
    }
}

using System;

namespace PostiveInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a Integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine("The integer is a postive number and multiple of 3");
                }
                else if (x % 7 == 0)
                {

                    Console.WriteLine("The integer is a postive number and multiple of 7");
                }
            }
            else { 
 
                    Console.WriteLine("The integer is not a postive number ");
            }
        }
    }
}

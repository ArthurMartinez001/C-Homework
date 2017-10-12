using System;

namespace ForLoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, increase numbers");
            for (int i = 0; i < 300; i++) // the ++ increaments the value of i by 1
            {
                Console.WriteLine($"Increase: {i.ToString()}");
                // in the section i.ToString() <-- that converts the numbers into a readeable string. 
                //also note that i.ToString is a Method and it is uisng these brackets {}
            }
            Console.WriteLine("Goodbye, decrease numbers");
            for (int d = 300; d > 0; d--)
                //I wrote this to show how to decrease from 300 to 1
                //notice the d- - decreases the number so d is greater than 0
            {
                Console.WriteLine($"Decrease: {d.ToString()}");
            }
        }
    }
}

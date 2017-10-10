using System;

namespace IfStatementsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Rachel = 20;
            int Robin = 26;
            int Stacey = 54;
            int Jesse = 60;
            // this if statement is only if Rachel can drink. 
            if (Rachel > 18)
            {
                Console.WriteLine("Rachel can vote");
            }
            //this if statement is only if both Rachel and Robin are over 21
            if (Rachel >= 21 && Robin >=21)
            {Console.WriteLine("Rachel and Robin can drink");
            }
            //this else if ststement is only of either Rachel or Robin may drink. 
            else if (Rachel >= 21 || Robin >= 21)
            {
                Console.WriteLine("At least one can drink");
            }
        }
    }
}

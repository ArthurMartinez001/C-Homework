using System;

namespace VariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 21; //not true
            int x = 5;
            double myHourRate = 150.00;
            var myName = "Arthur";
            Console.WriteLine($"myAge: {myAge}, x: {x}, myHourlyRate:{myHourRate}, myName: {myName}");


            // this part of the lesson, the user is able to figure out how to change all the original values
            myAge = 99;
            x = 100;
            myHourRate = 200.00;
            myName = "Silver Surfer";
            Console.WriteLine($"myAge: {myAge}, x: {x}, myHourlyRate:{myHourRate}, myName: {myName}");

                
        }
    }
}

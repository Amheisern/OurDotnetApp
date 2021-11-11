using System;

namespace OurDotnetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit 
            var personname = "Samantha";
            var score = 95;
            var otherscore = 100;

            //Explicit
            string othername = "Tom";
            int price = 42;
            var total = score + price;

            bool isexpensive = true;
            bool isWednesdays = true;

            var sentence = "of all the things i have lost i miss my mind the most";

            var howlong = sentence.Length;

            var rightnow = DateTime.Now;

            Console.Write("What is your name?");
            var name = Console.ReadLine();
            Console.Write("It is a pleasure to meet you, ");
            Console.WriteLine(name);

            var greeting = "It is a pleasure to meet you, " + name + "!";
            Console.WriteLine(greeting);

            string v = $"It is a pleasure to meet you, {name}";








        }
    }
}

using System;

namespace CSharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {   
            // making a simple drawing
            Console.WriteLine("Hello World!");
            Console.WriteLine("     /|");
            Console.WriteLine("    / |");
            Console.WriteLine("   /  |");
            Console.WriteLine("  /   |");
            Console.WriteLine(" /    |");
            Console.WriteLine("/_ _ _|");
            // Console.ReadLine();
            
            //Variables
            //with small story
            //concatenating 
            string characterName = "Gary"; // string data type in C# for variable
            int characterAge = 38; // number data type or integer in C# for variable
            Console.WriteLine("There was a man named " + characterName); //concatenating with characterName variable to add on to console print out
            Console.WriteLine("He was "+ characterAge +" years old"); //concatenating with characterAge variable to add in the middle of the console print out
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
            Console.ReadLine();

            //Datatypes with variables
            //core datatypes

            //syntax
            //for core datatypes
            
            //string
            string phrase = "string of text"; 
            //char only has one character
            char grade = 'A';
            //integer whole number + or -
            int number = 30;
            // float,double, decimal. All for use in accurate numbers/precision. Decimal being the most accurate.
            //example
            double money = 5.50;
            //boolean true or false information
            bool isAlive = true;
            
            // printing to console for check
            Console.WriteLine(phrase);
            Console.WriteLine(grade);
            Console.WriteLine(number);
            Console.WriteLine(money);
            Console.WriteLine(isAlive);
            Console.ReadLine();
        }
    }
}
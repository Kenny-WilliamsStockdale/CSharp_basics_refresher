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
            
            //Working with strings 
            //variables
            //methods
            //arrays/indexing
            
            //variable with example text string
            string greeting = "Text string\nHello World!";
            //printing greeting variable to console using .Length method to get information on how many characters in the string
            Console.WriteLine(greeting.Length);
            //printing greeting variable to console using .ToUpper() method to convert characters in string to all upper case characters
            Console.WriteLine(greeting.ToUpper());
            //printing greeting variable to console using .ToLower() method to convert characters in string to all lower case characters
            Console.WriteLine(greeting.ToLower());
            //printing greeting variable to console using .Contains() method to find if greeting contains a certain set of characters using parameters.
            //Example returns a bool true or false value.
            Console.WriteLine(greeting.Contains("World!"));
            //printing greeting variable to console using an array index [0]
            //in this example it will get the first item in the array index matching the string greeting value which is "T"  
            Console.WriteLine(greeting[0]);
            //printing greeting variable to console using an array index [0]
            //in this example it will get the third item in the array index matching the string greeting value which is "X" 
            Console.WriteLine(greeting[2]);
            //printing greeting variable to console using .IndexOf() method.
            //This tells if the greeting string value has the correct string character and at what index that character is positioned at.
            Console.WriteLine(greeting.IndexOf("Hello"));
            //printing greeting variable to console using .Substring() method.
            //This allows the use of grabbing a part of the string and printing that out.
            //example using index 12 should print out all of Hello World!
            Console.WriteLine(greeting.Substring(12));
            //printing greeting variable to console using .Substring() method.
            //This allows the use of grabbing a part of the string and printing that out.
            //using an extra parameter results in the length of what to grab and print out
            //example using index 12 and a length of 5 should print out Hello
            Console.WriteLine(greeting.Substring(12,5));

            Console.ReadLine();
        }
    }
}
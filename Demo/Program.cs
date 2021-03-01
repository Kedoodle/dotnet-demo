using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // ExampleUsingLoop();
            // ExampleUsingLinq();
            ExampleUsingJoin();
        }
        
        private static void Demos()
        {
            // Creating a variable using explicit typing
            string explicitTypedString = "Usually not preferred";
            // Creating a variable using implicit typing
            var implicitTypedString = "Usually preferred";
            
            // Creating a new object
            var anInstanceOfRandom = new Random();
            
            // Creating a new array for 5 strings
            var anEmptyStringArray = new string[5];

            // Creating a new list
            var anEmptyStringList = new List<string>();
        }

        private static void ExampleUsingLoop()
        {
            const string prompt = "Enter a name or press enter if finished: ";
            var names = new List<string>();
            
            Console.Write(prompt);
            var input = Console.ReadLine();
            while (input != null && !input.Equals(""))
            {
                names.Add(input);
                Console.Write(prompt);
                input = Console.ReadLine();
            }

            var commaSeparatedNames = "";
            for (var i = 0; i < names.Count; i++)
            {
                commaSeparatedNames += names[i];
                if (i < names.Count - 1)
                {
                    commaSeparatedNames += ", ";
                }
            }
            Console.Write($"Hello {commaSeparatedNames}");
        }
        
        
        private static void ExampleUsingLinq()
        {
            const string prompt = "Enter a name or press enter if finished: ";
            var names = new List<string>();
            
            Console.Write(prompt);
            var input = Console.ReadLine();
            while (input != null && !input.Equals(""))
            {
                names.Add(input);
                Console.Write(prompt);
                input = Console.ReadLine();
            }
            
            var commaSeparatedNames = names.Aggregate((current, next) => current + ", " + next);
            Console.Write($"Hello {commaSeparatedNames}");
        }

        
        private static void ExampleUsingJoin() {
            const string prompt = "Enter a name or press enter if finished: ";
            var names = new List<string>();
            
            Console.Write(prompt);
            var input = Console.ReadLine();
            while (input != null && !input.Equals(""))
            {
                names.Add(input);
                Console.Write(prompt);
                input = Console.ReadLine();
            }

            var commaSeparatedNames = string.Join(", ", names);
            Console.WriteLine($"Hello {commaSeparatedNames}");
        }
    }
}

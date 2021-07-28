using System;
using System.Linq;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some letter for looping");
            var letters = Console.ReadLine();
            var index = 0;
            var output = "";

            // iterate over each letter in letters
            for (var i = 0; i < letters.Length; i++)
            {
                // increment with each letter index
                index++;
                // iterate over each letter at each index
                for (var j = 0; j < index; j++)
                {
                    // display letters at specific index perspective times with syntax specific to order
                    if (j == 0 && i > 0)
                    {
                        var following = (letters[i]);
                        output += $"-{following}";
                    }
                    else if (i == 0)
                    {
                        var first = (letters[i]);
                        output += first;
                    }
                    else
                    {
                        output += $"{letters[i]}";
                    }
                }
            }
            // combine all the above to form output
            Console.WriteLine($"{output}");

        }
    }
}

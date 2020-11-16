// import
using System;

// A namespace is a collection of related classes.
namespace FortuneTeller2
{
    // Almost all C# code must be contained inside a class. It is convention to use the same name for the class and the *.cs file.
    class Program
    {
        // Main is a "method" in the Program class. A method is a function that exists inside a class. Main is a "static" method. This means we do not need to create a Program object in order to use it.
        static void Main(string[] args)
        {
            //These lines make up the "body" of the Main method. The "body" of a method contains the executable C# code. Here we create a string variable and print it to the Console.
            string fortune = "Everything will be ok.";
            Console.WriteLine(fortune);

            //Console.WriteLine()will print it's argument to the console and then add a "newline".
            //Console.Write() will print it's argument without adding a "newline"
            Console.Write("The quick brown");
            Console.WriteLine("fox jumps");
            Console.Write("over the");
            Console.WriteLine("lazy dog");
        }
    }
}
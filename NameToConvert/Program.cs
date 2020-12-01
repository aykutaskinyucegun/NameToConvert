using System;
using Converter.Models;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Human!");

            Console.WriteLine("Type your name to see how is it in my eyes!");

            Create an instance of UserInput object
           UserInputs userInputs = new UserInputs();
            userInputs.FullName = Console.ReadLine();

            BinaryConverter binaryConverter = new BinaryConverter();
            string binaryValue = binaryConverter.ConvertTo(userInputs.FullName);
            Console.WriteLine($"{userInputs.FullName} what I see as Binary: {binaryValue}");

            Console.WriteLine("Now try the binary!");

            userInputs.binary = Console.ReadLine();
            Console.WriteLine($"{userInputs.binary} from Binary to ASCII: {binaryConverter.ConvertBinaryToString(binaryValue)}");

            Console.WriteLine("Press é to see its hexadecimal!");

            string input = userInputs.FullName;
            string result = String.Concat(input.Select(x => ((int)x).ToString("x")));

            Console.WriteLine($"{userInputs.FullName} from ASCI to hexadecimal : {result}");

            ConsoleKeyInfo key = Console.ReadKey(); //this code takes user input
            Console.Write(key.KeyChar);
            userInputs.Character = key.KeyChar;
            if (userInputs.Character == 'é')
            {
                HexadecimalConverter hexadecimalConverter = new HexadecimalConverter();
                string hexavalue = hexadecimalConverter.ConvertTo(userInputs.FullName);
                Console.WriteLine($"{userInputs.FullName} and this is the hexaform: {hexavalue}");
            }
            else

                Console.WriteLine("opss so you don't want to learn it hexadeciaml!!");
        }


    }
}
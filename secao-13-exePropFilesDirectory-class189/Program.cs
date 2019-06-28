using System;
using System.IO;
using System.Collections.Generic;

namespace secao_13_exePropFilesDirectory_class189
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"F:\Users\wellv\Documents\Programação Orientada a Objeto C#\secao-13-exePropFilesDirectory-class189\Salles\";

            try
            {
                Console.WriteLine("Digit your salles:");
                char insertSalles = 'y';
                List<string> list = new List<string>();
                while (insertSalles== 'y')
                {
                    Console.Write("insert your sale: ");
                    string salles = Console.ReadLine();
                    list.Add(salles);
                    Console.Write("Would you like to insert more sales? (y/n)? ");
                    insertSalles = char.Parse(Console.ReadLine());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

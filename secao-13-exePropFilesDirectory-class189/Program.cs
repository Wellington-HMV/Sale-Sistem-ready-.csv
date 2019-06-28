using System;
using System.Globalization;
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

                Console.Write("Digit your new file: ");
                string nFile = Console.ReadLine();
                string path = Path + nFile;

                char insertSales = 'y';
                List<string> list = new List<string>();
                while (insertSales== 'y')
                {
                    Console.Write("insert your sale: ");
                    string sales = Console.ReadLine();
                    list.Add(sales);
                    Console.Write("Would you like to insert more sales? (y/n)? ");
                    insertSales = char.Parse(Console.ReadLine());
                }
                using (StreamWriter sw = File.AppendText(path))
                {
                    foreach (string x in list)
                    {
                        string[] fields = x.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

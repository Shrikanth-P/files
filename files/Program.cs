using System;
using System.IO;
namespace table
{
    class tables
    {
        public static void Main()
        {
           
            string path = @"Tables.txt";
            if (!File.Exists(path))
            {
               
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Tables From 1 to 10 : ");
                    for (int i = 1; i < 11; i++)
                    {
                        for (int j = 1; j < 11; j++)
                        {
                            sw.WriteLine($"{i}x{j}={i * j}");
                        }
                        sw.WriteLine();
                    }
                    
                }

            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}

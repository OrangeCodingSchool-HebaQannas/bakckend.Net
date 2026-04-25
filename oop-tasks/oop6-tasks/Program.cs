using System;
using System.IO;

namespace fileHandling_Tasks
{
    class Program
    {
        static void Main()
        {
            string filePath = "data.txt";
            string filePath2 = "data2.txt";

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                string myBio = "Name: Heba\n" + "Age: 21\n" +
                               "Specialization: Fullstack Developer\n" +
                               "Description: I build backend systems and learn C# daily.";
                File.WriteAllText(filePath2, myBio);
                Console.WriteLine("Data successfully written to file.\n");

                File.AppendAllText(filePath2, "\nGoal: Master Object-Oriented Programming.");

                string[] allLines = File.ReadAllLines(filePath2);

                int charCount = 0;
                int wordCount = 0;

                Console.WriteLine("~~~~~ Reading myBio File ~~~~~");

                foreach (string line in allLines) 
                {
                    Console.WriteLine(line);

                    foreach (char c in line)
                    {
                        if (c != ' ')
                        {
                            charCount++;
                        }
                    }

                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;
                }

                Console.WriteLine("\n ~~~~~ File Statistics ~~~~~");
                Console.WriteLine($"Total Characters (excluding spaces): {charCount}");
                Console.WriteLine($"Total Words: {wordCount}");
                                 
            }
            catch (Exception ex)
            {
                Console.WriteLine("A file error occurred: "+ex.Message);
            }
        }
        
    }
    
}




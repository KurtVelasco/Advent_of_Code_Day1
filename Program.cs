using System;
using System.IO;

namespace Advent_of_Code_Day1
{
    internal class Program
    {

        //MUELSYSE FIX YOUR DAMN SNOW MACHINE
        public int TOTAL_SUM = 0;
        public static string FILE_PATH = "puzzle";
        static void Main(string[] args)
        {
            Console.WriteLine(ELF_READ(FILE_PATH));
            Console.ReadLine();
        }
        public static int ELF_READ(string path)
        {
            int sum = 0;
            using (StreamReader sr= new StreamReader(path +".txt"))
            {
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    int calibrationValue = ELF_MATH(line);
                    sum += calibrationValue;
                }
                
               
            }
            return sum;
        }
        public static int ELF_MATH(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                int firstDigit = -1;
                int lastDigit = -1;

                foreach (char character in input)
                {
                    if (char.IsDigit(character))
                    {
                        int digit = int.Parse(character.ToString());

                        if (firstDigit == -1)
                        {
                            firstDigit = digit;
                        }

                        lastDigit = digit;
                    }

                }
                if (firstDigit == -1 && lastDigit == -1)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(firstDigit.ToString() + lastDigit.ToString());
                }
            }

            return 0;
        }
    }
}

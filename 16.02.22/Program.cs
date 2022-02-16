using System;

namespace _16._02._22
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Aforizm = { "LearN FroM YesterdaY, LivE FoR TodaY, HopE FoR TomoRroW " };
            SizeLetter(Aforizm);
        }
        public static void SizeLetter(string[] Aforizm)
        {
            foreach (string words in Aforizm)
            {
                foreach (char letter in words)
                {
                    if (char.IsLower(letter))
                    {
                        Console.Write(char.ToUpper(letter));
                    }
                    else
                    {
                        Console.Write(char.ToLower(letter));
                    }
                }
            }
        }
    }
}

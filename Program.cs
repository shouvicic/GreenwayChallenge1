using System;
using System.Linq;

namespace GreenWayHealthChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            while (true)
            { 
                string userInput = Console.ReadLine();
                string strcharcount = GetCharacterCountFromString(userInput);
                Console.WriteLine(strcharcount);
                Console.WriteLine("Enter a String");
            }             
                
        }

        public static string GetCharacterCountFromString(string userInput)
        {
            string charNameWithCount = string.Empty;
            try
            {
                userInput = userInput.ToUpper();
                char[] charArray = userInput.Distinct().ToArray();
                if (charArray != null)
                {
                    for (int i = 0; i < charArray.Count(); i++)
                    {
                        charNameWithCount += charArray[i].ToString() + "-" + Count(userInput, charArray[i]) + "\n\n";
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return charNameWithCount;
        }

        public static int Count(String userInput, char ch)
        {
            int countChar = userInput.Where(x => x == ch).Count();

            return countChar;
        }
    }
}

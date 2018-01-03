using System;

namespace ReverseString
{
    class Program
    {
        /// <summary>
        /// ReverseString() Function reverse the sentence words.
        /// </summary>
        /// <param name="sentence">Input perameter which needs to reverese.</param>
        /// <returns>Return the result.</returns>
        public static string ReverseString(string sentence)
        {
            var stringArray = sentence.Split();
            for (int i = 0; i < stringArray.Length; i++)
            {
                var charArray = stringArray[i].ToCharArray();
                string text = string.Empty;
                for (int j = charArray.Length - 1; j >= 0; j--)
                {
                    text += charArray[j];
                }
                stringArray[i] = text;
            }
            sentence = string.Empty;
            foreach (var item in stringArray)
            {
                sentence += item + " "; 
            }
            return sentence;
        }

        /// <summary>
        /// Main function to control the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World! This program shows you how to reverse the each word in sentance.");
                Console.WriteLine("\nTo see how it works type a sentance to reverse its words.");
                Console.Clear();
                Console.WriteLine(ReverseString(Console.ReadLine()));
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured !! {0}", e.Message);
            }
        }
    }
}
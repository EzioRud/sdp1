using System;

namespace Problems
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Prefix("Hello World!"));

        }

        static string Prefix(string input)
        {
            if(input == null)
            {
                return null;
            }
            else if (input == "")
            {
                return "0,0" + ":" + input;
            }
            int iLength = input.Length;
            string[] SplitArray = input.Split(" ");
            int iWords = SplitArray.Length;
            string answer = iLength.ToString() + "," + iWords.ToString() + ":" +input;

            return answer;
        }
    }
}

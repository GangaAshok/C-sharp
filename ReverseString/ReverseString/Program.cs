using System;

namespace ReverseString
{
    public class Program
    {
        static void Main(string[] args)
        {
            //    string str = "", reverse = "";
            //    Console.WriteLine("Please input the string to be reversed");
            //    str = Console.ReadLine();
            //    var length = str.Length - 1;
            //    while (length >= 0)
            //    {
            //        reverse = reverse + str[length];
            //        length--;
            //    }
            //    Console.WriteLine("The output is " + reverse);
            //    Console.ReadLine();
            //}
            //------------------------------------------------------------------------Approach 1
            //    string str = "Abc"; 
            Console.WriteLine("Enter the number to be reversed");
            String str = Console.ReadLine();
            Program program = new Program();
            string result = program.reversedString(str);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        public string reversedString(string str)
        {
            string reverse = "";
            for (int i = str.Length; i > 0; i--)
            {
                reverse = reverse + str[i - 1];

            }

            return reverse;
        }
        //------------------------------------------Approach 2
    }
}

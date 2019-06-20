using System;
using System.Collections;

namespace StackArragements
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first digit you need to input");
            int a = Int32.Parse(Console.ReadLine());
            Stack st = new Stack();
            st.Push(a);
           Console.WriteLine("1 - push the element x into the stack ,2 - delete the element present at the top of the stack 3 - print the maximum element in the stack.");
            Console.WriteLine("enter the option");
            int option = Int32.Parse(Console.ReadLine());
            Program program = new Program();
            int value = program.getSelectedOption(st,option);

        }

       public int getSelectedOption(Stack st,int option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the digit you need to input");
                    int b = Int32.Parse(Console.ReadLine());
                    return st.Push(b);
                default:
                    return null;
                    break;
            }
        }
    }
}

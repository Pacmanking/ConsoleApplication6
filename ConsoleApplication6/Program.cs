using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to your automated answering service\n" +
               "Please press the correct buttons for the following options ");
            Console.WriteLine("1, For sales");
            Console.WriteLine("3, For recording");
            Console.WriteLine("5, To leave");

            string x = Console.ReadLine();
            int c;

            if (int.TryParse(x,out c))
            {
                if (c == 1)
                {
                    Console.WriteLine("Our sales offices are closed at this time");
                }
                else if (c == 3)
                {
                    Console.WriteLine(" Please record your message now...");
                }
                else if (c == 5)
                {
                    Console.WriteLine("Goodbye");
                }
                else if (c == 0)
                {
                    Console.WriteLine("We’re transferring you to an operator");
                }
                else
                {
                    Console.WriteLine("Sorry. you’ve entered an invalid option");
                }
            }

            Console.ReadLine();
        }
    }
}

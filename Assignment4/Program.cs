using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the value of n");
            n=int.Parse(Console.ReadLine());
          if(n>0)
            {
                Console.WriteLine("The number is positive");
            }
       else if(n<0)
            {
                Console.WriteLine("The is negative");
            }
          else
            {
                Console.WriteLine("The number is o");
            }
         
           string result= (n % 2 == 0) ? "The number is Even" : "The number is Odd";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

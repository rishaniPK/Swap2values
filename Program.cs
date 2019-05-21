using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap2values
{
    class Program
    {
        //swaping Two Values 
        static void Main(string[] args)
        {
            int num1, num2, swap; //Define variables
            Console.WriteLine("Input the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            swap = num1;
            num1 = num2;
            num2 = swap;
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + num1);
            Console.WriteLine("Second Number : " + num2);
            Console.Read();
        }
    }
}

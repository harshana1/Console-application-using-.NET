using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] marks;
            marks = new int[5];*/

            int[] marks = new int[5];

            for (int i = 0; i < 5; i++) 
            {
                Console.Write("Enter Marks : ");
                marks[i] = Int32.Parse(Console.ReadLine());
            
            }
           /* Console.WriteLine(marks[0]);
            Console.WriteLine(marks[1]);
            Console.WriteLine(marks[2]);
            Console.WriteLine(marks[3]);
            Console.WriteLine(marks[4]);
            Console.WriteLine(marks[5]);*/

            for(int j = 0; j < 5; j++) 
            {
                Console.WriteLine(marks[j]);
            }



            Console.ReadLine();
        }
    }
}

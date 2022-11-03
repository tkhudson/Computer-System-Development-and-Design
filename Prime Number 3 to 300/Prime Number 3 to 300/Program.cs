using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_3_to_300
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration  
            bool isPrime = true;
            int i, j;
            //Calculate and display the Prime number  
            Console.WriteLine("Prime numbers between 3 and 300 are: ");
            Console.WriteLine("============================" +
                "===========================================" +
                "============================================");
            //For loop between 3 to 300
            for (i = 3; i <= 300; i++)
            {
                for (j = 3; j <= 300; j++)
                {
                    //check up to square root(i)
                    if (i != j && i % j == 0)
                    {
                        //return false
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    //display the result
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            //read the line
            Console.ReadKey();
        }
    }
}

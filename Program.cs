using System;
using System.Transactions;

namespace perfectnumber
{
    internal class program
    {

       static void Main(string[] args)
        {



            Console.WriteLine("enter the first number");
            int f1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int f2 = int.Parse(Console.ReadLine());
            int i , sum ;
            for (int n = f1; n <= f2; n++)
            {
                i = 1; 
                sum = 0 ;
                while(i < n)
                {

                    if (n % i == 0)
                        sum = sum + 1 ;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("{0}", n);

            }
            Console.WriteLine();





        }



    }




}

    
    

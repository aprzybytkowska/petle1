using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj ile liczb ciągu chcesz uzyskać : ");
            //int number = int.Parse(Console.ReadLine());
            //int sum=1;
            //int sum1 = 1;
            //int sum2 = 1;



            //for (int i = 1; i<= number; i++)
            //{
            //    if( i == 1)
            //    {
            //        sum = sum1;
            //        Console.WriteLine(sum1);

            //    }
            //    else if (i == 2)
            //    {
            //        sum = sum2;
            //        Console.WriteLine(sum2);

            //    }
            //    else
            //    {
            //        sum = sum1 + sum2;
            //        sum1 = sum2;
            //        sum2 = sum;
            //        Console.WriteLine(sum);
            //    }
            //}
            Console.WriteLine("Podaj ilość liczb ciągu do wyświetlenia: ");
            int number = int.Parse(Console.ReadLine());
            int[] fibonacci = new int[number];
            int sum = 0;
            int sum1 = 1;
            int sum2 = 1;

            for (int i = 0; i<= number - 1; i++)
            {
                if (i == 1)
                {
                    sum = 1;
                
                }
                else if (i == 2 )
                {
                    sum = 1;
                }
             
                else if (i !=0)
                {
                    sum = sum1 + sum2;
                    sum1 = sum2;
                    sum2 = sum;

                }
                fibonacci[i] = sum;

               
            }
          
            for (int i = fibonacci.Length -1; i >= 0; i--)
            {
                Console.Write(fibonacci[i] + " ");
            }

        }
    }
}

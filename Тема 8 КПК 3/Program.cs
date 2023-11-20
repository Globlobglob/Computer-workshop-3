using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.Runtime.InteropServices;

namespace Prakticum3
{
    internal class Program
    {

        //Exercice 1


        //Task 1
        /* static int Line(int x)
         {
             for (int i = 1; i<=x; i++)
             {
                 WriteLine("#");
             }
             WriteLine();

             return x;
         }
         static void Main(string[] args)
         {
             Write("Enter value= ");
             int val = int.Parse(ReadLine());

             int result = Line(val);
             Console.WriteLine(result);

         }*/


        // task 2
        /* static int Line(int x)
         {
         for (int h = 1; h <= 5; h++)
             {
                 WriteLine(" ");
             }
            
        for (int i = 1; i <= x; i++)
             {
                 Write("#");
             }

             WriteLine();

             return x;
         }
         static void Main(string[] args)
         {
             Write("Enter value= ");
             int val = int.Parse(ReadLine());

             int result = Line(val);
             Console.WriteLine(result);

         }*/

        //task 3 

        /* static void Line(int x) 
          {
                 for (int u = 0; u < 5; u++)
                 {
                     WriteLine(" ");
                 }

                 for (int g = 0; g < x; g++)
                 {
                     Write("x");
                 }
          }
          static void Main(string[] args)
          {
              Write("Enter value= ");
              int val = int.Parse(ReadLine());

              Line(val);
          }
         */

        //task 4

        /*  static void Line(int x,int y)
          {
              for(int i = 1; i <= y; i++)
              {
                  for(int h = 1; h <= x; h++)
                  {
                      Write("#");
                  }

                  WriteLine("#");
              }

          }
          static void Main(string[] args)
          {
              Write("Enter value = height ");
              int val = int.Parse(ReadLine());

              Write("Enter value = weight ");
              int val2 = int.Parse(ReadLine());



              Line(val,val2);
              ReadKey();
          }
        */



        // task 5

        /* static int Func(int x , int y)
         {
                 for (int i = 1; i < x; i++)
                 {

                    for (int h = 1; h < 2; h++)
                    {
                      WriteLine(" ");
                    }
                    for (int j = 1; j < y; j++)
                    {
                         Write("#");
                    }
                     WriteLine("#");
                 }
             return x;   
         }

         static void Main(string[] args)
         {
             int height = 4;
             int width = 7;  

             int res=Func(height, width);
             Console.WriteLine(res);
         }*/

        //task 5

        /*static void Func()
            
        {
            for (int i = 8; i > 0; i--)
            {
                for (int h = i; h >0; h--)
                {
                    Write("#");
                }
                WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            Func();
        }
        */

        // task 6
        /* static void Func()
         {


             for (int i = 1; i < 9; i++)
             {

                 for (int j = 1; j < 9-i ; j++)
                 {
                     Write(" ");
                 }

                 for (int x = 1; x < i; x++)
                 {
                     Write("#");
                 }

                 WriteLine();
             }
         }

         static void Main(string[] args)
         {

             Func();
         }
        */

        //exercice 3

        /*
         static double Func(double  y)
        {
            return (1 + Math.Sin(1)) / 3 + (3 + Math.Sin(3)) / 3 + (5 + Math.Sin(5)) / 3;  
        }


       static void Main(string[] args)
        {
            double res = Func(0);
            
            Write($"Result={res}");
        }

        */

        // exercice 4



        //task 1 

        /* static int Func(int value_1, int value_2)
         {
             return Math.Min(value_1,value_2); 
         }
         static void Main(string[] args)
         {
             int[]values=new int[3];
             for (int i = 0; i < values.Length; i++)
             {
                 Write($"Enter a value{i+1}= ");
                 values[i] = int.Parse(Console.ReadLine());
             }

             int res = Func(Func(values[0], values[1]), values[2]);
             Console.WriteLine("Минимальное значение = " + res);
         }*/

        //task 2

        /*
        static int Func(int value_1, int value_2)
        {
            return Math.Max(value_1, value_2);
        }
        static void Main(string[] args)
        {
            int[] values = new int[4];
            for (int i = 0; i < values.Length; i++)
            {
                Write($"Enter a value{i + 1}= ");
                values[i] = int.Parse(Console.ReadLine());
            }

            int res = Func(Func(values[0], values[1]), Func(values[2], values[3]));
            Console.WriteLine("Max value = " + res);
        */



        //task 3

        /* static int Func(int value_1, int value_2)
         {
             return  Math.Max(value_1, value_2);
         }
         static void Main(string[] args)
         {
             int[] values = new int[4];
             for (int i = 0; i < values.Length; i++)
             {
                 Write($"Enter a value{i + 1}= ");
                 values[i] = int.Parse(Console.ReadLine());
             }

             int max1 = Func(values[0], values[1]);
              int max2 =Func(values[2], values[3]);
             Console.WriteLine($"Max value = {max1} + {max2} = {max1+max2}");
             */

        //task  4
        /*static int Func(int value_1, int value_2)
        {
            return Math.Max(value_1, value_2);
        }
        static void Main(string[] args)
        {
            int[] values = new int[2];
            for (int i = 0; i < values.Length; i++)
            {
                Write($"Enter a value{i + 1}= ");
                values[i] = int.Parse(Console.ReadLine());
            }

            int max1 = Func(values[0],2*values[1]);
            int max2 = Func(2 * values[0] - values[1], values[1]);

            Write($" Summ max= {max1}+{max2}={max1+max2}");
          
        }*/


        //Task 5

        static int Func(int value_1, int value_2)
        {
            return Math.Min(value_1, value_2);
        }
        static void Main(string[] args)
        {
            int[] values = new int[2];
            for (int i = 0; i < values.Length; i++)
            {
                Write($"Enter a value{i + 1}= ");
                values[i] = int.Parse(Console.ReadLine());
            }

            int max1 = Func( 2 * values[0], values[1] + values[0]);
            int max2 = Func( 2 * values[0] - values[1], values[1]);

            Write($" Summ min = {max1}+{max2}= {max1 + max2}");



        }



    }
}

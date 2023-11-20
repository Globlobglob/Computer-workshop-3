using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    internal class Program
    {

       /* static double Func(double y)
        {
            return (1 + Math.Sin(1) / 3) + ((5 + 5) / 3) + ((7 + 7) / 3);

        }

        static void Main(string[] args)
        {
            Console.Write("Enter an number= ");
            double number=double.Parse(Console.ReadLine());

            double result = Func(number);
            Console.WriteLine(result);
        }
       */



      /*  static int Time(int h,int m,int s)
        {
            h = 3600;
            m = 60;
            return h + m + s;   
        }

        static void Main(string[] args)
        
        {
            
                Write($"Enter an hours=");

               int numbers = int.Parse(Console.ReadLine());
                Write($"Enter an minute=");

               int numbers1 = int.Parse(Console.ReadLine());
                Write($"Enter an sec=");

                int numbers2 = int.Parse(Console.ReadLine());

           

            double res = Time(numbers, numbers1, numbers2);

            Console.WriteLine(res);

        }
      */


        /* static void Numbers(int n)
         {
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                array[i] = i+1;     
            }
             foreach(int i in array)
            {
                if (i % 2 == 0)
                {
                    Write(i );
                }
            }

        }

        static void Main(string[] args) 
        {
            Write("Enter right values 2 up n = ");
            int n=int.Parse(Console.ReadLine());


            Numbers(n);
     
        }


        */




        //static int Averrgage(int[] array)
        //{
        //    int sum = 0;
        //    foreach (int num in array)
        //    {
        //        sum += num;
        //    }
        //    int average = sum / array.Length;
        //    return average;
        //}
        


        //static void  Array(int[]array)
        //{

        //    Random rnd = new Random();
            
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = rnd.Next(163, 191);
        //        Console.WriteLine(array[i]);
               
        //    }

        //    int result = Averrgage(array);
        //    Console.WriteLine("Среднее арифметическое  "+result);

        //}

        //static void Main(string[] args)
        //{
        //    int[] array = new int[12];
             
        //    Array(array);
        //}
        

        static int Min(int[] omas)
        {
            return Math.Min(0, omas.Length);
        }

        static int Max(int[] omas)
        {
            return Math.Max(0, omas.Length);
        }



        static void Main(string[] args) 
        
        {
            int[] omas = { 37, 0, 50, 46, 0, 13 };

            int max = Max(omas);
            int mini = Min(omas);
            Console.WriteLine(mini);
            Console.WriteLine(max);
        
        }











    }
}

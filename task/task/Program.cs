﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1
            Console.WriteLine("enter your number 1");
            int a = int.Parse(Console.ReadLine());s
            Console.WriteLine("enter your number 2");
            int b = int.Parse(Console.ReadLine());
         
            Console.WriteLine("sum of number is"  +  (a + b));
            
            Console.WriteLine("difference of number is"  + (Math.Abs(a-b)));

            Console.WriteLine("product of number is"  +  a * b);

            //task2

            /*Console.WriteLine("enter yours number");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter yours number");
            int b = int.Parse(Console.ReadLine());

           double res=  Math.Pow(a, b);
           Console.WriteLine(res);
           
       
            Console.WriteLine(Math.Pow(a, b));*/

            //task3

           /* Console.WriteLine("eneter the length");
             double l = double.Parse(Console.ReadLine());
            Console.WriteLine("eneter the width");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("eneter the height ");
            double h = double.Parse(Console.ReadLine());

            double res = (l * w * h);
                Console.WriteLine(res);
            Console.WriteLine("yours volume of rectangle"+(l*w*h));*/

            //task4

           /* Console.WriteLine("enter the r ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.PI * 2 * r);
            double res = (2 * Math.PI * r);
            Console.WriteLine(res);*/

            //task5

           /* Console.WriteLine("enter the numerator");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the denominator");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("the quoti" + n / d);
            Console.WriteLine("the remain" + n % d);
            int res = ((n/d)+(n % d));
            Console.WriteLine(res);*/

            //task6


            /*Console.WriteLine("enter your number");
                int a=int.Parse(Console.ReadLine());
            int res= (a*a);
             Console.WriteLine(res);
             Console.WriteLine("square"+a*a);*/

            //task7
           /* Console.WriteLine("enter your number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(a));
            double res=Math.Sqrt(a);
            Console.WriteLine(res);*/

            //task8

           /* Console.WriteLine("enter your height");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("enter your breath");
            double b = double.Parse(Console.ReadLine());
            double res = (1.0 / 2 * (b * h));
            Console.WriteLine(res);
            Console.WriteLine(1 / 2.0 * (b * h));*/

            //task9

            /*Console.WriteLine("enter your kilometer");
            double k = double.Parse(Console.ReadLine());
            double m = 1.60934;
            double res = (k * m);
            Console.WriteLine(res);
            Console.WriteLine("the milles is " + k * m);*/

            //task10

            /*Console.WriteLine("enter your celsius");
            double c =double.Parse(Console.ReadLine());
            double res=((c*9.0/5)+32);
            Console.WriteLine(res);
            Console.WriteLine("the f is " + ((c * 9 / 5.0) + 32));*/

            //task11

            /* Console.WriteLine("enter the num a");
                 int a=int.Parse(Console.ReadLine());
             Console.WriteLine("enter the num b");
             int b = int.Parse(Console.ReadLine());
             int c= b;
             b = a;
             a = c;
             Console.WriteLine("swap number {0} ,{1}" ,a,b);*/
             
            //task12
            /*Console.WriteLine("eneter num a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num b");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("swap number{0},{1}", a, b);*/

            //task13

           /* Console.WriteLine("eneter num a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num b");
            int b = int.Parse(Console.ReadLine());
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("swap number{0},{1}", a, b);*/

            //task14

            /*Random r = new Random();
            int res = r.Next(1, 100);
            Console.WriteLine(res);*/

            //task15

            /*Console.WriteLine("eneter num length");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine("eneter num width");
            int w = int.Parse(Console.ReadLine());
            double  Sqft = 43.560;
            double res = (l * w )/ Sqft;
            Console.WriteLine(res);*/

            //16

           /* Console.WriteLine("eneter num ");
            double n = double.Parse(Console.ReadLine());
            double res = (n*(n+1)/2);
            Console.WriteLine(res);*/

            //17

            /*Console.WriteLine("eneter amount");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("eneter tips");
            double t= double.Parse(Console.ReadLine());
            double res = (a*t/100);
            Console.WriteLine(res);*/

            //18

            /*Console.WriteLine("eneter num 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("eneter num 2");
            int n2= int.Parse(Console.ReadLine());
            Console.WriteLine("eneter num n3");
            int n3 = int.Parse(Console.ReadLine());
            double res = ((n1+n2+n3)/3);
            Console.WriteLine(res);*/

            //task 19

            /*Console.WriteLine("enter the amount paid");
            int a = int.Parse(Console.ReadLine());
            decimal t = 18.0M;
            decimal st = t / 100;
            decimal pt = (a / (1 + st));
            decimal res = pt;
            Console.WriteLine(res);
            Console.WriteLine("your acutual price is" + res);*/

            //task20

           /* Console.WriteLine("eneter basic pay");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("eneter DA");
            double d= double.Parse(Console.ReadLine());
            Console.WriteLine("eneter num TA");
            double t = double.Parse(Console.ReadLine());
            double p = 8.0;
            double g = (b + (b*(d / 100)) + (b*(t / 100)) - (b*(p/100));
            double res=g;
            Console.WriteLine(res);*/

            //task21

            /*Console.WriteLine("eneter the principle");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("eneter the  number of year ");
            double n= double.Parse(Console.ReadLine());
            Console.WriteLine("eneter num rate of i");
            double r = double.Parse(Console.ReadLine());
            double si = (p * n * r / 100);
            double res = si;
            Console.WriteLine(res);*/

            //task22

            /*Console.WriteLine("eneter the principle");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("eneter the  number of year ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("eneter num rate of i");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("eneter num of time ");
            double t = double.Parse(Console.ReadLine());
            double ci = p *Math.Pow (1+(r/n), (n*t));
            double res = ci;
            Console.WriteLine(res);*/

            //task23

           /* Console.WriteLine("eneter the height");
            double h = double.Parse(Console.ReadLine());
            double i = h / 2.54;
            Console.WriteLine(i);
            double f = i / 12;
            Console.WriteLine(f);*/

            //task24

           /* Console.WriteLine("eneter the weight");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("eneter the  height ");
            double h = double.Parse(Console.ReadLine());
            double bmi = ((h / w ) * h);
            double res = bmi;
            Console.WriteLine(res);*/

            //task25


           /* Console.WriteLine("eneter the rollno");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("eneter your name ");
            string n = Console.ReadLine();
            Console.WriteLine("eneter the mark1");
            double m1 = double.Parse(Console.ReadLine());
            Console.WriteLine("eneter the mark2 ");
            double m2= double.Parse(Console.ReadLine());
            Console.WriteLine("eneter the mark3 ");
            double m3 = double.Parse(Console.ReadLine());
            double avg = ((m1 + m2 + m3) / 3);
            double res = avg;
            Console.WriteLine(res);
            Console.WriteLine("your average is " + res);*/
























            

















        }
    }
}

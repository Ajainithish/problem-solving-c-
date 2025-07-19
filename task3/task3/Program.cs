using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {


            //task9
            //while
            /*int a = 1;
            while (a <= 5)
            {
                int j = 1;
                while (j <= 20)
                {
                    Console.WriteLine(j + "x" + a + "=" + (a * (j)));
                    j++;
                }
               
                a++;*/

            // dowhile

            /*  int a=1;
              do
              {
                  int j=1;
                  while (j <= 20)
                  {
                      Console.WriteLine(j + "x" + a + "=" + (a * (j)));
                      j++;
                  }
                  a++;
              }
              while(a<=5);*/



            //task10
            //forloop
            /*Console.WriteLine("enter the number");
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<1;i++)
            {
                int res = ((n*(n + 1)) / 2);
                Console.WriteLine(res);
            }*/
            //while
            /* Console.WriteLine("enter the number");
             int n = int.Parse(Console.ReadLine());
             int i=0;
             while (i < 1)
             {
                 int res = ((n*(n + 1)) / 2);
                 Console.WriteLine(res);
                 i++;
            
             }*/
            //dowhile
            /*Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            do
            {
                int res = ((n * (n + 1)) / 2);
                Console.WriteLine(res);
                i++;

            }
            while (i < 1);*/

            //task11
            //forloop
            /*Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 1; i++)
            {
                int res = (n * (n + 1)) ;
                Console.WriteLine(res);
            }*/

            //while
            /*Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < 1)
            {
                int res = (n * (n + 1));
                Console.WriteLine(res);
                i++;

            }*/
            //dowhile
            /* Console.WriteLine("enter the number");
             int n = int.Parse(Console.ReadLine());
             int i = 0;
             do
             {
                 int res = (n * (n + 1));
                 Console.WriteLine(res);
                 i++;

             }
             while (i < 1);*/

            //task12
            //forloop
            /* Console.WriteLine("enter the number");
             double n = double.Parse(Console.ReadLine());
             for (double i = 0; i < 1; i++)
             {
                 double res = (n*n);
                 Console.WriteLine(res);
             }
             */
            //while
            /* Console.WriteLine("enter the number");
             double n = double.Parse(Console.ReadLine());
             int i=0;
             while (i < 1)
             {
                 double res = (n * n);
                 Console.WriteLine(res);
                 i++;
             }*/
            //dowhile
            /* Console.WriteLine("enter the number");
             double n = double.Parse(Console.ReadLine());
             int i = 0;
             do
             {
                 double res = (n * n);
                 Console.WriteLine(res);
                 i++;
             }
             while (i < 1);*/

            //task13

            //forloop

            /* Console.WriteLine("enter the number k");
             int k = int.Parse(Console.ReadLine());
             Console.WriteLine("enter the number n");
             int n = int.Parse(Console.ReadLine());
             int sum = 0;
             for (int i = 1; i <= n; i ++)
             {
                if(i%k==0)
                 {
                     sum = sum + i;
                    
                 }
             }
             Console.WriteLine(sum);*/

            //while
            /*Console.WriteLine("enter the number k");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number n");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int i=1;
            while (i <= n)
            {
                if (i % k == 0)
                {
                    sum = sum + i;
                   

                }
                i++;
            }

            Console.WriteLine(sum);*/

            //dowhile
            /* Console.WriteLine("enter the number k");
             int k = int.Parse(Console.ReadLine());
             Console.WriteLine("enter the number n");
             int n = int.Parse(Console.ReadLine());
             int sum = 0;
             int i = 1;
             do
             {
                 if (i % k == 0)
                 {
                     sum = sum + i;


                 }
                 i++;

             }
             while (i <= n);

             Console.WriteLine(sum);*/



            //task 15
            //forloop
            /* Console.WriteLine("enter the number n");
             long n = long.Parse(Console.ReadLine());
             long fact=1;
             for (int i = 1; i <= n; i++)
             {
                 if (n < 0)
                 {
                     Console.WriteLine("no factorial");
                 }
                 else if (n == 0)
                 {
                     Console.WriteLine("0 is 1");
                 }
                 else
                 {
                     fact *= i;
                 }
                 Console.WriteLine(fact);


             }*/

            //task14
            //forloop
            /* Console.WriteLine("enter the number n");
             int n = int.Parse(Console.ReadLine());
            
                 if (n % 3 == 0)
                 {
                     if (n % 5 == 0)
                     {
                         Console.WriteLine("fizzBizz");
                     }

                 }
                 else if (n % 3 == 0)
                 {
                     Console.WriteLine("fizz");
                 }

                 else if (n % 5 == 0)
                 {
                     Console.WriteLine("Bizz");
                 }
                 else
                 {
                     for (int i = 1; i <= n; i++)
                     {
                         Console.WriteLine(i);
                     }
                 }*/
            //while
            /*Console.WriteLine("enter the number n");
            int n = int.Parse(Console.ReadLine());
            int i=1;
                if (n % 3 == 0)
                {
                    if (n % 5 == 0)
                    {
                        Console.WriteLine("fizzBizz");
                    }

                }
                else if (n % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }

                else if (n % 5 == 0)
                {
                    Console.WriteLine("Bizz");
                }
                else
                {
                    while (i <= n)
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                    
                }*/
            //dowhile
            /* Console.WriteLine("enter the number n");
             int n = int.Parse(Console.ReadLine());
             int i=1;
                 if (n % 3 == 0)
                 {
                     if (n % 5 == 0)
                     {
                         Console.WriteLine("fizzBizz");
                     }

                 }
                 else if (n % 3 == 0)
                 {
                     Console.WriteLine("fizz");
                 }

                 else if (n % 5 == 0)
                 {
                     Console.WriteLine("Bizz");
                 }
                 else
                 {
                     do
                     {
                         Console.WriteLine(i);
                         i++;

                     }
                     while (i <= n);
                 }*/


            //task16   

            //forloop
            /*Console.WriteLine("enter the number of subject");
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("enter your mark :");
                total += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("total mark is"+total);
            double avg = (double)total / n;
            Console.WriteLine("yours average is"+avg);*/

            //while

            /*Console.WriteLine("enter the number of subject");
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine("enter your mark :");
                total += int.Parse(Console.ReadLine());
                i++;
            }
            double avg = (double)total / n;
            Console.WriteLine("yours average is"+avg);*/

            //dowhile
            /* Console.WriteLine("enter the number of subject");
             int n = int.Parse(Console.ReadLine());
             int total = 0;
             int i = 1;
             do
             {
                 Console.WriteLine("enter your mark :");
                 total += int.Parse(Console.ReadLine());
                 i++;
             }
             while (i <= n);
              double avg = (double)total / n;
             Console.WriteLine("yours average is"+avg);*/

            //task17
            //forloop
            /*Console.WriteLine("enter the total number of rounds");
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("enter score for an round :");
                total += int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("your final total is"+total);
            */
            //while
            /*Console.WriteLine("enter the total number of rounds");
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine("enter score for an round :");
                total += int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("your final total is" + total);
            */
            //dowhile
            /*Console.WriteLine("enter the total number of rounds");
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            int i = 1;
            do
            {
                Console.WriteLine("enter score for an round :");
                total += int.Parse(Console.ReadLine());
                i++;
            }
            while (i <= n);
             Console.WriteLine("your final total is" + total);
            */

            //task18
            //whileloop
            /* while (true)
             {
                 Console.WriteLine("enter the number 1");
                 double a = double.Parse(Console.ReadLine());

                 Console.WriteLine("enter the number 2");
                 double b = double.Parse(Console.ReadLine());

                 Console.WriteLine("enter the calculation method '+' '-' '*' '/' '%' ");
                 char op = char.Parse(Console.ReadLine());

                 if (op == '+')
                 {
                     Console.WriteLine(a + b);
                 }
                 else if (op == '-')
                 {
                     Console.WriteLine(a - b);
                 }
                 else if (op == '*')
                 {
                     Console.WriteLine(a * b);
                 }
                 else if (op == '%')
                 {
                     Console.WriteLine(a % b);
                 }
                 else if (op == '/')
                 {
                     Console.WriteLine(a / b);
                 }
                 Console.WriteLine("type 'yes' to continue or 'qiute' to leave  ");
                 string i = Console.ReadLine();
                 if (i == "no")
                 {
                     break;
                 }
             }*

            //dowhile
            /*  do
              {
                  Console.WriteLine("enter the number 1");
                  double a = double.Parse(Console.ReadLine());

                  Console.WriteLine("enter the number 2");
                  double b = double.Parse(Console.ReadLine());

                  Console.WriteLine("enter the calculation method '+' '-' '*' '/' '%' ");
                  char op = char.Parse(Console.ReadLine());

                  if (op == '+')
                  {
                      Console.WriteLine(a + b);
                  }
                  else if (op == '-')
                  {
                      Console.WriteLine(a - b);
                  }
                  else if (op == '*')
                  {
                      Console.WriteLine(a * b);
                  }
                  else if (op == '%')
                  {
                      Console.WriteLine(a % b);
                  }
                  else if (op == '/')
                  {
                      Console.WriteLine(a / b);
                  }
                  Console.WriteLine("type 'yes' to continue or 'qiute' to leave  ");
                  string i = Console.ReadLine();
                  if (i == "no")
                  {
                      break;
                  }
              }
              while (true);
           
             */

            //task19
            //forloop
           
           /* Console.WriteLine("how many rounds ");
            int n = int.Parse(Console.ReadLine());


            Console.WriteLine("1 is rock");
            Console.WriteLine("2 is paper");
            Console.WriteLine("3 is scissors");

            int u = 0;
            int a = 0;

            
            for (int i = 1; i <= n; i++)
            {

               
                Console.WriteLine(" your turn");
                int t = int.Parse(Console.ReadLine());

                Random c = new Random();
                int result = c.Next(1, 3);
                Console.WriteLine(result);


                {
                    if (t == result)
                    {
                        Console.WriteLine("it draw");
                    }
                    else if (t == 1 && result == 2)
                    {
                        Console.WriteLine("failed");
                        a++;
                    }
                    else if (t == 2 && result == 1)
                    {
                        Console.WriteLine("you one point");
                        u++;
                    }
                    else if (t == 2 && result == 3)
                    {
                        Console.WriteLine("failed");
                        a++;
                    }
                    else if (t == 3 && result == 2)
                    {
                        Console.WriteLine("you one point");
                        u++;
                    }
                    else if (t == 1 && result == 3)
                    {
                        Console.WriteLine("you one point");
                        u++;
                    }
                    else if (t == 3 && result == 1)
                    {
                        Console.WriteLine("failed");
                        a++;
                    }
                }
            }
            if (u > a)
            {
                Console.WriteLine("user win");
            }
            else if (a > u)
            {
                Console.WriteLine("Computer Win");
            }
            else if (a == u)
            {
                Console.WriteLine("it draw");
            }*/

            //whileloop

           /* Console.WriteLine("how many rounds ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("1 is rock");
            Console.WriteLine("2 is paper");
            Console.WriteLine("3 is scissors");
            int i = 1;
            int u = 0;
            int a = 0;

            while (i <= n)
            {
                Console.WriteLine(" your turn");
                int t = int.Parse(Console.ReadLine());

                Random c = new Random();
                int result = c.Next(1, 3);
                Console.WriteLine(result);

                {
                    if (t == result)
                    {
                        Console.WriteLine("it draw");
                    }
                    else if (t == 1 && result == 2)
                    {
                        Console.WriteLine("failed");
                        a++;
                    }
                    else if (t == 2 && result == 1)
                    {
                        Console.WriteLine("you one point");
                        u++;
                    }
                    else if (t == 2 && result == 3)
                    {
                        Console.WriteLine("failed");
                        a++;
                    }
                    else if (t == 3 && result == 2)
                    {
                        Console.WriteLine("you one point");
                        u++;
                    }
                    else if (t == 1 && result == 3)
                    {
                        Console.WriteLine("you one point");
                        u++;
                    }
                    else if (t == 3 && result == 1)
                    {
                        Console.WriteLine("failed");
                        a++;
                    }

                }
                i++;

            }
            if (u > a)
            {
                Console.WriteLine("user win");
            }
            else if (a > u)
            {
                Console.WriteLine("Computer Win");
            }
            else if (a == u)
            {
                Console.WriteLine("it draw");
            }
            */

            //dowhile

            /*Console.WriteLine("how many rounds ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("1 is rock");
            Console.WriteLine("2 is paper");
            Console.WriteLine("3 is scissors");
            int i = 1;
            int u = 0;
            int a = 0;
             
             do
              {
              Console.WriteLine(" your turn");
                int t = int.Parse(Console.ReadLine());

                Random c = new Random();
                int result = c.Next(1, 3);
                Console.WriteLine(result);
              {
                    if (t == result)
                    {
                        Console.WriteLine("it draw");
                    }
                    else if (t == 1 && result == 2)
                    {
                        Console.WriteLine("failed");
                        a++;
                    }
                    else if (t == 2 && result == 1)
                    {
                        Console.WriteLine("you one point");
                        u++;
                    }
             else if (t == 2 && result == 3)
                    {
                        Console.WriteLine("failed");
                        a++;
                    }
                    else if (t == 3 && result == 2)
                    {
                        Console.WriteLine("you one point");
                        u++;
                    }
                    else if (t == 1 && result == 3)
                    {
                        Console.WriteLine("you one point");
                        u++;
                    }
                    else if (t == 3 && result == 1)
                    {
                        Console.WriteLine("failed");
                        a++;
                    }
             

              }
             i++;
                  
            }
             while(i<=n);
            if (u > a)
            {
                Console.WriteLine("user win");
            }
            else if (a > u)
            {
                Console.WriteLine("Computer Win");
            }
            else if (a == u)
            {
                Console.WriteLine("it draw");
            }*/
             
           




            //task20
            //while
/*
           int a = 0;
            Random c = new Random();
            int magic = c.Next(1, 21);
            int n = magic;    
            while (true)
            {
                Console.WriteLine("enter your guessing number");
                int g = int.Parse(Console.ReadLine());
                a++;

                if (g > n)
                {
                    Console.WriteLine( g+"   is higher than magic number");
                }
                else if (g < n)
                {
                    Console.WriteLine( g+"   is lower than magic number ");
                }
                else if (g == n)
                {
                    Console.WriteLine("it's Correct");
                    Console.WriteLine("magic number is  "+ n);
                   
                    break;
                }

                
            }
            Console.WriteLine("attempts to find the number " + a);
           */
            

            //forloop
           /* int a=0;
            Console.WriteLine("enter your starting number");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your ending number");
            int e = int.Parse(Console.ReadLine());

            Random c = new Random();
            int magic = c.Next(1, 21);
            int n = magic;

            for (; s <= e; s++)
            {
                Console.WriteLine("enter your guessing number");
                int g = int.Parse(Console.ReadLine());
                a++;

                if (g > n)
                {
                    Console.WriteLine(g + "   is higher than magic number");
                }
                else if (g < n)
                {
                    Console.WriteLine(g + "   is lower than magic number ");
                }
                else if (g == n)
                {
                    Console.WriteLine("it's Correct");
                    Console.WriteLine("magic number is  " + n);

                    break;
                }

            }
            Console.WriteLine("attempts to find the number " + a);
            */


















        }
        }
    }


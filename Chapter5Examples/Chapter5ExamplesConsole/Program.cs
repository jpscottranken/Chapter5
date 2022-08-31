using System;

namespace Chapter5ExamplesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 17;
            int y = 12;
            int num1;
            int max;
            int min;
            string size = "";

            //if (x == y)
            //{
            //    Console.WriteLine("x equals y");
            //}
            //else
            //{
            //    Console.WriteLine("x does NOT equal y");
            //}

            //if (x != y)
            //{
            //    Console.WriteLine("x DOES NOT equal y");
            //}
            //else
            //{
            //    Console.WriteLine("x DOES equal y");
            //}

            //if (x > y)
            //{
            //    Console.WriteLine("x IS GREATER THAN y");
            //}
            //else
            //{
            //    Console.WriteLine("x IS NOT GREATER THAN y");
            //}

            //if (x >= y)
            //{
            //    Console.WriteLine("x IS GREATER THAN OR EQUAL to y");
            //}
            //else
            //{
            //    Console.WriteLine("x IS NOT GREATER THAN y");
            //}

            //if (x < y)
            //{
            //    Console.WriteLine("x IS LESS THAN y");
            //}
            //else
            //{
            //    Console.WriteLine("x IS NOT LESS THAN y");
            //}

            //if (x <= y)
            //{
            //    Console.WriteLine("x IS LESS THAN OR EQUAL TO y");
            //}
            //else
            //{
            //    Console.WriteLine("x IS NOT LESS THAN OR EQUAL TO y");
            //}

            //int x = 17;
            //int y = 12;

            //if ((x >= 20) && (y <= 100))
            //{
            //    Console.WriteLine("Condition true");
            //}
            //else
            //{
            //    Console.WriteLine("Condition false");
            //}

            //if ((x >= 10) && (y <= 100))
            //{
            //    Console.WriteLine("Condition true");
            //}
            //else
            //{
            //    Console.WriteLine("Condition false");
            //}

            //int x = 17;
            //int y = 12;

            //if ((x <= 10) || (y <= 100))
            //{
            //    Console.WriteLine("Condition true");
            //}
            //else
            //{
            //    Console.WriteLine("Condition false");
            //}

            //if ((x >= 10) && (y <= 100))
            //{
            //    Console.WriteLine("Condition true");
            //}
            //else
            //{
            //    Console.WriteLine("Condition false");
            //}

            //if (!(x >= 10) && (y <= 100))
            //{
            //    Console.WriteLine("Condition true");
            //}
            //else
            //{
            //    Console.WriteLine("Condition false");
            //}

            //if (!((x >= 10) || (y <= 100)))
            //{
            //    Console.WriteLine("Condition true");
            //}
            //else
            //{
            //    Console.WriteLine("Condition false");
            //}

            //Console.Write("Enter a number: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //if (num1== 0)
            //{
            //    Console.WriteLine("0 is neither odd nor even");
            //}
            //else if (num1 % 2 == 0)
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");
            //}

            //Console.Write("Enter your size (S, M, or L): ");
            //size = Console.ReadLine();
            //size = size.ToUpper();

            //if (size == "S")
            //{
            //    Console.WriteLine("You're a small");
            //}
            //else if (size == "M")
            //{
            //    Console.WriteLine("You're a medium");
            //}
            //else if (size == "L")
            //{
            //    Console.WriteLine("You're a large");
            //}
            //else
            //{
            //    Console.WriteLine("Unknown size");
            //}
            //Console.ReadLine();

            //Console.Write("Enter your size (S, M, or L): ");
            //size = Console.ReadLine();

            //switch (size)
            //{
            //    case "S":
            //    case "s":
            //        Console.WriteLine("You're a small");
            //        break;

            //    case "M":
            //    case "m":
            //        Console.WriteLine("You're a medium");
            //        break;

            //    case "L":
            //    case "l":
            //        Console.WriteLine("You're a large");
            //        break;

            //    default:
            //        Console.WriteLine("Unknown size");
            //        break;
            //}

            //if (x >= y)
            //{
            //    max = x;
            //}
            //else
            //{
            //    max = y;
            //}

            //max = (x >= y) ? x : y;

            //Console.WriteLine("max = " + max.ToString());

            //min = (x <= y) ? x : y;

            //Console.WriteLine("min = " + min.ToString());

            ////  while loop is a pretest loop
            //int lcv = 1;        //  Initializing the loop control variable
            //while (lcv <= 10)   //  Testing the value of the loop control variable
            //{
            //    Console.WriteLine("while loop " + lcv.ToString());
            //    ++lcv;          //  Changing the value of the loop control variable
            //}

            //Console.WriteLine("\n\n");

            ////  for loop is a pretest loop (counting loop)
            //for (int lcv2 = 1; lcv2 <= 10; ++lcv2)
            //{
            //    Console.WriteLine("for loop " + lcv2.ToString());
            //}

            //Console.WriteLine("\n\n");

            ////  do/while loop is a posttest loop
            //int lcv3 = 1;        //  Initializing the loop control variable
            //do                   
            //{
            //    Console.WriteLine("do/while loop " + lcv3.ToString());
            //    ++lcv3;          //  Changing the value of the loop control variable
            //}  while (lcv3 <= 10);//  Testing the value of the loop control variable

            //  while loop is a pretest loop
            int lcv = 0;        //  Initializing the loop control variable
            while (lcv < 10)    //  Testing the value of the loop control variable
            {
                ++lcv;          //  Changing the value of the loop control variable

                if (lcv == 7)
                {
                    //break;  //  Output should be 1 2 3 4 5 6 
                    continue; //  Output should be 1 2 3 4 5 6 8 9 10
                }

                Console.WriteLine("while loop " + lcv.ToString());
            }

            Console.ReadLine();
        }
    }
}

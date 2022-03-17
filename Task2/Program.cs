using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputAnswer;
            bool continueWhile;
            while (true)
            {

                Console.WriteLine("Start: Y/N");
                inputAnswer = Convert.ToString(Console.ReadLine());
                continueWhile = (inputAnswer == "y" || inputAnswer == "Y");

                if (continueWhile == false)
                {
                    Console.WriteLine("exiting...");
                    break;
                }


                // --
                Console.WriteLine("daxil et:");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a % 3 == 0 && a % 2 == 0)
                {
                    Console.WriteLine("3-e bolunen cut");
                }
                else if (a % 3 == 0 && a % 2 == 1)
                {
                    Console.WriteLine("3-e bolunen tek");
                }
                else
                {
                    Console.WriteLine("3-e bolunmur");
                }
            }
        }
    }
}


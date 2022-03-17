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

                Console.WriteLine("Start: y/n");
                inputAnswer = Convert.ToString(Console.ReadLine());
                continueWhile = (inputAnswer == "y" || inputAnswer == "Y");

                if (continueWhile == false)
                {
                    Console.WriteLine("exited");
                    break;
                }


                // ----------
                Console.WriteLine("daxil et:");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a % 3 == 0 )
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");

                }



            }
        }
    }
}

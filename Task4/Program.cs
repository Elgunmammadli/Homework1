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
                a = Math.Abs(a);

                if (a >=0 && a<10)
                {
                    Console.WriteLine("1-reqemli");
                }
                else if(a >= 10 && a < 100)
                {
                    Console.WriteLine("2-reqemli");

                }
                else if (a >= 100 && a < 1000)
                {
                    Console.WriteLine("3-reqemli");

                }
                else if (a >= 1000 && a < 10000)
                {
                    Console.WriteLine("4-reqemli");

                }
                else if (a >= 10000 && a < 100000)
                {
                    Console.WriteLine("5-reqemli");

                }
                else
                {
                    Console.WriteLine("Nezere alinmayib");
                }



            }
        }
    }
}

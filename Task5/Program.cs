using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String inputAnswer;
            bool continueWhile;
            while (true)
            {
                Console.WriteLine("Start: Y/N ");
                inputAnswer = Convert.ToString(Console.ReadLine());
                continueWhile = (inputAnswer == "Y" || inputAnswer == "y");
                if (continueWhile == false)
                {
                    Console.WriteLine("Exited");
                    break;
                }
                int number1, number2, qismet;
                Console.WriteLine("1ci ededi daxil edin:");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2ci ededi daxil edin:");
                number2 = Convert.ToInt32(Console.ReadLine());
                qismet = number1 / number2;
                if (number1%number2==0)
                {
                    Console.WriteLine($"{number1}, {number2}-e tam bolunur : qismet = {qismet}");
                }
                else
                {
                    Console.WriteLine("Bolunmur");
                }

            }
        }
    }
}

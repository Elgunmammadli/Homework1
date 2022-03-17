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
                continueWhile = (inputAnswer=="Y" || inputAnswer=="y");
                if (continueWhile == false)
                {
                    Console.WriteLine("Exited");
                    break;
                }
                int number1, number2,cem;
                Console.WriteLine("1ci ededi daxil edin:");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2ci ededi daxil edin:");
                number2 = Convert.ToInt32(Console.ReadLine());
                cem = number1 + number2;
                cem = Math.Abs(cem);
                if (cem>=10 && cem < 100)
                {
                    Console.WriteLine($"{number1} ve {number2} reqemlerinin cemi ikireqemlidir : Cem = {cem}");
                }
                else if(cem>=100 && cem < 1000)
                {
                    Console.WriteLine($"{number1} ve {number2} reqemlerinin cemi ucreqemlidir : Cem = {cem}");
                }
                else
                {
                    Console.WriteLine("Nezere alinmayib");
                }

            }
        }
    }
}

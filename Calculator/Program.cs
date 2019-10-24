using System;

namespace Calculator
{
    class Program
    {

        //private int RunAddition()
        private static void RunAddition()
        {
            int number1;
            int number2;
            Console.WriteLine("Ange ett nummer: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ett nummer: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 + number2);
        }

        private static void RunSubtraction()
        {
            int number1;
            int number2;
            Console.WriteLine("Ange ett nummer: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ett nummer: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 - number2);
        }

        private static void RunMultiplication()
        {
            int number1;
            int number2;
            Console.WriteLine("Ange ett nummer: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ett nummer: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 * number2);
        }

        private static void RunDivision()
        {
            int number1;
            int number2;
            Console.WriteLine("Ange ett nummer: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ett nummer: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 / number2);
        }


        //static int AskUserForANumber()
        //{
        //    Console.WriteLine("Ange ett nummer: ");
        //    return int.Parse(Console.ReadLine());
        //}



        static void Main(string[] args)
        {
            int usersLoopChoise; //for the loop

            do
            {
                Console.WriteLine("RÄKNA RÄTT MED KALKYLATORN");
                Console.WriteLine();
                Console.WriteLine("Ange");
                Console.WriteLine("1 för att addera");
                Console.WriteLine("2 för att subtrahera");
                Console.WriteLine("3 för att multiplicera");
                Console.WriteLine("4 för att dividera");
                Console.WriteLine();
                Console.WriteLine("9 för att avsluta programmet.");

                //usersChoise = int.Parse(Console.ReadKey().ToString());
                usersLoopChoise = int.Parse(Console.ReadLine());
                switch (usersLoopChoise)
                {
                    case 9:
                        break;
                    case 1:
                        RunAddition();
                        break;
                    case 2:
                        RunSubtraction();
                        break;
                    case 3:
                        RunMultiplication();
                        break;
                    case 4:
                        RunDivision();
                        break;
                }
            } while (usersLoopChoise != 9);


        }
    }
}

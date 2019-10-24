using System;

namespace Calculator
{
    class Program
    {

        //private int RunAddition()
        private static void RunAddition()
        {
            double number1;
            double number2;
            Console.Write("Ange ett nummer: ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Ange ett nummer: ");
            number2 = double.Parse(Console.ReadLine());
            Console.Write("Resultat: " + number1 * number2);
        }

        private static void RunSubtraction()
        {
            double number1;
            double number2;
            Console.Write("Ange ett nummer: ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Ange ett nummer: ");
            number2 = double.Parse(Console.ReadLine());
            Console.Write("Resultat: " + number1 * number2);
        }

        private static void RunMultiplication()
        {
            double number1;
            double number2;
            Console.Write("Ange ett nummer: ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Ange ett nummer: ");
            number2 = double.Parse(Console.ReadLine());
            Console.Write("Resultat: " + number1 * number2);
        }

        private static void RunDivision()
        {
            double number1;
            double number2;
            Console.Write("Ange ett nummer: ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Ange ett nummer: ");
            number2 = double.Parse(Console.ReadLine());


                if (number1 == 0)
                    Console.WriteLine("Värdet 0 får ej användas vid division.");
                else 
                    Console.WriteLine("Resultat: " + (number1 / number2));

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
                Console.WriteLine();
                Console.WriteLine("Ange");
                Console.WriteLine("1 för att addera");
                Console.WriteLine("2 för att subtrahera");
                Console.WriteLine("3 för att multiplicera");
                Console.WriteLine("4 för att dividera");
                Console.WriteLine();
                Console.WriteLine("9 för att avsluta programmet.");
                Console.WriteLine();
                Console.Write("Ange ditt val: ");

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

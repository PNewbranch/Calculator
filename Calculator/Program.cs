using System;

namespace Calculator
{
    class Program
    {

        private static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("\tAnge:");
            Console.WriteLine("\t1 för att addera");
            Console.WriteLine("\t2 för att subtrahera");
            Console.WriteLine("\t3 för att multiplicera");
            Console.WriteLine("\t4 för att dividera \n");
            Console.WriteLine("\t9 för att avsluta programmet. \n");
            Console.Write("Ange ditt val: ");
        }
    
        private static void RunAddition()
        {
            double number1;
            double number2;
            Console.Write("Ange ditt första nummer: ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Ange ditt andra nummer: ");
            number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultat: " + (number1 + number2));
        }

        private static void RunSubtraction()
        {
            double number1;
            double number2;
            Console.Write("Ange ditt första nummer: ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Ange ditt andra nummer: ");
            number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultat: " + (number1 - number2));
        }

        private static void RunMultiplication()
        {
            double number1;
            double number2;
            Console.Write("Ange ditt första nummer: ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Ange ditt andra nummer: ");
            number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultat: " + (number1 * number2));
        }

        private static void RunDivision()
        {
            double number1;
            double number2;
            Console.Write("Ange ditt första nummer: ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Ange ditt andra nummer: ");
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
            bool uppRunning = true;
            
            try
            {

                do
                {

                    ShowMenu();

                    try
                    {
                        //usersChoise = int.Parse(Console.ReadKey().ToString());
                        usersLoopChoise = int.Parse(Console.ReadLine());
                        switch (usersLoopChoise)
                        {
                            case 9:
                                uppRunning = false;
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
                        if (usersLoopChoise != 9)
                        {
                            Console.WriteLine("Tryck någon tangent för att fortsätta.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Felakttigt värde inmatat, vänligen försök igen.");
                        Console.Clear();
                    }

                } while (uppRunning);
            
            }
            catch (Exception)
            {
                Console.WriteLine("Något odefinierat fel uppstod, vänligen försök igen.");
                Console.Clear();
            }
        }
    }
}

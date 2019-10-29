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
            Console.WriteLine("\t4 för att dividera\n");
            Console.WriteLine("\t9 för att avsluta programmet\n");
            Console.Write("Ange ditt val: ");

        }

        private static double AskForInput() //(outparametern) RETURN-värdet skrivs FÖRE metodnamnet - return= DOUBLE
        {
            Console.Write("Ange ett nummer: ");
            return double.Parse(Console.ReadLine()); //skickar det inlästa värdet som "return"
        }

        private static void WaitForValueToContinue()
        {
            Console.WriteLine("Tryck någon tangent för att fortsätta.");
            Console.ReadKey();
            Console.Clear();
        }

        private static void RunAddition(double num1, double num2) //förväntade inparametrar skrivs i parentes - input typ DOUBLE var num1
        {
            Console.WriteLine(num1 + num2);
        }

        private static void RunSubtraction(double num1, double num2) 
        {
            Console.WriteLine(num1 - num2);
        }

        private static void RunMultiplication(double num1, double num2)
        {
            Console.WriteLine(num1 * num2);
        }

        private static void RunDivision(double num1, double num2) 
        {
            if ((num1 == 0) || (num2 == 0))
            {
                Console.WriteLine("Det är ej tillåtet att användar nollor vid division!");
            }
            else
            {
                Console.WriteLine(num1 / num2);
            }

        }
        
        static void Main(string[] args)
        {

            bool uppRunning = true; //loopar så länge denna är sann
            int usersLoopChoise; //användarens val
           
            try
            {
                do  //min do-sats
                {
                    ShowMenu();

                    try //min try som fågnar upp fel tecken
                    {
                        //usersChoise = int.Parse(Console.ReadKey().ToString());
                        usersLoopChoise = int.Parse(Console.ReadLine());
                        switch (usersLoopChoise)
                        {
                            case 9:
                                //Console.WriteLine("Du har valt att avsluta!");
                                uppRunning = false;
                                break;
                            case 1:
                                RunAddition(AskForInput(), AskForInput());
                                break;
                            case 2:
                                RunSubtraction(AskForInput(), AskForInput());
                                break;

                            case 3:
                                RunMultiplication(AskForInput(), AskForInput());
                                break;
                            case 4:
                                RunDivision(AskForInput(), AskForInput());
                                break;
                        }
                        if (usersLoopChoise != 9)
                        {
                            WaitForValueToContinue();
                        }
                    }

                    catch (Exception)
                    {
                        Console.WriteLine("\nFelaktigt värde inmatat, vi försöker igen!");
                        Console.WriteLine("Ange heltal vid val av räknesätt och heltal/decimaltal (kommaavskiljare) vid beräkning.");
                        WaitForValueToContinue();
                    }

                } while (uppRunning); //loop
            
            }
            catch (Exception)
            {
                Console.WriteLine("\n\nNågot odefinierat fel uppstod, vänligen försök igen!!!\n\n");
                WaitForValueToContinue();
            } //try-carch

        } //main
    } //class program
}

﻿using System;

namespace Calculator
{
    class Program
    {

        private static void RunAddition()
        {
            Console.WriteLine("+");
        }

        private static void RunSubtraction()
        {
            Console.WriteLine("-");
        }

        private static void RunMultiplication()
        {
            Console.WriteLine("*");
        }

        private static void RunDivision()
        {
            Console.WriteLine("/");
        }





        static void Main(string[] args)
        {
            int usersLoopChoise; //for the loop
            int usersFirstNumber;
            int usersLastNumber;




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
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace car_wash_console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;

            string intro = "Welcome to the Car Wash App";
            Console.WriteLine(intro);

            while (runProgram)
            {
                CreateLine();
                MainOptions();

                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Choose the service");
                    Console.WriteLine("1 - Fast Wash");
                    Console.WriteLine("2 - Long Wash");
                    Console.WriteLine("3 - Especial Wash");
                    Console.WriteLine("Write the option number to choose it: ");
                    string serviceOption = Console.ReadLine();

                    if (serviceOption == "1")
                    {
                        Console.WriteLine("\nFast Wash selected. Confirm? (Yes/No)");
                        //To lower case, trim spaces
                        //if yes, select car, then the available employee
                        //if no do something else
                    }
                    else if (serviceOption == "2")
                    {
                        Console.WriteLine("Long Wash selected. Confirm? (Yes/No)");
                        //To lower case, trim spaces
                        //if yes, select car, then the available employee
                        //if no do something else
                    }
                    else if (serviceOption == "3")
                    {
                        Console.WriteLine("Especial Wash selected. Confirm? (Yes/No)");
                        //To lower case, trim spaces
                        //if yes, select car, then the available employee
                        //if no do something else
                    }
                    else
                    {
                        Console.WriteLine("Invalid option...");
                    }
                }

                else if (userInput == "3")
                {
                    Console.WriteLine("What is the employee's name?");
                    string newEmployeeName = Console.ReadLine();
                    Console.WriteLine("What is the employee's salary");
                    string newEmployeeSalary = Console.ReadLine();
                    Console.WriteLine("What is the employee's adress");
                    string newEmployeeAdress = Console.ReadLine();

                    Console.WriteLine($"New employee");
                    Console.WriteLine($"Name: {newEmployeeName}.");
                    Console.WriteLine($"Salary: {newEmployeeSalary}.");
                    Console.WriteLine($"Adress: {newEmployeeAdress}.");
                    Console.WriteLine($"Confirm? (Yes/No)");
                    Console.ReadLine();
                }

                else if (userInput == "5")
                {
                    ExitProgram();
                }

                else
                {
                    InvalidChoiceErrorMessage();
                }

                void CreateLine()
                {
                    Console.WriteLine("\n|----------------------------------------------------------|\n");
                }

                void MainOptions()
                {
                    Console.WriteLine("Options:");
                    Console.WriteLine("1 - Add Service");
                    Console.WriteLine("2 - Add Client");
                    Console.WriteLine("3 - Add Employee");
                    Console.WriteLine("5 - Exit");
                    Console.WriteLine("Write the option number to choose it: ");
                }

                void InvalidChoiceErrorMessage()
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid option, choose again.");
                    Console.ResetColor();
                }

                void ExitProgram()
                {
                    runProgram = false;
                }
            }
        }
    }
}

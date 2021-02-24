﻿using AW1.Arrays;
using AW1.Funktionen;
using AW1.Referenzen;
using System;

namespace AW1
{
    class Program
    {
        public static void Main(string[] args)
        {
            EnhancedMenu();
            Console.ReadKey();
        }

        private static void EnhancedMenu()
        {
            while (true)
            {
                Console.WriteLine("Aufrufcode definieren:");
                string code = Console.ReadLine().ToLower();
                if (code == "exit") return;
                else if (code[0] == 'a')
                {
                    if (code[1] == '5') AB5.Task1();
                    else if (code[1] == 'm')
                    {
                        if (code[2] == '1') ABMDArrays.Task1();
                        else if (code[2] == '2')
                        {
                            if (code[3] == 'a')
                                ABMDArrays.Task2(Subtask.A);
                            else if (code[3] == 'b')
                                ABMDArrays.Task2(Subtask.B);
                        }
                        else if (code[2] == '3')
                        {
                            if (code[3] == 'a')
                                ABMDArrays.Task3(Subtask.A);
                            else if (code[3] == 'b')
                                ABMDArrays.Task3(Subtask.B);
                        }
                    }
                }
                else if (code[0] == 'f')
                {
                    if (code[1] == 'a')
                    {
                        if (code[2] == '1') ABFunktionen.Task1();
                        else if (code[2] == '2') ABFunktionen.Task2();
                        else if (code[2] == '3') ABFunktionen.Task3();
                    }
                    else if (code[1] == 'f')
                    {
                        Console.WriteLine("Bitte geben Sie einen Wert für n ein");
                        int n = Convert.ToInt32(Console.ReadLine());
                        if (code[2] == 'i') Console.WriteLine(Fakultät.Iterative(n));
                        else if (code[2] == 'r') Console.WriteLine(Fakultät.Recursive(n));
                    }
                    else if (code[1] == 'r')
                    {
                        if (code[2] == '1')
                        {
                            double a = 0, b = 0;
                            if (code[3] == 'a')
                            {
                                Console.WriteLine("Wert für a?");
                                a = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Wert für b?");
                                b = Convert.ToDouble(Console.ReadLine());
                            }
                            Recursive.Task1((Subtask)code[3], a, b);
                        }
                        else if (code[2] == '2') Recursive.Task2((Subtask)code[3]);
                        else if (code[2] == '3') Recursive.Task3();
                    }
                }
                else if (code[0] == 'r')
                {
                    if (code[1] == 's') Semantik.TaskA();
                }
                Console.WriteLine();
            }
        }
    }
}
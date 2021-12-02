using AW1.Arrays;
using AW1.Beziehungen;
using AW1.Funktionen;
using AW1.Interfaces;
using AW1.Loops;
using AW1.OOP;
using AW1.Referenzen;
using AW1.Sortieren;
using AW1.Suchen;
using AW1.Vererbung;
using AW1.Wiederholung;
using AW1.Wiederholung.Experten;
using AW1GUI;
using System;
using System.Windows;

namespace AW1
{
    public class Program
    {
        [STAThread]
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
                //Arrays
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
                //Funktionen
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
                //Loops
                else if (code[0] == 'l')
                {
                    if (code[1] == '1')
                    {
                        Aufgabe1 a = new Aufgabe1();
                        if (code[2] == 'a') a.Task1();
                        else if (code[2] == 'b') a.Task2();
                        else if (code[2] == 'c') a.Task3();
                    }
                    else if (code[1] == '2')
                    {
                        Aufgabe2 a = new Aufgabe2();
                        if (code[2] == 'a') a.Task1();
                        else if (code[2] == 'b') a.Task2();
                        else if (code[2] == 'c') a.Task3();
                        else if (code[2] == 'd') a.Task4();
                    }
                }
                //Referenzen
                else if (code[0] == 'r')
                {
                    if (code[1] == 'e') Semantik.TaskA();
                    else if (code[1] == 's')
                    {
                        if (code[2] == 'b') Structs.TaskB();
                        else if (code[2] == 'c') Structs.TaskC();
                        else if (code[2] == 'd') Structs.TaskD();
                        else if (code[2] == 'e') Structs.TaskE();
                        else if (code[2] == 'f') Structs.TaskF();
                    }
                }
                //Suchen + Sortieren
                else if (code[0] == 's')
                {
                    if (code[1] == 'l')
                    {
                        if (code[2] == 'a') LinearSearch.TaskA();
                        else if (code[2] == 'c') LinearSearch.TaskC();
                    }
                    else if (code[1] == 'b')
                    {
                        if (code[2] == 'b') BinarySearch.TaskB();
                        else if (code[2] == 'c') BinarySearch.TaskC();
                    }
                    //Sortieren
                    else if (code[1] == 's')
                    {
                        if (code[2] == 'b')
                        {
                            if (code[3] == 'a') Bubblesort.TaskA();
                            else if (code[3] == 'b') Bubblesort.TaskB();
                            else if (code[3] == 'c') Bubblesort.TaskC();
                        }
                    }
                }
                //Wiederholung
                else if (code[0] == 'w')
                {
                    if (code[1] == '4')
                    {
                        if (code[2] == 'a') Wiederholung0421.TaskA();
                        else if (code[2] == 'b') Wiederholung0421.TaskB();
                        else if (code[2] == 'c') Wiederholung0421.TaskC();
                    }
                    else if (code[1] == '6')
                    {
                        if (code[2] == 'a') Wiederholung0621.TaskA();
                        else if (code[2] == 'b') Wiederholung0621.TaskB();
                        else if (code[2] == 'c') Wiederholung0621.TaskC();
                    }
                    else if (code[1] == 'p')
                    {
                        if (code[2] == 'b') Password.TaskB();
                        else if (code[2] == 'c') Password.TaskC();
                    }
                }
                //OOP
                else if (code[0] == 'o')
                {
                    if (code[1] == 'i')
                    {
                        if (code[2] == 'c') Immobilienverwaltung.TaskC();
                        else if (code[2] == 'd') Immobilienverwaltung.TaskD();
                    }
                }
                //Vererbung
                else if (code[0] == 'v')
                {
                    if (code[1] == 'v')
                    {
                        if (code[2] == 'a') Vererbung.Vererbung.TaskA();
                    }
                    else if (code[1] == 'p')
                    {
                        if (code[2] == 'a') PersonenVerwaltung.TaskA();
                    }
                    else if (code[1] == 'o')
                    {
                        if (code[2] == 'c') Onlineshop.TaskC();
                        else if (code[2] == 'd') Onlineshop.TaskD();
                    }
                }
                //Beziehungen
                else if (code[0] == 'b')
                {
                    if (code[1] == 'k')
                    {
                        if (code[2] == 'c') Konto.TaskC();
                        else if (code[2] == 'd') Konto.TaskD();
                    }
                    else if (code[1] == 'l')
                    {
                        if (code[2] == 'b') Lager.TaskB();
                    }
                }
                //gui
                else if (code[0] == 'g')
                {
                    var application = new Application();
                    application.Run(new MainWindow());
                    return;
                }
                //interfaces
                else if (code[0] == 'i')
                {
                    if (code[1] == 'c')
                    {
                        if (code[2] == 'b') CS01.TaskB();
                        else if (code[2] == 'c') CS01.TaskC();
                        else if (code[2] == 'd') CS01.TaskD();
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
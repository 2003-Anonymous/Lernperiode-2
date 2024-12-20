using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    
        
    public class Zylinder
    {
        private static readonly object fileLock = new object(); // Lock-Objekt

        public void ZylinderOperation()
        {
            double value1 = 0;
            double value2 = 0;
            string enterResult;
            double result = 0;
            bool resultentering = false;
            string path = @"C:\Users\joshu\source\repos\LA_Lernperiode-2\Taschenrechner\Number_Save.txt";

            do
            {
                Console.WriteLine("Welchen Wert willst du errechnen? [r,d,v,h,A,U,Vk,b,As]");
               
                enterResult = Console.ReadLine();

                Console.Clear();

                switch (enterResult)
                {
                    case "r":
                        ResultR(value1, value2, result);
                        break;
                    case "d":
                        Console.Write($"r = ");
                        value1 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round(value1 * 2, 2);
                        Console.WriteLine($"d = {result}");
                        break;
                    case "v":
                        Console.Write($"h = ");
                        value1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write($"r = ");
                        value2 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round((Math.PI * Math.Pow(value1, 2)) * value2, 2);
                        Console.WriteLine($"v = {result}");

                        break;
                    case "h":
                        Console.Write($"v = ");
                        value1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write($"r = ");
                        value2 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round(value1 / (Math.PI * Math.Pow(value2, 2)), 2);
                        Console.WriteLine($"h = {result}");
                        break;
                    case "A":
                        Console.Write($"r = ");
                        value1 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round(Math.PI * Math.Pow(value1, 2), 2);
                        Console.WriteLine($"A = {result}");
                        break;
                    case "U":
                        Console.Write($"r = ");
                        value1 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round(2 * Math.PI * value1, 2);
                        Console.WriteLine($"A = {result}");
                        break;
                    case "Vk":
                        Console.Write($"r = ");
                        value1 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round((4 / 3) * Math.PI * Math.Pow(value1, 3), 2);
                        Console.WriteLine($"VK = {result}");
                        break;
                    case "b":
                        Console.Write($"r = ");
                        value1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Winkel = ");
                        value2 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round(2 * Math.PI * value1 * (value2 / 360), 2);
                        Console.WriteLine($"b = {result}");
                        break;
                    case "As":
                        Console.Write($"r = ");
                        value1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Winkel = ");
                        value2 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round(Math.PI * Math.Pow(value1, 2) * (value2 / 360), 2);
                        Console.WriteLine($"A = {result}");
                        break;
                    default:
                        Console.WriteLine("Ungültige Eigabe!");
                        resultentering = true;
                        break;
                }
            } while (resultentering);

            Console.WriteLine("Willst du das Resultat speichern?[y/n] ");
            if (Console.ReadLine() == "y")
            {
                File.WriteAllText(path, result.ToString());
            }
            Console.Clear();


            static void ResultR(double wert1, double wert2, double result)
            {
                bool enterR = false;
                do
                {
                    string eingabeR;

                    Console.WriteLine("Aus welcher Variable willst du r berrechnen?");
                    eingabeR = Console.ReadLine();

                    switch (eingabeR)
                    {
                        case "d":
                            Console.Write("d = ");
                            wert1 = Convert.ToDouble(Console.ReadLine());

                            result = Math.Round(wert1 / 2, 2);
                            Console.WriteLine($"r = {result}");
                            break;
                        case "v":
                            Console.Write($"h = ");
                            wert1 = Convert.ToDouble(Console.ReadLine());

                            Console.Write($"v = ");
                            wert2 = Convert.ToDouble(Console.ReadLine());

                            result = Math.Round(Math.Sqrt(wert2 / wert1 * Math.PI), 2);
                            Console.WriteLine($"r = {result}");
                            break;
                        case "h":
                            Console.Write($"h = ");
                            wert1 = Convert.ToDouble(Console.ReadLine());

                            Console.Write($"v = ");
                            wert2 = Convert.ToDouble(Console.ReadLine());

                            result = Math.Round(Math.Sqrt(wert2 / (wert1 * Math.PI)), 2);
                            Console.WriteLine($"r = {result}");
                            break;
                        case "A":
                            Console.Write($"A = ");
                            wert1 = Convert.ToDouble(Console.ReadLine());

                            result = Math.Round(Math.Sqrt(wert1 / Math.PI), 2);
                            Console.WriteLine($"r = {result}");
                            break;
                        case "U":
                            Console.Write($"U = ");
                            wert1 = Convert.ToDouble(Console.ReadLine());

                            result = Math.Round(Math.Sqrt(wert1 / (2 * Math.PI)), 2);
                            Console.WriteLine($"r = {result}");
                            break;
                        case "VK":
                            Console.Write($"VK = ");
                            wert1 = Convert.ToDouble(Console.ReadLine());

                            result = Math.Round(Math.Pow((3 * wert1) / 4 * Math.PI, 1 / 3), 2);
                            Console.WriteLine($"r = {result}");
                            break;
                        case "b":
                            Console.Write($"b = ");
                            wert1 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Winkel = ");
                            wert2 = Convert.ToDouble(Console.ReadLine());

                            result = Math.Round(wert1 / (wert2 / 360) / (2 * Math.PI), 2);
                            Console.WriteLine($"r = {result}");
                            break;
                        case "AS":
                            Console.Write($"As = ");
                            wert1 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Winkel = ");
                            wert2 = Convert.ToDouble(Console.ReadLine());

                            result = Math.Round(Math.Sqrt(wert1 / (wert2 / 360) / Math.PI), 2);
                            Console.WriteLine($"r = {result}");
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe!");
                            enterR = true;
                            break;
                    }
                } while (enterR);
            }
        }
    }
}



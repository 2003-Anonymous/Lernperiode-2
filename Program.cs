using System;
using System.ComponentModel.Design;
using System.IO;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        private static readonly object fileLock = new object(); // Lock-Objekt

        static void Main(string[] args)
        {
            double wert1 = 0;
            double wert2 = 0;            
            string eingabeResult;
            double result = 0;
            bool enterResult = false;          

            do
            {
                Console.WriteLine("Welchen Wert willst du errechnen? ");
                eingabeResult = Console.ReadLine();

                switch (eingabeResult)
                {
                    case "r":
                        ResultR(wert1, wert2, result);
                        break;
                    case "d":
                        Console.Write($"r = ");
                        wert1 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round(wert1 * 2, 2);
                        Console.WriteLine($"d = {result}");
                        break;
                    case "v":
                        Console.Write($"h = ");
                        wert1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write($"r = ");
                        wert2 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round((Math.PI * Math.Pow(wert1, 2)) * wert2, 2);
                        Console.WriteLine($"v = {result}");

                        break;
                    case "h":
                        Console.Write($"v = ");
                        wert1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write($"r = ");
                        wert2 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round(wert1 / (Math.PI * Math.Pow(wert2, 2)), 2);
                        Console.WriteLine($"h = {result}");
                        break;
                    case "A":
                        Console.Write($"r = ");
                        wert1 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round(Math.PI * Math.Pow(wert1, 2), 2);
                        Console.WriteLine($"A = {result}");
                        break;
                    case "U":
                        Console.Write($"r = ");
                        wert1 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round(2 * Math.PI * wert1, 2);
                        Console.WriteLine($"A = {result}");
                        break;
                    case "VK":
                        Console.Write($"r = ");
                        wert1 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round((4/3) * Math.PI * Math.Pow(wert1,3), 2);
                        Console.WriteLine($"VK = {result}");
                        break;
                    case "b":
                        Console.Write($"r = ");
                        wert1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Winkel = ");
                        wert2 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round(2*Math.PI*wert1*(wert2/360), 2);
                        Console.WriteLine($"b = {result}");
                        break;
                    case "As":
                        Console.Write($"r = ");
                        wert1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Winkel = ");
                        wert2 = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round(Math.PI* Math.Pow(wert1,2)*(wert2/360), 2);
                        Console.WriteLine($"A = {result}");
                        break;
                    default:
                        Console.WriteLine("Ungültige Eigabe!");
                        enterResult = true;
                        break;
                }
            } while (enterResult);
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

                            result = Math.Round(Math.Pow((3 * wert1)/4 * Math.PI,1/3), 2);
                            Console.WriteLine($"r = {result}");
                            break;
                        case "b":
                            Console.Write($"b = ");
                            wert1 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Winkel = ");
                            wert2 = Convert.ToDouble(Console.ReadLine());

                            result = Math.Round(wert1 / (wert2/360) / (2*Math.PI), 2);
                            Console.WriteLine($"r = {result}");
                            break;
                        case "AS":
                            Console.Write($"As = ");
                            wert1 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Winkel = ");
                            wert2 = Convert.ToDouble(Console.ReadLine());

                            result = Math.Round(Math.Sqrt(wert1 /(wert2/360) / Math.PI), 2);
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
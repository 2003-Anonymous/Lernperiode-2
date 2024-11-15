using System.Data;
using System.IO;

namespace Taschenrechner
{
    internal class Taschenrechner
    {
        static void Main(string[] args)
        {
            double zahl1;
            double zahl2;
            double result = 0;
            double x2 = 0;
            string op;
            bool calculate = true;        

            Console.WriteLine("Taschenrechner");

            while (calculate)
            {
                 bool middle = true;

                try
                {
                    Console.Write("Gib eine Zahl ein: ");
                    zahl1 = Convert.ToDouble(Console.ReadLine());
                    
                    while (middle)
                    {

                        Console.Write("Gib den Operator ein: ");
                        op = Console.ReadLine();

                        string[] opArray = { "+", "-", "*", "/", "p", "w", "Pi" };

                        while (true)
                        {
                            if (!opArray.Contains(op))
                            {
                                Console.WriteLine("Fehlerhafte Eingabe");
                            }
                            break;
                        }

                        if(op == "Grössen")
                        {

                        }

                        Console.Write("Gib eine zweite Zahlt ein: ");
                        zahl2 = Convert.ToDouble(Console.ReadLine());
                        
                        
                        if(zahl1 == 7)
                        {
                            double[] nightresult;

                            nightresult = mitternachtsFormel(result, x2);
                            Console.WriteLine($"x1 = {nightresult[0]}");
                            Console.WriteLine($"x2 = {nightresult[1]}");
                            
                        }else if(op == "Pi")
                        {
                            result = annäherungPi(zahl1);
                            Console.WriteLine(result);
                        }
                        else
                        {
                            result = berechneOperation(zahl1, zahl2, op);
                            Console.WriteLine(result);
                        }
                        bool conCalc;
                        do
                        {
                            Console.Write("Mit Ergebnis weiterrechnen? [y/n]: ");
                            string antwort = Console.ReadLine();

                            if (antwort == "y")
                            {
                                middle = true;
                                conCalc = false;
                                zahl1 = result;
                            }
                            else if (antwort == "n")
                            {
                                conCalc = false;
                                middle = false;
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe");
                                conCalc = true;
                            }
                        }
                        while (conCalc);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fehlerhafte Eingabe!");
                    Console.WriteLine(ex.ToString());
                }
            }
        }


        static double berechneOperation(double zahl1, double zahl2, string op)
        {
            double result = 0;

            if (op == "+")
            {
                result = zahl1 + zahl2;

                return result;
            }
            else if (op == "-")
            {
                result = zahl1 - zahl2;

                return result;
            }
            else if (op == "*")
            {
                result = zahl1 * zahl2;

                return result;
            }
            else if (op == "/")
            {
                result = zahl1 / zahl2;

                return result;
            }
            else if (op == "p")
            {
                result = (long)Math.Pow(zahl1, zahl2);

                return result;
            }
            else if (op == "w")
            {
                result = Math.Pow(zahl2, 1/zahl1);
                return result;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");

                return 0;
            }
        }
        static double[] mitternachtsFormel(double x1, double x2)
        {
            double a = 0;
            double b = 0;
            double c = 0;


            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());

            x1 = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

            x2 = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

            double[] resultArray = { x1, x2 };

            //showArray(resultArray);

            return resultArray;
        }

        static void showArray(double[] resultArray)
        {
            for(int i = 0; i < resultArray.Length; i++)
            {
                Console.WriteLine($"X{i} = {resultArray[i]}");                
            }
        }
        static double annäherungPi(double resultPi)
        {
            int vorzeichen = 1;
            double Pi = 0;
            int k = 0;
            string path = @"C:\Users\joshu\source\repos\LA_Lernperiode-2\Test\Zahl_PI.txt";
            bool stopPi = false;

            Task.Run(() =>
            {
                Console.ReadLine();
                stopPi = true;
            });


            while (true)
            {
                Pi += vorzeichen * (1.0 / (2 * k + 1)) * 4;
                vorzeichen *= -1;
                k++;

                if (stopPi)
                {
                    Console.WriteLine("Programm angehalten.");
                    break;
                }

                Console.WriteLine(Pi);

                bool writing = false;
                int count = 0;


                while (!writing && count < 5)
                {
                    try
                    {
                        File.WriteAllText(path, Pi.ToString());
                        writing = true;
                    }
                    catch (IOException)
                    {
                        count++;
                        Thread.Sleep(100);
                    }
                }
            }
            resultPi = Pi;
            return resultPi;

        
        }
    }
}



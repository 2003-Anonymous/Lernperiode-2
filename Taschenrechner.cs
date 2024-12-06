using System.Data;
using System.IO;
using System.Reflection;

namespace Taschenrechner
{
    internal class Taschenrechner
    {
        static void Main(string[] args)
        {
            double zahl1 = 0;
            double zahl2 = 0;
            double result = 0;
            double x2 = 0;
            string op = "";
            bool calculate = true;
            

            while (calculate)
            {
                

                Console.Write("Wie willst du rechnen? \n(Taschenrechner[T], Grössen[G], Pi[P], Mitternachtsformel[M]: ");
                string firstDecision = Console.ReadLine();

                Console.Clear();

                if(firstDecision == "T")
                {
                    result = Calculator(zahl1, zahl2, result, op);
                }
                else if(firstDecision == "G")
                {
                    Zylinder zylinderresult = new Zylinder();
                    zylinderresult.ZylinderOperation();
                }
                else if(firstDecision == "P")
                {
                    result = AnnäherungPi(zahl1);
                    Console.WriteLine(result);
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                    }
                }
                else if(firstDecision == "M")
                {
                    double[] nightresult;

                    nightresult = MitternachtsFormel(result, x2);
                    Console.WriteLine($"x1 = {nightresult[0]}");
                    Console.WriteLine($"x2 = {nightresult[1]}");
                }
            }
        }


        static double BerechneOperation(double zahl1, double zahl2, string op)
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
        static double[] MitternachtsFormel(double x1, double x2)
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

        
        static double AnnäherungPi(double resultPi)
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

        static double Calculator(double zahl1, double zahl2, double result, string op)
        {
            string[] numberSaves;

            string path = @"C:\Users\joshu\source\repos\LA_Lernperiode-2\Taschenrechner\Number_Save.txt";
            while (true)
            {
                bool middle = true;
                try
                {
                    Console.Write("Gib eine Zahl ein: ");



                    if (Console.ReadKey(intercept: true).Key == ConsoleKey.S)
                    {
                        numberSaves = File.ReadAllLines(path);

                        Console.Clear();

                        for (int i = 0; i < numberSaves.Length; i++)
                        {                            
                            Console.WriteLine($"{i+1}: {numberSaves[i]}");
                        }
                        // Funktion für Speicheraufruf


                        //zahl1 = Convert.ToDouble(File.ReadAllText(path));
                        //Console.WriteLine(zahl1);
                    }
                    else
                    {
                        zahl1 = Convert.ToDouble(Console.ReadLine());
                    }

                    while (middle)
                    {
                        while (true)
                        {
                            Console.Write("Gib den Operator ein: ");
                            op = Console.ReadLine();

                            string[] opArray = { "+", "-", "*", "/", "p", "w" };

                            if (!opArray.Contains(op))
                            {
                                Console.WriteLine("Fehlerhafte Eingabe");
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.Write("Gib eine zweite Zahlt ein: ");
                        
                        if(Console.ReadKey(intercept: true).Key == ConsoleKey.S)
                        {
                            zahl2 = Convert.ToDouble(File.ReadAllText (path));
                            Console.WriteLine (zahl2);
                        }
                        else
                        {
                            zahl2 = Convert.ToDouble(Console.ReadLine());
                        }

                        result = BerechneOperation(zahl1, zahl2, op);
                        Console.WriteLine(result);

                        bool conCalc = true;
                        do
                        {
                            Console.Write("Mit Ergebnis weiterrechnen? [y/n/s/nn]: ");
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
                                Console.Clear();
                            }
                            else if (antwort == "nn")
                            {
                                Console.Clear ();
                                return result;
                            }
                            else if (antwort == "s")
                            {
                                File.WriteAllText(path, result.ToString());
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
        static void SavedNumbers()
        {

        }
    }
}



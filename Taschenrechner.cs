using System.Data;
using System.IO;
using System.Reflection;

namespace Taschenrechner
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            double number1 = 0;
            double number2 = 0;
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
                    result = CalculatorFunction(number1, number2, result, op);
                }
                else if(firstDecision == "G")
                {
                    Zylinder zylinderresult = new Zylinder();
                    zylinderresult.ZylinderOperation();
                }
                else if(firstDecision == "P")
                {
                    result = ApproachPi(number1);
                    Console.WriteLine(result);
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                    }
                }
                else if(firstDecision == "M")
                {
                    double[] nightresult;

                    nightresult = MidnightFormula(result, x2);
                    Console.WriteLine($"x1 = {nightresult[0]}");
                    Console.WriteLine($"x2 = {nightresult[1]}");
                }
            }
        }


        static double CalculateOperation(double number1, double number2, string op)
        {
            double result = 0;

            if (op == "+")
            {
                result = number1 + number2;

                return result;
            }
            else if (op == "-")
            {
                result = number1 - number2;

                return result;
            }
            else if (op == "*")
            {
                result = number1 * number2;

                return result;
            }
            else if (op == "/")
            {
                result = number1 / number2;

                return result;
            }
            else if (op == "p")
            {
                result = (long)Math.Pow(number1, number2);

                return result;
            }
            else if (op == "w")
            {
                result = Math.Pow(number2, 1/number1);
                return result;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");

                return 0;
            }
        }
        static double[] MidnightFormula(double x1, double x2)
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

            

            return resultArray;
        }

        
        static double ApproachPi(double resultPi)
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

        static double CalculatorFunction(double number1, double number2, double result, string op)
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

                        int[] selectedIndex = SavedNumbers(numberSaves, path);
                        Console.Clear();
                        number1 = Convert.ToInt32(numberSaves[selectedIndex[0]]);
                        Console.WriteLine(number1);
                        
                    }                
                    else
                    {
                        number1 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.Clear();
                    Console.WriteLine(number1);
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
                        Console.Clear();
                        Console.WriteLine(number1);
                        Console.WriteLine(op);
                        Console.Write("Gib eine zweite Zahlt ein: ");
                        
                        if(Console.ReadKey(intercept: true).Key == ConsoleKey.S)
                        {
                            numberSaves = File.ReadAllLines(path);

                            int[] selectedIndex = SavedNumbers(numberSaves, path);
                            Console.Clear();
                            number2 = Convert.ToInt32(numberSaves[selectedIndex[0]]);
                            Console.WriteLine(number2);
                        }
                        else
                        {
                            number2 = Convert.ToDouble(Console.ReadLine());
                        }

                        result = CalculateOperation(number1, number2, op);
                        Console.Clear();
                        Console.WriteLine(number1);
                        Console.WriteLine(op);
                        Console.WriteLine(number2);
                        Console.WriteLine("-----------");
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
                                number1 = result;
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
                                numberSaves = File.ReadAllLines(path);

                                
                                int selectedIndex = 0;

                                
                                while (true)
                                {
                                    Console.Clear();

                                    
                                    for (int i = 0; i < numberSaves.Length; i++)
                                    {
                                        if (i == selectedIndex)
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkGray;
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine(numberSaves[i]);
                                            Console.ResetColor();
                                        }
                                        else
                                        {
                                            Console.WriteLine(numberSaves[i]);
                                        }
                                    }

                                    

                                    
                                    var key = Console.ReadKey(true).Key;

                                    if (key == ConsoleKey.UpArrow)
                                    {
                                        selectedIndex = (selectedIndex == 0) ? numberSaves.Length - 1 : selectedIndex - 1;
                                    }
                                    else if (key == ConsoleKey.DownArrow)
                                    {
                                        selectedIndex = (selectedIndex == numberSaves.Length - 1) ? 0 : selectedIndex + 1;
                                    }
                                    else if (key == ConsoleKey.Enter)
                                    {
                                        
                                        numberSaves[selectedIndex] = result.ToString();
                                        File.WriteAllLines(path, numberSaves);                                        
                                        Console.ReadKey();
                                        break;
                                    }                                    
                                }
                            
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
        static int[] SavedNumbers(string[] numberSaves, string path)
        {
            int[] numberSavesPos = new int[2];
            

            Console.Clear();

           
            int selectedIndex = 0;

            
            while (true)
            {
                Console.Clear(); 

                
                for (int i = 0; i < numberSaves.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(numberSaves[i]);
                        Console.ResetColor(); 
                    }
                    else
                    {
                        Console.WriteLine(numberSaves[i]);
                    }
                }

                
                var key = Console.ReadKey(true).Key;

                
                if (key == ConsoleKey.UpArrow)
                {
                    
                    selectedIndex = (selectedIndex == 0) ? numberSaves.Length - 1 : selectedIndex - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    
                    selectedIndex = (selectedIndex == numberSaves.Length - 1) ? 0 : selectedIndex + 1;
                }
                else if (key == ConsoleKey.Enter)
                {
                    
                    numberSavesPos[0] = selectedIndex;
                    return numberSavesPos;
                }
            }
        }
    }
}



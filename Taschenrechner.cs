using System.Data;

namespace Taschenrechner
{
    internal class Taschenrechner
    {
        static void Main(string[] args)
        {
            double zahl1;
            double zahl2;
            double result = 0;
            double result2 = 0;
            string op = "";
            bool end = true;
            bool y = true;
            bool a = true;
            bool wiederholen = true;

            Console.WriteLine("Taschenrechner");

            while (end)
            {
                y = true;

                try
                {
                    Console.Write("Gib eine Zahl ein: ");
                    zahl1 = Convert.ToDouble(Console.ReadLine());

                    while (y)
                    {

                        Console.Write("Gib den Operator ein: ");
                        op = Console.ReadLine();

                        Console.Write("Gib eine zweite Zahlt ein: ");
                        zahl2 = Convert.ToDouble(Console.ReadLine());

                        
                        if(zahl1 == 7)
                        {
                            mitternachtsFormel(result, result2);                            
                        }
                        else
                        {
                            result = berechneOperation(zahl1, zahl2, result, result2, op);
                            Console.WriteLine(result);
                        }

                        do
                        {
                            Console.Write("Mit Ergebnis weiterrechnen? [y/n]: ");
                            string antwort = Console.ReadLine();

                            if (antwort == "y")
                            {
                                y = true;
                                a = false;
                                zahl1 = result;
                            }
                            else if (antwort == "n")
                            {
                                a = false;
                                y = false;
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe");
                                a = true;
                            }
                        }
                        while (a);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fehlerhafte Eingabe!");
                    Console.WriteLine(ex.ToString());
                }
            }
        }


        static double berechneOperation(double zahl1, double zahl2, double result, double result2, string op)
        {

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
        static void mitternachtsFormel(double result, double result2)
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

            result = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

            result2 = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

            double[] resultArray = { result, result2 };

            showArray(resultArray);
        }

        static void showArray(double[] resultArray)
        {
            for(int i = 0; i < resultArray.Length; i++)
            {
                Console.WriteLine($"X{i} = {resultArray[i]}");                
            }
        }
    }
}



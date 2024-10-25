namespace Taschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rechnen = 1;
            double zahl1;
            double zahl2;
            double zahl3;
            double result = 0;
            string op;
            bool end = true;
            bool y = true;

            Console.WriteLine("Taschenrechner");

            while (end)
            {
                y = true;

                Console.Write("Gib eine Zahl ein: ");
                zahl1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Gib den Operator ein: ");
                op = Console.ReadLine();

                Console.Write("Gib eine zweite Zahlt ein: ");
                zahl2 = Convert.ToDouble(Console.ReadLine());

                switch (rechnen)
                {
                    case 1:
                        double solution = berechneOperation(zahl1, zahl2, result, op);

                        Console.WriteLine($"Resultat: {solution}");
                        break;
                    case 2:
                        //double solution1 = weiterrechnen(zahl1, zahl2, result, op);

                        Console.WriteLine($"Resultat: {solution1}");
                        break;

                }



                /*while (y)
                {
                    Console.Write("Mit Ergebnis weiterrechnen [y/n]");
                    string antwort = Console.ReadLine();

                    if (antwort == "y")
                    {                       
                        y = false;
                        rechnen = 2;
                    }
                    else if (antwort == "n")
                    {                      
                        rechnen = 1;
                        y = false;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe");
                    }
                }*/

            }

            //Console.WriteLine($"Ergebnis = {result}");

        }

        /*static double weiterrechnen(double zahl1, double zahl2, double result, string op)
        {

            if (op == "+")
            {
                result = result + zahl2;

                return result;
            }
            else if (op == "-")
            {
                result = result - zahl2;

                return result;
            }
            else if (op == "*")
            {
                result = result * zahl2;

                return result;
            }
            else //if (op == "/")
            {
                result = result / zahl2;

                return result;
            }
        }*/

        static double berechneOperation(double zahl1, double zahl2, double result, string op)
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
            else //if (op == "/")
            {
                result = zahl1 / zahl2;

                return result;
            }





        }


    }
}



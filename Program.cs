using System;
using System.IO;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        private static readonly object fileLock = new object(); // Lock-Objekt

        static void Main(string[] args)
        {
            int r;
            int d;
            int v;
            int h;
            int u;
            int f;
            int o;

            double wert1 = 0;
            double wert2 = 0;
            double wert3 = 0;
            string eingabe1;
            string eingabe2;
            string eingabeResult;
            int result;


            Console.WriteLine("Welchen Wert willst du errechnen? ");
            eingabeResult = Console.ReadLine();            

            switch (eingabeResult)
            {
                case "r":
                    
                    break;
                case "d":

                    break;
                case "v":
                    Console.WriteLine("Erforderlicher Wert: h\nMögliche Werte: U,d,r,A");
                    Console.Write("Mit welchem Wert willst du rechnen?: ");
                    eingabe1 = Console.ReadLine();
                    eingabe2 = "h";

                    Wert1(eingabe1,eingabe2,wert1,wert2);

                    break;
                case "h":

                    break;
                case "A":

                    break;
                case "U":

                    break;
            }

        
        }
        static void Wert1(string eingabe1, string eingabe2, double wert1, double wert2 )
        {
            switch (eingabe1)
            {
                case "r":
                    Console.Write("r = ");
                    wert1 = Convert.ToInt32(Console.ReadLine());
                    break;
                case "d":

                    break;
                case "v":

                    break;
                case "h":

                    break;
                case "U":

                    break;
                case "A":

                    break;
               

            }            
        }
        static double Result(int result, int wert1, int wert2)
        {
            Console.Write($"{wert1} = ");
            wert1 = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{wert2} = ");
            wert2 = Convert.ToInt32(Console.ReadLine());

            switch (result)
            {
                case 'r':

                    break;
                case 'd':

                    break;
                case 'v':

                    break;
                case 'h':

                    break;
                case 'U':

                    break;
                case 'A':

                    break;
                

            }
            return result;
        }
        static void Wert2(int wert1, string eingabe2)
        {
            switch (wert1)
            {
                case 'r':

                    break;
                case 'd':

                    break;
                case 'v':

                    break;
                case 'h':

                    break;
                case 'U':

                    break;
                case 'A':

                    break;


            }
        }
    }
}




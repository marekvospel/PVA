using System;
using System.Linq;

namespace PVA.Lessons {

    public class Hodina5 {

        // Metoda na spusteni
        public static void Start() {

            /*
             * Tema hodiny: Metody
             */
            
            /*
             * Nasledujici veci jsou metody
             * 
             * Console.ReadLine();
             * Console.WriteLine();
             * Console.Write();
             * int.Parse(string);
             * double.TryParse(string, out double);
             * 
             */

            // Vlastni metoda - viz nize
            Kalkulacka();

            // Metoda muze mit argumenty
            Pozdrav("Marek");
            // Metoda muze mit i vice argumentu
            Pozdrav("Marek", 15);

            /*
             * ^ nemuzeme mit 2 metody se stejnymi argumenty
             * static void Pozdrav(string)... a static void Pozdrav(string)... nebude fungovat, ale
             * static void Pozdrav(string, int)... a static void Pozdrav(string)... bude
             * static void Pozdrav(string, int)... a v static oid Pozdrav(string, double)... bude take fungovat
             */

            /*
             * Metody mohou vracet i nejake data
             */
            string pi = GetPi();
            Console.WriteLine("Hodnota pi je {0}.",pi);
        }

        /*
         * Vytvoreni metody ktera vraci text Pi ("3.14")
         * Da se take napsat jako
         * private static string GetPi() => "3.14";
        */
        private static string GetPi() {
            return "3.14";
        }

        /*
         * Vlastni metoda - kod uvnitr
         * Kalkulacka
         */
        private static void Kalkulacka() {
            char[] operators = { '+', '-', '*', '/'};
            double first;
            double second;
            char op;

            while (true) {
                Console.Write("Number 1:");
                if (double.TryParse(Console.ReadLine(), out first)) break;
            }
            
            while (true) {
                Console.Write("Enter operator:");
                string input = Console.ReadLine();
                if (input == null) continue;
                op = input.ToCharArray()[0];
                if (operators.Contains(op)) break;
            }
            
            while (true) {
                Console.Write("Number 2:");
                if (double.TryParse(Console.ReadLine(), out second)) break;
            }
            
            if (op.Equals('+')) Console.WriteLine("The result is {0}", first + second);
            if (op.Equals('-')) Console.WriteLine("The result is {0}", first - second);
            if (op.Equals('*')) Console.WriteLine("The result is {0}", first * second);
            if (op.Equals('/')) Console.WriteLine("The result is {0}", first / second);
        }

        /*
         * Definovani metody s argumentem jmeno - string
         * string jmeno se pote muze pouzivat kdekoliv uvnitr metody Pozdrav
         */
        private static void Pozdrav(string jmeno) {
            Console.WriteLine("Ahoj {0}, jak je?", jmeno);
            Console.WriteLine("Tvoje jmeno je {0} znaku dlouhe", jmeno.Length);
        }

        /*
         * Definovani metody s vice argumenty jmeno - string a vek - int
         * string jmeno a int vek se pote muze pouzivat kdekoliv uvnitr metody Pozdrav
         */
        private static void Pozdrav(string jmeno, int vek) {
            Console.WriteLine("Ahoj {0}, jak je?", jmeno);
            Console.WriteLine("Je ti {0} let!", vek);
            Console.WriteLine("Tvoje jmeno je {0} znaku dlouhe", jmeno.Length);
        }

    }
}
using System;
using System.Collections.Generic;

namespace PVA.Lessons {
    public class Hodina8 {

        public static void Start() {
            
            /*
             * Odebrani duplicitnich znaku v char[]
             */
            
            // vytvoreni arraye
            char[] arr = {'a', 'b', 'c', 'c', 'a', 'b'};
            // spusteni metody a ulozeni newArr
            char[] newArr = Deduplicate(arr);

            // Vypsani vsech znaku v newArr
            foreach (char c in newArr) Console.WriteLine(c);
            
            // napsano jednodusseji (vytvoreni stringu a prevedeni na char array a pote vypsani arraye - funguje jen s char[] nebo string[])
            Console.WriteLine(Deduplicate("abccab".ToCharArray()));
            
            
        }

        /*
         * Metoda na odebrani duplicitnich znaku v char[]
         */
        static char[] Deduplicate(char[] input) {
            // vytvoreni listu - jelikoz list nema definovanou delku
            List<char> output = new List<char>();
            // projeti celeho inputu
            foreach (char c in input) {
                // Pokud output neobsahuje znak c
                if (!output.Contains(c)) {
                    // pridat znak do outputu
                    output.Add(c);
                }
            }
            // Prevedeni listu na char[]
            return output.ToArray();
        }
        
    }
}
using System;
using System.Linq;

namespace PVA.Lessons {
    
    public class Hodina9 {

        public static void Start() {
            
            // Random class
            
            /* Vytvoeeni objektu random */
            Random random = new Random();
            
            // Nahodne cislo v +
            int random1 = random.Next();
            
            // Nahodne cislo v + do 10000
            int random2 = random.Next(10000);
            
            // Nahodne cislo mezi 5 a 20
            int random3 = random.Next(5, 20);
            
            // Nahodne cislo mezi 0 a 1
            double random4 = random.NextDouble();
            
            // Vypsani vygenerovanych cisel
            Console.WriteLine(random1);
            Console.WriteLine(random2);
            Console.WriteLine(random3);
            Console.WriteLine(random4);
            
            // Spusteni metody RandomArr
            int[] arr = RandomArr(10, 11);
            
            // Vypsani vysledku metody
            foreach (int i in arr) {
                Console.WriteLine(i);
            }
        }

        static int[] RandomArr(int length, int maxNumber) {
            // Pokud je delka vetsi nez maximalni cislo (ochrana proti zacykleni)
            if (maxNumber <= length) return null;

            // Vytvoreni objektu random
            Random random = new Random();
            
            // Vytvoreni vystupniho pole
            int[] arr = new int[length];
            
            // plneni pole
            for (int i = 0; i < arr.Length; i++) {
                // vygenerovani nahodneho cisla po dobu co je v arr
                int next = random.Next(maxNumber);
                while (arr.Contains(next)) {
                    next = random.Next(maxNumber);
                }
                arr[i] = next;
            }

            // vraceni pole
            return arr;
        }
        
    }
    
}
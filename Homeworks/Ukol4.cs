using System;
using System.Linq;

namespace PVA.Homeworks {
    
    public class Ukol4 {

        public static void Start() {

            // Spusteni funkce random arr
            int[] random = RandomArr(10, 200);

            // vypsani vysledku
            foreach (int i in random) {
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
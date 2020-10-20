using System;

namespace PVA.Lessons {
    
    public class Hodina2 {

        public static void Start() {
            
            /*
             * Tema hodiny: Cykly
             *
             * cyklus = loop
             */

            /*
             * Cyklus #1 do, while
             * v tomto pripade pouzito na ziskani cisla od uzivatele
             */

            double num;
            
            // vsechen kod uvnitr nasledujicich zavorkach {} a pote () spusti - v napsanem poradi
            do {
                Console.WriteLine("Zadejte cislo...");
            } while (!double.TryParse(Console.ReadLine(), out num));
            // uvnitr () je podminka za ktere se ma tento cyklus opakovat
            // po dobu co to bude true tak se vse bude opakovat
            // pouzitim while (true); se kod bude opakovat do nekonecna (o tom vice pozdeji)
            // double.TryParse vraci false ale pokud zadana hodnote (Console.ReadLine()) je double vrati to true 
            
            double num2;
            
            // While funguje stejne jen vypada trochu jinak
            // !POZOR nejdrive se spusti kod uvnitr a pak az se kontroluje podminka
            while (!double.TryParse(Console.ReadLine(), out num2)) {
                Console.WriteLine("Zadejte cislo...");
            }

            /*
             * Cyklus #2 for
             */

            // Cyklus for funguje podobne jako do, while - je potreba aby byla splnena podminka
            // Uvnitr zavorek se nejdrive pise definovani hodnoty (int i = 0); pote podminka (i < 10); a pote co se ma stat po dokonceni kodu v {} (i++)
            // V tomto pripade se kod zopakuje 10x a vypise 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 kazde na jiny radek
            for (int i = 0; i < 10; i++) {
                // Uvnitr for cyklu muzeme pouzivat hodnotu i (popr jinak pojmenovanou)
                Console.WriteLine(i);
            }
            
        }
        
    }
    
}
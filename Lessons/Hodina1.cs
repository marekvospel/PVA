using System;

namespace PVA.Lessons {
    
    public class Hodina1 {

        public static void Start() {
            
            /*
             * Tema hodiny: Uvod, Promene, Podminky
             */
            
            /*
             * Vypsani hodnoty do konzole
             */
            
            // Vypsat hodnotu muzeme pomoci Console.WriteLine(string)
            Console.WriteLine("Text ktery se zobrazi v konzoli.");
            
            /*
             * Promene 
             */
            
            // Deklarace
            // Deklarovanim promene rekneme programu ze budeme pouzivat promenou
            // To se dela tak ze napiseme typ promene (napr. int, double, float, char, string, bool)
            int cislo;
            // typy promenych int, double, float jsou cisla
            // char je znak (treba pismeno) a string je rada znaku
            // bool muze byt pravda nebo lez (true/false)
            
            // Definice
            // Definici nastavime hodnotu drive deklarovane promene
            cislo = 1;
            
            // Samozrejme muzeme deklarovat a definovat najednou
            int druhecislo = 5;

            // Priklad definice a definovani jinych typu promenych
            char znak;
            znak = 'a';
            bool pravda = true;
            bool lez = false;
            string text;
            text = "abcd";
            double desetinecislo = 0.5;

            /*
             * Vyuziti promenych
             */
            
            // Promene muzeme pouzivat napriklad uvnitr zavorky v Console.WriteLine(<promena>); abychom vypsali jeji hodnotu
            Console.WriteLine(text);
            Console.WriteLine(pravda);
            Console.WriteLine(lez);
            Console.WriteLine(znak);
            Console.WriteLine(cislo);
            Console.WriteLine(druhecislo);
            Console.WriteLine(desetinecislo);
            
            /*
             * Podminky
             */
            
            // Pokud chceme aby se neco stalo pouze za nejake podminky muzeme pouzit if
            // pokud podminka v () je pravda (true) tak se spusti kod uvnitr slozenych zavorek {}
            if (true) {
              Console.WriteLine("Podminka 1 je pravda");
            }

            if (false) {
              Console.WriteLine("Podminka 2 je pravda");
            }
            
            // Do podminek muzeme psat i podminky jako treba jestli je cislo mensi nez 5 atd.
            if (cislo < 5) {
              Console.WriteLine("Podminka 3 je pravda");
            }
            
            // Pokud chceme kontrolovat jestli je promena stejna jako jina hodnota pouzijeme ==
            // jedno = nepouzijeme jelikoz tim bychom programu rikali ze definujeme promenou
            if (cislo == 1) {
              Console.WriteLine("Podminka 4 je pravda");
            }
            
            /*
             * Dalsi mozne operatory:
             * <= je mensi nebo se rovna
             * >= je vetsi nebo se rovna
             * < je mensi
             * > je vetsi
             * == rovna se
             * != se nerovna
             */
            
            // Jinak
            // Pokud chceme udelat neco kdyz podminka neni pravda tak pouzijeme else
            
            if (false) {
                Console.WriteLine("Podminka 5 je pravda");
            } else {
                Console.WriteLine("Podminka 5 neni pravda");
            }
            
            // AND a OR
            // Pokud chcete pouzit vice podminek do jednoho radku if muzete pouzit AND a OR
            // AND = &&
            // OR = ||

            // toto se spusti protoze jedna z podminek je pravda
            if (true || false) {
              Console.WriteLine("Podminka 6 je pravda");
            }
            
            // toto se nespusti protoze jen jedna z podminek je pravda
            if (true && false) {
                Console.WriteLine("Podminka 7 je pravda");
            }
            
            // toto se spusti protoze obe podminky jsou pravda
            if (true && true) {
                Console.WriteLine("Podminka 8 je pravda");
            }
            
            /*
             * Switch
             */
            
            // Pokud chceme kontrolovat jestli je promena rovna  specificke hodnote vickrat za sebou
            // muzeme pouzit switch
            
            int i = 0;
            
            // uvnitr () je promena kterou chceme kontrolovat
            switch (i) {
                // pokud je to hodnota v () tak se spusti odsazeny kod az po break;
                case (1):
                    Console.WriteLine("Hodnota je jedna");
                    break;
                // pokud je to hodnota v () tak se spusti odsazeny kod az po break;
                case (0):
                    Console.WriteLine("Hodnota je nula");
                    break;
            }
        }
        
    }
    
}
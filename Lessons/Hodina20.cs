using System;
using System.IO;

namespace PVA.Lessons {

    public class Hodina20 {

        public static void Start() {
            // Prace se soubory
            // je nutne importovat System.IO
            // using System.IO;
            
            // Nize pouzivam ./HodinaX.txt jako lokaci souboru
            // muzete pouzit napr /home/vospel/Desktop/HodinaX.txt pro full control kde soubor ma byt
            // ./Hodina.txt znamena ze to bude v slozce projektu (project/bin/Debug/netcoreapp3.1/HodinaX.txt)

            Console.WriteLine("Zapisovani do souboru...");

            // Zapsani dat do souboru
            // Pole radku co se pridaji
            String[] lines = {"radek1", "radek2"};
            // Vytvoreni StreamWriteru (false = prepsavat vse uvnitr souboru, true = text se bude pouze pridavat)
            StreamWriter sw = new StreamWriter("./HodinaX.txt", false);
            // Pro kazdy radek
            foreach (var line in lines) {
                // Zapsani radku do souboru
                sw.WriteLine(line);
                // Vycisteni pameti
                sw.Flush();
            }

            // Uzavreni Streamu
            sw.Close();

            Console.WriteLine("Cteni souboru...");

            // Vytvoreni StreamReaderu (na cteni)
            StreamReader sr = new StreamReader("./HodinaX.txt");
            string line2;
            // Cist radky dokud nedojdou
            while ((line2 = sr.ReadLine()) != null) {
                // Vypsani do konzole
                Console.WriteLine(line2);
            }
            // Uzavreni streamu
            sr.Close();
            
            Console.WriteLine("Jina metoda cteni souboru...");

            // Pomosi using nemusime uzavirat StreamReader (sr.Close();)
            using (StreamReader sr2 = new StreamReader("./HodinaX.txt")) {
                string line3;
                // Cist radky dokud nedojdou
                while ((line3 = sr2.ReadLine()) != null) {
                    // Vypsani do konzole
                    Console.WriteLine(line3);
                }
            }

        }
    }

}
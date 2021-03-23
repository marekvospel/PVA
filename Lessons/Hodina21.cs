using System;
using System.Collections.Generic;

namespace PVA.Lessons {
    
    public class Hodina21 {

        public static void Start() {

            // Takto vytvorime novy Dictionary
            // string je klic a double hodnota
            // klic je unikadni (v tomto pripade string) ktery ma presne 1 hodnotu (ted double)
            // Dictionary funguje hodne podobne jako matematicke funkce, akorat muze mit vice datovych typu
            // Kdyby slo o Dictionary<double, double> tak by to fungovalo stejne. Kazdy 1 klic ma presne 1 hodnotu.
            Dictionary<string, double> slovnicekUwU = new Dictionary<string, double>();
            
            // Do dictionary pridavame pomoci metody Add
            slovnicekUwU.Add("kocicka", 1337);
            
            // Do dictionary nemuzeme pridat 2 hodnoty se stejnym klicem
            // spousteni slovnicekUwU.Add("kocicka", 1337); znovu vyhodi chybu
            
            // Cteni je stejne jako u listu nebo poli, akorat nepouzivame indexy ale klic
            Console.WriteLine(slovnicekUwU["kocicka"]);
            
            // Muzeme pouzivat funkce jako ContainsKey
            if (slovnicekUwU.ContainsKey("kocicka")) Console.WriteLine("I told u!");
            
            // Prenastavit hodnotu muzeme stejne jako u listu
            slovnicekUwU["kocicka"] = 547706;

            // Cteni ze souboru viz Hodina20.cs

        }
        
    }
}
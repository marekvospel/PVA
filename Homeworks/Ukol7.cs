using System;
using System.Collections.Generic;

namespace PVA.Homeworks {
    
    public class Ukol7 {

        public static void Start() {

            // 1. úkol -vymyslete jak nahradit pasní hustoty do konstruktoru tím, že pokud by jsme zadali nějakou látku vybrala by se nám látka z "databáze" a rovnou k ní se přířadila hustota
            Latky2 _ = new Latky2();
            // 2. úkol -zkuste umožnit na místo zadání hustoty tělesa zadat hmotnost tělesa a došlo by k výpočtu hustoty ((zkusit i tím zařadit k látce kterou budete mít v tabulce látek))
            Krychle2 krychle2 = new Krychle2(true, "voda", Math.Pow(2, 3)); //"1. úkol" na tomhle řádku nebude muset uživatel zadávat hustotu, ale stačí zadat látku 
            Krychle2 krychle1 = new Krychle2(false,997, 8);
            Console.WriteLine(krychle2.Hmotnost);
            Console.WriteLine(krychle1.Hmotnost);
            Console.Read();
        }
    }
    
    class Teleso2 {
        public string Latka { get; set; }
        public double Objem { get; set; }
        public double Hmotnost { get; set; }
        public double Hustota { get; set; }
        
        public Teleso2(bool secondArgObjem, string latka, double objemOrHmotnost) {
            if (secondArgObjem) {
                Latka = latka;
                Hustota = Latky2.GetByLatka(latka);
                Objem = objemOrHmotnost;
                // hustota = hmotnost/ objem
                Hmotnost = Hustota * objemOrHmotnost;
            }
            else {
                
            }
        }
        
        public Teleso2(bool firstArgHmotnost, double hmotnostOrHustota, double objem) {
            if (firstArgHmotnost) {
                Latka = Latky2.GetByHustota(hmotnostOrHustota);
                Hmotnost = hmotnostOrHustota;
                Objem = objem;
                // hustota = hmotnost/ objem
                Hustota = hmotnostOrHustota / objem;
            } else {
                Latka = Latky2.GetByHustota(hmotnostOrHustota);
                Hustota = hmotnostOrHustota;
                Objem = objem;
                // hustota = hmotnost/ objem
                Hmotnost = hmotnostOrHustota * objem;
                
            }
        }
    }
    class Krychle2 : Teleso2  {
        public Krychle2(bool secondArgObjem, string latka, double objemOrHmotnost) : base(secondArgObjem, latka, objemOrHmotnost) {

        }
        public Krychle2(bool firstArgHmotnost, double hmotnostOrHustota, double objem) : base(firstArgHmotnost, hmotnostOrHustota,objem) {

        }
    }

    class Latky2 {
        private static Dictionary<string, double> latky = new Dictionary<string, double>();

        public Latky2() {
            /*
            voda - 997
            asfalt - 1300
            olovo - 11340
            papír - 800
            zlato 19320
            teflon - 2200
            */
            latky.Add("voda", 997);
            latky.Add("asfalt", 1300);
            latky.Add("olovo", 11340);
            latky.Add("papír", 800);
            latky.Add("zlato", 19320);
            latky.Add("teflon", 2200);
        }
        
        public static double GetByLatka(string latka) {
            if (latky.ContainsKey(latka)) {
                return latky[latka];
            }

            return 0;
        }

        public static string GetByHustota(double hustota) {
            if (latky.ContainsValue(hustota)) {
                foreach (var latka in latky) {
                    if (latka.Value == hustota) return latka.Key;
                }
            }

            return "";
        }
        
    }
}
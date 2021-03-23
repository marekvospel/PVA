using System;
using System.Collections.Generic;
using System.IO;

namespace PVA.Homeworks {
    
    public class Ukol8 {

        public static void Start() {

            // 1. úkol -vymyslete jak nahradit pasní hustoty do konstruktoru tím, že pokud by jsme zadali nějakou látku vybrala by se nám látka z "databáze" a rovnou k ní se přířadila hustota
            Latky _ = new Latky();
            // 2. úkol -zkuste umožnit na místo zadání hustoty tělesa zadat hmotnost tělesa a došlo by k výpočtu hustoty ((zkusit i tím zařadit k látce kterou budete mít v tabulce látek))
            Krychle krychle = new Krychle(true, "voda", Math.Pow(2, 3)); //"1. úkol" na tomhle řádku nebude muset uživatel zadávat hustotu, ale stačí zadat látku 
            Krychle krychle1 = new Krychle(false,997, 8);
            Console.WriteLine(krychle.Hmotnost);
            Console.WriteLine(krychle1.Hmotnost);
            Console.Read();
        }
    }
    
    class Teleso {
        public string Latka { get; set; }
        public double Objem { get; set; }
        public double Hmotnost { get; set; }
        public double Hustota { get; set; }
        
        public Teleso(bool secondArgObjem, string latka, double objemOrHmotnost) {
            if (secondArgObjem) {
                Latka = latka;
                Hustota = Latky.GetByLatka(latka);
                Objem = objemOrHmotnost;
                // hustota = hmotnost/ objem
                Hmotnost = Hustota * objemOrHmotnost;
            }
            else {
                
            }
        }
        
        public Teleso(bool firstArgHmotnost, double hmotnostOrHustota, double objem) {
            if (firstArgHmotnost) {
                Latka = Latky.GetByHustota(hmotnostOrHustota);
                Hmotnost = hmotnostOrHustota;
                Objem = objem;
                // hustota = hmotnost/ objem
                Hustota = hmotnostOrHustota / objem;
            } else {
                Latka = Latky.GetByHustota(hmotnostOrHustota);
                Hustota = hmotnostOrHustota;
                Objem = objem;
                // hustota = hmotnost/ objem
                Hmotnost = hmotnostOrHustota * objem;
                
            }
        }
    }
    class Krychle : Teleso  {
        public Krychle(bool secondArgObjem, string latka, double objemOrHmotnost) : base(secondArgObjem, latka, objemOrHmotnost) {

        }
        public Krychle(bool firstArgHmotnost, double hmotnostOrHustota, double objem) : base(firstArgHmotnost, hmotnostOrHustota,objem) {

        }
    }

    class Latky {
        private static Dictionary<string, double> latky = new Dictionary<string, double>();

        public Latky() {
            /*
             * File Format:
             * voda-997
             * asfalt-1300
             * olovo-11340
             * papír-800
             * zlato-19320
             * teflon-2200
            */

            using (StreamReader reader = new StreamReader("./Homeworks/Ukol8/latky.txt")) {

                string line;
                while ((line = reader.ReadLine()) != null) {
                    string[] latka = line.Split("-");
                    if (latka.Length <= 1 || latka.Length >= 3) continue;
                    if (!double.TryParse(latka[1], out double _)) return;
                    latky.Add(latka[0], double.Parse(latka[1]));
                }
                
            }
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
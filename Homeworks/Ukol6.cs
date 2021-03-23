using System;
using System.Collections.Generic;

namespace PVA.Homeworks {
    
    public class Ukol6 {

        public static void Start() {

            // 1. úkol -vymyslete jak nahradit pasní hustoty do konstruktoru tím, že pokud by jsme zadali nějakou látku vybrala by se nám látka z "databáze" a rovnou k ní se přířadila hustota
            Latky1 _ = new Latky1();
            // 2. úkol -zkuste umožnit na místo zadání hustoty tělesa zadat hmotnost tělesa a došlo by k výpočtu hustoty ((zkusit i tím zařadit k látce kterou budete mít v tabulce látek))
            Krychle1 krychle = new Krychle1(true, "voda", Math.Pow(2, 3)); //"1. úkol" na tomhle řádku nebude muset uživatel zadávat hustotu, ale stačí zadat látku 
            Krychle1 krychle1 = new Krychle1(false,997, 8);
            Console.WriteLine(krychle.Hmotnost);
            Console.WriteLine(krychle1.Hmotnost);
            Console.Read();
        }
    }
    
    class Teleso1 {
        public string Latka { get; set; }
        public double Objem { get; set; }
        public double Hmotnost { get; set; }
        public double Hustota { get; set; }
        
        public Teleso1(bool secondArgObjem, string latka, double objemOrHmotnost) {
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
        
        public Teleso1(bool firstArgHmotnost, double hmotnostOrHustota, double objem) {
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
    class Krychle1 : Teleso1  {
        public Krychle1(bool secondArgObjem, string latka, double objemOrHmotnost) : base(secondArgObjem, latka, objemOrHmotnost) {

        }
        public Krychle1(bool firstArgHmotnost, double hmotnostOrHustota, double objem) : base(firstArgHmotnost, hmotnostOrHustota,objem) {

        }
    }

    class Latky1 {
        private static List<string> latky = new List<string>();
        private static List<double> hustoty = new List<double>();

        public Latky1() {
            /*
            voda - 997
            asfalt - 1300
            olovo - 11340
            papír - 800
            zlato 19320
            teflon - 2200
            */
            latky.Add("voda");
            hustoty.Add(997);
            latky.Add("asfalt");
            hustoty.Add(1300);
            latky.Add("olovo");
            hustoty.Add(11340);
            latky.Add("papír");
            hustoty.Add(800);
            latky.Add("zlato");
            hustoty.Add(19320);
            latky.Add("teflon");
            hustoty.Add(2200);
        }
        
        public static double GetByLatka(string latka) {
            if (latky.IndexOf(latka) != -1) {
                return hustoty[latky.IndexOf(latka)];
            }

            return 0;
        }

        public static string GetByHustota(double hustota) {
            if (hustoty.IndexOf(hustota) != -1) {
                return latky[hustoty.IndexOf(hustota)];
            }

            return "";
        }
        
    }
}
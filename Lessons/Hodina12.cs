using System;
using System.Threading;

namespace PVA.Lessons {

    public class Hodina12 {

        public static void Start() {
            
            /*
             * Class Clovek nize
             */
            Clovek clovek = new Clovek("Pepa", "Novotny", 20, 180, 60);

            // prenastavovani hodnot cloveka a cteni hodnot

            clovek.Jmeno = "Karel";
            
            Thread.Sleep(2000);
            
            Console.WriteLine(clovek.Jmeno);
            
            Console.WriteLine(clovek.BMI());
            
            
            // vypsani informaci jako datumu vytvoreni atd.
            Console.WriteLine("Cas vytvoreni: " + clovek.JmenoCreated);
            Console.WriteLine("Cas editace: " + clovek.JmenoEdited);
            Console.WriteLine("Cas zobrazeni: " + clovek.JmenoViewed);


        }
        
    }

    class Clovek {
        private string _jmeno;

        public DateTime JmenoCreated;
        public DateTime JmenoViewed;
        public DateTime JmenoEdited;
        
        public string Jmeno {
            // vse zde se spusti kdyz chcete precist hodnotu Jmeno
            // napr. Console.WriteLine(clovek.Jmeno);
            get {
                // toto nastavi hodnotu kdy vylo jmeno naposledy prectene a vrati souromou hodnotu _jmeno
                JmenoViewed = DateTime.Now;
                return _jmeno;
            }
            // vse zde se spusti kdyz chcete nastavit hodnotu Jmeno
            // napr. clovek.Jmeno = "Marek"
            set {
                // toto nastavi hodnotu kdy vylo jmeno naposledy upravene a prenastavi souromou hodnotu _jmeno
                JmenoEdited = DateTime.Now;
                _jmeno = value;
            }
        }

        public string Prijmeni { get; set; }
        public double Vyska { get; set; }
        public int Vek { get; set; }
        public double Hmotnost { get; set; }

        public Clovek(string jmeno, string prijmeni, int vek, double vyska, double hmotnost) {
            this.Jmeno = jmeno;
            this.JmenoCreated = DateTime.Now;
            this.Prijmeni = prijmeni;
            this.Vyska = vyska;
            this.Hmotnost = hmotnost;
            this.Vek = vek;
        }

        public double BMI() {
            double vyskaM = (double) Vyska / 100;
            double bmi = Hmotnost / Math.Pow(vyskaM, 2);
            return bmi;
        }
    }
}
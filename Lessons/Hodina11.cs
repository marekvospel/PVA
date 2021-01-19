using System;

namespace PVA.Lessons {
    
    class Hodina11 {
        public static void Test(string[] args) {


            int[] pole = { 1, 2, 3 };

            // Objekt muzeme nastavit na cokoliv
            object a = 1;
            object b = 2;
            object c = "test";
            object d = 'x';
            object e = true;

            // i na veci jako pole
            object z = pole;

            // C# si stale pamatuje co za typ (Int32[] ...)
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            
            Console.WriteLine(z);

            // Pokud pak chceme prevest zpatky z objektu musime pouzit (<typ>):
            // int[] pole2 = (int[]) z;
            // string text = (string) c;

            // coz funguje i napr. s boolem
            // if ((bool) e) {
            //     Console.WriteLine("E je bool a je true!");
            // }

            /* 
             * class Clovek
             * 
             * viz nize
             */

            // Vytvorime objekt Clovek
            Clovek11 marek = new Clovek11();

            // K hodnote Age a Weight nemuzu pristupovat jelikoz jsou private
            // marek.Weight = 60;
            // marek.Age = 15;

            // Ale k Name a Addres pristupovat muzu jelikoz jsou public
            marek.Name = "Marek";
            marek.Address = "Dolni Brezany";

            Console.WriteLine(marek.Name);

            // Take muzu spoustet metody uvnitr classy
            marek.Pozdrav();

            // A tyto metody mohou i vracet hodnoty
            double soucet = marek.Secti(1, 1);
            Console.WriteLine(soucet);

            /*
             * Constructors
             * 
             * vice dole
             */

            Clovek11 franta = new Clovek11(5, 30, "franta");

            franta.Prezdivka = "frana";
            Console.WriteLine(franta.Prezdivka);

            // Nyni ma franta hodnotu veku, vahy a jmena bez potreby pouziti franta.Name = "Franta";
            Console.WriteLine(franta);

            Console.ReadKey();

            /*
             * Getter a Setter
             * 
             * vice nize 
             */
        }
    }

    class Clovek11  {
        // Class muze mit sve data (jako lide muzou mit v hlave data - napr jmeno, vek, vaha atd.)
        double Weight;
        // Kvuli programatorskym "pravidlum" se uvadi private ikdyz je private defaultne, kvuli citelnosti kodu
        double Height;
        // Pokud chceme pouzivat udaj i zvenku class Clovek musime k tomu pridat public
        public string Name;
        public string Address;

        // Classy mohou mit i metody ktere neco dokazi delat

        // Opet je potreba aby metoda mohla byt pouzita zvenci pridat pred ni public
        public void Pozdrav() {
            Console.WriteLine("Ahoj {0}", Name);
        }

        // Metody mohou i vracet hodnoty
        public double Secti(double cislo1, double cislo2) {
            return cislo1 + cislo2;
        }

        /*
         * Pouziti trid
         * 
         * vice nahore 
         */

        // Tridy maji automaticky constructor bez parametru ()

        // ale defaultni muzeme prepsat pomoci vytvoreni jineho constructeru
        public Clovek11 () {
            // K vlastnim udajum muzeme pristupovat pomoci pouziti jejich nazvu
            Weight = 0;
            Height = 0;
            // nebo pomoci this.jejich nazev
            // this.Age = 0;
        }

        // Pokud chceme v constructeru mit parametry, je potreba vytvorit constructor s parametry
        // Pote se to pouzije pomoci new Clovek(<parametry>);
        public Clovek11 (int weight, int height, string name) {
            Weight = weight;
            Height = height;
            Name = name;
        }

        // Classy mohou mit i vice constructeru a ty mohou byt i private i public

        /*
         * Pouziti Constructeru
         * 
         * vice nahore 
         */

        // Pomoci Getteru a setteru (definovanych pomoci { get; } { set; } nebo kombinaci { get; set; })
        // muzeme dostat nebo nastavit private hodnotu
        public string Prezdivka;
        
        
        public double Bmi() {
            double vyskaM = Height / 100;
            double bmi = Weight / Math.Pow(vyskaM, 2);
            return bmi;
        }
    }
}
using System;

namespace PVA.Lessons {
    
    
    public class Hodina15 {

        public static void Start() {

            /*
             * Dedicnost
             * Vytvorime class Player s public Username a metodou Doge a classy Mage a Warrior
             * viz. nize
             */

            // Nyni muzeme vytvorit Waririora / Mage a vytvorit si jejich objekty a ty budou mit metody a hodnoty z obou class
            Warrior player1 = new Warrior("pepa123", "Long Sword");
            Mage player2 = new Mage("1honza", "Powerfull Wand");
            // Objekt Mage se muze nastavit na misto Player jelikoz to Player je, s par pridanymi metodami a hodnotami
            Player player3 = new Mage("2honza", "Powerfull Wand");
            
            player2.Attack();
            // Muzeme pouzit jak Doge metodu z Player tridy
            player1.Doge();
            // Tak Attack metodu z Mage / Warrior
            player1.Attack();
            player2.Doge();
            
            // Ale jelikoz player3 je pouze player tak nemuzeme pouzivat Attack metodu
            player3.Doge();
            
            // Museli bychom player3 castovat
            ((Mage) player3).Attack();

            // Promene ze tridy Warrior / Mage muzeme psat, pokud je objekt Warrior
            Console.WriteLine(player1.Sword);
            Console.WriteLine(player2.Wand);
            // Tedy player3 bychom znovu museli castovat
            
            // Username muzeme pouzivat i u hrace3, jelikoz Username je v Player class
            Console.WriteLine(player3.Username);
            Console.WriteLine(player1.Username);
        }
        
    }

    class Player {
        public string Username { get; }

        // Constructor je protected aby se nemohl vytvorit novy hrac pomoci new Player("username"); ale aby mohl byt pouzit v classach Mage a Warrior
        protected Player(string username) {
            Username = username;
        }
        
        public void Doge() {
            Console.WriteLine("You have doged an attack!");
        }
    }

    // kdyz za Mage dame : Player, rekneme ze Mage rozsiruje tridu Player, coz znamena ze s objektem Mage je mozne pouzivat metodu Doge & hodnotu username
    // nyni kdyz vytvorime objekt z classy Player, muzeme pouzit jak promenou Wand tak promenou Username z Player. a bude mit i metodu Attack a Doge
    class Mage : Player {
        public string Wand { get; }

        // Constructor Mage hrace, bere si 2 argumenty a nastavuje hodnotu Wand
        // base(username) spousti protected constructor v classe Player, ktere zapise i Username
        public Mage(string username, string wand) : base(username) {
            Wand = wand;
        }
        
        public void Attack() {
            Console.WriteLine("You have dealt 5 damage!");
        }
    }
    
    // Trida Warrior, ktera je stejna jako Mage, jen Metoda Attack dava vetsi damage, misto Wand ma trida promenou Sword
    class Warrior : Player {
        public string Sword { get; }

        public Warrior(string username, string sword) : base(username) {
            Sword = sword;
        }
        
        public void Attack() {
            Console.WriteLine("You have dealt 10 damage!");
        }
    }
}
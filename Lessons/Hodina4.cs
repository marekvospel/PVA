using System;
using System.Collections.Generic;

namespace PVA.Lessons {
    public class Hodina4 {

        public static void Start() {
            
            /*
             * Tema hodiny: List
             */
            
            /*
             * Pole = Array
             * 
             * Listy jsou podobne jako Pole
             * je mezi nimi ale rozdil.
             *
             * Pole ma pevny pocet prvku.
             * List ma vice vlastnich metod ale pro pole musime pouzivat externi funkce (Array.Sort(array);)
             */
            
            // Timto vytvorime list ve kterem mohou byt cisla (int)
            List<int> list = new List<int>();
            // Timto vytvorime list ve kterem mohou byt znaky (char)
            List<char> list2 = new List<char>();
            
            // Abychom do listu pridali hodnotu muzeme pouzit list.Add
            list.Add(10);
            list.Add(20);
            list.Add(50);
            list.Add(30);
            list.Add(100);
            list.Add(150);
            
            list2.Add('t');
            
            // Na odebrani pak muzeme pouzit metody jako
            
            // Odebere 1. hodnotu (10) - index 0 
            list.RemoveAt(0);

            // Odebere 2. a 3. hodnotu (20 a 50) - index 1 a 2
            list.RemoveRange(1, 2);
            
            // Odebere hodnotu 100 (5. hodnotu)
            list.Remove(100);
            
            // Hodnotu z listu vypiseme stejne jako z pole
            Console.WriteLine(list[1]);
            Console.WriteLine(list2[0]);
            
            // Opakovat s kazdou hodnotou v listu
            foreach (double i in list) {
                
                // Vypsat hodnotu i z listu
                Console.WriteLine(i);
                
            }
        }
        
    }
}
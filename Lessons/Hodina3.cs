using System;

namespace PVA.Lessons {
    
    public class Hodina3 {

        public static void Start() {
            
            /*
             * Tema hodiny: Pole
             */
            
            /*
             * Pole = Array
             *
             * Pole jsou "rady" dat v kodu (tj. mnoziny hodnot)
             *
             * pole pozname podle [] (pole s cisly je tedy int[], se znaky char[])
             */
            
            // Definovat pole je mozne nasledovne
            
            
            
            // nove pole cisel (int) o delce 6 s obsahem 1, 2, 3, 4, 5, 6
            int[] arr = new int[] { 1, 8, 3, 10, 11, 8}; // jednodusseji jen int[] arr2 = { 1, 2, 3, 4, 5, 6};
            
            // nove prazdne pole znaku (char) o delce 5
            char[] arr2 = new char[5];
            
            /*
             * Nastavit hodnotu pole muzeme pomoci array[index] = hodnota
             * index = pozice
             * pole zacinaji na indexu 0
             */
            arr2[0] = 'a';
            arr2[1] = 'b';
            arr2[2] = 'c';
            // Prenastavi 1. hodnotu z a na d
            arr2[0] = 'd';

            // prenastavi 1. hodnotu z 8 na 7
            arr[0] = 7;

            /*
             * Hodnotu z pole ziskame pomoci array[index]
             * priklad:
             * int i = arr2[0]
             */
            
            // Tudiz takto muzeme vypsat 1. hodnotu z arr2
            Console.WriteLine(arr[0]);
            
            // Console.WriteLine na pole nemuzeme pouzit. 
            Console.WriteLine(arr); // Vypise System.Int32[]

            /*
             * Na vypsani pole muzeme pouzit cyklus (loop)
             */
            
            // forloop
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
            
            // foreachloop
            foreach (int j in arr) {
                Console.WriteLine(j);
            }

            // while loop (popr. stejne funguje i do {} while())
            int k = 0;
            while (k < arr.Length) {
                Console.WriteLine(arr[k]);
                k++;
            }
            
            /*
             * S Poli muzeme delat i dalsi zajimave veci jako treba je prevracet, seradit atd
             */
            
            // Pole seradime pomoci
            Array.Sort(arr);
            
            // Nyni pokud vypiseme 1. hodnotu z arr budeme mit tu nejnizsi hodnotu z arr
            Console.WriteLine("Nejnizsi hodnota je: " + arr[0]);
            
            // Pole Prevratime pomoci Array.Reverse() coz zpusobi ze 1. hodnota se stane posledni, 2. predposledni atd.
            Array.Reverse(arr);
            
            // Nyni pokud vypiseme 1. hodnotu z arr budeme mit tu nejvyssi hodnotu z arr
            Console.WriteLine("Nejvyssi hodnota je: " +arr[0]);

        }
        
    }
    
}
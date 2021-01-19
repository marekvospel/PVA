using System;

namespace PVA.Homeworks {
    
    public class Ukol2 {

        public static void Start() {

            // Ukol 2.1
            
            Console.WriteLine("    [Are arrays equal]    ");
            
            // Definovani arr1 a arr2
            char[] arr1 = new char[5];
            char[] arr2 = new char[5];

            // informace o ukladani do arr1
            Console.WriteLine("Inserting data to array 1");
            // Opakovat stejne dlouho jako je arr1 dlouha
            for (int i = 0; i < arr1.Length; i++) {

                // Opakovat dokud loop neni zevnitr prerusen
                while (true) {
                    // Zazadani uzivatele o vstup
                    Console.Write("Enter value {0}:", i + 1);
                    string input = Console.ReadLine();
                    // Validace vstupu
                    if (input.Length >= 1) {
                        arr1[i] = input[0];
                        break;
                    } 
                }
                
            }
            
            // informace o ukladani do arr2
            Console.WriteLine("Inserting data to array 2");
            // Opakovat stejne dlouho jako je arr1 dlouha
            for (int i = 0; i < arr2.Length; i++) {

                // Opakovat dokud loop neni zevnitr prerusen
                while (true) {
                    // Zazadani uzivatele o vstup
                    Console.Write("Enter value {0}:", i + 1);
                    string input = Console.ReadLine();
                    // Validace vstupu
                    if (input.Length >= 1) {
                        arr2[i] = input[0];
                        break;
                    } 
                }
                
            }

            // Vypsani informace zda jsou arraye stejne (ukazuje na CompareArrays metodu)
            Console.WriteLine(CompareArrays(arr1, arr2) ? "Array 1 and Array2 are equal!" : "Arrays aren't equal!");    
            
            
            // Ukol 2.2
            Console.WriteLine("    [Find arrays inside arrays]    ");
            
            // definovani rady znaku
            string input2;
            
            while (true) {
                // Zazadani uzivatele o vstup
                Console.Write("Enter text (will be converted to char array):");
                // Ziskani vstupu od uzivatele
                input2 = Console.ReadLine();   
                // Prerusit pokud je vstup platny
                if (input2 != "") break;
            }

            // definovani aktualnich hodnot (ktere se pouzivaji v loopu jako aktualni znak a info o nem)
            char currentChar = default;
            int currentLength = 0;
            int currentPosition = 0;

            // definovani nejvyssich hodnot (ktere se postupne v loopu zvysuji)
            int highestLength = 0;
            int highestPosition = 0;

            // Projit cely input (prevedeny na Pole znaku - char Array - char[])
            for (int i = 0; i < input2.ToCharArray().Length; i++) {
                
                // pokud je aktualni znak stejny jako ten ke kteremu jsme se dostali pres for loop
                if (currentChar == input2.ToCharArray()[i]) {
                    // zvysit delku aktualniho retezce 
                    currentLength++;
                }
                
                // Pokud ma aktualni znak defaultni hodnotu (jeste nebyl zadan)
                if (currentChar == default) {
                    // nastavit informaci o aktualnim znaku
                    currentChar = input2.ToCharArray()[i];
                    currentLength = 1;
                    currentPosition = i;
                }
                
                // Pokud je aktualni delka vetsi nez nejvyssi delka
                if (highestLength < currentLength) {
                    // nastavit hodnotu aktualniho znaku na nejvyssi
                    highestLength = currentLength;
                    highestPosition = currentPosition;
                }

                // pokud aktualni znak neni stejny jako znak ke kteremu jsme se dostali pres for loop
                if (currentChar != input2.ToCharArray()[i]) {
                    // nastavit informaci o aktualnim znaku
                    currentChar = input2.ToCharArray()[i];
                    currentLength = 1;
                    currentPosition = i;
                }

            }
            
            // Vypsani informaci o rade znaku
            Console.WriteLine("Longest chain of characters is made from {0}, is {1} long and starts on position {2}.", input2.Substring(highestPosition, 1), highestLength, highestPosition);

        }

        // Metoda CompareArrays
        private static bool CompareArrays(char[] arr1, char[] arr2) {
            // Pokud jsou arraye jinak dlouhe, nemuzou si byt rovne
            if (arr1.Length != arr2.Length) return false;
            
            // Opakovat stejne dlouho jako je arr1 dlouha
            for (int i = 0; i < arr1.Length; i++) {
                // pokud znak na pozici i v arr1 neni stejny jako znak na pozici i v arr2, arraye si nemuzou byt rovne
                if (arr1[i] != arr2[i]) return false;
            }

            // Pokud se kod dostal sem, arraye si jsou rovne
            return true;
        }
    }
    
    
    
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace PVA.Homeworks {
    
    public class UkolX {

        public static void Start() {
            
            // vytvoreni arraye
            char[] arr = {'a', 'b', 'c', 'c', 'a', 'b', 'c'};
            // spusteni metody a ulozeni newArr
            char[] newArr = RemoveMultiples(arr, 1);

            // Vypsani vsech znaku v newArr
            foreach (char c in newArr) Console.WriteLine(c);
            
            // Zjednodusene zapsani
            Console.WriteLine(RemoveMultiples("abccabc".ToCharArray(), 1));
            
        }

        static char[] Deduplicate(char[] input) {
            return RemoveMultiples(input, 0);
        }

        static char[] RemoveMultiples(char[] input, int maxOccurance) {
            List<char> output = new List<char>();

            foreach (char c in input) {
                
                if (output.Count(cr => c == cr) <= maxOccurance) output.Add(c);
                
            }

            return output.ToArray();
        }

    }
    
}
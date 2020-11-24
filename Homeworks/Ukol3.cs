using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace PVA.Homeworks {
    
    public class Ukol3 {

        public static void Start() {
            
            // vytvoreni arraye
            char[] arr = {'a', 'b', 'c', 'c', 'a', 'b', 'c'};
            // spusteni metody a ulozeni newArr
            char[] newArr = RemoveMultiples(arr, 1);

            // Vypsani vsech znaku v newArr
            foreach (char c in newArr) Console.WriteLine(c);
            
            // Zjednodusene zapsani
            Console.WriteLine(RemoveMultiples("abccabc".ToCharArray(), 1));
            
            // Spusteni DoS utoku na web ssps.cz
            DoS("https://ssps.cz");
        }

        static void DoS(string url) {
            
            Console.WriteLine("Starting DoS attack on {0}...", url);
            
            // Prevedeni stringu na Uri objekt
            Uri uri = new Uri(url);
            
            Console.WriteLine("Attacking...");

            // Vytvoreni webove zadosti
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(uri);
            // Ziskani odpovedi ze zadosti request
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            
            // Pokud http status code requestu je 200
            if (response.StatusCode.Equals(HttpStatusCode.OK)) {
                Console.WriteLine("Attack was successfull with 1 web request!");
            } else {
                Console.WriteLine("Attack was not succesfull! :c");
            }

            // Zavrit pripojeni
            response.Close();

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
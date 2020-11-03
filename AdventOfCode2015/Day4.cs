using System;
using System.Security.Cryptography;
using System.Text;

namespace PVA.AdventOfCode2015 {
    public class Day4 {

        public static void Start() {

            string input = "ckczppom";
            int i = 1;

            while (true) {

                string hash = Encode(input + i);

                if (hash.StartsWith("000000")) Console.Write("\nThe number is {0}!\n", i);
                
                Console.Write("\rCurrently on position {0}! Current MD5 hash is {1}", i, hash);
                i++;
            }
            
            
        }
        
        public static string Encode(string text) {
            MD5 md5 = MD5.Create();

            byte[] input = Encoding.UTF8.GetBytes(text);
            byte[] hash = md5.ComputeHash(input);

            StringBuilder builder = new StringBuilder();
            
            for (int i = 0; i < hash.Length; i++)  {
                builder.Append(hash[i].ToString("x2"));
            }
            
            return builder.ToString().ToLower();
        }

    }
}
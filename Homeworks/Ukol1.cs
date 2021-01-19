using System;

namespace PVA.Homeworks {
    
    public class Ukol1 {

        public static void Start() {
            
            Console.WriteLine("    [Lowest and highest]    ");
            
            double[] nums = new double[10];

            for (int i = 0; i < nums.Length; i++) {

                do {
                    Console.Write("Enter number "+(i+1)+":");
                    if (double.TryParse(Console.ReadLine(), out nums[i])) break;
                } while (true);

            }

            Array.Sort(nums);
            Console.WriteLine(nums[0] + " is the lowest number!");
            Console.WriteLine(nums[(nums.Length - 1)] + " is the highest number!");
            
            Console.WriteLine("    [Sum of numbers]    ");

            int[] nums2 = new int[5];
            
            for (int i = 0; i < nums2.Length; i++) {

                do {
                    Console.Write("Enter number "+(i+1)+":");
                    if (int.TryParse(Console.ReadLine(), out nums2[i])) break;
                } while (true);

            }

            int finalNum = 0;
            
            for (int i = 0; i < nums2.Length; i++) {

                finalNum += nums2[i];

            }
            
            Console.WriteLine("Sum of all numbers is "+finalNum+"!");

            Console.WriteLine("    [Stars]    ");
            
            int amount;
            string stars = "";
            
            do {
                Console.Write("Enter amount of stars:");
                if (int.TryParse(Console.ReadLine(), out amount)) break;
            } while (true);

            for (int i = 0; i < amount; i++) {
                stars += "*";
            }
            
            Console.WriteLine(stars);
            
        }
        
    }
}
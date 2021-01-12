using System;
using System.Collections.Generic;

namespace PVA.Lessons {
    
    public class Hodina14 {
        
        public static void Start() {

            DateTime date1 = new DateTime(2021, 1, 25);
            DateTime date2 = new DateTime();
            //01.01.0001 00:00:00:00
            date2 = date2.AddDays(11);
            date2 = date2.AddYears(2020);
            
            Task task1 = new Task("Odevzdání úkolu na PVA", "Dokončit program úkolníčku", date1);
            Task task2 = new Task("Odevzdání projektu pro STP", "Odevzdat všechny výstupy včetně finální prezentace", date2);

            List<Task> tasks = new List<Task>();
            tasks.Add(task1);
            tasks.Add(task2);
            
            
            foreach (var item in tasks)
            {
                if (!item.Complete)
                {
                    Console.Write(item.Name + " ");
                    Console.WriteLine(item.deathLine);
                    Console.WriteLine(item.Description);
                    Console.WriteLine();
                }               
                
            }
        }
    }
    
    class Task {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Complete { get; set; }
        public DateTime deathLine; 
        public Task(string name, string descrition, DateTime dLine) {
            Name = name;
            Description = descrition;
            deathLine = dLine;
            Complete = false;
        }
    }
        
}
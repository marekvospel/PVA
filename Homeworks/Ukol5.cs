using System;
using System.Collections.Generic;

namespace PVA.Homeworks {
    
    public class Ukol5 {

        public static void Start() {

            TaskManager manager = new TaskManager();
            
            Task pva = new Task("PVA Homework", new DateTime(2021, 1, 19), "Napsat TaskManager", "Odevzdat ho");
            Task kbb = manager.CreateTask("KBB Homework", new DateTime(2021, 1, 15), "Napsat referat na DoubleTagging", "Odevzdat ho");

            manager.AddTask(pva);
            manager.AddTask(kbb);

            manager.PrintTasks();

            pva.Complete = true;

            manager.PrintTasks();
            
        }

    }

    class TaskManager {
        public List<Task> Tasks { get; private set; }

        /**
         * <summary>
         * Constructs TaskManager class creating new empty <see cref="Task"/> List (Tasks)
         * </summary>
         */
        public TaskManager() {
            Tasks = new List<Task>();
        }
        
        /**
         * <summary>
         * Add existing <see cref="Task"/> object to this TaskManager
         * </summary>
         */
        public void AddTask(Task task) {
            Tasks.Add(task);
        }

        /**
         * <summary>
         * Create a task without needing to create object <see cref="Task"/>
         * and automatically add it to this TaskManager
         * </summary>
         */
        public Task CreateTask(string name, DateTime deadline, params string[] steps) {
            Task task = new Task(name, deadline, steps);
            Tasks.Add(task);
            return task;
        }
        
        /**
         * <summary>
         * Print all tasks and their details such as deadline, and their steps
         * </summary>
         */
        public void PrintTasks() {
            foreach (var task in Tasks) {
                if (task.Complete) return;
                Console.WriteLine(task.Name);
                Console.WriteLine("Deadline: {0}", task.Deadline);
                Console.WriteLine("Steps: ");
                for (int step = 0; step < task.Steps.Length; step++) {
                    Console.WriteLine("  {0}) {1}", step + 1, task.Steps[step]);
                }
                Console.WriteLine();
            }
        }
    }
    
    class Task {
        public string Name { get; private set; }
        public DateTime Deadline { get; private set; }
        public bool Complete { get; set; }
        public string[] Steps { get; private set; }

        /**
         * <summary>
         * Create a new Task. If you want to print it out you will need to add it to <see cref="TaskManager"/> and use <see cref="TaskManager.PrintTasks()"/>
         * * </summary>
         */
        public Task(string name, DateTime deadline, params string[] steps) {
            Name = name;
            Deadline = deadline;
            Steps = steps;
            Complete = false;
        }
    }
    
}
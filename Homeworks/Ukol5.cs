using System;
using System.Collections.Generic;

namespace PVA.Homeworks {
    
    public class Ukol5 {

        public static void Start() {
            TaskManager taskManager = new TaskManager();
            taskManager.CreateTask("test", DateTime.Now, "test", "test");
            
            CommandManager commandManager = new CommandManager();
            Command ls = new Ls();
            Command add = new Add();
            Command remove = new Remove();
            Command complete = new Complete();
            Command clear = new Clear();
            Command exit = new Exit();
            commandManager.AddCommands(ls, add, complete, remove, clear, exit);

            Console.WriteLine("Welcome to TaskManager!");

            while (true) {

                string command = "";
                Console.Write("> ");
                while (command == "") {
                    command = Console.ReadLine();
                    if (command == "")
                        Console.Write("> ");
                }

                Command cmd = commandManager.DetectCommand(command);

                if (cmd != null) {
                    int status = cmd.Execute(command, taskManager);
                    if (status == -1) return;
                } else Console.WriteLine("There is no such command!");

            }

        }

    }

    class CommandManager {
        private List<Command> Commands { get; }

        public CommandManager() {
            Commands = new List<Command>();
        }
        public void AddCommands(params Command[] cmds) {
            foreach (Command command in cmds) {
                Commands.Add(command);
            }
        }
        
        public Command DetectCommand(string fullCommand) {
            string[] args = fullCommand.Split(null);

            foreach (var cmd in Commands) {
                if (args[0].ToLower() == cmd.Name) return cmd;
            }
            
            return null;
        }
        
    }

    abstract class Command {
        public abstract string Name { get; }
        public abstract int Execute(String fullCommand, TaskManager manager);
    }

    class TaskManager {
        public List<Task> Tasks { get; }

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
            foreach (var t in Tasks) {
                if (task.Name == t.Name) return;
            }
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
            foreach (var t in Tasks) {
                if (task.Name == t.Name) return null;
            }
            Tasks.Add(task);
            return task;
        }

        /**
         * <summary>
         * Create a <see cref="Task"/> from this task manager
         * </summary>
         */
        public int RemoveTask(string name) {
            foreach (var task in Tasks) {
                if (task.Name == name) {
                    Tasks.Remove(task);
                    return 0;
                }
            }
            
            return 1;
        }
        
        /**
         * <summary>
         * Get <see cref="Task"/> from this TaskManager using its name
         * </summary>
         */
        public Task GetTaskByName(string name) {
            foreach (var task in Tasks) {
                if (task.Name == name) {
                    return task;
                }
            }
            
            return null;
        }
        
        /**
         * <summary>
         * Print all tasks and their details such as deadline, and their steps
         * </summary>
         */
        public void PrintTasks() {
            foreach (var task in Tasks) {
                Console.WriteLine(task.Name);
                Console.WriteLine("Deadline: {0}", task.Deadline);
                if (task.Complete) Console.WriteLine("Task is completed!");
                else {
                    Console.WriteLine("Steps: ");
                    for (int step = 0; step < task.Steps.Length; step++) {
                        Console.WriteLine("  {0}) {1}", step + 1, task.Steps[step]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
    
    class Task {
        public string Name { get; }
        public DateTime Deadline { get; }
        public bool Complete { get; set; }
        public string[] Steps { get; }

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
    
    #region commands

    class Ls : Command {
        public override string Name { get; } = "ls";

        public override int Execute(String fullCommand, TaskManager manager) {
            manager.PrintTasks();
            return 0;
        }
    }
    
    class Clear : Command {
        public override string Name { get; } = "clear";

        public override int Execute(String fullCommand, TaskManager manager) {
            Console.Clear();
            return 0;
        }
    }
    
    class Exit : Command {
        public override string Name { get; } = "exit";

        public override int Execute(String fullCommand, TaskManager manager) {
            return -1;
        }
    }
    
    class Add : Command {
        public override string Name { get; } = "add";

        public override int Execute(String fullCommand, TaskManager manager) {
            string[] args = fullCommand.Split(null);

            if (args.Length < 6) {
                Console.WriteLine("Not enough arguments! Usage: add <name> <year> <month> <day> <step 1> [step2] [step3]...");
                return 1;
            }
            
            double check2 = 0;
            double check3 = 0;
            
            if (!double.TryParse(args[2], out double check) || !double.TryParse(args[3], out check2) || !double.TryParse(args[4], out check3)) {
                Console.WriteLine("Year, month or day is invalid! Usage: add <name> <year> <month> <day> <step 1> [step2] [step3]...");
                Console.WriteLine($"You entered values: Year: {check}, Month: {check2} and Day: {check3}");
                return 1;
            }
            
            DateTime dateTime = new DateTime();

            dateTime = dateTime.AddDays(double.Parse(args[4]));
            dateTime = dateTime.AddMonths((int) double.Parse(args[3]));
            dateTime = dateTime.AddYears((int) double.Parse(args[2]));

            string[] steps = new string[args.Length - 5];
            for (int i = 5; i < args.Length; i++) {
                steps[i - 5] = args[i].Replace("_", " ");
            }
            
            Task task = new Task(args[1].Replace("_", " "), dateTime, steps);
            manager.AddTask(task);
            
            return 0;
        }
    }
    
    class Remove : Command {
        public override string Name { get; } = "remove";

        public override int Execute(String fullCommand, TaskManager manager) {
            string[] args = fullCommand.Split(null);

            if (args.Length < 2) {
                Console.WriteLine("Missing task! Usage: remove <task>");
                return 1;
            }

            int status = manager.RemoveTask(args[1].Replace("_", " "));

            if (status == 1) {
                Console.WriteLine("There is no such a task!");
                return 1;
            }

            Console.WriteLine("Task {0} was removed!", args[1].Replace("_", " "));
            return 0;
        }
    }
    
    class Complete : Command {
        public override string Name { get; } = "complete";

        public override int Execute(String fullCommand, TaskManager manager) {
            string[] args = fullCommand.Split(null);

            if (args.Length < 2) {
                Console.WriteLine("Missing task! Usage: complete <task>");
                return 1;
            }

            Task task = manager.GetTaskByName(args[1].Replace("_", " "));

            if (task == null) {
                Console.WriteLine("There is no such a task!");
                return 1;
            }

            if (task.Complete) {
                Console.WriteLine("This task is already complete!");
                return 1;
            }
            
            task.Complete = true;
            
            Console.WriteLine("Task {0} was completed!", args[1].Replace("_", " "));
            return 0;
        }
    }
    
    #endregion commands
}
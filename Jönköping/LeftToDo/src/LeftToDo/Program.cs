/*
    @Author: Elias Posluk
    Student-id: poel20ty
    Assignment 2, class Program.cs
    .NET Core & C# programming
    @date 29/11/2020
*/

using System;
using System.Collections.Generic;

namespace LeftToDo
{
    class Program
    {
        //Creating a taskManager object that manages a new task, listing and archiving tasks.
        private readonly TaskManager taskManager = new TaskManager();
        static void Main(string[] args)
        {
            Program program = new Program();
            
            bool showMenu = true;

            while(showMenu)
            {
                showMenu = program.MainMenu();
            }
        } //main end   
        
            /*
                MainMenu is the method that the user will be meeted by in the
                begining of the console run. All the input from the user will be
                handeld in the switch-statement, where a numerical input from 1-4 will
                call a function for that specific purpose. The numerical input 5 will 
                terminate the program.
            */
            private bool MainMenu()
            {
                Console.Clear();
                //the menu
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----------------------------------------------------------");
                Console.ResetColor();
                Console.WriteLine("Welcome to the TO DO List, The Dailey Task Manager Handler.\n");
                Console.WriteLine(
                                  "With this task mangager handler you can add a new task, list all tasks, archive all completed task, and list all completed tasks."+ Environment.NewLine +
                                  "1. Add a new task " + Environment.NewLine +
                                  "2. List all tasks" + Environment.NewLine +
                                  "3. Archive all completed tasks" + Environment.NewLine +
                                  "4. List all completed tasks" + Environment.NewLine +
                                  "5. Terminate program" + Environment.NewLine);

                switch (Console.ReadLine())
                {
                    case "1":
                        AddNewTask(); // Method to list all the to do tasks/assignments
                    return true;

                    case "2":
                        ListAllTasksNonArchived(); // method that adds a new task
                    return true;

                    case "3":
                        ArchiveAllCompletedTasks(); // method that archives all completed tasks
                    return true;

                    case "4":
                        ListAllArchivedTasks(); // method that lists all archived tasks
                    return true;
                    
                    case "5":
                        return false; // terminates the program
                default:
                        return true;
                }//switch end
            }//MainMenu end

            /*
                The method "AddNewTask()" gets you the option to create new tasks with or without features,
                like deadlines or check list functionality to your tasks. All the input from the user will be
                handeld in the switch-statement, where a numerical input from 1-4 will call a function for that specific purpose. 
            */
            public void AddNewTask()
            {
                Console.Clear();
                Console.WriteLine("Options:" + Environment.NewLine +
                              "1) Add a new task" + Environment.NewLine + 
                              "2) Add a new task with deadline" + Environment.NewLine + 
                              "3) Add a new task with built-in check list" + Environment.NewLine + 
                              "4) Return to \"Main Menu\""+ Environment.NewLine +                                                              
                               "Please select an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddNewTaskWithNoDeadline();
                        break;
                    case "2":
                        AddNewTaskWithDeadline();
                        break;
                    case "3":
                        AddNewTaskWithCheckList();
                        break;
                    case "4":
                        break;
                    default:
                        AddNewTask();
                        break;
                }//end switch in addnewtask method
            }//method AddNewTask end

        //This method adds a new task with no extra feature or deadline.
        public void AddNewTaskWithNoDeadline()
        {
            Console.Clear();
            Console.WriteLine("Add a new task:" + Environment.NewLine +
                              "---------------"  );

            // gets input data from the console and 
            //creates a new task with the input given from the user
            string name = Util.ReadInput("Please enter a \"task name\": ");
            taskManager.AddNewTask(name);
 
            Util.ShowMessage("\r\nYou have created a new task!");
        }

        //This method adds a new task that has a deadline.
        public void AddNewTaskWithDeadline()
        {
            Console.Clear();
            Console.WriteLine("Add a new task with deadline:");
            Console.WriteLine("-----------------------------");

            /*
             Gets the tasks name and number of days left to complete the tasks deadline, 
             from the user input, and creates a new task.
            */
            string name = Util.ReadInput("Please enter a \"task name\": ");
            int days = Util.ReadIntInput("Please enter the \"number of days\" left to complete the task: ");
            taskManager.AddNewTaskWithDeadline(name, days);

            Util.ShowMessage("\r\nYou have created a new task with deadline!");
        }

        //This method adds a new task that has a built-in checklist.
        public void AddNewTaskWithCheckList()
        {
            Console.Clear();
            Console.WriteLine("Add a new task with built-in check list:");
            Console.WriteLine("----------------------------------------");
            
                //Gets the tasks name from the user input, and creates a new task.
            string name = Util.ReadInput("Please enter a \"task name\": ");
            taskManager.AddNewTaskWithCheckList(name);

            Util.ShowMessage("\r\nYou have created a new task with built-in checklist!");
        }

        //This method lists all non-archived tasks.
        public void ListAllTasksNonArchived()
        {
            Console.Clear();
            Console.WriteLine("All the days tasks :");
            Console.WriteLine("--------------------");

            // Gets all non-archived tasks and prints them to console
            List<Task> nonArchivedTasks = taskManager.GetAllNonArchivedTasks();
            Util.PrintTasks(nonArchivedTasks);
           
            if (nonArchivedTasks.Count <= 0)
                Util.ShowMessage("You have no tasks!");
            else
            {
                string message = string.Format("\r\nYou have {0} {1}.", nonArchivedTasks.Count, nonArchivedTasks.Count == 1 ? "task" : "tasks");
                Console.WriteLine(message);

                //If there is at least one unfinished task, the user will get the option to mark the tasks to complete.
                bool found = false;
                foreach (Task task in nonArchivedTasks)
                {
                    if (!task.IsCompleted)
                    {
                        found = true;
                        break;
                    }
                }

                // show "mark as complete" option to the user
                if (found)
                    ShowNewOptionsToChangeStatus(nonArchivedTasks);
                else
                    Util.ShowMessage("");
            }
        }

        //This method provides tasks to be marked as completed.
        public void ShowNewOptionsToChangeStatus(List<Task> nonArchivedTasks)
        {
            Console.WriteLine("\r\n--------------------------------");
            Console.WriteLine("Options :");
            Console.WriteLine("Press \"the number\" of the task to be marked as completed or just");
            Console.WriteLine("Press \"Enter\" to return to \"Main Menu\"");
            Console.Write("\r\nPlease select an option: ");

            string line = Console.ReadLine();
            bool success = int.TryParse(line, out int number);
            if (success)
            {
                // number : the number of the task to be marked as completed
                if (number > 0 && number <= nonArchivedTasks.Count)
                {
                    Task task = nonArchivedTasks[number - 1];
                    if (task.IsCompleted)
                    {
                        Util.ShowMessage(string.Format("\r\nTask {0} has already been completed!", number));
                        return;
                    }

                    // if task is a special type of task that has a built-in checklist (TaskWithCheckList), 
                    // mark the tasks as completed in the checklist 
                    if (task is TaskWithCheckList taskWithCheckList)
                        taskWithCheckList.MarkAsCompleted();
                    else
                        task.MarkAsCompleted();

                    Util.ShowMessage(string.Format("\r\nYou marked Task {0} as completed!", number));
                }
            }
        }

        //This method archives all completed tasks.
        public void ArchiveAllCompletedTasks()
        {
            Console.Clear();
            Console.WriteLine("Archive all completed tasks:");
            Console.WriteLine("----------------------------");

            taskManager.ArchiveAllCompletedTasks();

            Util.ShowMessage("All completed tasks have been archived!");
        }

        //This method lists all archived tasks.
        public void ListAllArchivedTasks()
        {
            Console.Clear();
            Console.WriteLine("All archived tasks :");
            Console.WriteLine("--------------------");

            //Gets all archived tasks and prints them out
            List<Task> archivedTasks = taskManager.GetAllArchivedTasks();
            Util.PrintTasks(archivedTasks);

            if (archivedTasks.Count <= 0)
            {
                Util.ShowMessage("You have no archived tasks!");
            }
            else
            {
                string message = string.Format("\r\nYou have {0} {1}.", archivedTasks.Count, archivedTasks.Count == 1 ? "archived task" : "archived tasks");
                Util.ShowMessage(message);
            }
        }
    }//class program end
}//Namespace end

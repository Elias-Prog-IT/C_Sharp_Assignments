/*
    @Author: Elias Posluk
    Student-id: poel20ty
    Assignment 2, class TaskManager.cs
    .NET Core & C# programming
    @date 29/11/2020
*/

using System.Collections.Generic;

namespace LeftToDo
{
    /*
        This TaskManager class manages tasks operations as adding new tasks, archiving tasks, 
        listing tasks and listing archived tasks.      
    */
    public class TaskManager
    {
        // All tasks saved in the list AllTasks.
        public List<Task> AllTasks { get; } = new List<Task>();

        //Adds a new task that has no deadline.
        public Task AddNewTask(string name)
        {
            Task task = new Task { Name = name };
            AllTasks.Add(task);
            return task;
        }

        //Adds a new task that HAS a deadline.
        public Task AddNewTaskWithDeadline(string name, int days)
        {
            TaskWithDeadline task = new TaskWithDeadline
            {
                Name = name,
                Days = days
            };

            AllTasks.Add(task);
            return task;
        }

        //Adds a new task that has a built-in checklist.
        public Task AddNewTaskWithCheckList(string name)
        {
            TaskWithCheckList task = new TaskWithCheckList { Name = name };
            AllTasks.Add(task);
            return task;
        }

        //Archives all completed tasks.
        public void ArchiveAllCompletedTasks()
        {
            foreach (Task task in AllTasks)
            {
                if (task.IsCompleted)
                    task.IsArchived = true;
            }
        }

        //Returns all archived tasks.
        public List<Task> GetAllArchivedTasks()
        {
            List<Task> archivedTasks = new List<Task>();
            foreach (Task task in AllTasks)
            {
                if (task.IsArchived)
                    archivedTasks.Add(task);
            }

            return archivedTasks;
        }

        //Returns all non-archived tasks.
        public List<Task> GetAllNonArchivedTasks()
        {
            List<Task> nonArchivedTasks = new List<Task>();

            foreach (Task task in AllTasks)
            {
                if (!task.IsArchived)
                    nonArchivedTasks.Add(task);
            }
            return nonArchivedTasks;
        }
    }
}
/*
    @Author: Elias Posluk
    Student-id: poel20ty
    Assignment 2, class TaskWithCheckList.cs inherts Task.cs
    .NET Core & C# programming
    @date 29/11/2020
*/
using System.Collections.Generic;

namespace LeftToDo
{

    //Task that has a built-in checklist.
    public class TaskWithCheckList : Task
    {

        //A list with CheckList Tasks. 
        public readonly List<Task> CheckList = new List<Task>();

        //Constructor.
        public TaskWithCheckList()
        {
            AddDefaultTasksToCheckList();
        }

        /*
            Hides default "mark as completed" method because if this type of task is marked as completed, 
            all items in the checklist must also be marked as completed.
        */
        public new void MarkAsCompleted()
        {
            base.MarkAsCompleted();

            foreach (Task task in CheckList)
                task.MarkAsCompleted();
        }
       
        //Adds default built-in tasks to the object.
        public void AddDefaultTasksToCheckList()
        {
            CheckList.Add(new Task { Name = "Built-in Task 1" });
            CheckList.Add(new Task { Name = "Built-in Task 2" });
            CheckList.Add(new Task { Name = "Built-in Task 3" });
            CheckList.Add(new Task { Name = "Built-in Task 4" });
        }

        //Overrides default ToString() method.
        public override string ToString()
        {
            string format = ToString("N");
            string checkListTasks = "";

            foreach (Task task in CheckList)
                checkListTasks += string.Format("\r\n\t{0}", task.ToString());

            return string.Format("{0} {1}", format, checkListTasks);
        }
    }
}
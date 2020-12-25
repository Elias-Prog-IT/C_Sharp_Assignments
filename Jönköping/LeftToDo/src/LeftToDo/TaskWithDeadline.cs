/*
    @Author: Elias Posluk
    Student-id: poel20ty
    Assignment 2, class TaskWithDeadLine.cs inherts Task.cs
    .NET Core & C# programming
    @date 29/11/2020
*/

namespace LeftToDo
{
    //Class that handels deadlines.
    public class TaskWithDeadline : Task
    {
        //The number of days left to complete the task.
        public int Days { get; set; }

        public override string ToString()
        {
            string format = ToString("N");
            return string.Format("{0}, Deadline : {1}", format, Days);
        }
    }
}
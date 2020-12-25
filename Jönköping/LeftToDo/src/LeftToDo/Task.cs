/*
    @Author: Elias Posluk
    Student-id: poel20ty
    Assignment 2, class Task.cs
    .NET Core & C# programming
    @date 29/11/2020
*/

namespace LeftToDo
{
    // Task that has no deadline.
    // This is a super class for other type of task classes that will inherit the properties from the super class.
    public class Task
    {
        // Getters and setters for the tasks name.
        public string Name { get; set; }

        //data type boolean for gettes and set to see if the task is completed.
        public bool IsCompleted { get; private set; }

        //data type boolean for getters and setters to see if the task archived.
        public bool IsArchived { get; set; }

        //This method marks the tasks as completed. 
        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        //Overrides default to ToString() method. Returns a string that represents the current object.
        public override string ToString()
        {
            return ToString("N");
        }

        //Returns a string that represents the current object.
        public string ToString(string format)
        {
            if (string.IsNullOrEmpty(format))
                format = "N";  

            string normalFormat = string.Format("{0} {1}", IsCompleted ? "X" : " ", Name);
            switch (format.ToUpperInvariant())
            {
                case "N":
                    return normalFormat;
                case "A":
                    return string.Format("{0} {1}, IsArchived : {2}", IsCompleted ? "X" : " ", Name, IsArchived ? "Yes" : "No");
                default:
                    return normalFormat;
            }
        }
    }
}
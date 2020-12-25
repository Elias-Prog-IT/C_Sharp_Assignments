/*
    @Author: Elias Posluk
    Student-id: poel20ty
    Assignment 2, class UnitTest1.cs
    .NET Core & C# programming
    @date 29/11/2020
*/
using System.Collections.Generic;
using Xunit;

namespace LeftToDo.Tests
{
    public class UnitTest1
    {
        //TaskManager to be tested with its functionality.
        readonly TaskManager taskManager = new TaskManager();

        //Tests adding new task that has no deadline to the list.
        [Fact]
        public void TestAddNewTaskToList()
        {

            Assert.Equal(0, taskManager.AllTasks.Count);
            taskManager.AddNewTask("Check email");
            Assert.Equal(1, taskManager.AllTasks.Count);

            Task addedTask = taskManager.AllTasks[0];
            Assert.Equal("Check email", addedTask.Name);
            Assert.False(addedTask.IsArchived);
            Assert.False(addedTask.IsCompleted);

        }

        //Tests adding new task that has a deadline to the list.
        [Fact]
        public void TestAddNewTaskWithDeadlineToList()
        {
            //Adds a new task
            Assert.Equal(0, taskManager.AllTasks.Count);
            taskManager.AddNewTaskWithDeadline("Do assignments", 3);
            Assert.Equal(1, taskManager.AllTasks.Count);

            //Asserts properties to the added tasks.
            TaskWithDeadline addedTask = (TaskWithDeadline)taskManager.AllTasks[0];
            Assert.Equal("Do assignments", addedTask.Name);
            Assert.Equal(3, addedTask.Days);
            Assert.False(addedTask.IsArchived);
            Assert.False(addedTask.IsCompleted);

        }

        //Tests adding new task that has a built-in checklist to the list.
        [Fact]
        public void TestAddNewTaskWithChecklistToList()
        {
            //Adds new tasks
            Assert.Equal(0, taskManager.AllTasks.Count);
            taskManager.AddNewTaskWithCheckList("Finish exercise program");
            Assert.Equal(1, taskManager.AllTasks.Count);

            //Asserts properties to the added tasks.
            TaskWithCheckList addedTask = (TaskWithCheckList)taskManager.AllTasks[0];
            Assert.Equal("Finish exercise program", addedTask.Name);
            Assert.False(addedTask.IsArchived);
            Assert.False(addedTask.IsCompleted);

            //Asserts all inner tasks with for-each.
            foreach (Task innerTask in addedTask.CheckList)
            {
                Assert.False(innerTask.IsCompleted);
            }
        }

        //Tests adding different type of tasks to the list.
        [Fact]
        public void TestAddDifferentTypeTasksToList()
        {

            Assert.Equal(0, taskManager.AllTasks.Count);

            taskManager.AddNewTask("Check email");
            Assert.Equal(1, taskManager.AllTasks.Count);
            Assert.Equal("Check email", taskManager.AllTasks[0].Name);

            taskManager.AddNewTaskWithDeadline("Do assignments", 3);
            Assert.Equal(2, taskManager.AllTasks.Count);
            Assert.Equal("Do assignments", ((TaskWithDeadline)taskManager.AllTasks[1]).Name);

            taskManager.AddNewTaskWithCheckList("Finish exercise program");
            Assert.Equal(3, taskManager.AllTasks.Count);
            Assert.Equal("Finish exercise program", ((TaskWithCheckList)taskManager.AllTasks[2]).Name);
        }

        //Tests marking tasks as completed.
        [Fact]
        public void TestMarkTaskAsCompleted()
        {
            Task task = taskManager.AddNewTask("Check email");

            Assert.False(task.IsCompleted);
            task.MarkAsCompleted();
            Assert.True(task.IsCompleted);
        }

        //Tests marking tasks as completed with a built-in checklist.
        [Fact]
        public void TestMarkTaskWithCheckListAsCompleted()
        {
            TaskWithCheckList task = (TaskWithCheckList)taskManager.AddNewTaskWithCheckList("Finish exercise program");

            Assert.False(task.IsCompleted);
            foreach (Task innerTask in task.CheckList)
            {
                Assert.False(innerTask.IsCompleted);
            }
            task.MarkAsCompleted();

            //Assert-check inner tasks with for-each.
            Assert.True(task.IsCompleted);
            foreach (Task innerTask in task.CheckList)
            {
                Assert.True(innerTask.IsCompleted);
            }
        }

        //Tests archiving all completed tasks.
        [Fact]
        public void TestArchiveAllCompletedTasks()
        {
            Task task1 = taskManager.AddNewTask("Check emails");
            Task task2 = taskManager.AddNewTaskWithDeadline("Do homeworks", 5);
            Task task3 = taskManager.AddNewTaskWithCheckList("Finish exercise program");
            Task task4 = taskManager.AddNewTask("Sleep");

            //marks as completed before archive operation
            Assert.Equal(4, taskManager.AllTasks.Count);
            task1.MarkAsCompleted();
            task4.MarkAsCompleted();

            //archive all completed tasks
            Assert.Equal(0, taskManager.GetAllArchivedTasks().Count);
            Assert.Equal(4, taskManager.GetAllNonArchivedTasks().Count);
            taskManager.ArchiveAllCompletedTasks();

            //checks the operation result
            Assert.Equal(2, taskManager.GetAllNonArchivedTasks().Count);
            List<Task> allArchivedTasks = taskManager.GetAllArchivedTasks();
            Assert.Equal(2, allArchivedTasks.Count);
            Assert.Equal("Check emails", allArchivedTasks[0].Name);
            Assert.Equal("Sleep", allArchivedTasks[1].Name);
        }

        //Tests all non-archived tasks.
        [Fact]
        public void TestGetAllNonArchivedTasks()
        {
            Task task1 = taskManager.AddNewTask("Check emails");
            taskManager.AddNewTaskWithDeadline("Do homeworks", 5);
            taskManager.AddNewTaskWithCheckList("Finish exercise program");
            taskManager.AddNewTask("Sleep");

            //marks as completed before archiving operation
            Assert.Equal(4, taskManager.AllTasks.Count);
            task1.MarkAsCompleted();

            //archives all completed tasks
            Assert.Equal(0, taskManager.GetAllArchivedTasks().Count);
            Assert.Equal(4, taskManager.GetAllNonArchivedTasks().Count);
            taskManager.ArchiveAllCompletedTasks();

            //checks the operations result
            List<Task> allNonArchivedTasks = taskManager.GetAllNonArchivedTasks();
            Assert.Equal(3, allNonArchivedTasks.Count);
            Assert.Equal("Do homeworks", allNonArchivedTasks[0].Name);
            Assert.Equal("Finish exercise program", allNonArchivedTasks[1].Name);
            Assert.Equal("Sleep", allNonArchivedTasks[2].Name);
        }
    }
}
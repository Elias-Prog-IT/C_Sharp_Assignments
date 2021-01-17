using System.ComponentModel;
/*
	@Author Elias Posluk
    Course: DA562B, Fundamental Programming in C#
	@date 2017-11-25
	Assignment_5_task1, Different Tasks Assignment
	Kristianstad University
*/
using System.Runtime.CompilerServices;

namespace Task1
{
    public class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
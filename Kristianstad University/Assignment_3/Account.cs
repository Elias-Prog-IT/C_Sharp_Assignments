/*
	@Author Elias Posluk
    Course: DA562B, Fundamental Programming in C#
	@date 2017-10-29
	Assignment_3, Different Tasks Assignment
	Kristianstad University
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentModule3
{
    class Account
    {
        private double _balance;
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public Account()
        {
            _balance = 0;
        }

        public Account(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

         //sätter in summan som användaren vill sätta in.
         //Räntan är på 1.05%, tagen från exempelbilden
        public double Deposit(double amount)
        {
            _balance += amount * 1.05;
            return _balance;
        }

        //bool som kollar om man kan ta ut pengar
        public bool TryWithdraw(double amount)
        {
            if (amount > _balance)
            {
                return false;
            }
            _balance -= amount;
            return true;
        }
    }
}
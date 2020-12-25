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
    class HeartRates
    {
        private string _firstName;
        private string _lastName;
        private int _yearBirth;
        private int _currentYear;

        public int CurrentYear
        {
            get
            {
                return _currentYear;
            }
            set
            {
                _currentYear = value;
            }
        }

        public int YearBirth
        {
            get
            {
                return _yearBirth;
            }
            set
            {
                _yearBirth = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return 
                    _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public HeartRates()
        {}

        public HeartRates(string firstName, string lastName, int yearBirth, int currentYear)
        {
            _firstName = firstName;
            _lastName = lastName;
            _yearBirth = yearBirth;
            _currentYear = currentYear;
        }

        //kalkylerar åldern
        public int Age()
        {
            return _currentYear - _yearBirth;
        }

        //får fram högsta hjärtvärdet
        public int MaximumHeartRate()
        {
            return 220 - Age();
        }

        //får fram minimum hjärtvärde
        public double MinimumTargetHeartRate()
        {
            int maxHeartRate = MaximumHeartRate();
            return maxHeartRate * 0.5;
        }

        public double MaximumTargetHeartRate()
        {
            int maxHeartRate = MaximumHeartRate();
            return maxHeartRate * 0.85;
        }
    }
}
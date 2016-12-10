using System;

namespace Assessment.Models
{
    public class Person
    {
        public string FirstName
        {
            get { return "Johnny"; }
            set { }
        }

        public string LastName { get; set; }

        public double Age
        {
            get { return (_birthDate - DateTime.Now).TotalDays; }
        }

        private DateTime _birthDate;

        public void SetBirthdate(DateTime birthDate)
        {
            _birthDate = birthDate;
        }
    }
}
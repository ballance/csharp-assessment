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

        private string _lastName;

        public string LastName { get { return _lastName; } set {} }

        public double Age
        {
            get { return (DateTime.Now -_birthDate).Days / 365; }
        }

        private DateTime _birthDate;

        public void SetBirthdate(DateTime birthDate)
        {
            _birthDate = birthDate;
        }
    }
}
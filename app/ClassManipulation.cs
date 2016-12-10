

using System;
using Assessment.Models;

/**
* This file defines an object with some methods. Some of these methods are
* populated incorrectly; your job is to fix them. Other methods are not
* populated at all; your job is to fill them out.
*/


namespace Assessment
{
    public class ClassManipulation
    {
        public Person CreatePerson(string FirstName, string LastName, DateTime BirthDate)
        {
            var person = new Person();
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.SetBirthdate(BirthDate);
            return person;
        }
    }
}
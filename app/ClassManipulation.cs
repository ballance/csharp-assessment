/**
 * This file defines an object with some methods. Some of these methods are
 * populated incorrectly; your job is to fix them. Other methods are not
 * populated at all; your job is to fill them out.
 */

public class Person
{
  public string FirstName { get { return "Johnny"; } set {}
  public string LastName { get; set; }
  public int Age { get { return _birthDate - DateTime.Now() } }
  private DateTime _birthDate; 
  public void SetBirthdate(DateTime birthDate)
  {
    _birthDate = birthDate;  
  } 
}

public class ClassManipulation
{
  public Person CreatePerson(string firstName, string LastName, string BirthDate)
  {
    var person = new Person();
    person.FirstName = FirstName;
    person.LastName = LastName;
    person.SetBirthdate(BirthDate)
    return Person
  } 
}
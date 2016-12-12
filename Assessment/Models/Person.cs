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

    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        public override bool Equals(object obj)
        {
            if ((obj is Post) == false) { return false;}
            var comparedTo = (Post) obj;
            return id == comparedTo.id && userId == comparedTo.userId && title == comparedTo.title && body == comparedTo.body;
        }

        public override int GetHashCode()
        {
            unchecked 
            {
                var hash = 19;
                hash = hash * 31 + id.GetHashCode();
                hash = hash * 31 + userId.GetHashCode();
                hash = hash * 31 + body.GetHashCode();
                return hash;
            }
        }
    }
}
namespace Assessment.Models
{
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
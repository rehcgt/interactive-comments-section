namespace interactive_comments_section.Models
{
    public class User
    {
        public Image Image { get; set; }
        public string Username { get; set; }
        public bool isCurrentUser { get; set; }
    }

    public class Image
    {
        public string Png { get; set; }
        public string Webp { get; set; }
    }    

    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string CreatedAt { get; set; }
        public int Score { get; set; }
        public User User { get; set; }
        public List<Comment> Replies { get; set; }
    }

    public class Root
    {
        public List<Comment> Comments { get; set; }
        public User User { get; set; }
    }
}

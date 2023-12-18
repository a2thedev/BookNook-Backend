namespace FullStackAuth_WebAPI.Models
{
    public class Review
    {
        

        public int Id { get; set; }

        public string BookdId { get; set; }

        public string Text { get; set; }

        public double Rating { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}

namespace api.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Coins { get; set; }
        public int HighScore { get; set; }

    }
}

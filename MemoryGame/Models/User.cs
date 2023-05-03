namespace Models
{
    public class User
    {
        public string UserName { get; set; }
        public int Tries { get; set; }
        public int Time { get; set; }

        public User(string userName, int tries, int time)
        {
            this.UserName = userName;
            this.Tries = tries;
            this.Time = time;
        }
    }
}

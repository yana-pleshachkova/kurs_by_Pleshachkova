namespace DVDS
{
    public class Session
    {
        public int UserId { get; protected set; }
        public string Token { get; protected set; }
        public long Expires { get; protected set; }
        public int Role { get; protected set; }

        public Session(int userId, string token, long expires, int role)
        {
            UserId = userId;
            Token = token;
            Expires = expires;
            Role = role;
        }
    }
}

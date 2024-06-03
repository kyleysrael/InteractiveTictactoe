namespace UserNamespace
{
    public abstract class User
    {
        protected string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;
        }

        public bool verifyLogin(string id, string pass)
        {
            return id.Equals(this.user_id) && pass.Equals(this.user_password);
        }

        public string UserId
        {
            get { return user_id; }
        }

        public abstract void updatePassword(string newPassword);
    }

    public class Administrator : User
    {
        private string admin_name;
        private List<Player> players;

        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            this.admin_name = name;
            this.players = new List<Player>();
        }

        public override void updatePassword(string newPassword)
        {
            this.user_password = newPassword;
        }

        public void updateAdminName(string name)
        {
            this.admin_name = name;
        }

        public string AdminName
        {
            get { return admin_name; }
        }

        public bool createPlayer(string playerName, string playerId, string playerPass)
        {
            if (players.Any(p => p.verifyLogin(playerId, "")))
            {
                return false;
            }

            Player newPlayer = new Player(playerName, playerId, playerPass);
            players.Add(newPlayer);
            return true;
        }

        public bool updatePlayerPassword(string playerId, string newPassword)
        {
            var player = players.FirstOrDefault(p => p.UserId == playerId);
            if (player != null)
            {
                player.updatePassword(newPassword);
                return true;
            }
            return false;
        }

        public Player findPlayer(string playerId)
        {
            return players.FirstOrDefault(p => p.verifyLogin(playerId, ""));
        }

        public int PlayerCount
        {
            get { return players.Count; }
        }

        public bool verifyPlayerLogin(string id, string pass)
        {
            return players.Any(p => p.verifyLogin(id, pass));
        }
    }

    public class Player : User
    {
        private string player_name;

        public Player(string name, string id, string pass) : base(id, pass)
        {
            this.player_name = name;
        }

        public override void updatePassword(string newPassword)
        {
            this.user_password = newPassword;
        }
    }
}

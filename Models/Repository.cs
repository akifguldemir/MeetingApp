namespace MeetingApp.Models
{
    public static class Repository 
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Name = "Ali", Email = "ali@gmailcom", Phone = "05437769468", WillAttend = true});
            _users.Add(new UserInfo() { Name = "Ahmet", Email = "ahmet@gmailcom", Phone = "05437723235", WillAttend = false});
            _users.Add(new UserInfo() { Name = "Can", Email = "can@gmailcom", Phone = "054377236536", WillAttend = true});
        }

        public static List<UserInfo> getUsers {
            get {
                return _users;
            }
        }

        public static void addUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}
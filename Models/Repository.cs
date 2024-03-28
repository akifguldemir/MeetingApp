namespace MeetingApp.Models
{
    public static class Repository 
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id=1, Name = "Ali", Email = "ali@gmailcom", Phone = "05437769468", WillAttend = true});
            _users.Add(new UserInfo() { Id=2, Name = "Ahmet", Email = "ahmet@gmailcom", Phone = "05437723235", WillAttend = false});
            _users.Add(new UserInfo() { Id=3, Name = "Can", Email = "can@gmailcom", Phone = "054377236536", WillAttend = true});
        }

        public static List<UserInfo> getUsers {
            get {
                return _users;
            }
        }

        public static void addUser(UserInfo user)
        {
            user.Id = getUsers.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
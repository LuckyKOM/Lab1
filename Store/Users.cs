namespace Store
{
    public  class Users
    {
        public string Title { get; set; }
        public int Password { get; set; }
        public Users(string title, int password)
        {
            Title = title;
            Password = password;
        }
    }
}

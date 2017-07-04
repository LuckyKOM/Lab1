namespace Store
{
    public class Books : Product

    {
        public int NumberOfPages { get; set; }
        public string Author { get;  set; }
        public int YearOfPublish { get; set; }

        public Books()
        {

        }

    }
}

namespace c_basics_session05
{
    public enum Genre { Fiction, NonFiction, Science }

    public class Book
    {
        //Q1
        private string password = "secret";

        //Q2
        internal int copiesInStock = 5;

        //Q3
        public string Title;

        //Q4
        public Genre Genre { get; set; }
    }
}
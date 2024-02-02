namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person agatha = new Person("Agatha", "Christie", 44);

            agatha.Describe();


            Book book = new
                ("And Then There Were None",
                 agatha,
                 new DateTime(1939, 11, 6));

            book.Describe();
        }
    }
}

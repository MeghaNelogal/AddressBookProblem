namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book");
            Console.WriteLine("------WelCome To Address Book Program------");
            AddressBookMain book = new AddressBookMain();
            book.AddContacts();
            book.Display();
        }
    }
}
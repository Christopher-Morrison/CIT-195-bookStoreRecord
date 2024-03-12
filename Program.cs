using System;
namespace BookStoreRecord
{
    class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price)
        {
            public static void Main()
            {                 
                Bookstore book1 = new(1,"Harry Potter and the Philosopher's Stone", "J.K.Rowling",29.99 );
                Bookstore book2 = new(2, "The way of Kings", "Brandon Sanderson", 37.49);
                Bookstore book3 = book2 with { ID = 3, Title = "Words of Radiance",Price =  27.08};
                
                // displaying records in the unique way they can be printed
                Console.WriteLine(book1);
                Console.WriteLine(book2);
                Console.WriteLine(book3);

            }
        }
    }

}

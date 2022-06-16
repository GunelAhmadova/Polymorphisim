using System;

namespace Polimorphisim
{
    class Program
    {
        static void Main(string[] args)
        {
            Library Reader = new Library();
            Book book1 = new Book()
            {
                Name = "Siddharta",
                Author = "Hermann Hesse",
                Genre = "Fiction",
                Price = 7,
            };
            Book book2 = new Book()
            {
                Name = "idiot",
                Author = "F.Dostoyevski",
                Genre = "Classic",
                Price = 20
            };
            Journal journal1 = new Journal()
            {
                Name = "Time",
                Company = "Time Warner",
                Price = 15
            };
            Journal journal2 = new Journal
            {
                Name = "Ekinci",
                Company = "Baku magazine",
                Price = 50,
            };
            Reader.AddProduct(book1);
            Reader.AddProduct(book2);
            Reader.AddProduct(journal1);
            Reader.AddProduct(journal2);

            Console.WriteLine("1. kitablarin sayini gosterin");
            Console.WriteLine("2. jurnallarin sayini gosterin");
            Console.WriteLine("3. kitablarin siyahsini gosterin");
            Console.WriteLine("4. jurnallarin siyahsini gosterin");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine(Reader.GetBooksCount());
                    break;

              

                case "2":

                    Console.WriteLine(Reader.GetJournalsCount());

                    break;

                case "3":
                    foreach (var item in Reader.GetProducts(true))
                    {
                        Console.WriteLine(item.GetInfo());  
                    }
                    break;


                case "4":
                    foreach (var item in Reader.GetProducts(false))
                    {
                        Console.WriteLine(item.GetInfo()); 

                    }
                    break;

            }
        }
    }
}

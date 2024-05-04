using KESCHA.Classes;
namespace KESCHA
{
    class Program
    {
        static void Main()
        {   
            Book book= new Book(name: "Kiob nomi");

            Console.Write("Kitob nomini kiriting: ");
            string name = Console.ReadLine();
            book.NameBook = name;

            Console.Write("Kitob muallifini kiriting: ");
            string muallif = Console.ReadLine();

            Console.Write("Kitob narxini kiriting: ");
            int narxi = Convert.ToInt32(Console.ReadLine());

            book.KitobHaqida(muallif, narxi);
            book.KitobMuallifiHaqida(muallif);
        }
    }
}
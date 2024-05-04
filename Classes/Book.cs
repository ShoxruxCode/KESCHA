namespace KESCHA.Classes
{
    class Book
    {
        private string nameBook;
        private string muallif;
        private int narxi;
        public string NameBook 
        {
            get { return nameBook; }
            set { nameBook = value; }
        }
        public string Muallif
        {
            get{ return muallif; }
            set { muallif = value; }
        }
        public int Narxi
        {
            get { return narxi; }
            set { narxi = value; }
        }
        public Book(string name, string muallif, int narxi)
        {
            NameBook = name;
            Muallif = muallif;
            Narxi = narxi;
        }
        public Book(string name)
        {
            NameBook = name;
        }
        public void KitobHaqida(string muallif, int narxi)
        {
            Muallif = muallif;
            Narxi = narxi;
            if(narxi > 0)
            {
                Console.WriteLine($"Kitob muallifi {muallif}. Ushbu Kitobning nomi {NameBook}. Kitobning narxi {narxi} so'm");
            }
            else
            {
                Console.WriteLine("Siz kitob narxiga manfiy qiymat berdingiz");
            }
        }
        public void KitobMuallifiHaqida(string muallif)
        {
            Muallif = muallif;
            Console.WriteLine($"Kitob {muallif} ismli shaxs nomidan bosma xonaga berildi");
        }
    }
}
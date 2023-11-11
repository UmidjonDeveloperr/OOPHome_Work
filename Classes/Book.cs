namespace OOPHOMEWORK.Classes
{
    class Book
    {
        private string Name { get; set; }
        public string Autor { get; set; }
        public int Price { get; set; }
        public int price 
        { 
            get{
                return Price;
            } 
            set{
                if(price>0)
                    Price=value;
            } 
        }

        public Book()
        {
            Name="No name";
            Autor="No Autor";
            Price=0;
        }
        public Book(string name, int price)
        {
            Name=name;
            Autor="No Autor";
            Price=price;
            System.Console.WriteLine($"Name is {Name} and it is {Price} uzs!");
        }
        
        public int ValueOfBooks(int count, int price)
        {
            return count*price;
        }

    }
}
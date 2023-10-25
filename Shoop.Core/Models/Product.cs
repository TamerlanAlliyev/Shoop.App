namespace Shoop.Core.Models
{
    public class Product
    {
        private static int _id;
        public  int Id { get => _id; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Catagory { get; set; }
        public int StockCount { get; set; }
        public void GetFullInfo()
        {
            Console.WriteLine($"Name : {Name}, Price : {Price} , Catagory : {Catagory} , StockCount : {StockCount}");
        }

    }
}

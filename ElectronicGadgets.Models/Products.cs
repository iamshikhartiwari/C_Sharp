namespace ElectronicGadgets.Models{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public void GetProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Name: {ProductName}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Price: {Price:C}"); 
        }

        public void UpdateProductInfo(string description, decimal price)
        {
            Description = description;
            Price = price;
        }

        public bool IsProductInStock()
        {
            return true;
        }
    }
}

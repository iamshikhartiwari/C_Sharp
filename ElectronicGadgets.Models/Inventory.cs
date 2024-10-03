namespace ElectronicGadgets.Models{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public Product Product { get; set; }
        public int QuantityInStock { get; set; }
        public DateTime LastStockUpdate { get; set; }

        public Product GetProduct()
        {
            return Product;
        }

        public int GetQuantityInStock()
        {
            return QuantityInStock;
        }

        public void AddToInventory(int quantity)
        {
            QuantityInStock += quantity;
            LastStockUpdate = DateTime.Now;
        }

        public void RemoveFromInventory(int quantity)
        {
            QuantityInStock -= quantity;
            LastStockUpdate = DateTime.Now;
        }

        public void UpdateStockQuantity(int newQuantity)
        {
            QuantityInStock = newQuantity;
            LastStockUpdate = DateTime.Now;
        }

        public bool IsProductAvailable(int quantityToCheck)
        {
            return QuantityInStock >= quantityToCheck;
        }

        public decimal GetInventoryValue()
        {
            return QuantityInStock * Product.Price;
        }

        public void ListLowStockProducts(int threshold)
        {
            if (QuantityInStock < threshold)
            {
                Console.WriteLine($"Low stock for {Product.ProductName}: {QuantityInStock} left.");
            }
        }

        public void ListOutOfStockProducts()
        {
            if (QuantityInStock == 0)
            {
                Console.WriteLine($"Out of stock: {Product.ProductName}");
            }
        }
    }
}

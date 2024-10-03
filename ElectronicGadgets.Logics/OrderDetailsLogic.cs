using ElectronicGadgets.Models;


namespace ElectronicGadgets.Logics
{
    public class InventoryService
    {
        public void AddStock(Inventory inventory, int quantity)
        {
            inventory.AddToInventory(quantity);
            Console.WriteLine($"Added {quantity} units to {inventory.GetProduct().ProductName}. Total in stock: {inventory.GetQuantityInStock()}");
        }

        public void RemoveStock(Inventory inventory, int quantity)
        {
            if (inventory.IsProductAvailable(quantity))
            {
                inventory.RemoveFromInventory(quantity);
                Console.WriteLine($"Removed {quantity} units from {inventory.GetProduct().ProductName}. Total in stock: {inventory.GetQuantityInStock()}");
            }
            else
            {
                Console.WriteLine($"Not enough stock for {inventory.GetProduct().ProductName}. Current stock: {inventory.GetQuantityInStock()}");
            }
        }

        public void ListLowStockProducts(List<Inventory> inventories, int threshold)
        {
            foreach (var inv in inventories)
            {
                inv.ListLowStockProducts(threshold);
            }
        }

        public void ListOutOfStockProducts(List<Inventory> inventories)
        {
            foreach (var inv in inventories)
            {
                inv.ListOutOfStockProducts();
            }
        }
        
        // Additional methods for inventory management can be added here
    }
}

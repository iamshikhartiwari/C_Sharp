using ElectronicGadgets.Models;

namespace TechShop.logic
{
    public class ProductService
    {
        public void UpdateProductDescription(Product product, string newDescription)
        {
            product.UpdateProductInfo(newDescription, product.Price);
        }

        public void UpdateProductPrice(Product product, decimal newPrice)
        {
            product.UpdateProductInfo(product.Description, newPrice);
        }

        public bool CheckProductAvailability(Product product, Inventory inventory)
        {
            return inventory.IsProductAvailable(1); // Check for 1 unit availability
        }
        
        // Additional methods for product management can be added here
    }
}

using ElectronicGadgets.Models;

namespace ElectronicGadgets.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal CalculateSubtotal()
        {
            return Quantity * Product.Price;
        }

        public void GetOrderDetailInfo()
        {
            Console.WriteLine($"Order Detail ID: {OrderDetailID}");
            Console.WriteLine($"Product: {Product.ProductName}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Subtotal: {CalculateSubtotal():C}"); 
        }

        public void UpdateQuantity(int newQuantity)
        {
            Quantity = newQuantity;
        }

        public void AddDiscount(decimal discountPercentage)
        {
            // Logic to apply a discount (not implemented here)
        }
    }
}

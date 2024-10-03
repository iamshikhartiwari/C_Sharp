using ElectronicGadgets.Models;

namespace TechShop.logic
{
    public class OrderService
    {
        public void ProcessOrder(Order order, List<OrderDetail> orderDetails)
        {
            order.TotalAmount = orderDetails.Sum(detail => detail.CalculateSubtotal());
            Console.WriteLine($"Order processed. Total amount: {order.TotalAmount:C}");
        }

        public void CancelOrder(Order order, List<OrderDetail> orderDetails)
        {
            foreach (var detail in orderDetails)
            {
                detail.Product.Price += detail.CalculateSubtotal(); // Adjust stock if needed
            }
            Console.WriteLine($"Order {order.OrderID} has been canceled.");
        }

        public void UpdateOrderStatus(Order order, string status)
        {
            order.UpdateOrderStatus(status);
        }
        
        // Additional methods for order management can be added here
    }
}

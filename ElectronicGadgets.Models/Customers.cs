// namespace ElectronicGadgets.Models{
//     public class Customer
//     {
//         public int CustomerID { get; set; }
//         public string FirstName { get; set; }
//         public string LastName { get; set; }
//         public string Email { get; set; }
//         public string Phone { get; set; }
//         public string Address { get; set; }

//         public int CalculateTotalOrders()
//         {
//             return 0; 
//         }

//         public void GetCustomerDetails()
//         {
//             Console.WriteLine($"Customer ID: {CustomerID}");
//             Console.WriteLine($"Name: {FirstName} {LastName}");
//             Console.WriteLine($"Email: {Email}");
//             Console.WriteLine($"Phone: {Phone}");
//             Console.WriteLine($"Address: {Address}");
//         }

//         public void UpdateCustomerInfo(string email, string phone, string address)
//         {
//             Email = email;
//             Phone = phone;
//             Address = address;
//         }
//     }
// };


namespace ElectronicGadgets.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        
        // Method examples
        public int CalculateTotalOrders()
        {
            // Placeholder for actual calculation
            return 0;
        }

        public void GetCustomerDetails()
        {
            Console.WriteLine($"Customer: {FirstName} {LastName}, Email: {Email}, Phone: {Phone}, Address: {Address}");
        }

        public void UpdateCustomerInfo(string email, string phone, string address)
        {
            Email = email;
            Phone = phone;
            Address = address;
        }
    }
}

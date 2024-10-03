namespace ElectronicGadgets.Logics;
using ElectronicGadgets.Models;
public class Class1
{
    public class CustomerService
    {
        public void UpdateCustomerEmail(Customer customer, string newEmail)
        {
            customer.Email = newEmail;
        }

        // Add more business logic here
    }
}

/// <summary>
/// Interface Default Implementation
/// <br /><br />
/// Demonstrates default method implementations in interfaces, including
/// code reuse, backward compatibility, flexibility, and explicit interface implementation.
/// </summary>

namespace InterfaceDefaultImplementation
{
    /// <summary>
    /// Defines a customer contract with a default loyalty discount implementation.
    /// </summary>
    public interface ICustomer
    {
        int CustomerId { get; set; }

        void ApplyLoyaltyDiscount()
        {
            Console.WriteLine("Applying 10% loyalty discount.");
        }
    }

    /// <summary>
    /// Implements ICustomer and uses the default loyalty discount implementation.
    /// </summary>
    public class Customer : ICustomer
    {
        public int CustomerId { get; set; }
    }

    /// <summary>
    /// Implements ICustomer and provides a different loyalty discount implementation.
    /// </summary>
    public class VIPCustomer : ICustomer
    {
        public int CustomerId { get; set; }

        void ICustomer.ApplyLoyaltyDiscount()
        {
            Console.WriteLine(
                $"Applying 20% loyalty discount for VIP customer with ID {CustomerId}.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            ICustomer customer = new Customer
            {
                CustomerId = 101
            };

            ICustomer vipCustomer = new VIPCustomer
            {
                CustomerId = 202
            };

            customer.ApplyLoyaltyDiscount();
            vipCustomer.ApplyLoyaltyDiscount();
        }
    }
}

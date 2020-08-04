using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    class ImprovedPatternMatching
    {
        // C# 8
        public double GetDiscount(Customer customer)
        {
            return customer switch
            {
                WalkinCustomer _ => 0.1,
                OnlineCustomer onlineCustomer when onlineCustomer.Age >= 70 => 0.4,
                OnlineCustomer onlineCustomer when onlineCustomer.Age >= 60 => 0.3,
                OnlineCustomer _ => 0.2,
                null => throw new ArgumentNullException(),
                _ => throw new ArgumentException()
            };
        }












        //// C# 9
        public double GetDiscountWithImprovedPatternMatching(Customer customer)
        {
            return customer switch
            {
                WalkinCustomer => 0.1,  // Type pattern
                OnlineCustomer onlineCustomer => onlineCustomer.Age switch
                {
                    // Relational patterns
                    >= 70 => 0.4,
                    >= 60 and < 70 => 0.3, // Logical pattern
                    _ => 0.2
                },
                not null => throw new ArgumentException(), // Logical pattern
                null => throw new ArgumentNullException()
            };

            // + You can use not keyword like this:
            if (customer is not WalkinCustomer)
            {
            }
        }


    }

    class Customer
    {
        public int Age { get; set; }
    }
    class OnlineCustomer : Customer
    {

    }
    class WalkinCustomer : Customer
    {

    }
}

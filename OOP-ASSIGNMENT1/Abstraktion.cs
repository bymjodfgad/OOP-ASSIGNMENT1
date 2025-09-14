using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASSIGNMENT1
{
    abstract class PaymentMethod
    {
        public abstract void Pay(double amount); 
    }

    class CreditCard : PaymentMethod
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Betalar {amount} kr med Kreditkort");
        }
    }

    class PayPal : PaymentMethod
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Betalar {amount} kr med PayPal");
        }
    }
}

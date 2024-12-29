using System;

namespace SOLID_Principles
{
    public class D_DependencyInversionPrinciple
    {
    }
    public interface IPaymentMethod
    {
        void PaymentProcess();
    }
    public class CreditCardPayment : IPaymentMethod
    {
        public void PaymentProcess()
        {
            Console.WriteLine("Processing credit card payment.");
        }
    }
    public class PaypalPayment : IPaymentMethod
    {
        public void PaymentProcess()
        {
            Console.WriteLine("Processing paypal payment.");
        }
    }
    public class WalletPayment : IPaymentMethod
    {
        public void PaymentProcess()
        {
            Console.WriteLine("Processing wallet payment.");
        }
    }

    public class PaymentProcessor
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }
        public void Process()
        {
            _paymentMethod.PaymentProcess();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}

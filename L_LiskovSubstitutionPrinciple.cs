using System;

namespace SOLID_Principles
{
    internal class L_LiskovSubstitutionPrinciple
    {
    }

    public class Customer
    {
        public virtual double GetRoomRate(double baseRate)
        {
            return baseRate;
        }
    }

    public class PremiumMember: Customer
    {
        public override double GetRoomRate(double baseRate)
        {
            return baseRate * 0.8; // Premium members get a 20% discount
        }
    }

    public class CorporateMember: Customer
    {
        public override double GetRoomRate(double baseRate)
        {
            // throw new NotImplementedException("Corporate members must use a corporate account."); - uncomment to Violate LSP
            return baseRate * 0.7; // Corporate members get a 30% discount
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            double baseRate = 100;

            // Regular guests
            Customer regularGuest = new Customer();
            Console.WriteLine("Regular guest room rate: $" + regularGuest.GetRoomRate(baseRate));

            // Premium members
            Customer premiumMember = new PremiumMember();
            Console.WriteLine("Premium member room rate: $" + premiumMember.GetRoomRate(baseRate));

            // Corporate members
            Customer corporateMember = new CorporateMember();
            Console.WriteLine("Corporate member room rate: $" + corporateMember.GetRoomRate(baseRate));
        }
    }
}

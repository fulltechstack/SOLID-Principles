using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    internal class O_OpenClosedPrinciple
    {
    }

    public abstract class Discount
    {
        public abstract double ApplyDiscount(double billAmount);
    }

    public class FlatDiscount : Discount
    {
        public override double ApplyDiscount(double billAmount) {
            return billAmount - 10; // Flat $10 discount
        }
    }

    public class PercentageDiscount: Discount
    {
        public override double ApplyDiscount(double billAmount)
        {
            return billAmount * 0.9; // 10% discount
        }
    }

    public class SeasonalDiscount: Discount
    {
        public override double ApplyDiscount(double billAmount)
        {
            return billAmount * 0.8; // 20% discount
        }
    }

    public class DiscountCalculator
    {
        public double CalculateDiscount(Discount discount, double billAmount)
        {
            return discount.ApplyDiscount(billAmount);
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            double billAmount = 100;

            Discount flatDiscount = new FlatDiscount();
            DiscountCalculator calculator = new DiscountCalculator();
            Console.WriteLine("Flat discount: " + calculator.CalculateDiscount(flatDiscount, billAmount));

            Discount percentageDiscount = new PercentageDiscount();
            Console.WriteLine("Percentage discount: " + calculator.CalculateDiscount(percentageDiscount, billAmount));
        }
    }
}

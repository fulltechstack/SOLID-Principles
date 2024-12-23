using System;

namespace SOLID_Principles
{
    internal class S_SingleResponsibilityPrinciple
    {
    }

    public class Chef
    {
        public void PrepareFood()
        {
            Console.WriteLine("Cooking food...");
        }

    }

    public class Receptionist
    {
        public void ManageBookings()
        {
            Console.WriteLine("Manage table bookings...");
        }
    }
}

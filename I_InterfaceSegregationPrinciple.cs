using System;

namespace SOLID_Principles
{
    public class I_InterfaceSegregationPrinciple
    {
    }

    //public interface IHotelServices
    //{
    //    void BookRoom();
    //    void OrderFood();
    //    void ManageEvent();
    //}

    public interface IRoomBookingService
    {
        void BookRoom();
    }
    public interface IFoodOrderingService
    {
        void OrderFood();
    }
    public interface IEventManagementService
    {
        void ManageEvent();
    }

    public class RegularGuest : IRoomBookingService
    {
        public void BookRoom()
        {
            Console.WriteLine("Room booked successfully");
        }
    }

    public class EventClient : IEventManagementService
    {
        public void ManageEvent()
        {
            Console.WriteLine("Event managed successfully");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            IRoomBookingService regularGuest = new RegularGuest();
            regularGuest.BookRoom();

            IEventManagementService eventClient = new EventClient();
            eventClient.ManageEvent();
        }
    }
}

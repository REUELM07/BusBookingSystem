using System;

class BusBookingApp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Smart Bus Booking System");

        Console.Write("Enter your name: ");
        string passengerName = Console.ReadLine();

        Console.Write("Enter route (Chandigarh to Delhi): ");
        string routeChoice = Console.ReadLine();

        Console.WriteLine("Checking available buses...");

        Console.WriteLine("Seat booked successfully for " + passengerName);
        Console.WriteLine("Route selected: " + routeChoice);

        Console.WriteLine("Tracking bus location: Sector 17 Bus Stand");
    }
}
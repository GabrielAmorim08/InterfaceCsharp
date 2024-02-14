using System.Globalization;
using Entites;
using InterfaceCsharp;
System.Console.WriteLine("Enter rental data: ");
System.Console.WriteLine("Car model: ");
String model = Console.ReadLine();
System.Console.WriteLine("Pickup (dd/MM/yyy hh:ss): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
System.Console.WriteLine("Return (dd/MM/yyy hh:ss): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start,finish, new Vehicle(model));
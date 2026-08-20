namespace OOP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical 
            #region Q1  Object Copying
            //a) What happens when you assign one object variable to another object variable?
            //get a copy from reference to the same object

            //b) Does assigning one object to another create a new object? Explain.
            //No, get a copy from reference to the same object

            //c) What is the difference between copying an object and copying its reference?
            //Copying the reference: Both variables refer to the same object.
            //Copying the object:separate object is created with copied data.
            #endregion
            #region Q2  Shallow Copy vs Deep Copy
            //a) What is a Shallow Copy?
            //creates a new object and copies the values of the old object (top level alone)

            //b) What is a Deep Copy?
            //creates a new seperate object and creates new copies of values from old object.

            //c) What happens to reference-type members when a Shallow Copy is created?
            // refer to the same object (but sting no because immutable)

            //d) What happens to reference-type members when a Deep Copy is created?
            //create seperate object 

            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            // when need to create completely independent version of objects.
            #endregion
            #region Q3  Static Members
            //a) What is a static field, and how is it different from an instance field?
            //belongs to the class itself and There is only one shared copy of it for all objects.
            // but instance field belongs to each object separately

            //b) What is a static method? Can a static method directly access instance members?
            //belongs to the class and can be called without creating an object,Nooooooooo

            //c) What is a static constructor, and when is it executed?
            // used to initialize static members,It is executed automatically once, before the class is used for the first time.

            //d) What is a static class? Can you create an object from a static class?
            //contains only static members,Noooooo
            #endregion
            #region Q4  Extension Methods
            //a) What is an Extension Method?
            // allows you to add a new method to an existing class without modifying the original class.

            //b) What keyword must be used in the first parameter of an extension method?
            //this

            //c) Where must an extension method be declared?
            //inside a static class.

            //d) Can an extension method access private members of the class it extends?
            //Nooooo


            #endregion
            #region Q5  Partial Classes and Partial Methods
            //a) What is a Partial Class?
              //allows you to split one class into multiple files. The compiler combines all parts into one class.

            //b) Why would a developer split one class into multiple files?
              //To organize the code and easy to maintain it.

            //c) What is a Partial Method?
              // method declared in one part of a partial class and its implementation in another part.

            //d) What happens if a declared partial method has no implementation?
              //no effect
            #endregion
            #endregion
            #region practical

            //string deliveryCenter = "Cairo";
            //Console.WriteLine("\n=========================================");
            //Console.WriteLine($"Delivery Center: {deliveryCenter} ");
            //Console.WriteLine("======================================");

            //    string driverName = "Osama Ahmed";
            //    center.Driver = driverName;


            //    Console.WriteLine($"\nDriver : {driverName}");


            //    Console.WriteLine("\n------------------------------------------");

            DeliveryCenter center = new DeliveryCenter();

            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Smart Delivery Management System");
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("\n");
            Shipment shipment = new Shipment();
            Console.WriteLine("\n");
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Creating Shipments...");
            DeliveryUtilities.PrintSeparator();
            #region Standard


            Console.WriteLine("\nEnter Standard Shipment Data");

            Console.Write("Tracking Code: ");
            string trackingCode01 = Console.ReadLine()!;

            Console.Write("Description: ");
            string description01 = Console.ReadLine()!;

            Console.Write("Weight: ");
            double weight01 = double.Parse(Console.ReadLine()!);

            Console.Write("Delivery Fee: ");
            decimal deliveryFee01 = decimal.Parse(Console.ReadLine()!);

            Console.Write("City: ");
            string city01 = Console.ReadLine()!;

            Console.Write("Street: ");
            string street01 = Console.ReadLine()!;

            Console.Write("Building Number: ");
            int buildingNumber01 = int.Parse(Console.ReadLine()!);

            Console.Write("Tracking Status: ");
            string trackingStatus01 = Console.ReadLine()!;

            DeliveryAddress address01 = new DeliveryAddress(city01, street01, buildingNumber01);

            StandardShipment standard = new StandardShipment(
                trackingCode01,
                description01,
                weight01,
                deliveryFee01,
                address01);

            standard.TrackingStatus = trackingStatus01;

            if (center.AddShipment(standard))
            {
                Console.WriteLine("Standard Shipment Created.");
            }
            else
            {
                Console.WriteLine("Delivery Center is Full.");
            }


            #endregion
            #region Express 
            Console.WriteLine("\nEnter Express Shipment Data");

            Console.Write("Tracking Code: ");
            string trackingCode02 = Console.ReadLine()!;

            Console.Write("Description: ");
            string description02 = Console.ReadLine()!;

            Console.Write("Weight: ");
            double weight02 = double.Parse(Console.ReadLine()!);

            Console.Write("Delivery Fee: ");
            decimal deliveryFee02 = decimal.Parse(Console.ReadLine()!);

            Console.Write("City: ");
            string city02 = Console.ReadLine()!;

            Console.Write("Street: ");
            string street02 = Console.ReadLine()!;

            Console.Write("Building Number: ");
            int buildingNumber02 = int.Parse(Console.ReadLine()!);

            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine()!);

            Console.Write("Tracking Status: ");
            string trackingStatus02 = Console.ReadLine()!;

            DeliveryAddress address02 = new DeliveryAddress(city02, street02, buildingNumber02);

            ExpressShipment express = new ExpressShipment(trackingCode02, description02, weight02, deliveryFee02,
                address02, extraFee);

            express.TrackingStatus = trackingStatus02;

            if (center.AddShipment(express))
            {
                Console.WriteLine("Express Shipment Created.");
            }
            else
            {
                Console.WriteLine("Delivery Center is Full.");
            }
            #endregion
            #region International
            Console.WriteLine("\nEnter International Shipment Data");

            Console.Write("Tracking Code: ");
            string trackingCode03 = Console.ReadLine()!;

            Console.Write("Description: ");
            string description03 = Console.ReadLine()!;

            Console.Write("Weight: ");
            double weight03 = double.Parse(Console.ReadLine()!);

            Console.Write("Delivery Fee: ");
            decimal deliveryFee03 = decimal.Parse(Console.ReadLine()!);

            Console.Write("City: ");
            string city03 = Console.ReadLine()!;

            Console.Write("Street: ");
            string street03 = Console.ReadLine()!;

            Console.Write("Building Number: ");
            int buildingNumber03 = int.Parse(Console.ReadLine()!);

            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine()!);

            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine()!;

            Console.Write("Tracking Status: ");
            string trackingStatus03 = Console.ReadLine()!;

            DeliveryAddress address03 = new DeliveryAddress(city02, street02, buildingNumber02);

            InternationalShipment International = new InternationalShipment(trackingCode03, description03, weight03, deliveryFee03,
                address03, customsFee, destinationCountry);

            International.TrackingStatus = trackingStatus03;
            if (center.AddShipment(International))
            {
                Console.WriteLine("International Shipment Created");
            }
            else
            {
                Console.WriteLine("Delivery Center is Full.");
            }
            #endregion

            Console.WriteLine("\n");

            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Object Copying");
            DeliveryUtilities.PrintSeparator();

            Shipment shipment2 = standard;

            Console.WriteLine($"Original Shipment  : {standard.TrackingCode}");
            Console.WriteLine($"Assigned Shipment  : {shipment2.TrackingCode}");

            Console.WriteLine();
            Console.WriteLine($"Same Object : {ReferenceEquals(standard, shipment2)}");

            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Shallow Copy");
            DeliveryUtilities.PrintSeparator();

            //Shipment shallow = standard.ShallowCopy();
            //Console.WriteLine($"Original Shipment Address : {standard.Destination.city}");
            //Console.WriteLine($"Copied Shipment Address   : {shallow.Destination.city}\n");

            //Console.WriteLine("Changing copied shipment address...\n");

            //shallow.Destination.city = "Giza";

            //Console.WriteLine($"Original Shipment Address : {standard.Destination.city}");
            //Console.WriteLine($"Copied Shipment Address   : {shallow.Destination.city}\n");


            //Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(standard.Destination, shallow.Destination)}");


            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Deep Copy");
            DeliveryUtilities.PrintSeparator();

            Shipment deep = standard.DeepCopy();
            Console.WriteLine($"Original Shipment Address : {standard.Destination.city}");
            Console.WriteLine($"Copied Shipment Address   : {deep.Destination.city}\n");

            Console.WriteLine("Changing copied shipment address...\n");

            deep.Destination.city = "Giza";

            Console.WriteLine($"Original Shipment Address : {standard.Destination.city}");
            Console.WriteLine($"Copied Shipment Address   : {deep.Destination.city}\n");


            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(standard.Destination, deep.Destination)}");


            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Extension Methods");
            DeliveryUtilities.PrintSeparator();


            Console.WriteLine(standard.GetSummary());
            Console.WriteLine(express.GetSummary());
            Console.WriteLine(International.GetSummary());

            Console.WriteLine($"{standard.TrackingCode} Is Delivered : {standard.IsDelivered()}");
            Console.WriteLine($"{International.TrackingCode} Is Delivered : {International.IsDelivered()}");


            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Tracking Status");
            DeliveryUtilities.PrintSeparator();

            standard.TrackingStatus = "Out For Delivery";

            Console.WriteLine($"Tracking status changed to: {standard.TrackingStatus}");


            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Static Utilities");
            DeliveryUtilities.PrintSeparator();


            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle();
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("\n");

            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");


            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Partial Method");
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("\n");

            standard.TrackingStatus = "Delivered";

            Console.WriteLine($"Tracking status changed to: {standard.TrackingStatus}");

            Console.WriteLine("\n");
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Assignment Completed");
            DeliveryUtilities.PrintSeparator();









            //center.PrintAllShipments();


            //ITrackable[] Items =
            //{
            //         new StandardShipment( trackingCode01,description01,weight01,deliveryFee01,address01),
            //             new ExpressShipment(trackingCode02, description02, weight02, deliveryFee02,address02, extraFee),
            //              new InternationalShipment(trackingCode03, description03, weight03, deliveryFee03,
            //            address03, customsFee, destinationCountry)
            //};


            //Console.WriteLine("\n======================================");
            //Console.WriteLine("Tracking Status\n");
            //center.PrintTrackingStatuses(Items);


            //Console.WriteLine("\n======================================");
            //Console.WriteLine("Insurance\n");
            //center.printIInsurableCosts(Items);

            //Console.WriteLine("\n======================================\n");

            //Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");


            //    Console.WriteLine("\n======================================");
            //    Console.Write("\n\nPrinting Using DeliveryHelper...\n\n");

            //    Shipment[] shipments = new Shipment[]
            //    {
            //            new StandardShipment( trackingCode01,description01,weight01,deliveryFee01,address01),
            //             new ExpressShipment(trackingCode02, description02, weight02, deliveryFee02,address02, extraFee),
            //              new InternationalShipment(trackingCode03, description03, weight03, deliveryFee03,
            //            address03, customsFee, destinationCountry)
            //};
            //    foreach (Shipment shipment in shipments)
            //    {
            //        DeliveryHelper.PrintShipmentDetails(shipment);
            //        Console.WriteLine($"\n{shipment.Name} Printed Successfully.");
            //    }

            //    Console.WriteLine("\n======================================");
            //    Console.Write("\n\nUpdating Weight...\n\n");

            //    Shipment sh = new Shipment("Sh102");
            //    double OriginalWeight = 3;
            //    Console.WriteLine($"Original Weight : {OriginalWeight} KG\n");

            //    sh.weightUpdate(5);

            //    Console.WriteLine($"Updated Weight : {sh.Weight} KG\n");

            //    sh.weightUpdate(sh.Weight, 0.5);

            //    Console.WriteLine($"Updated Weight After Packing : {sh.Weight} KG\n");




            //    Console.WriteLine("\n======================================");
            //    Console.Write("\n\nPrinting Using Shipment[]...\n\n");


            //    foreach (Shipment shipment in shipments)
            //    {
            //       shipment.PrintShipment();
            //    }
            //    Console.WriteLine("\n======================================");







            #endregion
        }
    }
}

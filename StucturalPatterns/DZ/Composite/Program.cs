using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //create xml file
            //XDocument xDoc = new XDocument();

            //XElement Car = new XElement("Car");
            //XElement NameCar = new XElement("name","Honda");
            //XElement ModelCar = new XElement("model", "Civic");
            //XElement YearCar = new XElement("year", "1999");
            //XElement costCar = new XElement("price", "3000");
            //Car.Add(NameCar, ModelCar, YearCar, costCar);

            //XElement Car1 = new XElement("Car");
            //XElement NameCar1 = new XElement("name", "Nissan");
            //XElement ModelCar1 = new XElement("model", "180sx");
            //XElement YearCar1 = new XElement("year", "1995");
            //XElement costCar1 = new XElement("price", "50000");
            //Car1.Add(NameCar1, ModelCar1, YearCar1, costCar1);

            //XElement Car2 = new XElement("Car");
            //XElement NameCar2 = new XElement("name", "Toyota");
            //XElement ModelCar2 = new XElement("model", "Supra");
            //XElement YearCar2 = new XElement("year", "1998");
            //XElement costCar2 = new XElement("price", "10000");
            //Car2.Add(NameCar2, ModelCar2, YearCar2, costCar2);

            //XElement Cars = new XElement("Cars");
            //Cars.Add(Car, Car1, Car2);

            //xDoc.Add(Cars);

            //xDoc.Save("Cars.xml");


            //XDocument xDoc = XDocument.Load("Cars.xml");
            //foreach (XElement item in xDoc.Element("Cars").Elements("Car"))
            //{
            //    XElement name = item.Element("name");
            //    XElement model = item.Element("model");
            //    XElement year = item.Element("year");
            //    XElement price = item.Element("price");

            //    if (name != null && model != null && year != null && price != null)
            //    {
            //        Console.WriteLine("Name {0} Model {1} Year {2} Cost - {3}",
            //            name.Value,model.Value,year.Value,price.Value);

            //    }
            //}

            var car1 = new Car() { CarMark = "Porshe", CarModel = "911", CarYear = "1990" };
            var xmlCar1 = new XMLCar("Coupe", car1);
            var car2 = new Car() { CarMark = "Porshe", CarModel = "Carerra", CarYear = "1985" };
            var xmlCar2 = new XMLCar("Targa", car2);
            var car3 = new Car() { CarMark = "Porshe", CarModel = "911", CarYear = "2016" };
            var xmlCar3 = new XMLCar("Cabriolet", car3);


            var xmlCars = new XMLCars() { Name = "Porshes" };
            xmlCars.Add(xmlCar1);
            xmlCars.Add(xmlCar2);
            xmlCars.Add(xmlCar3);
            xmlCars.Print();



            Console.ReadKey();
        }
    }
}

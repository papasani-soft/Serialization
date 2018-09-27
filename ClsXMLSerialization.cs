using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Serialization
{
    public class XMLSerialization
    {
        public  void CreateSerialize()
        {
            XmlSerializer serialization = new XmlSerializer(typeof(Product));
            Product car = new Product("BMW", 1, 10000000);
            serialization.Serialize(Console.Out, car);
            Console.ReadLine();
        }
    }
    public class Product
    {
        [XmlElementAttribute("Name")]
        public string name;
        [XmlAttributeAttribute("Quantity")]
        public int quantity;
        [XmlAttributeAttribute("Price")]
        public int price;
        public Product()
        { }
        
        public Product(string name, int quantity, int price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Serialization
{
    public class XMLWrite
    {
        public class Book
        {
            public String title;
        }
        public void WriteXML()
        {
            Book overview = new Book();
            overview.title = "Serialization Overview";
            XmlSerializer writer = new XmlSerializer(typeof(Book));


            FileStream file = File.Create("f:/serialxmldemo.xml");

            writer.Serialize(file, overview);
            file.Close();
            Console.WriteLine("Xml serialization complete");
            Console.ReadLine();
        }
        public void CreateXml()
        {
            XMLWrite x = new XMLWrite();
            x.WriteXML();
        }
    }
}

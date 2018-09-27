using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Serialization
{
    class ReadXML
    {
        public  void ReadXMLFile()
        {
            XMLWrite.Book b = new XMLWrite.Book { title = "Serialization Overview" };
            XmlSerializer writer = new XmlSerializer(typeof(XMLWrite.Book));
            StreamWriter wfile = new StreamWriter(@"e://serialxmldemo.xml");
            writer.Serialize(wfile, b);
            wfile.Close();

            // Now we can read the serialized book ...  
            XmlSerializer reader =
                new XmlSerializer(typeof(XMLWrite.Book));
            StreamReader file = new StreamReader(
                @"e://serialxmldemo.xml");
            XMLWrite.Book overview = (XMLWrite.Book)reader.Deserialize(file);
            Console.WriteLine("title=" + overview.title);
            Console.ReadLine();
            file.Close();

            Console.WriteLine(overview.title);
        }
        public void CreateXML()
        {
            ReadXML x = new ReadXML();
            x.ReadXMLFile();
            
        }
    }
}

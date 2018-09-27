using System;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter program no. to execute");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Serialization obj1 = new Serialization();
                    obj1.CreateSerialize();
                    break;
                case 2:
                    Serialization1 obj2 = new Serialization1();
                    obj2.CreateSerialize();
                    break;
                case 3:
                    Serialization2 obj3 = new Serialization2();
                    obj3.CreateSerialize1();
                    break;
                case 4:
                    XMLSerialization obj4 = new XMLSerialization();
                    obj4.CreateSerialize();
                    break;
                case 5:
                    XMLWrite obj5 = new XMLWrite();
                    obj5.CreateXml();
                    break;
                case 6:
                    ReadXML obj6 = new ReadXML();
                    obj6.CreateXML();
                    break;
                case 7:
                    Deserial_Demo obj7 = new Deserial_Demo();
                    obj7.CreateDesrialize();
                    break;
                case 8:
                    string filename = "F:/file.txt";
                    DataContract.Serialize(filename);
                    break;
                default:
                    break;
            }
            Console.Read();
        }
    }
}

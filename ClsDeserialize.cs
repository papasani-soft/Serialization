using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Serialization
{
    [Serializable]
    class Deserial_Demo
    {
        public void CreateDesrialize()
        {
            FileStream fs = new FileStream("f://serial_demo.txt", FileMode.Open);
            BinaryFormatter bfm = new BinaryFormatter();
            Serail_demo sr = (Serail_demo)bfm.Deserialize(fs);
            Console.WriteLine("std_id = " + sr.std_id);
            Console.WriteLine("std_name= " + sr.std_name);
            Console.ReadLine();
        }
    }
}

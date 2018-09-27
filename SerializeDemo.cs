using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Serialization
{
    [Serializable]
    class Serail_demo
    {
        public int std_id;
        public string std_name;
        public Serail_demo(int std_id, string std_name)
        {
            this.std_id = std_id;
            this.std_name = std_name;
        }
        public static void Main(string[] args)
        {
            FileStream fs = new FileStream("f://serial_demo.txt", FileMode.OpenOrCreate);
            BinaryFormatter bfm = new BinaryFormatter();
            Serail_demo sr = new Serail_demo(101, "anji");
            bfm.Serialize(fs, sr);
            fs.Close();
            Console.WriteLine("Serialization completed");
            Console.ReadLine();
        }
    }
}

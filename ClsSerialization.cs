using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Serialization
{
    [Serializable]
    public class MyObject
    {
        public int n1 = 0;
        public int n2 = 0;
        public String str = null;
    }
    public class Serialization
    {
        public void CreateSerialize()
        {
            MyObject obj = new MyObject();
            obj.n1 = 1;
            obj.n2 = 24;
            obj.str = "Some String";
            IFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, obj);
            stream.Close();
        }  
    }
}

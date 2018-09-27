using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Serialization
{
    [Serializable]
    public class MyObject1
    {
        public int n1;
        [NonSerialized] public int n2;
        public String str;
    }
    public class Serialization2
    {
        public void CreateSerialize1()
        {
            MyObject1 obj = new MyObject1();
            obj.n1 = 1;
            obj.n2 = 24;
            obj.str = "Some String";
            IFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("MyFile1.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, obj);
            stream.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Serialization
{
    [Serializable]
    class Student
    {
        int rollno;
        string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    public class Serialization1
    {
        public  void CreateSerialize()
        {
            FileStream stream = new FileStream("f:\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s = new Student(101, "sonoo");
            formatter.Serialize(stream, s);
            stream.Close();
        }
    }
}

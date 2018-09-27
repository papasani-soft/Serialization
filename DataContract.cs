using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Serialization
{
    public class Student1
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }
    class DataContract
    {
       
        public static void Serialize(string filename)
        {
            Student1 student = new Student1();
            student.Name = "TestName";
            student.Salary = 700;
            student.Address = "TestAddress";
            using (FileStream ioStream = new FileStream(filename, FileMode.Create))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(Student));
                serializer.WriteObject(ioStream, student);
            }
        }
    }
}

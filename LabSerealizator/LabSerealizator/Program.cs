using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace LabSerealizator
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Vasya", "a1234", "OOP", 23, 4.5);
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("student.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, student1);

                Console.WriteLine("Объект сериализован Binary");
            }

            using (FileStream fs = new FileStream("student.dat", FileMode.OpenOrCreate))
            {
                Student newPerson = (Student)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован ");
                Console.WriteLine("Name: {0} --- ID: {1} --TEAM :{2}---CODE :{3}--MARK :{4}",student1.name,student1.id,student1.team,student1.code,student1.mark);
            }

            SoapFormatter formatter2 = new SoapFormatter();
            
            using (FileStream fs = new FileStream("student.soap", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, student1);

                Console.WriteLine("Объект сериализован SOAP");
            }

            XmlSerializer formattexml = new XmlSerializer(typeof(Student));

           
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, student1);

                Console.WriteLine("Объект сериализован xml");
            }







            Console.ReadLine();
        }
    }
}

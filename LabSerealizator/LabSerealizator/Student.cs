using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.IO;

namespace LabSerealizator
{
     [Serializable]
   public  class Student
    {
        public string name { get; set; }
        public string id { get; set; }
        public string team { get; set; }
        public int code { get; set; }
        public double mark { get; set; }

        public Student(string name, string id, string team, int code, double mark)
        {
            this.name = name;
            this.id = id;
            this.team = team;
            this.code = code;
            this.mark = mark;
        }
        public Student()
        {
            name = "none";
            id = "none";
            team = "none";
            code = 0;
            mark = 0;
        }
    }
}

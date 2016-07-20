using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportPanelProject
{
  public   class Passenger:Airport,IAirport
  {
       
        public PasName Name { get; set; }
        public string Pasport { get; set; }
        public string National { get; set; }
        public BethDate Birthday { get; set; }
        public Sex _Sex { get; set; }
       // public Airplane plane;
        public string plane_num { get; set; }
        public Bus_econ comf{ get; set; }
        public double price { get; set; }
        

        public Passenger()
        {
            Name = new PasName();
            Pasport = "none";
            National = "none";
            _Sex = Sex.Indefined;
            Birthday = new BethDate();
            comf = Bus_econ.Indefened;
            plane_num = "none";
            price = 0.00;
        }
        public Passenger(PasName test )
        {
            Name = new PasName(test.first_name,test.second_name);// { first_name = test.first_name, second_name = test.second_name };
            Pasport = "none";
            National = "none";
            _Sex = Sex.Indefined;
            Birthday = new BethDate();
            comf = Bus_econ.Indefened;
            plane_num = "none";
            price = 0.00;
        }

        public struct PasName
        {
           public  string first_name;
           public  string second_name;
           public PasName(string first , string second )
           {
               first_name = first;
               second_name = second;
           }
          
         
        }


        public struct BethDate
        {
           public  int day;
           public  month _month;
           public  string year;
           public BethDate(int d, month m, string y)
           {
               day = d;
               _month = m;
               year = y;
           }

        }

     


        

        public static Passenger EnterPassenger()
        {
            Passenger passenger = new Passenger();
            Console.WriteLine("Vvedit nomer reysu:");
            string reus = Console.ReadLine();
            reus.ToUpper();
            if (reus.Length <= 6)
            {
                passenger.plane_num = reus;
            }
            else
            {
                passenger.plane_num = "none";
            }
           
            passenger.Name = EnterName();
            Console.WriteLine("Vvedit nomer pasportu:");
            string str = Console.ReadLine();
            if (str.Length > 6 && str.Length<16)
            {
                passenger.Pasport = str;
            }
            else
            {
                passenger.Pasport = "none";
            }
            Console.WriteLine("Vvedit gromadyanstvo:");
            string str2 = Console.ReadLine();
            if (str2.Length>1 && str2.Length < 30)
            {
                passenger.National = str2;
            }
            else
            {
                passenger.National = "none";
            }
            Console.WriteLine("Vvedit stat': Indefined = 0, male=1, famaly=2");
            int pol = Airport.EnterInt();
            if (pol > 0 && pol < 3)
            {
                passenger._Sex = (Sex)pol;
            }
            else
            {
                passenger._Sex = Sex.Indefined;
            }
            Console.WriteLine("VVedit daty narodjennya:");
            passenger.Birthday = EnterDate();
            Console.WriteLine("Vvedit klas komfortu:business=1, economy=2");
            int comf = Airport.EnterInt();
            if (comf > 0 && comf < 3)
            {
                passenger.comf = (Bus_econ)comf;
            }
            else { passenger.comf = Bus_econ.Indefened; }
            Console.WriteLine("Vvedit vartist' kvutka:");
            passenger.price = Airport.EnterDouble();
            return passenger;
        }

        public void ShowPassenger()
        {
            if (!String.IsNullOrEmpty(this.Name.first_name) || !String.IsNullOrEmpty(this.Name.second_name) )
            Console.WriteLine("Nomer reysu:{0} |Imya:{1} |Prizvuche:{2} |Gromadyanstvo:{3} |Pasport:{4} |Stat':{5} |Date narodjennya:{6} {7},{8} |klass:{9}|vartist':{10}|",
                              this.plane_num,this.Name.first_name, this.Name.second_name, this.National, this.Pasport, this._Sex, this.Birthday.day,
                                             this.Birthday._month, this.Birthday.year, this.comf,this.price);
        }

        public void DeletePassenger()
        {
            this.Name = new PasName();
            this.Pasport = "none";
            this.National = "none";
            this._Sex = Sex.Indefined;
            this.Birthday = new BethDate();
            this.comf = Bus_econ.Indefened;
            this.plane_num = "none";
            this.price = 0.00;

        }


        public static PasName EnterName()
        {
            PasName name = new PasName();
            Console.WriteLine("Vvedit imya:");
            string str = Console.ReadLine();
            if (str.Length < 20)
            {
                name.first_name = str;
            }
            else
            {
                name.first_name = str.Remove(15);
            }
            Console.WriteLine("Vvedit prizvuche:");
            string str2 = Console.ReadLine();
            if (str2.Length < 20)
            {
                name.second_name = str2;
            }
            else
            {
                name.second_name = str2.Remove(20);
            }
            return name;  

        }

        public static BethDate EnterDate()
        {
            BethDate _date = new BethDate();
            Console.WriteLine("Vvedit den':");
            int d = Airport.EnterInt();
            if (d > 0 && d <= 31)
            {
                _date.day = d;
            }
            else { _date.day = -1; }
            Console.WriteLine("vvedit misayc chuslom vid 1 do 12':");
            int m = Airport.EnterInt();
            if (m > 0 && m <= 12)
            {
                _date._month = (month)m;
            }
            else { _date._month = month.Indefined; }
            Console.WriteLine("Vvedit rik:");
            string year = Console.ReadLine();
            if (year.Length == 4 &&( year.StartsWith("19")||year.StartsWith("20")))
            {
                _date.year = year;
            }
            else
            { _date.year = "Indefended"; }
            return _date;
        }

       




          
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportPanelProject
{
 
  public   enum month { Indefined = 0, January, Feb, March, April, May, June, July, August, September, October, November, December, };
  public   enum Bus_econ { Indefened = 0, business, economy, };
  public   enum Port { Indefined = 0, Kiev = 1, Lviv, Hharkiv, Odessa, Varshava, Rome, Stambul, Oslo, Kair, }
  public   enum Terminal { Indefened = 0, A, B, C, D, }
  public   enum Aircompany { Indefended = 0, MAY, GBA, TAI, OdessaAir, LvivAir, }
  public   enum Status { Indefended = 0, registraciya,gotov_do_vulyotu,vuletiv,vidmineno,vidletiv_do, zatrumka,chekaetsya_na, v_polyoti, }
  public   enum Sex { Indefined = 0, male, famaly, }
       

  public    class Airplane:Airport,IAirport
    {
        public string Number{ get;set;}
        public Date Date_in { get; set; } //прибуття до нас
        public Time Time_in { get; set; }
        public Date Date_out { get; set; }//виліт від нас
        public Time Time_out { get; set; }
        public Date Date_finish { get; set; }//прибуття в пункт призначення
        public Time Time_finish { get; set; }
        public Port Port_from { get; set; }
        public Port Port_to { get; set; }
        public Terminal Terminal_out { get; set; }//термінал виліту
       // public Terminal Terminal_in { get; set; }//термінал прибуття
        public Status status { get; set; }
        public Aircompany Company { get; set; }
       // public Comfort Seats { get; set; }
        public  Passenger[] number_passenger;

        public Airplane()
        {
            this.Number = "None";
            Date_in = new Date();

            Time_in = new Time();

            Date_out = new Date();

            Time_out = new Time();

            Date_finish = new Date();

            Time_finish = new Time();

            Port_from = new Port();

            Port_to = new Port();

            Terminal_out = new Terminal();

            //Terminal_in = new Terminal();

            status = new Status();

            Company = new Aircompany();
            number_passenger = new Passenger[40];
            for (int i = 0; i < number_passenger.Length;i++ )
            {
                number_passenger[i] = new Passenger();
            }
            // Comfort Seats = new Comfort();

        }


              public struct Date
        {
           public  int day;
         
           public  month _month;
           public  string year;

           public Date(int d,month m,string y)
           {
               this.day = d;
               _month = m;
               year = y;
           }
            
        }  
       
    
       
        
        


        public struct Time
        {
           public  int hour;
           public  int minute;
           public Time(int h, int m)
           {
               hour = h;
               minute = m;
           }
            
        }


       

      
    


        public static Airplane EnterFlightFrom()
        {
            Airplane plane=new Airplane();
            Console.WriteLine("Enter Number of plane:");
            plane.Number = Console.ReadLine();
            plane.Number.ToUpper();
            Console.WriteLine("Vvedit status reysu:");
            Console.WriteLine("Indefended = 0, vidmineno=4, zatrumka=6,chekaetsya_na=7, v_polyoti=8");
            int st =Airport.EnterInt();
            if (st==4||st==6||st==7||st==8)
            {
                plane.status= (Status)st;
               
            }
            else 
            {
                plane.status =Status.Indefended;
            }
            Console.WriteLine("Vvedit daty prubyt'a:");
            plane.Date_in = EnterDate();
            Console.WriteLine("Vvedit chas prubyt'a:");
            plane.Time_in = EnterTime();
            Console.WriteLine("Z yakogo porty letut' do Kueva:");
            Console.WriteLine("Indefined = 0, Lviv=2, Hharkiv=3, Odessa=4, Varshava=5, Rome=6, Stambul=7, Oslo=8, Kair=9");
            int p =Airport.EnterInt();
            if (p > 1 && p <10)
            {
                plane.Port_from = (Port)p;
            }
            else
            {
                plane.Port_from = Port.Indefined;
            }
            Console.WriteLine(" port prubytya:Kiev=1");
            plane.Port_to = Port.Kiev;
            Console.WriteLine("Vvedit terminal:Indefened = 0, A=1, B=2, C=3, D=4,");
            int term = EnterInt();
            if (term < 0 && term < 5)
            {
                plane.Terminal_out = (Terminal)term;
            }
            else
            {
                plane.Terminal_out = Terminal.Indefened;
            }
            Console.WriteLine("Vvedit aviakompaniyu:Indefended = 0, MAY=1, GBA=2, TAI=3, OdessaAir=4, LvivAir=5");
            int aviacom = Airport.EnterInt();
            if (aviacom > 0 && aviacom < 6)
            {
                plane.Company = (Aircompany)aviacom;
            }
            else
            {
                plane.Company = Aircompany.Indefended;
            }

            return plane;
        }
        public static Airplane EnterFlightTo()
        {
            Airplane plane = new Airplane();
            Console.WriteLine("Enter Number of plane:");
            plane.Number = Console.ReadLine();
            plane.Number.ToUpper();
            Console.WriteLine("Vvedit status reysu:");
            Console.WriteLine("Indefended = 0, registraciya=1,gotov_do_vulyotu=2,vuletiv=3,vidmineno=4,vidletiv_do=5, zatrumka=6");
            int st =Airport.EnterInt();
            if (st > 0 && st < 7)
            {
                plane.status = (Status)st;

            }
            else
            {
                plane.status = Status.Indefended;
            }
            Console.WriteLine("Vvedit daty vulyoty:");
            plane.Date_out = EnterDate();
            Console.WriteLine("Vvedit chas vulyoty:");
            plane.Time_out = EnterTime();
            Console.WriteLine("Vvedit daty prubytya v kincevuy punkt:");
            plane.Date_finish = EnterDate();
            Console.WriteLine("Vvedit chas prubytya v kincevuy punkt:");
            plane.Time_finish = EnterTime();
            Console.WriteLine(" port vidpravlennya:Kiev=1");
            plane.Port_from = Port.Kiev;
            Console.WriteLine("Vvedit port prubytya:");
            Console.WriteLine("Indefined = 0,  Lviv=2, Hharkiv=3, Odessa=4, Varshave=5, Rome=6, Stambul=7, Oslo=8, Kair=9");
            int _port = Airport.EnterInt();
            if (_port > 1 && _port < 10)
            {
                plane.Port_to = (Port)_port;
            }
            else
            {
                plane.Port_to = Port.Indefined;
            }
            Console.WriteLine("Vvedit terminal:Indefened = 0, A=1, B=2, C=3, D=4,");
            int term = Airport.EnterInt();
            if (term > 0 && term < 5)
            {
                plane.Terminal_out = (Terminal)term;
            }
            else
            {
                plane.Terminal_out = Terminal.Indefened;
            }
            Console.WriteLine("Vvedit aviakompaniyu:Indefended = 0, MAY=1, GBA=2, TAI=3, OdessaAir=4, LvivAir=5");
            int aviacom = Airport.EnterInt();
            if (aviacom > 0 && aviacom < 6)
            {
                plane.Company = (Aircompany)aviacom;
            }
            else
            {
                plane.Company = Aircompany.Indefended;
            }

            return plane;
        }

        public static Date EnterDate()
        {
            Date _date = new Date();
            Console.WriteLine("Vvedit den':");
             int d =Airport.EnterInt();
            if(d>0 && d<=31)
            {
                _date.day = d;
            }
            else { _date.day = 0; }
             Console.WriteLine("vvedit misayc chuslom vid 1 do 12':");
             int m =Airport.EnterInt() ;
             if (m > 0 && m <= 12)
             {
                 _date._month = (month)m;
             }
             else { _date._month = month.Indefined; }
             Console.WriteLine("Vvedit rik:");
             string year=Console.ReadLine();
             if (year == "2016" || year == "2017")
             {
                 _date.year = year;
             }
             else
             { _date.year = "Indefended"; }
             return _date;
        }


        public static Time  EnterTime()
        {
            Time _time = new Time();
            Console.WriteLine("Vvedit godunu':");
            int t = Airport.EnterInt();
            if (t >= 0 && t <= 23)
            {
                _time.hour = t;
            }
            else { _time.hour = -1; }
            Console.WriteLine("vvedit munytu  vid 0 do 59:");
            int m = Airport.EnterInt();
            if (m >= 0 && m <60)
            {
                _time.minute = m;
            }
            else { _time.minute = -1; }
            return _time;
           
        }

        public void ShowFlightFrom()
        {
            Console.WriteLine("Number-{0}|From-{1}|To-{2}|Status-{3}|Terminal-{4}|prubyttay v Kuiv-{5}-{6}-{7}|{8}:{9}|Kompaniya-{10}",
                               this.Number, this.Port_from, this.Port_to, this.status, this.Terminal_out,
                               this.Date_in.day, this.Date_in._month, this.Date_in.year, this.Time_in.hour, this.Time_in.minute,
                               this.Company);
        }

        public void ShowFlightTo()
        {
            Console.WriteLine("Number-{0}|From-{1}|To-{2}|Status-{3}|Terminal-{4}|vidpravlenya z Kueva-{5}-{6}-{7}|{8}:{9}|prubyttya v misce pruznachenny-{10}-{11}-{12}|{13}:{14}|Kompaniya-{15}",
                               this.Number, this.Port_from, this.Port_to, this.status, this.Terminal_out, this.Date_out.day, this.Date_out._month, this.Date_out.year,
                               this.Time_out.hour, this.Time_out.minute, 
                               this.Date_finish.day, this.Date_finish._month, this.Date_finish.year, this.Time_finish.hour, this.Time_finish.minute, this.Company);
        }
       
            
        


       
        
    }
}

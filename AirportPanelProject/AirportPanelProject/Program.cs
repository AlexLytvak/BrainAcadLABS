using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportPanelProject
{
    class Program
    {
        const int MAXPLAINE = 50;//максимальна кількість літаків
        const int MAXPASSENGER = 500;//максимальна кількість літаків
       
        static void Main(string[] args)
        {
            Airport kiev = new Airport();
            kiev.pricelist.Add(new Airport.Price());
            //
            Airplane[] masplainTo = new Airplane[MAXPLAINE];
            for (int i = 0; i < masplainTo.Length; i++)
            {
                masplainTo[i] = new Airplane();
            }
            Airplane[] masplainFrom = new Airplane[MAXPLAINE];
            for (int i = 0; i < masplainFrom.Length; i++)
            {
                 masplainFrom[i] = new Airplane();
            }
            Passenger[] maspas = new Passenger[MAXPASSENGER];
            for(int i=0;i<maspas.Length;i++)
            {

                maspas[i] = new Passenger();
            }
            Airplane plane1 = new Airplane();
            plane1.Number = "Test_to";
            plane1.Port_to = Port.Odessa;
            plane1.Port_from = Port.Kiev;
            Airplane plane2 = new Airplane();
            plane2.Number = "Test_from";
            plane2.Port_from = Port.Lviv;
            plane2.Port_to = Port.Kiev;
            //
            Passenger.PasName testName = new Passenger.PasName("test_ferst", "test_second");
            Passenger testpas = new Passenger(testName); 
            masplainTo[0] = plane1;
            masplainFrom[0] = plane2;
            maspas[0] = testpas;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Dodatu reys");
                Console.WriteLine("2.Dodatu pasagura");
                Console.WriteLine("3.Pokaz prubuvayuchuh reysiv");
                Console.WriteLine("4.Pokaz reysiv vidpravlennya");
                Console.WriteLine("5.Pokaz pasaguriv");
                Console.WriteLine("6.Poshuk po pasagury");
                Console.WriteLine("7.Poshuk po reysu");
                Console.WriteLine("8.Pokaz praysu");
                Console.WriteLine("9.Vudalutu");
                Console.WriteLine("0.zavershutu roboty");
                int menu = Airport.EnterInt();
                switch (menu)
                {
                    #region 1
                    case 1:
                        {
                            Console.WriteLine("1- reys prubuttya; 2-reys vidpravlennya;");
                            int r = Airport.EnterInt();
                            if (r == 1)
                            {
                                Airplane plane = new Airplane();
                                plane = Airplane.EnterFlightFrom();
                                for (int i = 0; i < masplainFrom.Length; i++)
                                {
                                    if (masplainFrom[i].Number =="None")
                                    {
                                        masplainFrom[i] = plane;

                                        break;
                                    }
                                }
                            }
                            else
                            {
                                Airplane plane = new Airplane();
                                plane = Airplane.EnterFlightTo();
                                for (int i = 0; i < masplainTo.Length; i++)
                                {
                                    if (masplainTo[i].Number == "None")
                                    {
                                        masplainTo[i] = plane;

                                        break;
                                    }
                                }

                            }
                            break;
                        }
                    #endregion
                    #region 2
                    case 2:
                        {
                            Passenger pas = new Passenger();
                            pas = Passenger.EnterPassenger();
                            for (int i = 0; i < maspas.Length; i++)
                            {
                                if (String.IsNullOrEmpty(maspas[i].Name.first_name)&&String.IsNullOrEmpty(maspas[i].Name.second_name ))
                                {
                                    maspas[i] = pas;
                                    break;
                                }
                            }
                            for (int i = 0; i < masplainTo.Length; i++)
                            {
                                if (pas.plane_num == masplainTo[i].Number)
                                {
                                    for (int j = 0; j < masplainTo[i].number_passenger.Length; j++)
                                    {
                                        if (masplainTo[i].number_passenger[j] == null)
                                        {
                                            masplainTo[i].number_passenger[j] = pas;
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    #endregion
                    #region 3
                    case 3:
                        {
                            for (int i = 0; i < masplainFrom.Length; i++)
                            {
                                if (masplainFrom[i].Number !="None")
                                    masplainFrom[i].ShowFlightFrom();

                            }
                            break;
                        }
#endregion
                    #region 4
                    case 4:
                        {
                            for (int i = 0; i < masplainTo.Length; i++)
                            {
                                if (masplainTo[i].Number !="None")
                                    masplainTo[i].ShowFlightTo();

                            }
                            break;
                        }
                    #endregion
                    #region 5
                    case 5:
                        {
                            for (int i = 0; i < maspas.Length; i++)
                            {
                                if (maspas[i] != null)
                                    maspas[i].ShowPassenger();

                            }

                            break;
                        }
                    #endregion
                    #region 6
                    case 6:
                        {
                            Console.WriteLine("Poshuk po:1-Imeni;2-Prizvuchu;3-Pasportu;4-Reusy;5-Vartosti kvutka; 0-vuhid");
                            int poshuk = Airport.EnterInt();
                            switch (poshuk)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Vvedit im'ya:");
                                        string imya = Console.ReadLine();
                                        for (int i = 0; i < maspas.Length; i++)
                                        {
                                            if (maspas[i].Name.first_name == imya)
                                                maspas[i].ShowPassenger();
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Vvedit prizvuche:");
                                        string imya = Console.ReadLine();
                                        for (int i = 0; i < maspas.Length; i++)
                                        {
                                            if (maspas[i].Name.second_name == imya)
                                                maspas[i].ShowPassenger();
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Vvedit nomer pasportu:");
                                        string imya = Console.ReadLine();
                                        for (int i = 0; i < maspas.Length; i++)
                                        {
                                            if (maspas[i].Pasport == imya)
                                                maspas[i].ShowPassenger();
                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("Vvedit nomer reysu:");
                                        string imya = Console.ReadLine();
                                        imya.ToUpper();
                                        for (int i = 0; i < maspas.Length; i++)
                                        {
                                            if (maspas[i].plane_num == imya)
                                                maspas[i].ShowPassenger();
                                        }
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.WriteLine("Vvedit vartist' kvutka:vuvid +10$ -10$ vid vartosti");
                                        double pr = Airport.EnterDouble();
                                        for (int i = 0; i < maspas.Length; i++)
                                        {
                                            if (maspas[i].price == pr + 10 || maspas[i].price == pr - 10)
                                                maspas[i].ShowPassenger();
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    #endregion
                    #region 7
                    case 7:
                        {
                            {
                                bool flag1 = true;
                                Console.WriteLine("1-poshuk prubuvayuchuh reisiv;2- vidbyvayuchuh;0-vuhid");
                                while (flag1)
                                {
                                    int reys = Airport.EnterInt();
                                    if (reys == 1)
                                    {
                                        Console.WriteLine("1-po nomeru;2-portu vidpravlennya;3-dati prubutya/chasy prubyttya;4-aviakompanii;0-vuhid;");
                                        int v=Airport.EnterInt();
                                        switch (v)
                                        {
                                            case 1:
                                                {
                                                    Console.WriteLine("Vvedit nomer reisu:");
                                                    string str = Console.ReadLine();
                                                    str.ToUpper();
                                                    for (int i = 0; i < masplainFrom.Length; i++)
                                                    {
                                                        if (str == masplainFrom[i].Number)
                                                        {
                                                            masplainFrom[i].ShowFlightFrom();
                                                        }
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    Console.WriteLine(" 2-Lviv, 3-Hharkiv, 4-Odessa, 5-Varshava, 6-Rome, 7-Stambul, 8-Oslo, 9-Kair");
                                                    int num = Airport.EnterInt();
                                                    for (int i = 0; i < masplainFrom.Length; i++)
                                                    {
                                                        if (num == (int)masplainFrom[i].Port_from)
                                                        {
                                                            masplainFrom[i].ShowFlightFrom();
                                                        }
                                                       // else { Console.WriteLine("Nemae takogo reisu"); }
                                                    }
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    Console.WriteLine("Vvedit rik. pidtrumuetsya 2016 i 2017");
                                                    string  str = Console.ReadLine();
                                                    Console.WriteLine("Vvedit misyac:1-January,2-Feb,3-March,4-April,5-May,6-June,7-July,8-August,9-September,10-October,11-November,12-December ");
                                                    int num = Airport.EnterInt();
                                                    Console.WriteLine("Vvedit den' 1-31");
                                                    int d = Airport.EnterInt();
                                                    for (int i = 0; i < masplainFrom.Length; i++)
                                                    {
                                                        if (num == (int)masplainFrom[i].Date_in._month && d == (int)masplainFrom[i].Date_in.day && masplainFrom[i].Date_in.year == str)
                                                        {
                                                            masplainFrom[i].ShowFlightFrom();
                                                        }
                                                    }
                                                        Console.WriteLine("VVedit goduny:0-23.Vuvid +/-1 goduna");
                                                        int god = Airport.EnterInt();

                                                        for (int i = 0; i < masplainFrom.Length; i++)
                                                        {
                                                            if (((god == masplainFrom[i].Time_in.hour) || (god == masplainFrom[i].Time_in.hour + 1) || (god == masplainFrom[i].Time_in.hour - 1)) && (num == (int)masplainFrom[i].Date_in._month && d == (int)masplainFrom[i].Date_in.day && masplainFrom[i].Date_in.year == str))
                                                            {
                                                                masplainFrom[i].ShowFlightFrom();
                                                            }
                                                        }
                                                        
                                                   
                                                    break;
                                                }
                                           
                                            case 4:
                                                {
                                                    Console.WriteLine("1-MAY,2-GBA,3-TAI,4-OdessaAir,5-LvivAir,");
                                                    int num = Airport.EnterInt();
                                                    for (int i = 0; i < masplainFrom.Length; i++)
                                                    {
                                                        if (num == (int)masplainFrom[i].Company)
                                                        {
                                                            masplainFrom[i].ShowFlightFrom();
                                                        }
                                                    }
                                                    break;
                                                }
                                            default:
                                                    {
                                                        break;
                                                    }
                                        }
                                    }
                                    else if (reys == 2)
                                    {
                                        Console.WriteLine("1-po nomeru;2-portu sliduvannya;3-dati vulyotu/chasy vulyotu;4-dati prubuttya/chasu prubuttya; 5-aviakompanii;0-vuhid;");
                                        int num=Airport.EnterInt();
                                        switch(num)
                                        {
                                            case 1:
                                                {
                                                    Console.WriteLine("Vvedit nomer reisu:");
                                                    string str = Console.ReadLine();
                                                    str.ToUpper();
                                                    for (int i = 0; i < masplainTo.Length; i++)
                                                    {
                                                        if (str == masplainTo[i].Number)
                                                        {
                                                            masplainTo[i].ShowFlightTo();
                                                        }
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    Console.WriteLine(" 2-Lviv, 3-Hharkiv, 4-Odessa, 5-Varshava, 6-Rome, 7-Stambul, 8-Oslo, 9-Kair");
                                                    int n = Airport.EnterInt();
                                                    for (int i = 0; i < masplainTo.Length; i++)
                                                    {
                                                        if (n == (int)masplainTo[i].Port_to)
                                                        {
                                                            masplainTo[i].ShowFlightTo();
                                                        }
                                                    }
                                                    break;
                                                   
                                                }
                                            case 3:
                                                {
                                                    Console.WriteLine("Vvedit rik. pidtrumuetsya 2016 i 2017");
                                                    string str = Console.ReadLine();
                                                    Console.WriteLine("Vvedit misyac:1-January,2-Feb,3-March,4-April,5-May,6-June,7-July,8-August,9-September,10-October,11-November,12-December ");
                                                    int nam = Airport.EnterInt();
                                                    Console.WriteLine("Vvedit den' 1-31");
                                                    int d = Airport.EnterInt();
                                                    for (int i = 0; i < masplainTo.Length; i++)
                                                    {
                                                        if (nam == (int)masplainTo[i].Date_out._month && d == masplainTo[i].Date_out.day && masplainTo[i].Date_out.year == str)
                                                        {
                                                            masplainTo[i].ShowFlightTo();
                                                        }
                                                    }

                                                    Console.WriteLine("VVedit goduny:0-23.Vuvid +/-3 goduna");
                                                    int god = Airport.EnterInt();

                                                    for (int i = 0; i < masplainTo.Length; i++)
                                                    {
                                                        if (((god == masplainTo[i].Time_out.hour) || (god == masplainTo[i].Time_in.hour + 3) || (god == masplainTo[i].Time_in.hour - 3)) && (num == (int)masplainTo[i].Date_out._month && d == (int)masplainTo[i].Date_out.day && masplainTo[i].Date_out.year == str))
                                                        {
                                                            masplainTo[i].ShowFlightTo();
                                                        }
                                                    }


                                                    break;
                                                }
                                           
                                            case 4:
                                                {
                                                    Console.WriteLine("Vvedit rik. pidtrumuetsya 2016 i 2017");
                                                    string str = Console.ReadLine();
                                                    Console.WriteLine("Vvedit misyac:1-January,2-Feb,3-March,4-April,5-May,6-June,7-July,8-August,9-September,10-October,11-November,12-December ");
                                                    int nam = Airport.EnterInt();
                                                    Console.WriteLine("Vvedit den' 1-31");
                                                    int d = Airport.EnterInt();
                                                    for (int i = 0; i < masplainTo.Length; i++)
                                                    {
                                                        if (nam == (int)masplainTo[i].Date_finish._month && d == masplainTo[i].Date_finish.day && masplainTo[i].Date_finish.year == str)
                                                        {
                                                            masplainTo[i].ShowFlightTo();
                                                        }
                                                    }

                                                    Console.WriteLine("VVedit goduny:0-23.Vuvid +/-3 godunu");
                                                    int god = Airport.EnterInt();

                                                    for (int i = 0; i < masplainTo.Length; i++)
                                                    {
                                                        if (((god == masplainTo[i].Time_finish.hour) || (god == masplainTo[i].Time_finish.hour + 3) || (god == masplainTo[i].Time_finish.hour - 3)) && (num == (int)masplainTo[i].Date_finish._month && d == (int)masplainTo[i].Date_finish.day && masplainTo[i].Date_finish.year == str))
                                                        {
                                                            masplainTo[i].ShowFlightTo();
                                                        }
                                                    }

                                                    break;
                                                }
                                           
                                            case 5:
                                                {
                                                    Console.WriteLine("1-MAY,2-GBA,3-TAI,4-OdessaAir,5-LvivAir,");
                                                    int comp = Airport.EnterInt();
                                                    for (int i = 0; i < masplainTo.Length; i++)
                                                    {
                                                        if (comp == (int)masplainTo[i].Company)
                                                        {
                                                            masplainTo[i].ShowFlightTo();
                                                        }
                                                    }
                                                    break;
                                                }
                                            default:
                                                {
                                                    break;
                                                }
                                          
                                        }
                                    }
                                    else
                                    {
                                        if (reys == 0) { flag1 = false; break; }
                                        Console.WriteLine("Nevirnuy format vvody");

                                    }

                                }
                            }
                            break;
                        }
                    #endregion
                    #region 8
                    case 8:
                        {
                            bool flag2 = true;
                            Console.WriteLine("1-Dodatu praus;2- pereglyanutu praus;0-vuhid");
                            while (flag2)
                            {
                                int pric = Airport.EnterInt();
                                if (pric == 1)
                                {
                                    kiev.EnterPrice();  
                                    break;
                                }
                                
                                else if (pric == 2)
                                {
                                    kiev.ShowPrice();
                                    break;
                                }
                                else
                                {
                                    if (pric == 0) { flag2 = false; break; }
                                    Console.WriteLine("Nevirnuy format vvody");

                                }

                            }
                            break;
                        }
                    #endregion
                    #region 9
                    case 9:
                            {
                                Console.WriteLine("1-Vudalutu reys;2-vudalutu pasagura;3-vudalutu prays;0-vuhid");
                                int val = Airport.EnterInt();
                                switch (val)
                                {
                                    #region 9_1
                                    case 1:
                                        {
                                            for (int i = 0; i < masplainFrom.Length; i++)
                                            {
                                                if (masplainFrom[i].Number != "None")
                                                    masplainFrom[i].ShowFlightFrom();

                                            }
                                            for (int i = 0; i < masplainTo.Length; i++)
                                            {
                                                if (masplainTo[i].Number != "None")
                                                    masplainTo[i].ShowFlightTo();

                                            }

                                            Console.WriteLine("Vvedit nomer reysy:");
                                           string st= Console.ReadLine();
                                           st.ToUpper();
                                           for (int i = 0; i < masplainFrom.Length; i++)
                                           {
                                               if (masplainFrom[i].Number == st)
                                                   masplainFrom[i] = new Airplane();

                                           }
                                           for (int i = 0; i < masplainTo.Length; i++)
                                           {
                                               if (masplainTo[i].Number == st)
                                                   masplainTo[i] = new Airplane();

                                           }
                                            break;
                                        }
                                    #endregion
                                    #region 9_2
                                    case 2:
                                        {
                                            {
                                                Console.WriteLine("Poshuk po:1-Imeni;2-Prizvuchu;3-Pasportu;4-Reusy;5-Vartosti kvutka; 0-vuhid");
                                                int poshuk = Airport.EnterInt();
                                                #region poshuk
                                                switch (poshuk)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("Vvedit im'ya:");
                                                            string imya = Console.ReadLine();
                                                            for (int i = 0; i < maspas.Length; i++)
                                                            {
                                                                if (maspas[i].Name.first_name == imya)
                                                                {
                                                                    Console.WriteLine("{0}", i);
                                                                    maspas[i].ShowPassenger();
                                                                }
                                                            }
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            Console.WriteLine("Vvedit prizvuche:");
                                                            string imya = Console.ReadLine();
                                                            for (int i = 0; i < maspas.Length; i++)
                                                            {
                                                                if (maspas[i].Name.second_name == imya)
                                                                {
                                                                    Console.WriteLine("{0}", i);
                                                                    maspas[i].ShowPassenger();
                                                                }
                                                            }
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            Console.WriteLine("Vvedit nomer pasportu:");
                                                            string imya = Console.ReadLine();
                                                            for (int i = 0; i < maspas.Length; i++)
                                                            {
                                                                if (maspas[i].Pasport == imya)
                                                                {
                                                                    Console.WriteLine("{0}", i);
                                                                    maspas[i].ShowPassenger();
                                                                }
                                                            }
                                                            break;
                                                        }
                                                    case 4:
                                                        {
                                                            Console.WriteLine("Vvedit nomer reysu:");
                                                            string imya = Console.ReadLine();
                                                            imya.ToUpper();
                                                            for (int i = 0; i < maspas.Length; i++)
                                                            {
                                                                if (maspas[i].plane_num == imya)
                                                                {
                                                                    Console.WriteLine("{0}", i);
                                                                    maspas[i].ShowPassenger();
                                                                }
                                                            }
                                                            break;
                                                        }
                                                    case 5:
                                                        {
                                                            Console.WriteLine("Vvedit vartist' kvutka:vuvid +10$ -10$ vid vartosti");
                                                            double pr = Airport.EnterDouble();
                                                            for (int i = 0; i < maspas.Length; i++)
                                                            {
                                                                if (maspas[i].price == pr + 10 || maspas[i].price == pr - 10)
                                                                {
                                                                    Console.WriteLine("{0}", i);
                                                                    maspas[i].ShowPassenger();
                                                                }
                                                            }
                                                            break;
                                                        }
                                                    default:
                                                        {
                                                            break;
                                                        }
                                                }

                                            }
                                                #endregion
                                            Console.WriteLine("Vvedit poryadkovuy nomer pasagura:");
                                            int pnum = Airport.EnterInt();
                                            for (int i = 0; i < maspas.Length; i++)
                                            {
                                                if (pnum == i)
                                                {
                                                    for (int j = 0; j < masplainTo.Length; j++)
                                                    {
                                                        if (maspas[i].plane_num == masplainTo[j].Number)
                                                        {
                                                            for (int n = 0; i < masplainTo[j].number_passenger.Length; n++)
                                                            {
                                                                if (maspas[i].Pasport == masplainTo[j].number_passenger[n].Pasport)
                                                                {
                                                                    masplainTo[j].number_passenger[n] = new Passenger();
                                                                }
                                                            }
                                                        }
                                                    }
                                                   
                                                    maspas[i]=new Passenger();
                                                }
                                               
                                            }
                                            break;
                                        }
                                    #endregion 
                                    #region 9_3
                                    case 3:
                                        {
                                            kiev.ShowPrice();
                                            Console.WriteLine("Vvedit napryamok:Lviv-2, Hharkiv-3, Odessa-4, Varshava-5, Rome-6, Stambul-7, Oslo-8, Kair-9, ");
                                            int napryamok1 = Airport.EnterInt();
                                            Console.WriteLine("Vvedit aviakompaniyu:MAY-1, GBA-2, TAI-3, OdessaAir-4, LvivAir-5");
                                            int company1 = Airport.EnterInt();
                                            
                                            for(int i=0;i<kiev.pricelist.Count;i++)
                                            {
                                                
                                                if(kiev.pricelist[i].port==(Port)napryamok1 &&kiev.pricelist[i].aircompany==(Aircompany)company1)
                                                    kiev.pricelist.Remove(kiev.pricelist[i]);
                                                
                                            }
                                            break;
                                        }
                                    #endregion
                                    default:
                                        {
                                            break;
                                        }
                                }
                                break;
                            }
                    #endregion
                    default:
                        {
                            flag = false;
                            break;
                        }
                }
            }
           
        }

     
            
        }



    }


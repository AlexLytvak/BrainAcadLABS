using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Computer
{
    struct Comp
    {
       public string name;
       public int core;
       public double frequenсy;
       public  double ddr;
       public int hdd;
    }
    enum TypeOfComp
    {
        e_desktop,e_leptop,e_server,
    };
    class Program
    {
       
        static void Main(string[] args)
        {
           const int VIDDIL = 4;//кількість відділів
           int TYPEOF_PC=3;//кількість видів ПК(десктоп/лептоп/сервер)
           int sum = 0;
           int sum_desctop = 0;
           int sum_leptop = 0;
           int sum_server = 0;
            Comp desktop=new Comp() {name="desktop", core =4 , frequenсy = 2.2, ddr = 6, hdd = 500 };
           
            Comp leptop = new Comp() { name="leptop",core = 2, frequenсy = 1.7, ddr = 4, hdd = 360 };
            
            Comp server = new Comp() {name="server", core = 2, frequenсy = 3.6, ddr = 16, hdd = 40000 };

            int[, ] mas = new int[VIDDIL,TYPEOF_PC ];
            for (int i = 0; i < mas.GetLength(0); i++)
            { 
               Console.WriteLine("Vvedit dlay viddily -{0} :",i+1);
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    switch(j)
                    {
                        case (int) TypeOfComp.e_desktop:
                        Console.WriteLine("Kil'kist' desktopiv : ");
                        break;
                        case (int)TypeOfComp.e_leptop:
                        Console.WriteLine("Kil'kist' leptipiv : ");
                        break;
                        case (int)TypeOfComp.e_server:
                        Console.WriteLine("Kil'kist' serveriv: ");
                        break;
                    }
                   
                    
                       int valye = Convert.ToInt32(Console.ReadLine());
                        mas[i, j] = valye;
                        sum += valye; //сума всіх ПК
                    }
                }
            Console.WriteLine("VS'OGO NA FIRMI {0} PC ", sum);
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (j == (int)TypeOfComp.e_desktop)
                    {
                        sum_desctop += mas[i, j]; //кількість всіх десктопів
                    }
                    if (j == (int)TypeOfComp.e_leptop)
                    {
                        sum_leptop += mas[i, j];  //к-ть лептопів
                    }
                    if (j == (int)TypeOfComp.e_server)
                    {
                        sum_server += mas[i, j]; //к-сть серверів
                    }
                }
            }
            Console.WriteLine(" Iz nuh : decktopiv - {0}; leptopiv - {1}; serveriv - {2}", sum_desctop, sum_leptop, sum_server);

            //Пошук найшвидшого CPU і найбільшого  HDD
            double MaxCPUFr=0;
            int MaxHDD=0;
           
            Comp[] mas1 = new Comp[] { desktop, leptop, server };
            for (int i = 0; i < mas1.GetLength(0); i++)
            {
               
                if (mas1[i].frequenсy > MaxCPUFr)
                {
                    MaxCPUFr=mas1[i].frequenсy;
                    

                }
                if (mas1[i].hdd > MaxHDD)
                {
                    MaxHDD = mas1[i].hdd;
                   
                }
            }
             
            //порівняння на рівність найбільших параметрів
            for (int i = 0; i < mas1.GetLength(0); i++)
            {
                if (mas1[i].frequenсy == MaxCPUFr)
                {
                    Console.WriteLine("Naishvudsha chastota CPU= {0} MHz. v {1}",mas1[i].frequenсy,mas1[i].name);
                }
                if (mas1[i].hdd == MaxHDD)
                {
                    Console.WriteLine("Naibil'shuy ob'em HDD ={0} Gb. v {1}",mas1[i].hdd,mas1[i].name);
                }
            }

           

            Console.ReadLine();
        }

    }
}

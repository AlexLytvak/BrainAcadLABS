using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("1-square, 2- rectangle, 3- rhombus, 4 -triangle,5-circle,6-ellipse, 7- exit");
                int val = Convert.ToInt16(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        {
                            Rect_square.Point p1 = new Rect_square.Point();
                            Rect_square.Point p2 = new Rect_square.Point();
                            Read1(ref p1);
                            Read2(ref p2);
                            Rect_square square = new Rect_square(p1, p2);
                            if (square.inspection())
                            {
                                double S = square.Area();
                                Double P = square.Perimeter();
                                Console.WriteLine("S={0}, P={1}", Math.Round(S, 4), Math.Round(P, 4));
                            }

                            break;
                        }
                    case 2:
                        {
                            Rectangle.Point p1 = new Rectangle.Point();
                            Rectangle.Point p2 = new Rectangle.Point();
                            Rectangle.Point p3 = new Rectangle.Point();
                            Console.WriteLine("x1y1-tochka peretuny sumijnuh storin pr'amokutnuka");
                            Read1(ref p1);
                            Read2(ref p2);
                            Read3(ref p3);
                            Rectangle rect = new Rectangle(p1, p2, p3);
                            if (rect.inspection())
                            {
                                double S = rect.Area();
                                Double P = rect.Perimeter();
                                Console.WriteLine("S={0}, P={1}", Math.Round(S, 4), Math.Round(P, 4));
                            }
                            break;
                        }
                    case 3:
                        {
                            Rhombus.Point p1 = new Rhombus.Point();
                            Rhombus.Point p2 = new Rhombus.Point();
                            Rhombus.Point p3 = new Rhombus.Point();
                            Console.WriteLine("x1,y1- ce tochka peretuny diagonaley romba, x2,y2|x3,y3-vershunu romba ");
                            Read1(ref p1);
                            Read2(ref p2);
                            Read3(ref p3);
                            Rhombus rhomb = new Rhombus(p1, p2, p3);
                            if (rhomb.inspection())
                            {
                                double S = rhomb.Area();
                                Double P = rhomb.Perimeter();
                                Console.WriteLine("S={0}, P={1}", Math.Round(S, 4), Math.Round(P, 4));
                            }
                            break;

                        }
                    case 4:
                        {
                            Triangle.Point p1 = new Triangle.Point();
                            Triangle.Point p2 = new Triangle.Point();
                            Triangle.Point p3 = new Triangle.Point();
                            Read1(ref p1);
                            Read2(ref p2);
                            Read3(ref p3);
                            Triangle tria = new Triangle(p1, p2, p3);
                            if (tria.inspection())
                            {
                                double S = tria.Area();
                                Double P = tria.Perimeter();
                                Console.WriteLine("S={0}, P={1}", Math.Round(S, 4), Math.Round(P, 4));
                            }
                            break;
                        }
                    case 5:
                        {
                            Circle.Point p1 = new Circle.Point();
                            Circle.Point p2 = new Circle.Point();
                            Console.WriteLine("x1y1- centr kola, x2y2-tochka radiusy");
                            Read1(ref p1);
                            Read2(ref p2);
                            Circle circle = new Circle(p1, p2);
                            if (circle.inspection())
                            {
                                double S = circle.Area();
                                Double P = circle.Perimeter();
                                Console.WriteLine("S={0}, P={1}", Math.Round(S, 4), Math.Round(P, 4));
                            }
                            break;
                        }
                    case 6:
                        {
                            Ellipse.Point p1 = new Ellipse.Point();
                            Ellipse.Point p2 = new Ellipse.Point();
                            Ellipse.Point p3 = new Ellipse.Point();
                            Console.WriteLine("x1,y1- tochka peretune polyosey elipsa; x2y2-maluy radius';x3y3-velukuy radius");
                            Read1(ref p1);
                            Read2(ref p2);
                            Read3(ref p3);
                            Ellipse ellipse = new Ellipse(p1, p2, p3);
                            if (ellipse.inspection())
                            {
                                double S = ellipse.Area();
                                Double P = ellipse.Perimeter();
                                Console.WriteLine("S={0}, P={1}", Math.Round(S, 4), Math.Round(P, 4));
                            }
                            break;
                        }
                    case 7:
                        {
                            flag = false;
                            break;
                        }
                    default:
                        {
                            flag = false;
                            break;
                        }

                }
            }
           
         


           
        }

        public static void Read1(ref Shape.Point p1)
        {
            Console.WriteLine("Vvedite koordinati x1 :");
            p1.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite koordinati y1 :");
            p1.y = Convert.ToInt32(Console.ReadLine());
           
        }
        public static void Read2( ref Shape.Point p2)
        {
            Console.WriteLine("Vvedite koordinati x2 :");
            p2.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite koordinati y2 :");
            p2.y = Convert.ToInt32(Console.ReadLine());

        }
        public static void Read3(ref Shape.Point p3)
        {
            Console.WriteLine("Vvedite koordinati x3 :");
            p3.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite koordinati y3 :");
            p3.y = Convert.ToInt32(Console.ReadLine());
        }
    }
}

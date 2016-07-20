using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(12, 40,"It took 5 hours of work");
            Rectangle.row = Console.CursorTop+20;
            Rectangle.col = Console.CursorLeft+5;
            Console.SetCursorPosition(Rectangle.row, Rectangle.col);
            rec.DrowHoriz(rec.w);
            Console.SetCursorPosition(Rectangle.row, Rectangle.col + 1);
            for (int i = 1; i <= rec.h; i++)
            {
                
                rec.DrowVertical(rec.w);
                Console.SetCursorPosition(Rectangle.row, Rectangle.col + i);
            }
            Console.SetCursorPosition(Rectangle.row, Rectangle.col + rec.h);
            rec.DrowHoriz(rec.w);
            Console.SetCursorPosition(Rectangle.row, Rectangle.col + rec.h);
            Console.SetCursorPosition((Rectangle.row + rec.w) / 2,( Rectangle.col+(Rectangle.col + rec.h)) / 2);
            Console.Write(rec.ST);
            Console.ReadLine();
        }
    }
}

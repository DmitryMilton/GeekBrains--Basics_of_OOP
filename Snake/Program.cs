using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(11, 13, '*');
            Point p2 = new Point(14, 15, '#');
            Point p3 = new Point(17, 18, '%');
            Point p4 = new Point(24, 25, '$');


            // Создание списка целочисленных значений
            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            // Обращение к элементам списа по индексу
            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            // Удаление элемента по номеру индекса
            numList.RemoveAt(1);
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            
            // Создание списка объектов Point
            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);
            pointList.Add(p4);

            foreach (Point i in pointList)
            {
                //Console.WriteLine(i.x + " " + i.y + " " + i.sym);
                i.Draw();
            }

            Console.ReadLine();
        }

        public static void Func1(int value)
        {
            
        }

        public static void Func2(int value)
        {
            value = value + 1;
        }

        public static void Func3(int x)
        {
            x = x + 1;
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

        public static void Update(Point p)
        {
            p = new Point();
        }
    }
}

﻿using System;

/*
Составить программу, вычисляющую площадь и периметр треугольника,
заданного вещественными координатами трёх своих вершин (x1,y1),(x2,y2) и (x3,y3).
Получаемые от пользователя данные считать корректными.

Формат входных данных:
0
0
0
5
5
0

Формат выходных данных:
12,50
*/


namespace Task05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // ввести х1, х2, х3, у1, у2, у3

            double d12 = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double d13 = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            double d23 = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));

            double p = // посчитать полупериметр

            double s = // посчитать площадь

            Console.WriteLine($"{s:f2}");
        }
    }
}

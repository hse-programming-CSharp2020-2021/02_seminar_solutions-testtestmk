using System;

/*
Пользователь вводит с клавиатуры три целых числа X, Y и Z.
Используя тернарную операцию, определить выполняется ли для этих чисел неравенство треугольника.
На экран вывести сообщение «неравенство выполняется» или «неравенство не выполняется».

Формат входных данных:
4
5
6

Формат выходных данных:
неравенство выполняется
*/

namespace Task01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            // ввести y, z

            string answer = (x > y + z) && (y > x + z) && (z > x + y) ? "неравенство выполняется" : "неравенство не выполняется";

            Console.WriteLine(answer);
        }
    }
}

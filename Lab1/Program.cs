using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1 - Инкапсуляция");
            Console.WriteLine("Выполнил - Заинчковский\n");
            Console.WriteLine("Задание 1:");

            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };

            a.Add(b);
            b.Substract(a);


            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);

            a.Multiply(b);
            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);

            b.Divide(a);
            Console.WriteLine("a = {0} + {1}i", b.Real, b.Imag);


            Console.WriteLine("\n");
            Console.WriteLine("Задание 2:");

            Student s1 = new Student() { name = "Василий", gender = "мужчина", hairColor = "Желтый", age = 20 };
            Student s2 = new Student() { name = "Маша", gender = "женщина", hairColor = "Черный", age = 21 };

            s1.Add(s2);
            Console.WriteLine("Имя = {0} | Пол = {1} | Цвет волос = {2} | Возраст = {3}", s1.name, s1.gender, s1.hairColor, s1.age);

        }
    }
}

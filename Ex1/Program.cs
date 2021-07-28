using System;

namespace Ex1     // Задача 1 (Анкета) Катаев Сергей
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя:");
            var name = Console.ReadLine();

            Console.Write("Введите вашу фамилию:");
            var fename = Console.ReadLine(); 

            Console.Write("Введите ваш возраст:");
            var age = Console.ReadLine(); 

            Console.Write("Введите ваш рост:");
            var rost = Console.ReadLine();

            Console.Write("Введите ваш вес:");
            var ves = Console.ReadLine();

            Console.WriteLine(name + " " + fename + " " + age + " " + rost + " " + ves);  //вариант а

            Console.WriteLine("{0:G}", name + " " + fename + " " + age + " " + rost + " " + ves); //вариант b

            Console.WriteLine(string.Format($"{name} {fename} {age} {rost} {ves}")); //вариант с

        }
    }
}

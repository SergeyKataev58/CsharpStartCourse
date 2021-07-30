using System;

namespace Ex1     // Задача 1 (Анкета) Катаев Сергей
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Задача 1 (Анкета)");
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
            
            // Задача 2 (найти ИМТ человека)
            Console.WriteLine("Задача 2 (найти ИМТ человека)");
            Console.Write("Введите ваш рост в метрах:");
            var rost1 = Console.ReadLine();

            double a = Convert.ToDouble(rost1);

            Console.Write("Введите ваш вес:");
            var ves2 = Console.ReadLine();

            double b = Convert.ToDouble(ves2);

            double imt = b / (a * a);

            Console.WriteLine("Индекс массы вашего тела:" + imt);
            */
            //Задача 3 (Посчитать расстояние между точками)

            //Ввод координат
            Console.Write("Введите x1 = ");
            var x1 = Console.ReadLine();

            double a1 = Convert.ToDouble(x1);

            Console.Write("Введите x2 = ");
            var x2 = Console.ReadLine();

            double a2 = Convert.ToDouble(x2);

            Console.Write("Введите y1 = ");
            var y1 = Console.ReadLine();

            double b1 = Convert.ToDouble(y1);

            Console.Write("Введите y2 = ");
            var y2 = Console.ReadLine();

            double b2 = Convert.ToDouble(y2);

            double r = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));

            Console.WriteLine("Расстояние между точками = " + "{0:F2}",r);

        }

    }
}

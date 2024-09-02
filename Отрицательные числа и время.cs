//Задание 1
using System;
//class Program1
//{
//    static void Main()
//    {
//        Console.Write("Введите неотрицательное число N: ");
//        string input = Console.ReadLine();


//        if (ulong.TryParse(input, out ulong number))
//        {
//            ulong reversedNumber = 0;

//            while (number > 0)
//            {
//                ulong lastDigit = number % 10;
//                reversedNumber = reversedNumber * 10 + lastDigit;
//                number /= 10;
//            }

//            Console.WriteLine($"Число {input} в обратном порядке: {reversedNumber}");
//        }
//        else
//        {
//            Console.WriteLine("Введите корректное неотрицательное число.");
//        }
//    }
//}

//Задание 2
class Program2
{
    static void Main()
    {
        Console.Write("Введите часы (0-23): ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Введите минуты (0-59): ");
        int minutes = int.Parse(Console.ReadLine());
        hours = hours % 12;
        double minuteAngle = minutes * 6;
        double hourAngle = hours * 30 + (minutes * 0.5);
        double angle = Math.Abs(hourAngle - minuteAngle);

        if (angle > 180)
        {
            angle = 360 - angle;
        }

        Console.WriteLine($"Угол между часовой и минутной стрелками: {angle} градусов.");
    }
}
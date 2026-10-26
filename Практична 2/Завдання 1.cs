using System;

class LeapYear
{
    public static void Run()
    {
        Console.Write("Введіть рік: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 400 == 0)
            Console.WriteLine("Рік високосний");
        else if (year % 100 == 0)
            Console.WriteLine("Рік не високосний");
        else if (year % 4 == 0)
            Console.WriteLine("Рік високосний");
        else
            Console.WriteLine("Рік не високосний");
    }
}
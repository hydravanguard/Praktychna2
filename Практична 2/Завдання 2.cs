using System;

class Triangle
{
    public static void Run()
    {
        Console.Write("Введіть висоту трикутника: ");
        int height = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
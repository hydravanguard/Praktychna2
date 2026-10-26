using System;
using System.Data;

class Calculator
{
    public static void Run()
    {
        Console.WriteLine("Калькулятор");
        Console.Write("Введіть математичний вираз: ");

        string expression = Console.ReadLine();

        try
        {
            DataTable table = new DataTable();
            object result = table.Compute(expression, "");

            Console.WriteLine("Відповідь програми: " + result);
        }
        catch
        {
            Console.WriteLine("Помилка! Перевірте введений вираз.");
        }
    }
}
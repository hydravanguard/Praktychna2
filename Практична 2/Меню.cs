Console.WriteLine("Оберіть завдання:");
Console.WriteLine("1. Високосний рік");
Console.WriteLine("2. Трикутник");
Console.WriteLine("3. Хто хоче стати мільйонером?");
Console.WriteLine("4. Калькулятор");

Console.Write("Ваш вибір: ");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        LeapYear.Run();
        break;
    case "2":
        Triangle.Run();
        break;
    case "3":
        Millionaire.Run();
        break;
    case "4":
        Calculator.Run();
        break;
    default:
        Console.WriteLine("Невірний вибір");
        break;
}
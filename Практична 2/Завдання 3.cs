using System;

class Millionaire
{
    public static void Run()
    {
        int score = 0;

        Console.WriteLine("Хто хоче стати мільйонером?");
        Console.WriteLine("Питання 1. Які кольори має прапор України?");
        Console.WriteLine("1. Жовтий і блакитний");
        Console.WriteLine("2. Червоний і зелений");
        Console.WriteLine("3. Чорний і жовтий");
        Console.WriteLine("4. Зелений і фіолетовий");
        AskQuestion(1, ref score);

        Console.WriteLine("\nПитання 2. У якому місті знаходиться ДТЕУ?");
        Console.WriteLine("1. Вінниця");
        Console.WriteLine("2. Київ");
        Console.WriteLine("3. Львів");
        Console.WriteLine("4. Одеса");
        AskQuestion(2, ref score);

        Console.WriteLine("\nПитання 3. Скільки буде 2 + 2?");
        Console.WriteLine("1. 3");
        Console.WriteLine("2. 4");
        Console.WriteLine("3. 5");
        Console.WriteLine("4. 6");
        AskQuestion(2, ref score);

        Console.WriteLine("\nПитання 4. Яка мова використовується в цьому проєкті?");
        Console.WriteLine("1. Python");
        Console.WriteLine("2. Java");
        Console.WriteLine("3. C#");
        Console.WriteLine("4. HTML");
        AskQuestion(3, ref score);

        Console.WriteLine("\nПитання 5. Скільки днів має тиждень?");
        Console.WriteLine("1. 5");
        Console.WriteLine("2. 6");
        Console.WriteLine("3. 7");
        Console.WriteLine("4. 8");
        AskQuestion(3, ref score);

        Console.WriteLine($"\nГру завершено! Ваш результат: {score} балів.");
    }

    static void AskQuestion(int correctAnswer, ref int score)
    {
        Console.Write("Ваша відповідь: ");
        int answer = Convert.ToInt32(Console.ReadLine());

        if (answer == correctAnswer)
        {
            Console.WriteLine("Correct answer");
            score += 100;
        }
        else
        {
            Console.WriteLine("Wrong answer");
        }

        Console.WriteLine($"Current User Score: {score}");
    }
}
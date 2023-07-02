// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. До 10 символов.

Console.Write("Доброго времени суток! Введите число: ");

    string input = Console.ReadLine();
        if (input.Length >= 3)
            {
            char thirdDigit = input[2];
            Console.WriteLine($"Третья цифра числа: {thirdDigit}, Досвидания");
            }
        else
            {
            Console.WriteLine("Введенное число не имеет третьей цифры. Вводите снова");
            }
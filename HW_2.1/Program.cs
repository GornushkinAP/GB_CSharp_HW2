// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Здравствуйте! Введите трехзначное число: ");
    int number = int.Parse(Console.ReadLine());
    int secondDigit = (number / 10) % 10;
    Console.WriteLine("Вторая цифра числа: " + secondDigit + " Досвидания.");

// тут я пробовал написать условие которое проверяет 
// что пользователь ввел именно трехзначное число.
// не понял как это сделать. Видимо надо было делать через string как во второй задаче.
// // int number = Convert.ToInt32(Console.ReadLine()); 
// // int number.length = 3;

//     if (number.Length != 3)
//     {
//      Console.Write("Число не трехначное! Вводите снова");
//     }
//     else
//     {
//     char secondDigit = number[1];
//     Console.WriteLine($"Вторая цифра числа: {secondDigit}");
//     }


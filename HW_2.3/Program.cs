// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

  Console.WriteLine("Приветствую. Введите номер дня недели (от 1 до 7):");
        int dayOfWeek = int.Parse(Console.ReadLine());

        bool isWeekend = IsWeekend(dayOfWeek);
        Console.WriteLine(isWeekend ? "Да, это выходной день. Спасибо, досвидания." : "Нет, это не выходной день. Спасибо, досвидания.");
    
   static bool IsWeekend(int dayOfWeek)
    {
        return dayOfWeek == 6 || dayOfWeek == 7;
    }


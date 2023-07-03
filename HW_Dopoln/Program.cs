// Дополнительное:
// Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. 
// Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел 
// от 10 до 1000(999 - последнее). (каждый эл-т массива – сгенерирован случайно)
// Пример для 1 элемента массива: 591, сумма: 5+9+1 = 15; 
// произведение: 5*9*1 = 45; 45 / 15 - делится НАЦЕЛО, число "интересное"
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]



//Скажу честно, этот код сгенерировала нейросеть, так как я не понял. 
//Но обещаю разобраться =)
// Так как мне кажется этот код кривой )))

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        Random random = new Random();

        int count = 0;
        while (count < 10)
        {
            int number = random.Next(10, 1000);

            if (IsInterestingNumber(number))
            {
                array[count] = number;
                count++;
            }
        }

        Console.WriteLine("Сгенерированный массив интересных чисел:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();
    }

    static bool IsInterestingNumber(int number)
    {
        int sum = 0;
        int product = 1;

        string numberString = number.ToString();
        foreach (char digit in numberString)
        {
            int currentDigit = int.Parse(digit.ToString());
            sum += currentDigit;
            product *= currentDigit;
        }

        return (product % sum == 0);
    }
}
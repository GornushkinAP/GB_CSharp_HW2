// Дополнительное:
// Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. 
// Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел 
// от 10 до 1000(999 - последнее). (каждый эл-т массива – сгенерирован случайно)
// Пример для 1 элемента массива: 591, сумма: 5+9+1 = 15; 
// произведение: 5*9*1 = 45; 45 / 15 - делится НАЦЕЛО, число "интересное"
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]

int[] numbers = new int[10];
Random random = new Random();

int count = 0;
while (count < 10)
    {
    int number = random.Next(10, 1000);
      if (IsInteresting(number))
        {
        numbers[count] = number;
        count++;
        }
    }

Console.WriteLine("Сгенерированный массив:");
foreach (int number in numbers)
    {
    Console.Write(number + " ");
    }

Console.WriteLine();
Console.ReadLine();

static bool IsInteresting(int number)
    {
    int sum = 0;
    int product = 1;
    int tempNumber = number;
while (tempNumber > 0)
    {
    int digit = tempNumber % 10;
    sum += digit;
    product *= digit;
    tempNumber /= 10;
    }
return product % sum == 0;
    }


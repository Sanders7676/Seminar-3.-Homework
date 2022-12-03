// Задача 19. 
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!

Console.Write("Введите пятизначное число: ");
int num = InputInt();			                // Запускается метод приема 5-значного числа, вводимого через консоль
int[] palindrom = FillArray(num);	            // Запускается метод заполнения массива из знаков 5-значного числа





//IfPalindrom(palindrom);                         // Запускается метод проверки на палиндром
PrintPalindrom(palindrom);

// Метод для приема пятизначного числа, вводимого через консоль

int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum & num >= 10000 & num <= 99999)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        return -1;
    }
}


// Метод заполнения массива из знаков 5-значного числа

int[] FillArray(int num)
{
    int[] array = new int[5];    // {0,0,0,0,0}
    for (int temp = num, i = 5; i >= 1; temp = temp / 10, i = i - 1)
    {
        array[i - 1] = temp % 10;
    }
    return array;
}


// Метод проверки на палиндром

void IfPalindrom(int[] palindrom)
// {
//     if (palindrom[0] == palindrom[4] && palindrom[1] == palindrom[3])
//     {
//         Console.WriteLine($"Число {num} является палиндромом.");
//     }
//     else
//     {
//         Console.WriteLine($"Число {num} не является палиндромом.");
//     }
// }
{
    int[] ifPalindrom = new int[palindrom.Length];

    int size = palindrom.Length;

    for (int i = 0; i <= palindrom.Length - 1; i++, size = size - 1)
    {
        ifPalindrom[i] = palindrom[size - 1];
    }

    if (palindrom == ifPalindrom)
    {
        Console.WriteLine($"Число {num} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {num} не является палиндромом.");
    }
}


void PrintPalindrom(int[] palindrom)
{
    int count = palindrom.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{palindrom[i]} ");
        //Console.Write($"{ifPalindrom[i]} ");
    }
}
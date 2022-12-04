// Задача 19. 
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!



Console.Write("Введите пятизначное число: ");

int num = InputInt();

int[] palindrom = FillArray(num);

int[] ifPalindrom = CreateReversedArray(palindrom);

Console.WriteLine(CheckThePalindrom);


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
    int[] array = new int[5];

    for (int temp = num, i = 5; i >= 1; temp = temp / 10, i = i - 1)
    {
        array[i - 1] = temp % 10;
    }
    
    return array;
}



// Метод разворота массива

int[] CreateReversedArray(int[] palindrom);
{
    int[] reversedArray = new int[5];

    int size = 5;

    for (int i = 0; i <= 4; i++, size = size - 1)
    {
        reversedArray[i] = palindrom[size - 1];
    }

    return reversedArray;
}



// Метод проверки на палиндром

string CheckThePalindrom(int[] palindrom, int[] ifPalindrom)
{
    for (int i = 0; i <= palindrom.Length - 1; i++)
    {
        if (palindrom[i] == ifPalindrom[i])
        { }
        else
        {
            return ("Число не является палиндромом");
        }
    }
    return ("Число является палиндромом");
}
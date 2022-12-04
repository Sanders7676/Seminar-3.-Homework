// Задача 19. 
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!


Console.Write("Введите пятизначное число: ");

int num = InputInt();			                

if(num == -1)
{
    Console.WriteLine("Введено некорректное значение.");
}

int[] palindrom = FillArray(num);

int result = IfPalindrom(palindrom);

if(result == 1)
{
    Console.WriteLine($"Число является палиндромом.");
}
else
{
    Console.WriteLine($"Число не является палиндромом.");
}



// Метод для приема пятизначного числа, вводимого через консоль

int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum & num >= 10000 & num <= 99999)
    {
        return num;
    }
    return -1;
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


// Метод проверки на палиндром

int IfPalindrom(int[] palindrom)
{
    if (palindrom[0] == palindrom[4] && palindrom[1] == palindrom[3])
    {
        return 1;
    }
    else
    {
        return 0;
    }
}
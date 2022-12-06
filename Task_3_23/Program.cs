// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
//Задание должно быть выполнено в методе и метод должен вернуть массив чисел.


Console.Write("Введите число: ");

int num = InputInt();

int[] cubesTable = GetTableOfCubesOfNumbers(num);

Console.WriteLine($"Кубы чисел от 1 до {num}:");

Console.Write("| ");

PrintArray(cubesTable);


// Метод для приема числа, вводимого черз консоль

int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        return -1;
    }
}


// Метод формирования списка кубов чисел от 1 до N

int[] GetTableOfCubesOfNumbers(int num)
{
    int[] array = new int[num];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (int)(Math.Pow(i + 1, 3));
    }

    return array;
}


// Метод печати Массива

void PrintArray(int[] array)
{
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{array[i]} | ");
    }
}


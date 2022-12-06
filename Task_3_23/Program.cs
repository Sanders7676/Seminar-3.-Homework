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


//__________________________________________________________________________________
//__________________________________________________________________________________

//По Семинару 4

//Задача 25: Напишите программу, которая принимает на вход два числа (A и B) 
//и метод который возводит число A в натуральную степень B. 
//Задание должно быть выполнено в методе. 
//В методе не должно быть вывода в консоль. 
//Не использовать Math.Pow()


Console.Write("Введите первое число: ");

int A = InputInt();

Console.Write("Введите второе число: ");

int B = InputInt();

int numberToPower = RaisingNumberToPower (A, B);

Console.Write($"{A} в степени {B} равно {numberToPower}.");


// Метод для приема чисел, вводимых через консоль

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


//Метод возведения числа А в степень В

int RaisingNumberToPower (int A, int B)
{
	for (int result = A, count = 1; count < B; result = result * A, count++)
	{
		return result;
	}
}


//___________________________________________________________________________________________
//___________________________________________________________________________________________

//Задача 27
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11 ; 82 -> 10 ; 9012 -> 12


Console.Write("Введите число: ");

int number = InputInt();

int sumOfDigitsInNumber = SumOfDigitsInNumber (number);

Console.Write($"Сумма цифр в числе {number} равна {sumOfDigitsInNumber}.");


//Метод для приема чисел, вводимых через консоль

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


// Метод нахождения суммы цифр в числе


int SumOfDigitsInNumber(int number)
{
        for (int temp = number, result = 0; temp % 10 > 0; temp = temp / 10, result = result + temp % 10)
	{
        	return result;
    	}
}



//____________________________________________________________________________________________
//____________________________________________________________________________________________

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//Вариант 1 


Console.WriteLine("Введите числа для формирования массива:");

Console.WriteLine("Введите первое число:");

int num1 = InputInt();

Console.Write("Введите следующее число: ");

int num2 = InputInt();

Console.Write("Введите следующее число: ");

int num3 = InputInt();

Console.Write("Введите следующее число: ");

int num4 = InputInt();

Console.Write("Введите следующее число: ");

int num5 = InputInt();

Console.Write("Введите следующее число: ");

int num6 = InputInt();

Console.Write("Введите следующее число: ");

int num7 = InputInt();

Console.Write("Введите следующее число: ");

int num8 = InputInt();


int[] array = FillArray(num);

PrintArray (array);


//Метод для приема чисел, вводимых через консоль

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


// Метод заполнения массива из принятых чисел

int[] FillArray(int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8)
{
    	int[] arr = new int[8];
	
	arr[1] = num1;
	arr[2] = num2;
	arr[3] = num3;
	arr[4] = num4;
    arr[5] = num5;
	arr[6] = num6;
	arr[7] = num7;
	arr[8] = num8;

  	return array;
}


//Метод печати массива

void PrintArray (int[] array)
{
	for (i = 0; i < 8; i++)
	{
		Console.WriteLine($"array[i], ");
	}
}



____________________________________________________________________________________
____________________________________________________________________________________


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//Вариант 2 



//Console.WriteLine("Введите числа для формирования массива:");

//Console.WriteLine("Введите первое число:");

int num = InputInt();

int[] array = FillArray(num);

PrintArray (array);


//Метод для приема чисел, вводимых через консоль

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


// Метод заполнения массива из принятых чисел

int[] FillArray(int num)
{
    int[] array = new int[8];

    for (i = 0; i < 8; i++)
    {
	Console.WriteLine("Введите числа для формирования массива:");
	Console.WriteLine($"Введите {i+1}-e числo:");
	       
	array[i] = num;
    }
    return array;
}



//Метод печати массива

void PrintArray (int[] array)
{
	for (i = 0; i < 8; i++)
	{
		Console.WriteLine($"array[i], ");
	}
}

//____________________________________________________________________________________
//____________________________________________________________________________________

//Вариант 3

int[] arr = new int[8];

int[] array = FillArray(arr);

Console.WriteLine($"Массив выглядит следующим образом: ");

PrintArray (array);



//Еще вариант метода заполнения массива (Тогда убрать метод приема чисел)

int[] FillArray(int[] arr)
{
	for (i = 0; i < 8; i++)
    {
		Console.WriteLine("Введите числа для формирования массива:");
		Console.WriteLine($"Введите {i+1}-e числo:");
	    	int num = int.Parse(Console.ReadLine());
		arr[i] = num;
    }
    return arr;
}


//Метод печати массива

void PrintArray (int[] array)
{
	for (i = 0; i < 8; i++)
	{
        	Console.Write($"{array[i], ");
	}
}


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. 


Console.WriteLine("Введите координаты первой точки:");

Console.Write("Координата X: ");

double x1 = InputInt();

Console.Write("Координата Y: ");

double y1 = InputInt();

Console.Write("Координата Z: ");

double z1 = InputInt();


Console.WriteLine("Введите координаты второй точки:");

Console.Write("Координата X: ");

double x2 = InputInt();

Console.Write("Координата Y: ");

double y2 = InputInt();

Console.Write("Координата Y: ");

double z2 = InputInt();


double result = GetDistanceBetweenPoihts(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Расстояние между первой и второй точками равно {result}.");



// Метод для приема числа, вводимого черз консоль

double InputInt()
{
    bool isNum = double.TryParse(Console.ReadLine(), out double num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение");
        return -1;
    }
}

// Метод для определения расстояния между двумя точками на плоскости по их координатам

double GetDistanceBetweenPoihts(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
}
void zadacha19()
{
    /*Задача 19 Напишите программу, которая принимает на вход пятизначное 
    число и проверяет, является ли оно палиндромом.
    14212 -> нет, 12821 -> да, 23432 -> да*/

    Console.WriteLine("Введите пятизначное число: ");
    int num, r, sum = 0, t;
    num = Convert.ToInt32(Console.ReadLine());
    for (t = num; num != 0; num = num / 10)
    {
        r = num % 10;
        sum = sum * 10 + r;

    }
    if (t == sum)
        Console.WriteLine("Это число является полиндромом");
    else
        Console.WriteLine("это число не является полиндромом");



}

void zadacha21()
{
    /*Задача 21 Напишите программу, которая принимает на вход координаты 
    двух точек и находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53*/


    Console.Write("Введите координаты x первой точки: ");
    int x = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты y первой точки: ");
    int y = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты z первой точки: ");
    int z = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты x первой точки: ");
    int x1 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты y первой точки: ");
    int y1 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты z первой точки: ");
    int z1 = int.Parse(Console.ReadLine()!);

    int A = x - x1;
    int B = y - y1;
    int C = z - z1;

    double length = Math.Sqrt(A * A + B * B + C * C);
    length = Math.Round(length, 2);
    Console.WriteLine($"длина отрезка {length}");

}
//zadacha19();
//zadacha21();
//zadacha23();


void zadacha23()
{
    /* Задача 23 Напишите программу, которая принимает на вход число (N) 
    и выдаёт таблицу кубов чисел от 1 до N.
    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125*/


    Console.WriteLine("введите число: ");
    int num = Math.Abs(int.Parse(Console.ReadLine()!));
    int count = 1;
    while (count <= num)
    {
        Console.Write($"{Math.Pow(count, 3)}");
        if (count != num)
            Console.Write(",");
        count++;

    }

}




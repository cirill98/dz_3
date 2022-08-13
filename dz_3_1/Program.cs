Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

    if (a % 10 == a / 10000 & (a % 100) / 10 == ((a / 1000) % 10))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }

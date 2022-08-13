Console.WriteLine("Введите целое число: ");
int a = Int32.Parse(Console.ReadLine());
int index = 1;
while (index <= Math.Abs(a))
{
    if (index == a)
    {
        Console.WriteLine(index * index * index);
    }
    else
    {
        Console.Write($"{index * index * index}, ");
    }
    index++;
}

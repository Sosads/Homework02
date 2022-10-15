Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
    if(dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Пора на работу, бедолага");
    }
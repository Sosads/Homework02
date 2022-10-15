Console.WriteLine("Введите число.");
string number = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
if (number.Length > 2)
{
    Console.WriteLine(number[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
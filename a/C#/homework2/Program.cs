Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.Write($"Наибольшее число = {num1}");
    }
    else
    {
        Console.Write($"Наибольшее число = {num3}");
    }
}
else
{
    if (num2 > num3)
    {
        Console.Write($"Наибольшее число = {num2}");
    }
    else
    {
        Console.Write($"Наибольшее число = {num3}");
    }
}

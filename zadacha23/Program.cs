
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

int count = 0;
if (n>m)
{
    Console.WriteLine($"Ошибка ввода чисел, число n должно быть больше m");
}
Console.WriteLine("Результат: ");
while (n<=m & count<=m)
{
    int stepen3 = n*n*n;
    Console.WriteLine($"{stepen3}");
    n++;
    count++;
}



/*Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Pow(n,m));
*/
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

    int result = 1;
    for (int i = 1; i <= m; i++)
    {
        result = result * n;
    }
    Console.WriteLine(result);


Console.Clear();
Console.Write("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {m}, N = {n} ->");

void PrintValue(int val, int max)

{
    if (val % 2 == 0)

    {

        if (val == max || val == max - 1) Console.Write(val);

        else Console.Write(val + " , ");

    }

    if (val != max) PrintValue(val + 1, max);

    else return;
}

if (m > n) PrintValue(n, m);

else PrintValue(m, n);



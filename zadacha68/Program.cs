Console.WriteLine("введите n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите m");
int m = Convert.ToInt32(Console.ReadLine());

int nod(int n, int m)
{
    if (m==0)
        return n;
    return nod(m,n%m);
}
Console.WriteLine ($"Наибольший общий делитель: {nod(n,m)}");

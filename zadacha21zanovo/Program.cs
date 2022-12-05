Console.WriteLine("Введите Х точки А");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y точки А");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z точки А");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Х точки В");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y точки В");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z точки В");
int zb = Convert.ToInt32(Console.ReadLine());
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
Double result = Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2));
Console.WriteLine(Math.Round(result,2,MidpointRounding.ToZero));
//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

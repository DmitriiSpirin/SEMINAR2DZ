Console.Write("Введите первое число: ");
int NumA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int NumB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int NumC = Convert.ToInt32(Console.ReadLine());

int max = NumA;

if (NumA>max) max=NumA;
if (NumB>max) max=NumB;
if (NumC>max) max=NumC;

Console.WriteLine(max);

// Были проблемы с изменением названия комита

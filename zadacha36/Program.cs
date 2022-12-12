void FillArray(int[] ArrayToFill, int First, int Last)
{
    for (int i = 0; i < ArrayToFill.Length; i++)
    {
        ArrayToFill[i] = new Random().Next(First, Last + 1);
    }
}

void PrintArray(int[] ArrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < ArrayToPrint.Length; i++)
    {
        Console.Write($"{ArrayToPrint[i]}");
        if (i < ArrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int SumEvenElements(int[] ArrayToSeek)
{
    int result = 0;
    for (int i = 1; i < ArrayToSeek.Length; i++)
    {
        if (i % 2 != 0)
        {
            result = result + ArrayToSeek[i];
        }
    }
    return result;
}

int ArraySize = new Random().Next(1, 10);
int[] Array = new int[ArraySize];
int Final = 0;

FillArray(Array, -10, 10);
Final = SumEvenElements(Array);
Console.WriteLine("В массиве:");
PrintArray(Array);

Console.WriteLine($"Сумма значений нечётных элементов =  {Final}");

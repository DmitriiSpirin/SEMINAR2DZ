//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int num = new Random().Next(1,1000);

Console.WriteLine($"Сгенерировано случайное число - {num}");

int res = num % 100;
int fin = res / 10;

Console.WriteLine($"вторая цифра: {fin}");

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine ("Введите номер дня недели");
int num= Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Является ли день выходным:");

if (num==1)
{
Console.WriteLine ("нет");
   
}
else if (num==2)
{
Console.WriteLine ("нет");
}
else if (num==3)
{
 Console.WriteLine ("нет");   
}
else if (num==4)
{
 Console.WriteLine ("нет");   
}
else if (num==5)
{
 Console.WriteLine ("нет");   
}
else if (num==6)
{
 Console.WriteLine ("да");   
}
else if (num==7)
{
 Console.WriteLine ("да");   
}
else 
Console.WriteLine ("Введено число не дня недели");

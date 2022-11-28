/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

int Number = new int ();
Console.WriteLine("Введите число");
Number = Convert.ToInt32(Console.ReadLine());
int result = Number/2;
if (result == 2)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

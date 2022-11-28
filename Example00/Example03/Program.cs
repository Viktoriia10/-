/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */


int Number1 = new int();
Console.WriteLine("Введите число");
Number1 = Convert.ToInt32(Console.ReadLine());
int Number2 = new int();
Console.WriteLine("Введите число");
Number2 = Convert.ToInt32(Console.ReadLine());
int Number3 = new int();
Console.WriteLine("Введите число");
Number3 = Convert.ToInt32(Console.ReadLine());
if (Number1 < Number2)
{
    Console.WriteLine(Number2);
}
if (Number2 < Number3)
{
    Console.WriteLine(Number3);
}
if (Number3 < Number1)
{
    Console.WriteLine(Number1); 
}
else
{
    Console.Write("Максимальное число");
    Console.WriteLine(Number3);
}
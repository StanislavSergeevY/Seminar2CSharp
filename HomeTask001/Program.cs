// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

int Volue(int x)
{
  x = x / 10 % 10;
  return x;
}

Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n < 100 || n >= 1000)
  Console.WriteLine($"Введено не корректное число '{n}', повторите ввод!");
else
  Console.WriteLine($"Второе число '{Volue(n)}'");
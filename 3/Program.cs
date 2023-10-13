// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа 0 и 1.


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int x0=0;
int x1=1;
int x2=x0 + x1;

for (int i = 0; i < n; i++)
{
    Console.Write($"{x0} ");
    x2=x0 + x1;
    x0=x1;
    x1=x2;
}
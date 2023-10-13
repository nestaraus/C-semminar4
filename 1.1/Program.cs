// Напишите на вход три числа и проверьте может ли существовать треугольник со сторонами такой длинны.
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"[{string.Join(", ", size)}]");
if (size[0]<size[1]+size[2] &&
    size[1]<size[2]+size[0] &&
    size[2]<size[1]+size[0])
Console.Write("yes");
else
Console.Write("no");
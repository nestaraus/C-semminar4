// Напишите программу которая перевернет одномерный массив(последний элемент будет на первом месте, а первый элемент на последнем)

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
    }
}

void ReleaseArray(int[] array)
{
int temp=0;
for (int i = 0; i < array.Length/2; i++)
{
    temp = array[i];
    array[i]= array[array.Length-1-i];
    array[array.Length-1-i]=temp;
}
}


Console.Clear();
Console.Write("Размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");
ReleaseArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");
// Напишите программу, которая создает копию заданного массива с помощью поэлементного копирования


void copy(int[] arr, int[] newArr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i]=arr[i];

    }
}

int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[] newArr = new int [array.Length];
copy(array,newArr);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", newArr)}]");

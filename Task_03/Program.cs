// Написать программу замену элементов массива на противоположные.

void FillArray(int[] arrayColection)
{
    int index = 0;
    while (index < arrayColection.Length)
    {
        arrayColection[index] = new Random().Next(-100, 101);
        Console.Write($" {arrayColection[index]}");
        index++;
    }
}

void PrintArray(int[] arrayColection)
{
    int index = 0;
    while (index < arrayColection.Length)
    {
        arrayColection[index] = arrayColection[index] * -1;
        Console.Write($" {arrayColection[index]}");
        index++;
    }
}

int[] array = new int[10];
FillArray(array);
Console.WriteLine();
PrintArray(array);
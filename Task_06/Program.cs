// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];
Console.WriteLine("Задайте минимальное число массива : ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте максимальное число массива : ");
int max = int.Parse(Console.ReadLine() ?? "0") + 1;

void FillArray(int[] arrayColection)
{
    Console.Write($"Числа массива: ");
    int index = 0;
    while (index < arrayColection.Length)
    {
        arrayColection[index] = new Random().Next(min, max);
        Console.Write($" {arrayColection[index]}");
        index++;
    }
    Console.WriteLine();
}
void PrintArray(int[] arrayColection)
{
    int index = 0;
    int count = 0;
    while (index < arrayColection.Length)
    {
        if (arrayColection[index] >= 10 && arrayColection[index] <= 99)
        {
            count = count + 1;
        }
        index++;
    }
    Console.WriteLine($"Количество элементов из отрезка [10,99] в массиве = {count}");
}
FillArray(array);
PrintArray(array);

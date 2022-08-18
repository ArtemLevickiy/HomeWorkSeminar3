// Определить, присутствует ли в заданном массиве, некоторое число.

int count = 0;
Console.WriteLine("Задайте размер массива : ");
int[] array = new int[int.Parse(Console.ReadLine() ?? "0")];
Console.WriteLine("Задайте число которое ищем в массиве (-15,15) : ");
int number = int.Parse(Console.ReadLine() ?? "0");
void FillArray(int[] arrayColection)
{
    int index = 0;
    while (index < arrayColection.Length)
    {
        arrayColection[index] = new Random().Next(-15, 16);
        index++;
    }
}
void PrintArray(int[] arrayColection)
{
    int index = 0;
    while (index < arrayColection.Length)
    {
        Console.WriteLine($"Данные массива в {index + 1} ячейке = {arrayColection[index]}");
        if (number == arrayColection[index])
        {
            count++;
        }
        index++;
    }
}
FillArray(array);
PrintArray(array);
if (count > 0)
    Console.WriteLine($"Заданное число {number} есть в массиве.");
else
    Console.WriteLine($"Заданного числа {number} нет в массиве.");
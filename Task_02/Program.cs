// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива.

void FillArray(int[] arrayColection)
{
    int index = 0;
    while (index < arrayColection.Length)
    {
        arrayColection[index] = new Random().Next(0, 10);
        index++;
    }
}
void PrintArray(int[] arrayColection)
{
    int index = 0;
    while (index < arrayColection.Length)
    {
        Console.WriteLine($"Данные массива в {index + 1} ячейке = {arrayColection[index]}");
        index++;
    }
}
void ChangeArray(int[] arrayColection)
{
    int index = 0;
    int sum = 0;
    while (index < arrayColection.Length)
    {
        sum = sum + arrayColection[index];
        index++;
    }
    Console.WriteLine($"Сумма чисел массива = {sum}");
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);
ChangeArray(array);
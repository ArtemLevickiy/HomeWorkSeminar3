// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

Console.WriteLine("Задайте длинну массива : ");
int Length = int.Parse(Console.ReadLine() ?? "0");
double[] array = new double[Length];
void FillArray(double[] arrayColection)
{
    int index = 0;
    Console.Write($"Числа массива: ");
    while (index < arrayColection.Length)
    {
        arrayColection[index] = new Random().Next(1 , 11);

        Console.Write($" {arrayColection[index]}");
        index++;
    }
    Console.WriteLine();
}
void PrintArray(double[] arrayColection)
{
    int index = 0;
    double difference=0;
    double max = 0;
    double min =10;
    while (index < arrayColection.Length)
    {
        if(arrayColection[index]>max)
        {
            max = arrayColection[index];
        }
        index++;
    }
    while(index < arrayColection.Length)
    {
        if(arrayColection[index]<max)
        {
            min = arrayColection[index];
        }
        index++;
    }
    difference = max - min;
    Console.Write($"Разница между максимальным и минимальным числом: {difference}");
}
FillArray(array);
PrintArray(array);

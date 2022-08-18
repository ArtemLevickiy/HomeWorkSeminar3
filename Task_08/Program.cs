// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.WriteLine("Задайте длинну массива : ");
int Length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[Length];
void FillArray(int[] arrayColection)
{
    int index = 0;
    Console.Write($"Числа массива: ");
    while (index < arrayColection.Length)
    {
        arrayColection[index] = new Random().Next(1, 10);

        Console.Write($" {arrayColection[index]}");
        index++;
    }
    Console.WriteLine();
}
void PrintArray(int[] arrayColection)
{
    int index = 0;
    int product = 0;
    int firstNumber = 0;
    int secondNumber = 0;
    int N = 1;
    Console.Write($"Произведение пар чисел в одномерном массиве: ");
    while (index < arrayColection.Length)
    {
        firstNumber = arrayColection[index];
        if (index < arrayColection.Length - N)
        {
            secondNumber = arrayColection[arrayColection.Length - N];
            product = firstNumber * secondNumber;
            Console.Write(product + " ");
        }
        index++;
        N++;
    }
}
FillArray(array);
PrintArray(array);

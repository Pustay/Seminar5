// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Размер массива: ");
int i = Convert.ToInt32(Console.ReadLine());
int[] numb = new int[i];
FillArrayRandomNumbers(numb);
Console.WriteLine("Наш массив: ");
PrintArray(numb);
int count = 0;

for (int z = 0; z < numb.Length; z++)
    if (numb[z] % 2 == 0)
        count++;

Console.WriteLine($"Чётных чисел в массиве {count}");

void FillArrayRandomNumbers(int[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        numb[i] = new Random().Next(100, 999);
    }
}
void PrintArray(int[] numb)
{
    Console.Write("[ ");
    for (int i = 0; i < numb.Length; i++)
    {
        Console.Write(numb[i] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}
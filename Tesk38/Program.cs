// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int i = Convert.ToInt32(Console.ReadLine());
double[] numb = new double[i];
FillArrayRandomNumbers(numb);
Console.Write("Наш массив: ");
PrintArray(numb);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numb.Length; z++)
{
    if (numb[z] > max)
    {
        max = numb[z];
    }
    if (numb[z] < min)
    {
        min = numb[z];
    }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}, разница между {max} и {min} = {max - min}");

void FillArrayRandomNumbers(double[] numb)
{
    for (int j = 0; j < numb.Length; j++)
    {
        numb[j] = Convert.ToDouble(new Random().Next(0,100));
    }
}
void PrintArray(double[] numb)
{
    Console.Write("[ ");
    for (int j = 0; j < numb.Length; j++)
    {
        Console.Write(numb[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
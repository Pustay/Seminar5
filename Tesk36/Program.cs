// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int i = Convert.ToInt32(Console.ReadLine());
int[] numb = new int[i];
FillArrayRandomNumbers(numb);
Console.Write("Наш массив: ");
PrintArray(numb);
int sum = 0;

for (int z = 0; z < numb.Length; z+=2)
    sum = sum + numb[z];

    Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numb)
{
    for(int i = 0; i < numb.Length; i++)
        {
            numb[i] = new Random().Next(-100, 100);
        }
}
void PrintArray(int[] numb)
{
    Console.Write("[ ");
    for(int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
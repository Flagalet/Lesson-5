// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
int [] MasArray(int size)
{
    Console.Write($"{"["}");
    int[] num = new int [size];
    for(int i = 0; i < size; i++)
    {
        num[i] = new Random(). Next(99,1000);
        Console.Write(num[i]);
        if(i < size -1)
        {
        Console.Write($"{", "}");
        }
    }
    Console.Write($"{"]"}");
    return num;

}
void NumArray(int[] array)
{
    int b = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            b++;
        }      
    }
    Console.Write($"Колличество четных элементов -> {b}");    
}
Console.Clear();
Console.WriteLine("Введите длинну массива");
int numers = int.Parse(Console.ReadLine()!);
Console.Clear();
int[] numarray = MasArray(numers);
Console.WriteLine();
NumArray(numarray);
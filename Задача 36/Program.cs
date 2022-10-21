//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
int [] MasArray(int size)
{
    Console.Write($"{"["}");
    int[] num = new int [size];
    for(int i = 0; i < size; i++)
    {
        num[i] = new Random(). Next(0, 99);
        Console.Write(num[i]);
        if(i < size -1)
        {
        Console.Write($"{", "}");
        }
    }
    Console.Write($"{"]"}");
    return num;

}
int NewInt(int[] num)
{
    
    int sum = 0;
    for( int i = 1; i < num.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += num[i];
        }
    }
    return sum;
}
Console.Clear();
Console.WriteLine("Введите длинну массива");
int num = int.Parse(Console.ReadLine()!);
int[] numarray = MasArray(num);
Console.WriteLine( $"Сумма элементов: {NewInt(numarray)}");

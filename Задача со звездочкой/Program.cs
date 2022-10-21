// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
int [] Numers(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
            res[i] = int.Parse(nums[i]);
    }
    return res;
}
void Mas(int [] array)
{   
    Console.WriteLine();
    Console.Write($"{"["}");
    int num = 0;
    for(int i = 0; i < array.Length-1; i++)
    {
        for(int n = i + 1; n < array.Length; n++)
        {
            if (array[i] < array[n])
            {
                num = array[i];
                array[i] = array[n];
                array[n] = num;
            }
        }

    }
    Console.Write(String.Join(", ", array));
    Console.Write($"{"]"}");
    Console.WriteLine();

}

Console.Clear();
Console.Write("Введите числа массива: ");
string numers = Console.ReadLine();
int [] num = Numers(numers);
Mas(num);
Console.WriteLine();
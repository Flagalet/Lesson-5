// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
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

int Sum (int[] array)
{
    int minmax = 0;
    int min = array[0];
    int max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
         {
            min = array[i];
         }
        
        if  (array[i] > max) 
        {
            max = array[i];
        }

    }
    minmax = max - min;
    return minmax;
}
Console.Clear();
Console.Write("Введите числа массива:  ");
string array = Console.ReadLine();
int [] numers = Numers(array);
int nums = Sum(numers);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным числом массива => {nums}");
Console.WriteLine();

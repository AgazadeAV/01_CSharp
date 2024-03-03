int[] FillArray(int[] arr)
{
    int i = 0;
    while (i < arr.Length)
    {
        arr[i] = i + 1;
        i++;
    }
    return arr;

}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }
}

int GetSumOfElements(int[] arr)
{
    int sum = 0;
    foreach (int item in arr)
    {
        sum += item;
    }
    return sum;
}

int GetProductOfElements(int[] arr)
{
    int product = 1;
    foreach (int item in arr)
    {
        product *= item;
    }
    return product;
}

int n = 10;
int[] array = new int[n];

FillArray(array);
PrintArray(array);
int sum = GetSumOfElements(array);
int product = GetProductOfElements(array);
Console.WriteLine();
Console.WriteLine("The sum of array elements: " + sum);
Console.WriteLine("The product of array elements: " + product);
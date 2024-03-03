string GetNumbers(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == false)
        {
            letters += e;
        }
    }
    return letters;
}

int GetSizeOfArray(int num)
{
    int size = 0;
    while (num > 0)
    {
        num /= 10;
        size++;
    }
    return size;
}

int[] FillArray(int num, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[size - 1 - i] = num % 10;
        num /= 10;
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}

string str = Console.ReadLine()!;
string result = GetNumbers(str);
Console.WriteLine(result);
int number = Convert.ToInt32(result);
Console.WriteLine(number);
int size = GetSizeOfArray(number);
int[] arrayFromConsole = FillArray(number, size);
PrintArray(arrayFromConsole);
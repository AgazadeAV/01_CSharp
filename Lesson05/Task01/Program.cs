long FindFactorial(int number)
{
    if (number == 1 || number == 0)
    {
        Console.WriteLine($"Stop: {number}");
        return 1;
    }
    Console.WriteLine(number);
    return number * FindFactorial(number - 1);
}

Console.Write(FindFactorial(5));
 

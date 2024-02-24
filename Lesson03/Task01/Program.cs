double CalculateFormula(int a, int b, int c, int d)
{
    double numinator = a * b;
    int denomenator = c + d;
    double result = numinator / denomenator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);


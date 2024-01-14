Calculator calculator = new Calculator();

int answer = calculator.Add(10, 84);

Console.WriteLine($"10 + 84 is {answer}.");

class Calculator
{
    public int Add(int number1, int number2)
    {
        return number1 + number2;
    }
}
using Calculator;


int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Addition: {Operations.Add(a, b)}");
Console.WriteLine($"Subtraction: {Operations.Subtract(a, b)}");
Console.WriteLine($"Multiplication: {Operations.Multiply(a, b)}");
Console.WriteLine($"Division: {Operations.Divide(a, b)}");
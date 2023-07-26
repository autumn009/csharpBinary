Console.WriteLine("float");
float a = float.MaxValue;
Console.WriteLine($"a={a}");
Console.WriteLine($"a*2={a * 2}");

Console.WriteLine("double");
double b = double.MaxValue;
Console.WriteLine($"b={b}");
Console.WriteLine($"b*2={b * 2}");

Console.WriteLine("decimal");
decimal d = decimal.MaxValue;
Console.WriteLine($"d={d}");
try
{
    Console.WriteLine($"d*2={d * 2}");
}
catch (OverflowException e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("指定なし");
byte a = byte.MaxValue;
a++;
Console.WriteLine($"a={a}");
checked
{
    try
    {
        Console.WriteLine("checked");
        byte b = byte.MaxValue;
        b++;
        Console.WriteLine($"b={b}");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
unchecked
{
    Console.WriteLine("unchecked");
    byte c = byte.MaxValue;
    c++;
    Console.WriteLine($"c={c}");
}

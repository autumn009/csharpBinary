byte n = 10;
Console.WriteLine("*** 1つ増やす ***");
sub(1);
Console.WriteLine("*** 1つ減らす ***");
sub(255);

void sub(byte delta)
{
    Console.WriteLine($"{delta}を足します。");
    n += delta;
    Console.WriteLine($"nは{n}になりました。");
}

byte a = byte.MinValue + 1;
for (int i = 0; i < 4; i++)
{
    string s = "";
    if (a == byte.MaxValue) s = "型の最大値です";
    if (a == byte.MinValue) s = "型の最小値です";
    Console.WriteLine($"a={a,3} {Convert.ToString(a, 2).PadLeft(8, '0')} {s}");
    if (i == 3) break;
    a--; Console.WriteLine("a--;");
}

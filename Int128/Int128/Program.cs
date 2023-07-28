Int128 a = long.MaxValue;
for(; ;)
{
    a *= 16;
    if (a <= 0) break;
    Console.WriteLine(a);
}

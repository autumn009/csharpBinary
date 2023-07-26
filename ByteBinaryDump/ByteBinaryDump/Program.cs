byte n = 0;
while (true)
{
    Console.WriteLine($"{n,3}={Convert.ToString(n,2).PadLeft(8,'0')}");
    if (n == byte.MaxValue) break;
    n++;
}

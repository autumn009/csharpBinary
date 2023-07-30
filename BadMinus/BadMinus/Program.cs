short a = short.MinValue;
sub(a);
short b = (short)-a;
sub(b);

void sub(short x)
{
    Console.WriteLine($"x={x} {Convert.ToString(x, 2).PadLeft(16, '0')}");
}

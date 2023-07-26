sub(10);
sub(2);

void sub(float dval)
{
    Console.WriteLine($"div and mult by {dval}");
    float s = 1;
    float a = s;
    for (int i = 0; i < 10; i++) a /= dval;
    for (int i = 0; i < 10; i++) a *= dval;
    Console.WriteLine($"s={s}");
    Console.WriteLine($"a={a}");
    if (s == a) Console.WriteLine("s == a"); else Console.WriteLine("s != a");
}
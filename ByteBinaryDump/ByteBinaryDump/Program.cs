// 2進数ダンプ最大8桁
sub(2, 8);
// 8進数ダンプ最大3桁
sub(8, 3);
// 16進数ダンプ最大2桁
sub(16, 2);

void sub(int radix, int width)
{
    Console.WriteLine($"{radix}進数");
    byte n = 0;
    while (true)
    {
        if (n <= 8 || n >= 250)
            Console.WriteLine($"{n,3}={Convert.ToString(n, radix).PadLeft(width, '0')}");
        else if (n == 9) Console.WriteLine("(中略)");
        if (n == byte.MaxValue) break;
        n++;
    }
    Console.WriteLine();
}

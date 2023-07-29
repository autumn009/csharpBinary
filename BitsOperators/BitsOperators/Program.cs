sub("全ビットを反転", (n) => ~n);
sub("指定ビットだけを反転させろ(最も右の2ビット)", (n) => n ^ 0b11);
sub("ビットを立てろ(最も右の1ビット)", (n)=>n | 0b0000_0001);
sub("ビットを降ろせ(最も右から2番目の1ビット)", (n) => n & ~0b10);
sub("ビットを右へ(符合あり)", (n) => n >> 1);
sub("ビットを右へ(符合なし)", (n) => n >>> 1);
sub("ビットを左へ", (n) => n << 1);

void sub(string label, Func<int, int> func)
{
    uint initialBits = 0b1000_0000_0000_0000_0000_0000_0000_0110;
    Console.WriteLine(label);
    Console.WriteLine(Convert.ToString(initialBits, 2).PadLeft(32, '0'));
    int r = func((int)initialBits);
    Console.WriteLine(Convert.ToString(r, 2).PadLeft(32, '0'));
}

sub("byte", byte.MinValue, byte.MaxValue);
sub("sbyte", sbyte.MinValue, sbyte.MaxValue);
sub("short", short.MinValue, short.MaxValue);
sub("ushort", ushort.MinValue, ushort.MaxValue);
sub("int", int.MinValue, int.MaxValue);
sub("uint", uint.MinValue, uint.MaxValue);
sub("long", long.MinValue, long.MaxValue);
sub("ulong", ulong.MinValue, ulong.MaxValue);
sub("Int128", Int128.MinValue, Int128.MaxValue);
sub("UInt128", UInt128.MinValue, UInt128.MaxValue);
sub("Half", Half.MinValue, Half.MaxValue);
sub("float", float.MinValue, float.MaxValue);
sub("double", double.MinValue, double.MaxValue);
sub("decimal", decimal.MinValue, decimal.MaxValue);

void sub<T> (string name, T min, T max) where T : IComparable
{
    Console.WriteLine($"{name}\t{min}\t{max}");
}

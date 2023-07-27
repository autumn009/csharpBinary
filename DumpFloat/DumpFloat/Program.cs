dump(-1.0f);
dump(0.0f);
dump(0.5f);
dump(1.0f);
dump(2.0f);
dump(4.0f);
dump(0.1f);
dump(0.2f);
dump(0.3f);
dump(0.4f);

void dump(float a)
{
    var sb= new System.Text.StringBuilder();
    var bytes = BitConverter.GetBytes(a);
    for (int i = bytes.Length - 1; i >= 0; i--)
        sb.Append($"{Convert.ToString(bytes[i], 2).PadLeft(8, '0')}");
    var s = sb.ToString();
    Console.WriteLine($"{a,8}={s.Substring(0,1)} {s.Substring(1, 8)} {s.Substring(9, 23)}");
}

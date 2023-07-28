float a = 1;
for (int i = 0; i < 255; i++)
{
    a /= 1024;
    sub(i.ToString(), a);
    if (float.IsNormal(a) == false) break;
}
void sub(string label, float a)
{
    var sb = new System.Text.StringBuilder();
    var bytes = BitConverter.GetBytes(a);
    for (int i = bytes.Length - 1; i >= 0; i--)
        sb.Append($"{Convert.ToString(bytes[i], 2).PadLeft(8, '0')}");
    var s = sb.ToString();
    Console.WriteLine($"{label,2} {a,13}={s.Substring(0, 1)} {s.Substring(1, 8)} {s.Substring(9, 23)} float.IsNormal(a)={float.IsNormal(a)}");
}

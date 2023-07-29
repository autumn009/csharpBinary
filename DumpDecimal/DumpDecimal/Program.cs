dump(0.001m);
dump(0.01m);
dump(0.1m);
dump(10m);
dump(100m);
dump(-1.0m);

void dump(decimal a)
{
    var sb = new System.Text.StringBuilder();
    var nums = Decimal.GetBits(a);
    for (int i = nums.Length - 1; i >= 0; i--)
        sb.Append($"{Convert.ToString(nums[i], 2).PadLeft(32, '0')}");
    var s = sb.ToString();
    Console.WriteLine($"{a,8}=\n\t{s.Substring(0, 1)} {s.Substring(1, 7)} {s.Substring(8, 8)} {s.Substring(16, 16)}\n\t{s.Substring(32, 96)}");
}

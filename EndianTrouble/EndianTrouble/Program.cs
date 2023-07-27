Console.WriteLine("write 0xabcd to file");
var right = 0xabcd;
Console.WriteLine($"{right} ({right:X4})");
using (var stream = File.Create("sample.bin"))
{
    using (var writer = new BinaryWriter(stream))
    {
        writer.Write(right);
    }
}

Console.WriteLine("read little-endian");
var image = File.ReadAllBytes("sample.bin");
var val = image[0] + image[1] * 256;
Console.WriteLine($"{val} ({val:X4})");

Console.WriteLine("read big-endian");
var val2 = image[0] * 256 + image[1];
Console.WriteLine($"{val2} ({val2:X4})");

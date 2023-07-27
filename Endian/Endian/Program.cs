string endian = "ビッグ";
if (BitConverter.IsLittleEndian) endian = "リトル";
Console.WriteLine($"このシステムは{endian}エンディアンです。");

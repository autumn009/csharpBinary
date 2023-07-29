var logs = new string[256];
byte logPointer = 0;

for (int i = 0; i < 300; i++) addLog("DATA:" + i);
dumpLog();

void addLog(string s)
{
    logs[logPointer++] = s;
}

void dumpLog()
{
    for (int i = 0; i < 256; i++)
    {
        Console.Write($"{logs[--logPointer]},");
    }
}

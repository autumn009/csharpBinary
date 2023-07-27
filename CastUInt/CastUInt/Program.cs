uint a = 123;
// ↓キャストで型の不整合を解消している
sub((int)a);

void sub(int x) => Console.WriteLine($"x={x}");

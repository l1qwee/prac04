using System.Diagnostics;
using System.IO.Pipelines;
Console.WriteLine($"Логических процессов (ядер): {Environment.ProcessorCount}");

#if DEBUG
Console.WriteLine("Режим сборки: DEBUG");
#else
Console.WriteLine("Режим сборки: RELEASE");
#endif

long counter = 0;
var stopwatch = Stopwatch.StartNew();

while (stopwatch.ElapsedMilliseconds < 1000)
{
    counter++;
}

Console.WriteLine($"Итераций примерно за 1 секунду: {counter:N0}");
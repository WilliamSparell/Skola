using Datalogi_övning_1;
using System.Diagnostics;

for (int i = 0; i < 5; i++)
{
    Övning3();
}

void Övning1()
{
    Random rnd = new Random();
    double[] arr = new double[100000000];
    Stopwatch stopWatch = new Stopwatch();
    stopWatch.Start();
    for (int i = 0; i < arr.Length; i++)
    {
        int number = rnd.Next(100, 200);

        arr[i] = number;
    }
    stopWatch.Stop();
    Console.WriteLine("RunTime " + stopWatch.ElapsedMilliseconds);
}

void Övning1b()
{
    double summa = 0;
    Random rnd = new Random();
    double[] arr = new double[100000000];
    for (int i = 0; i < arr.Length; i++)
    {
        int number = rnd.Next(100, 200);

        arr[i] = number;
    }

    Stopwatch stopWatch = new Stopwatch();
    stopWatch.Start();
    for (int i = 0; i < arr.Length; i++)
    {
        summa += arr[i];
    }
    stopWatch.Stop();
    Console.WriteLine("RunTime " + stopWatch.ElapsedMilliseconds);
}

void Övning2()
{
    const int count = 100000000;
    Stopwatch stopWatch = new Stopwatch();
    stopWatch.Start();
    Random rnd = new Random();
    List<double> list = new List<double>();

    for (int i = 0; i < count; i++)
    {
        list.Add(rnd.Next(100, 200));
    }
    stopWatch.Stop();
    Console.WriteLine("RunTime " + stopWatch.ElapsedMilliseconds);
}

void Övning2b()
{
    const int count = 100000000;
    double summa = 0;
    Random rnd = new Random();
    List<double> list = new List<double>();
    for (int i = 0; i < count; i++)
    {
        list.Add(rnd.Next(100, 200));
    }

    Stopwatch stopWatch = new Stopwatch();
    stopWatch.Start();
    for (int i = 0; i < count; i++)
    {
        summa += list[i];
    }
    stopWatch.Stop();
    Console.WriteLine("RunTime " + stopWatch.ElapsedMilliseconds);
}

void Övning3()
{
    Stopwatch timer = Stopwatch.StartNew();
    const int count = 10000;
    double summa = 0;
    Random rnd = new Random();
    MyLinkedList<double> list = new();
    for (int i = 0; i < count; i++)
    {
        list.Push(rnd.Next(100, 200));
    }
    timer.Stop();
    Console.WriteLine("RunTime 1 " + timer.ElapsedMilliseconds);


    timer = Stopwatch.StartNew();
    for (int i = 0; i < count; i++)
    {
        summa += list.Get(i);
    }
    timer.Stop();
    Console.WriteLine("RunTime 2 " + timer.ElapsedMilliseconds);
}

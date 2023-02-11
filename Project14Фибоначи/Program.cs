Console.Clear();

double Fibon(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibon(n - 1) + Fibon(n - 2);
}
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibon(i));   
}

//Console.WriteLine(Fibon(10));
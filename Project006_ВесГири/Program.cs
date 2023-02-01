int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;                   //Задали значение переменной max весом первой гири

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max= ");                 //Line - перескакивает на след строку
Console.WriteLine(max);
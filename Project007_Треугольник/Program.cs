// Алгоритм 
// 1. Определить три точки
// 2. Выбрать две любых
// 3. Найти середину
// 4. Поставить точку
// 5. Выбрать случайную вершину треугольника
// 6. Соединить её с полученной на шаге 4 точкой
// 7. Перейти к шагу 3
// 8. Зациклить шаги 3-7

Console.Clear();
//Console.SetCursorPosition(10, 4);           //SetCursorPosition - задаёт отступы от левого и верхнего края
//Console.WriteLine("+");

int xa = 50, ya = 1,
    xb = 1, yb = 25,
    xc = 100, yc = 25;

Console.SetCursorPosition(xa, ya);           
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);           
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);           
Console.WriteLine("+");

int x = xa,  y = xb;

int count = 0;

while(count < 10000);
{
    //Выбираем одну из 3 точек
    int what = new Random().Next(0, 3);        //new Random().Next - формирует псевдослучайные числа. Полуинтервал [0;3) 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
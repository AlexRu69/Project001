Console.Write("Привет, введите ваше имя: ");  //Спрашиваем имя
string username = Console.ReadLine();         //Создаём переменную для хранения введённого имени

if(username.ToLower() == "маша")              //ToLower - переводит все значения в нижний регистр         
{
    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.WriteLine("Привет, " );
    Console.WriteLine(username);
}
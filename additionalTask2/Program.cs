//  В переменной string есть секретное сообщение, во второй есть пароль. 
//Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение

string secretMessage = "Секретное сообщение : TopSecret";
Console.WriteLine("Мы вам даём  случайное количество попыток для введения пароля xD : ");
int chances = Convert.ToInt32(new Random().Next(3,5));
Console.WriteLine(chances);
int tries=1;
while (tries <= chances)
{
    Console.WriteLine("Введите пароль для получения секретного сообщения");
    string passwordInput = Console.ReadLine();
    string password = "key";
    if (passwordInput == password)
    {
        Console.WriteLine(secretMessage);
        break;
    }
    else if (passwordInput != password && tries < chances)
    {
        Console.WriteLine("Введён неправильный пароль");
    }
    else if (passwordInput != password && tries == chances)
    {
        Console.WriteLine("Вы исчерпали количество попыток ввода паролей");
    }
    tries++;
}


/*string secret = "Секретики подъехали!";
string password = "123";
for (int i = 1; i <= 1; i++)
{
    string firstTry = Zagadka("Первая попытка!");
    if (firstTry == password)
    {
        Console.WriteLine($"Угадал! {secret}");
        break;
    }
    else Console.WriteLine("Проебал!");
    string secondTry = Zagadka("2 попытка!");
    if (secondTry == password)
    {
        Console.WriteLine($"Угадал! {secret}");
        break;
    }
    else Console.WriteLine("Проебал!");
    string thirdTry = Zagadka("3 попытка!");
    if (thirdTry == password)
    {
        Console.WriteLine($"Угадал! {secret}");
        break;
    }
    else Console.WriteLine("Проебал!");
}
string Zagadka(string popitka)
{
    Console.WriteLine($"Введите Ваш ответ {popitka}: ");
    string otvet = Console.ReadLine();
    return otvet;
}*/
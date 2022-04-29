//Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается

//if ввод не == "exit", то снова запрос ввода.

//Console.WriteLine("Введите слово для выхода из цикла");
//string password = Console.ReadLine();
string password = "";
while (password != "exit")
{
    Console.WriteLine("Введите слово для выхода из цикла");
    password = Console.ReadLine();     
    /*if (newpassword == "exit")
    {
        break;
    }*/
}

/* ЧЕСТНО СПИЗДИЛ С ИНЕТА
while (true) //вечный цикл
{
    Console.WriteLine("пароль для выхода:");
    string input = Console.ReadLine(); //Получаем введенные данные 
    if (input == "exit") //Если пользователь ввел слово exit, то 
        break; //Выходим из вечного цикла
    
}*/
bool exit= false;
bool flag_set_pass=false;
bool flag_set_name=false;
string [] ARR_Comands=new string [] {"SetName- установить имя","Help-список комманд","SetPassword- установить пароль","Exit-выход","WriteName-вывести имя после ввода пароля"};
string Name = "";                                     //не сумел запихнуть массив стринг как условие Case ("ARR_Comands" является переменная,
string Pass = "";                                     //но используется как тип) чтобы не пропадало зря испульзуется как вывод всего в кейсе help
Console.WriteLine("Введите команду :");
while (!exit)
{
  string commands=Console.ReadLine();
  commands=commands.ToLower();
  switch (commands)
  {
    case   "exit":
    exit=!exit;
    break;
    case "help":
    for (int i = 1; i < ARR_Comands.Length; i++)
    {
      Console.WriteLine(ARR_Comands[i]);
    }
    Console.WriteLine("Введите команду :");
    break;
    case "setpassword":
    Console.WriteLine("Введите пароль :");
    Pass=Console.ReadLine();
    Console.WriteLine("Пароль принят");
    Console.WriteLine("Введите команду :");
    flag_set_pass=true;
    break;
    case "setname":
    Console.WriteLine("Введите имя :");
    Name=Console.ReadLine();
    Console.WriteLine("установлено имя");
    Console.WriteLine("Введите команду :");
    flag_set_name=true;
    break;
    case "writename":
    if(!flag_set_pass)
    {
      Console.WriteLine("Неустановлен пароль! Хотите установить пароль? (y/n)  ");
      string answer=Console.ReadLine();
      if (answer== "y")
      {
        goto case "setpassword";
      }
      else
      {
        Console.WriteLine("Введите команду :");
        break;
      }
    }
    if(!flag_set_name)
    {
      Console.WriteLine("Неустановлен имя! Хотите установить имя? (y/n)  ");
      string answer=Console.ReadLine();
      if (answer== "y")
      {
        goto case "setname";
      }
      else
      {
        Console.WriteLine("Введите команду :");
        break;
      }
    }
    Console.WriteLine("Введите пароль :");
    string TMP_Pass=Console.ReadLine();
    if(TMP_Pass==Pass)
    {
      Console.WriteLine("Имя "+ Name);
    }
    else
    {
      Console.WriteLine("неверный пароль");
    }
    Console.WriteLine("Введите команду :");
    break;
    default:
    Console.WriteLine("команда не распознана. Введите команду Help для вывода списка всех комманд");
    break;
  }
}
////

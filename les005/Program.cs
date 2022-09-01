Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Витя")
{
   Console.WriteLine("Привет Витенька. ");
}

else
{
   Console.Write("Привет, ");
   Console.WriteLine(username);
}
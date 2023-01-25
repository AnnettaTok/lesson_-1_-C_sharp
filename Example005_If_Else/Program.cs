Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "анечка")
{
    Console.WriteLine("Ура! Это Анечка");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);

}

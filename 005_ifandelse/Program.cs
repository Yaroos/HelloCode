Console.WriteLine("Введите имя польователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "марина")
{
    Console.WriteLine("Ура, это же МАРИНА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
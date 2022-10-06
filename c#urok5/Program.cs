// See https://aka.ms/new-console-template for more information
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username == "Маша")
{
Console.WriteLine("Привет Маша");

}
else
{
Console.Write("Привет Незнакомец  - ");
Console.WriteLine(username);


}
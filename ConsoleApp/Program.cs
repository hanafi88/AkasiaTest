// See https://aka.ms/new-console-template for more information
using ConsoleApp.BusinessLogic;
int iMaxLoop = 100;

for (int i = 1; i <= iMaxLoop; i++)
{
    Console.WriteLine(CommonFuntion.WriteFizzBuzzLogic(i));
}

Console.ReadLine();
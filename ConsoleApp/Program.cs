// See https://aka.ms/new-console-template for more information
using BusinessLogic.Services;

int iMaxLoop = 100;
IFizzBuzzService buzzService = new FizzBuzzService(iMaxLoop);
buzzService.Write();

Console.ReadLine();
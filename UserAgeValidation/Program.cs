﻿// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutaja vanust
//kui kasutaja vanus on võiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram

Console.WriteLine("Enter your age:");
int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
} 
else //if (userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram.");
}
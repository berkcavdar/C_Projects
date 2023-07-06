using System;

int monthCurrent = DateTime.Now.Month;

switch (monthCurrent)
{   //Expressions
    case 1:
        Console.WriteLine("Current month is January");
        break;
    case 2:
        Console.WriteLine("Current month is February");
        break;
    case 3:
        Console.WriteLine("Current month is March");
        break;
    case 4:
        Console.WriteLine("Current month is April");
        break;
    case 5:
        Console.WriteLine("Current month is May");
        break;
    case 6:
        Console.WriteLine("Current month is June");
        break;
    default:
        Console.WriteLine("Input is not related!");
        break;
}


//Climate Expression
switch(monthCurrent) 
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Winter!");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Spring!");
        break;
    case 6: 
    case 7:
    case 8:
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Summer!");
        break;
    default:
        break;
}
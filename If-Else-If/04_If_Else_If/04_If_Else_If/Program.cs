using System;

int dateTime = DateTime.Now.Hour;

if (dateTime >= 6 && dateTime <11)
{
    Console.WriteLine("Good Morning");
}


else if (dateTime <= 18)
{
    Console.WriteLine("Have a nice day!");
}

else
{
    Console.WriteLine("Good Night!");
}

string result = dateTime <= 18 ? "Good Days " : "Good Night ";

Console.WriteLine(result);

result = dateTime >= 6 && dateTime < 11 ? "Good Morning " : dateTime <= 18 ? "Have a nice day!" : "Good Nigth";
Console.WriteLine(result);

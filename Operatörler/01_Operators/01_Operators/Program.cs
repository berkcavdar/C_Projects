using System;


//Assignment 

int x_variable = 3;
int y_variable = 4;

//Operations with assignments

y_variable = y_variable + 2; // y_variable += 2 alternative method
x_variable = x_variable * 2; // x_variable *=2 alternative method

Console.WriteLine(y_variable);
Console.WriteLine(x_variable);

y_variable = y_variable / 2;
Console.WriteLine(y_variable);

//Logical Operators
// || , && , !

bool isSuccess = true;
bool isCompleted = false;

// If both of them are true , output as Perfect!
if(isSuccess && isCompleted)
{
    Console.WriteLine("Perfect!");
}
// Either one of them or both of them are true , output as Perfect!

if (isSuccess || isCompleted)
{
    Console.WriteLine("Perfect!");
}

//Output as Fine because of both of them are true bool
if (isSuccess && !isCompleted)
{
    Console.WriteLine("Fine!");
}

//<,>,<=,>=,==,!= Operators

int a_variable = 3;
int b_variable = 4;
bool result = a < 4; // means true


using System;

//Implicit Conversion
byte a_variable = 5;
sbyte b_variable = 6;
short s_variable = 7;

int d_variable = a_variable + b_variable + s_variable;

Console.WriteLine("d_variable: " + d_variable);

long h_Variable = d_variable;
Console.WriteLine(h_Variable);

float i_variable = d_variable;
Console.WriteLine(i_variable);

string str_Variable = "string";
char chr_Variable = 'A';
object obj_Variable = str_Variable + chr_Variable;

Console.WriteLine(obj_Variable);

//Explicit Conversion

Console.WriteLine("*******Explicit Version**********");
int intVariable = 10;
byte byteVarialbe = (byte)intVariable;
Console.WriteLine("byteVariable: " + byteVarialbe);

float w_Variable = 10.3f;
byte v_Variable = (byte)w_Variable;
Console.WriteLine("v_Variable: " + v_Variable);

// ****ToString Method
Console.WriteLine("********ToString Method********");

int alt_x = 6;
string alt_y = alt_x.ToString();
Console.WriteLine("alt_y: " + alt_y);

// *****System.Convert
Console.WriteLine("*********System.Convert*******");

string alt_s_Var = "10", last_s_Var = "5";
int sum_One, sum_Two;
int totalSum;

sum_One = Convert.ToInt32(alt_s_Var);
sum_Two = Convert.ToInt32(last_s_Var);

totalSum = sum_One + sum_Two;
Console.WriteLine(totalSum);

//******Parse
Console.WriteLine("*************Parse*********");
ParseMethod();

static void ParseMethod()
{
    string textOne = "220";
    string textTwo = "150";
    int numberVar;
    double doubleVar;

    numberVar = Int32.Parse(textOne);
    Console.WriteLine(numberVar);

    doubleVar= Double.Parse(textTwo);
    Console.WriteLine(textTwo);


}
using System;

try
{
    Console.WriteLine("Enter a number: ");
    int inpNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Number is : " + inpNum);
}

catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message.ToString());
}

/** Optional
finally
{
    Console.WriteLine("Completed the operation.");
}*/


/*****************************/

try
{
    int numOne = int.Parse(null);
}

catch (ArgumentNullException ex)
{
    Console.WriteLine("You have entered nothing");
    Console.WriteLine(ex);
}
/****************************/
try
{
    int numSecond = int.Parse("test");
}

catch (FormatException ex)
{
    Console.WriteLine("Date Type is not correct!");
    Console.WriteLine(ex);
}

/**************************/

try
{
    int numThird = int.Parse("-200000000000000000000000");
}

catch(OverflowException ex) 
{
    Console.WriteLine("You have enter out of border size.");
    Console.WriteLine(ex);  
}

finally
{
    Console.WriteLine("Done.");
}



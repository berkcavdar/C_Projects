namespace Değişkenler_Ve_Veri_Tipleri;

class Program
{
    static void Main(string[] args)
    {
        int value = 2;
        string variable = null;
        string Variable = null;

        Console.WriteLine("Hello, World!");

        //Variable Types

        byte byte_variable = 5;
        sbyte sbyte_variable = 1;

        short short_variable = 5;
        unshort unshort_variable = 5;

        int int_variable = 10;
        Int16 Int16_variable = 1;
        Int32 Int32_variable = 32;
        Int64 Int64_variable = 64;

        uint uint_variable = 200;
        long long_variable = 500;
        ulong unsigned_long_variable = 1000;

        //Reel Numbers
        float float_variable = 32.3f;
        double double_variable = 10.5;
        decimal decimal_variable = 10;

      
        char char_variable = 'A';
        string string_variable = "string";

        bool bool_variable_true = true;
        bool bool_variable_false = false;

        DateTime dateTime = DateTime.Now;

        //Object Variable let in all types 
        object object_one_variable = "x";
        object object_two_variable = 4;
        object object_three_variable = 2.2;

        //String Methods
        string string_one_variable = "Alert";
        string string_two_variable = "Caution";
        string string_Three_Variable = "13";
        string total_string_variable = string_one_variable + " " + string_two_variable;
        int string_toNumber_Variable = Convert.ToInt32(string_Three_Variable);
        int string_toSecondNumber_Variable = int.Parse(string_Three_Variable);

        //Date Methods
        string date_Time = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(date_Time);
    }
}

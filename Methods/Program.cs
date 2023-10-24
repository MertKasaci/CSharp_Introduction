using System;

internal class Program
{
    private static void Main(string[] args)
    {

        //Add();
        //Add();
        //Add();
        //Add();
        //var result = Add2(20,30);
        //var result1 = Add3(20);
        //Console.WriteLine(result);
        //Console.WriteLine(result1);

        //int number1 = 20;
        //int number2 = 100;
        //var result = Add4(ref number1,number2);
        //Console.WriteLine(result);
        //Console.WriteLine(number1);


        //int number1;
        //int number2 = 100;
        //var result = Add5(out number1, number2);
        //Console.WriteLine(result);

        //Out keyword ref ile aynı işleve sahiptir fakat out ile parametre göndereceğimiz zaman öncesinde bu parametreye bir değer atamak zorunda değiliz.

        Console.WriteLine(Multiply(2, 4));
        Console.WriteLine(Multiply(2,4,5));
        
        Console.WriteLine(Add6(1,2,3,4,5,6));

    }
    //Dont Repeat Yourself ilkesi uymak için kullandığımız bir yapıdır methodlar.
    //Methodlar değer döndüren ve void olarak 2 ye ayrılır.
    //Hem değer döndüren hem de void methodlar parametreli ve parametresiz olarak kendi aralarında ayrıca 2 ye ayrılır.
    static void Add()
    {
        Console.WriteLine("Added!");
    }

    static int Add2(int number1, int number2)
    {
        var result = number1 + number2;
        return result;
    }

    //Parametreler default değerler alabilir.
    //Sadece ilk parametreye default parametre atayamayız , ya sondaki değere atarız yada bütün parametrelere.
    static int Add3(int number1, int number2 = 30)
    {
        var result = number1 + number2;
        return result;
    }

    //Ref keywordu ile calismak.
    static int Add4(ref int number1, int number2)
    {
        number1 = 30;
        return number1 + number2;
    }

    //Out keywordu ile calismak
    static int Add5(out int number1, int number2)
    {
        number1 = 30;
        return number1 + number2;
    }

    //Method Overloading
    static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3 ;
    }

    //Params keywordu
    static int Add6(params int[]numbers)
    {
        return numbers.Sum();
    }
    static int Add6(int number1 , params int[] numbers)
    {
        return numbers.Sum();
    }



}
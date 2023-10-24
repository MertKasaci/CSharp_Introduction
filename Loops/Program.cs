
//for (int i = 0; i <= 100; i++)
//{
//    Console.WriteLine(i);
//}

using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //100 den 0 a doğru bütün çift sayıları bastıralım.
        for (int i = 100; i >= 0; i = i - 2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Finished");

        //While Loop İle Çalışmak
        int number = 100;
        while (number >= 0)
        {
            Console.WriteLine(number);
            number--;
        }
        Console.WriteLine("Now number is {0}", number);

        //Do-While Döngüsü İle Çalışmak
        int number1 = 10;
        do
        {
            Console.WriteLine(number);
            number1--;
        } while (number1 >= 11);

        //ForEach Döngüsü İle Çalışmak.
        string[] students = new string[3] { "Engin", "Derin", "Salih" };
        foreach (var student in students)
        {
            //student = "Ahmet"; //student bir iterasyon değişkeni olduğu için değerini değiştiremeyiz.
            Console.WriteLine(student);
        }

        //Örnek Uygulama : Asal Sayı

        if (IsPrimeNumber(6))
        {
            Console.WriteLine("This is a prime number");
        }
        else
        {
            Console.WriteLine("This is not a prime number");
        }



       
    }
    
    static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number - 1; i++)
        {
            if (number % i == 0)
            {
                result = false;
            }

        }
        return result;
    }
}
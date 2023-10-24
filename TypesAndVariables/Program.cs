
//Value Types
int number1 = 10;
Console.WriteLine(number1);
Console.WriteLine("Number is {0}",number1);

//Asagidaki örnekler C# tarafından int veri tipine atanabilecek sayısal sınırı geçtiği için hata verir.
//int number1 = 10000000000
//int number1 = -2147483649

//Asagidaki örnekler ise integer tipteki sayısal değerlerin alabileceği minimum ve maksimum değerleri gösteriyor.
//int number1 = 2147483647
//int number1 = -2147483648



//Eğerki integer veri tipinin sınırlarının üstünde bir tamsayı tutmak istersek long veri tipini kullanabiliriz.
long number2 = 2147483648;
Console.WriteLine("Number is {0}", number2);
//Long veri tipi integerın 2 katı büyüklüğünde sayısal değerler tutar ve bundan dolayıda bellekte fazlasıyla yer kaplar.
//Long tipinde bir değişkenin alabileceği maksimum ve minimum değerler aşağıda verilmiştir.
//long number2 = 9223372036854775807
//long number2 = -9223372036854775808


//Bir diğer tam sayı tutan veri tipimiz ise shorttur.
//int veri tipi 32 bit , long veri tipi 64 bitlik alan kapsarken short veri tipi 16 bitlik bir alanı kapsar.
//Short tipinde bir değişkenin alabileceği maksimum ve minimum değerler aşağıda verilmiştir.
short number3 = 32767;
//short number4 = -32768;
Console.WriteLine("Number is {0}", number3);



//Byte veri tipi bellekte 8 bit yer kaplar.
//0 ile 255 dahil olmak üzere bu aralıktaki sayıları tutabilir.
byte number5 = 255;
Console.WriteLine("Number is {0}", number5);


//Mantıksal bir veri tipidir.
//Değişken olarak true veya false tutar.
//Koşullu ifadelerde sıklıkla kullanılır.
bool condition = false;
bool condition1 = true;


//Char veri tipi
//ASCII dediğimiz klavyede kullanabileceğimiz bütün karakterleri tutmak için kullanabileceğimiz bir veri tipidir.
//String dediğimiz daha sonra göreceğimiz veri tipide aslında bir karakter dizisidir.
char character = 'A';
Console.WriteLine("Character is : {0}" , (int)character);

//Double veri tipi ile tam sayıları tutmanın yanı sıra ondalıklı sayılarıda tutabiliriz.
double number6 = 10;
double number7 = 10.4;
Console.WriteLine("Number is {0}", number6);
Console.WriteLine("Number is {0}", number7);

//Decimal veri tipi virgülden sonra daha fazla basamak tutan ondalıklı sayıları tutmak için kullanabileceğimiz bir veri tipidir.
//Özellikle para birimi gibi verileri tutarken kullanılır.
//Ondalıklı değerin en sonuna 'm' koyarak bunun bir decimal olduğunu belirtebiliriz.
decimal number8 = 10.4m;
Console.WriteLine("Number is {0}", number8);

//Var Keyword
//Bir değişken değildir fakat herhangi bir değişkeni tutmak için kullanırız.
//Tuttugumuz değere göre değişkene tür kazandırırız var keywordu kullanarak.
var number9 = 10;
number9 = 'A'; //burda bir tip dönüşümü gerçekleşiyor.
//number9 = "A"; //integera string değer atayamayız.


//Enum Veri Tipi
Console.WriteLine(Days.Friday);
Console.WriteLine((int)Days.Friday);
enum Days
{
  Monday,Tuesday, Wednesday,Thursday ,Friday, Sunday
}







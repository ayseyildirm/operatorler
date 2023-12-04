using System.Diagnostics;

namespace operatorler;

class Program
{
    static void Main(string[] args)
    {
        //Atama ve İşlemli Atama
        int x = 3;
        int y = 3;
        y +=2;
        Console.WriteLine(y);//5

        y/=1;
        Console.WriteLine(y);//5

        x*=2;
        Console.WriteLine(x);//6

        //Mantıksal Operatörler
        // ||, &&, !
        bool isSuccess = true;
        bool isCompleted=false;
        
        if(isSuccess && isCompleted){
            Console.WriteLine("Perfect!");
        }
        if(isSuccess || isCompleted){//Veya//ve
            Console.WriteLine("Great!");
        }
        if(isSuccess && !isCompleted){
            Console.WriteLine("Fine!");
        }
        //İlişkisel Operatörler
        //<, >, >=, <=, ==, !=
        int a=3;
        int b=4;
        bool sonuc=a<b;
        Console.WriteLine(sonuc);//true

        sonuc=a>b;
        Console.WriteLine(sonuc);//false
        sonuc=a>=b;
        Console.WriteLine(sonuc);//false
        sonuc=a<=b;
        Console.WriteLine(sonuc);//false
        sonuc=a!=b;
        Console.WriteLine(sonuc);//true

        //Matematiksel Operatörler +,-,/,*
        int sayi1=10;
        int sayi2=5;
        int sonuc1=sayi1+sayi2;
        Console.WriteLine(sonuc1);
        sonuc1=sayi1-sayi2;
        Console.WriteLine(sonuc1);
        sonuc1=sayi1/sayi2;
        Console.WriteLine(sonuc1);
        sonuc1=sayi1*sayi2;
        Console.WriteLine(sonuc1);

        //% mod almak için kullanılır
        int sonuc2=20%3;
        Console.WriteLine(sonuc2);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {

        //Ekrana kullanıcıdan alınan sayısal bir bilgiyi ekrana yazınız.
        // Yazarken bilgilendirme mesajlarıyla birlikte olsun.


        int number = 0;  //herhangi bir değer ver 

        Console.WriteLine("Lütfen sayınızı giriniz:  ");

        number = int.Parse(Console.ReadLine()); //önce ekrandan okunuyor, anında Parse metodu ile integera çevriliyor.

        Console.WriteLine("Girmiş olduğunuz sayı : {0}" , number);

        Console.WriteLine("Lütfen programdan çıkmak için bir tuşa basınız..." );
        Console.ReadKey();


    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        //string name;
        //string nameDesc;

        //string Name;
        //string NameDesc;

        //name = "Melisa Çevik"; //Değişkene değer atama işlemi //tab tuşuna basarak direkt istediğimiz işi yapabiliriz. 
        ////atama işlemidir.
        //nameDesc = "Benim adim: ";

        //Name = "Cagri Sabanci"; //yorum

        //NameDesc = "Sevgilimin adi:";

        //Console.WriteLine(name); //tek satırda yazıyor. Bir alt satıra geçirir.

        //Console.Write(Name); //boşluk bırakmadan yan yana yazıyor

        //Console.WriteLine(nameDesc + "..............." + name); //eklemek istediklerini + ".." + şeklinde de ekleyebiliriz.
        //Console.Write(NameDesc + Name);

        byte a = 5;             //f9 ile işlemin nerede başlandığını adım adım görebiliriz f11 ile atadığın değerleri görüntüleyebiliriz. yani ilerlemeyi gözlemleriz.
        byte a1 = 255;          //byte ın aralığı daha küçük 256 yazdığında hata verir. daha büyük sayılar yazmak istersen int yaz.

        int toplam = a + a1;

        Console.WriteLine("Toplama İşlemi sonucu = " + toplam.ToString());          //ToString = sayısal değeri string yapar

        string name;
        Console.WriteLine("Lütfen adınızı girin: ");

        name = Console.ReadLine(); //bulunduğu satırda ne varsa OKU ve name'e yerleştir. string türünden değer girilmesi bekleniyor.
        Console.WriteLine("Adınız:" + name);

        //Sık yapılan hatalar
        // 
        // -Aynı satırda farklı türden değişkenler tanımlamaya çalışma
        // 
        // int m,string b; olmamalı int m,b olmalı
        // -Değişkene uygunsuz değer vermeye çalışma
        // int n;
        // n = "metin";
        //
        //-Değişkeni tanımlamadan ve/veya değişkene ilk değer vermeden değişkeni kullanmaya çalışma
        // int b; 
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //
        //Değişken tanımlaması ve/veya değer vermeyi yanlış yerde yapma
        //int a=5;
        //static void Main()
        //{
        //   Console.WriteLine(a);
        //}
        // değişken tanım ve değer verilmeleri main bloğu içinde yapılmalıdır.
        //
        // bazı değişken türlerindeki değ

        //
        // Ondalık sayı

        //-Metinsel değişkenlerle matematiksel işlem yapmaya çalışmak
        // string a5 = "1" , b2 = "2";
        // int c5 = a5 + b5;     //yanlış çünkü stringi int olarak atamaya çalışıyorsun    int=c5 = Convert.ToInt32(a5) + Convert.ToInt32(b5); yazarsan stringi inte çevirir.
        // Console.WriteLine(c5);
        //

        //-Bir değişkeni birden fazla kez tanımlamak    //yukarıda da tanımlandı. yine tanımlanıyor.
        // string a;
        // string a = "deneme";
        // Console.Writeline(a);
        //Değişkenlere değer verirken yanlış şekilde değer vermek
        // string = a=deneme;
        // Console.WriteLine(a);



        
        
        
        
        
        
        
        
        Console.ReadKey();  //tuşa basılması beklemek için kondu. Ekrana yazdığımızda herhangi bir tuşa basılmasan kaybolmaması için yazıldı.


    }
}   

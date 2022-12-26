internal class Program
{
    private static void Main(string[] args)
                    {

        //#region 1. if - else
        //if- else ile belli bir koşul 

        // if ( koşul)
        //      komut1;
        //else
        //  komut2;
        //
        // veya
        //
        //if ( koşul)
        //{
        // komutları
        // }
        //else
        // {
        // komutlar2
        //    // } 
        //    int a = 5, b = 7;

        //    if (a < b)
        //        Console.WriteLine("a, b' den küçüktür ");
        //    else
        //        Console.WriteLine("a, b' den küçük değildir");

        //    //if else yapılarında else olmak zorunda değil. Bu durumda sadece koşul sağlandığında çalışır, sağlanmazsa hiçbir şey yapmaz.

        //    #endregion

        //    #region 2. switch- case
        //    // sürekli if yazmak yerine switch kullanılır. if'in yaptığı işi daha az kodla yapar. Anlaşılırlığı arttırır. 

        //    //
        //    // Syntax:

        //    //switch(ifade)
        //    // {
        //    //    case sabit1;
        //    //      komut1;
        //    //      break;
        //    //    case sabit2;
        //    //      komut2;
        //    //      break2;
        //    //    default;
        //    //      komut3;
        //    //      break;
        //    //}
        //    // Bazı bilinmesi gerekenler
        //    //
        //    // * ) İfadenin ürettiği değer hangi case sabitinde varsa o casedeki komutlar işletilir. Eğer ifadenin ürettiği değer hiçbir case sabitinde yoksa default casedeki komutlar işletilir.

        //    //İfadenin ürettiği değer hangi case sabitinde varsa o "case"deki komutlar işletilir. Eğer ifadenin ürettiği değer hiçbir case sabitinde yoksa default casedeki komutlar işletilir.

        //    //Aynı şekilde, birden fazla case sabiti olamaz.

        //    int g = 4;
        //    switch (g)
        //    {
        //        case 4:
        //            Console.WriteLine("deneme1");
        //            break;
        //        case 5: //Bu case 4 olamaz mesela.
        //            Console.WriteLine("deneme 2");
        //            break;
        //        case 6:
        //            Console.WriteLine("deneme 3");
        //            break;
        //    }

        //    //Herhangi bir case'e ait komutların "break " satırı ile sonlandırılması gerekmektedir. Yoksa program hata verir.

        //    // *) Eğer programımızın bir casedeyken farklı bir case e gitmesini istiyorsak "goto" anahtar sözcüğünü kullanırız.
        //    // int j = 5;

        //    //        //    switch (j)
        //    //        //    {
        //    //        //    case4:
        //    //        //    string k1 = Console.ReadLine();
        //    //        //    Console.WriteLine(k1);
        //    //        //    break;
        //    //        //case5:
        //    //        //Console.WriteLine("Şimdi case4'e gideceksiniz.");
        //    //        //goto case 4;
        //    //        //default:
        //    //        //  console.write("deneme4");
        //    //        //break;
        //    //        //    }

        //    //        //goto satırı kullanılmışsa break; satırının kullanılmasına gerek yoktur.

        //    //        //Eğer farklı case sabitlerinin aynı komutları çalıştırmasını istiyorsak şöyle bir program yazılabilir:

        //    //        int k = 7;

        //    //        switch (k)
        //    //        {
        //    //        case4:
        //    //        case5:
        //    //        string l = Console.Readline(); //Ekrandan okuma yapar
        //    //        Console.Write(l);
        //    //        break;
        //    //        default: // Yukarıdaki caselerin hiçbiri sağlanmıyorsa default çalışır.
        //    //              Console.Write("deneme4");
        //    //        break;
        //    //         }


        //    //        #endregion
        //    //    }

        //    //}

        ////#region 3. for

        //int toplam = 0;
        //for (int i1 = 1; i1 <= 3; i1++)
        //    toplam += i1;                                 // toplam = toplam + i1    // i = 0 ken 1 topladı (koşulla) sonra formülü(i1 <= 3) kontrol etti. 3 olana kadar devam etti. i1 4    
        //Console.Write("toplam={0}", toplam);

        ////
        ////// girdiğimiz herhangi bir sayının faktöriyelini bulma  

        //float s;                 //önce değişken tanımladık.
        //int si, f1;              // f1 sonuç değeri
        //bool a1 = true;          //pozitiflik negatifliği belirleyen bir mantıksal değişken
        //for (; a1;)             // başta da ; var. For'un farklı bir gösterimi. esas döngü olayı bloğun içindedir, biz sadece başlamasını sağladık.
        //{
        //    Console.Write("Lütfen faktoriyelinin alınmasını istediğiniz sayıyı girin: ");

        //    s = Convert.ToSingle(Console.ReadLine());                //ToSingle = küçük sayılar için kullanılır.performansı arttırır. 

        //    si = (int)s;                                             // zorlama yaptı int'e.

        //    if (si != s || s < 1)                                    // s negatif mi diye kontrol et demek (s<1) 
        //    {
        //        Console.WriteLine("Lütfen pozitif tam sayı girin.");
        //        a1 = true;
        //    }
        //    else                                                     // pozitif bir değer girmişse  
        //    {
        //        a1 = false;


        //        for (f1 = 1; si > 1; si--)
        //            f1 *= si;

        //        Console.WriteLine("Faktöriyeli={0}", f1);
        //    }
        //}

        //
        //int a2;
        //for (int i = 0; i < 1; i++)
        //    a2 = 5;
        //Console.Write(a2); //Bu program çalışmaz, çünkü a değişkeni döngüden önce tanımlanmasına rağmen ilk değer verilmiyor.


        //1'den 1000'e (sınırlar dâhil) kadar olan sayılar içerisinde 5'e tam bölünen, ancak 7'ye tam bölünemeyen sayıları alt alta listeleyen, bu sayıların kaç tane olduğunu ve toplamını yazan bir program yazınız.

        //int toplam1 = 0, sayi = 0, i = 5;
        //for (; i < 1001; i += 5)
        //{
        //    if (i % 35 == 0)
        //        continue;
        //    sayi++;
        //    toplam += i;
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("Sayısı: " + sayi);
        //Console.WriteLine("Toplam: " + toplam1);

        //Konsol ekranına girilen 0 ile 100(sınırlar dâhil) arasındaki 10 notun en büyüğünü, en küçüğünü ve ortalamasını yazan programı yazınız.

        //int bnot = 0, toplam2 = 0, knot = 0;                    // büyük sayı,sayıların toplamı, küçük sayının ilk değeri atandı.

        //for (int sayac = 0, not; sayac < 3; sayac++)                // değişik bir for ataması. 10 kere iterasyon yap diyor. 10 kere notu girin yazıyor. a2 = iterasyon
        //{
        //    Console.Write(sayac + 1 + ". notu giriniz: ");    // dinamik değişken olarak mesaj oluşturuyor. 1
        //    not = Convert.ToInt32(Console.ReadLine());      // Int olarak algılatmak için yazdık.
        //    if (not > 100 || not < 0)                      
        //    {
        //        Console.Write("Yanlış not girdiniz. Lütfen tekrar ");
        //        sayac--;                                      // negatif sayı girilirse bir daha girmesini talep et. 
        //        continue;
        //    }
        //    if (sayac == 0)
        //    {
        //        bnot = not;                                   // a2 = 0 ise yani bir tek not girilmişse; en küçük de odur en büyük de odur ortalama da odur.
        //        knot = not;
        //    }
        //    else                                           
        //    {
        //        if (not > bnot )
        //            bnot = not;
        //        if (not < bnot)
        //            knot = not;
        //    }
        //    toplam2 += not;
        //}
        //Console.Write("En büyük: {0}\nEn küçük: {1}\nOrtalama: " + toplam2 / 3, bnot, knot);
        //Console.ReadKey();


        #region 4. while


        ////Nested While Loop 1

        //Console.Write("ENTER  A NUMBER ");
        //int sayi = Convert.ToInt32(Console.ReadLine());
        //int index = 1;
        //while (index <= sayi)                                  
        //{
        //    Console.WriteLine();
        //    int j = 1;
        //    while (j <= index)
        //    {
        //        Console.Write(j + " ");                  // j indexten büyük olana kadar iterasyona devam eder. while döngüsü olduğu için 4 e geldiğinde 1-2-3ü de yazdırıyor.
        //        j++;
        //    }
        //    index++;
        //}

        ////////Nested while loop 2
        //int satir = 1;
        //while (satir <= 5)
        //{
        //    int sutun = 1;
        //    while (sutun <= 5)
        //    {
        //        Console.Write(sutun + " ");
        //        sutun++;
        //    }
        //    Console.WriteLine();
        //    satir++;
        //}

        //#endregion

        //#region 5. do while
        //// nested do while
        char Choice;
        int MenuOption;
        float Number1, Number2;
        do
        {
            Console.WriteLine("Press 1 for Addition, 2 for Subtraction, 3 for Multiplication, 4 for Division");
            
            MenuOption = Convert.ToInt32(Console.ReadLine());
            switch (MenuOption)   //menu option değerim ne ise onu çalıştır demek.
            {
                case 1:
                    Console.WriteLine("Enter the value of two numbers");
                    Number1 = Convert.ToInt32(Console.ReadLine());
                    Number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Sum Is {Number1 + Number2}");  //$ direkt parametre yazmadan süslü paranteze alarak o formülü çalıştır
                    break;
                case 2:
                    Console.WriteLine("Enter the value of two numbers");
                    Number1 = Convert.ToInt32(Console.ReadLine());
                    Number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Difference Is {Number1 - Number2}"); //"Difference Is {0} - {1}", Number 1 , Number 2 de yazabilirdik ama bu daha kolay
                    break;
                case 3:
                    Console.WriteLine("Enter the value of two numbers");
                    Number1 = Convert.ToInt32(Console.ReadLine());
                    Number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Multiplication Is {Number1 * Number2}");
                    break;
                case 4:
                    Console.WriteLine("Enter the value of two numbers");
                    Number1 = Convert.ToInt32(Console.ReadLine());
                    Number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Division Is {Number1 / Number2}");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.WriteLine("Please Enter Y to continue, any keys to terminate");
            Choice = Convert.ToChar(Console.ReadLine());    
        }
        while (Char.ToUpper(Choice) == 'Y');   // Y ile karşılaşana kadar bunu yap demek. //kullanıcı küçük y de yazabilir onu otomatikmen büyütüyoruz. küçük y yazarsa da uygulasın diye.

        #endregion


        //Console.ReadKey();
    }

}
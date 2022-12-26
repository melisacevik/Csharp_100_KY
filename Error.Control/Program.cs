using System;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Hata oluşturabilecek durum

        int a = 100, b = 0;

        Console.WriteLine("{0} / {1} işleminin sonucu: {2} ", a, b, (a / b));

        #endregion

        #region Hata Avcısı

        try
        {
            Console.WriteLine("{0} / {1} işleminin sonucu: {2} ", a, b, (a / b));
        }
        catch
        {
            if (a != 0 && b == 0)
            {
                b = (a / 10);

                Console.WriteLine("B'nin değeri hata oluşturduğu için güncellenmiş ve {0} değeri atanmıştır.\n-> {1} / {2} işleminin sonucu: {3} ", b, a, b, (a / b));
            }
            else if (a == 0 && b != 0)
            {
                a = (b * 10);

                Console.WriteLine("A'nin değeri hata oluşturduğu için güncellenmiş ve {0} değeri atanmıştır.\n-> {1} / {2} işleminin sonucu: {3} ", a, a, b, (a / b));
            }
            else if (a == 0 && b == 0)
            {
                a = 50;
                b = 10;

                Console.WriteLine("{0} / {1} işleminin sonucu: {2} ", a, b, (a / b));
            }
        }
        #endregion

        #region Hata Metotları

        byte deger;

        try
        {
            Console.Write("Byte tipinde bir değer girin: ");

            deger = Convert.ToByte(Console.ReadLine());
        }
        catch (Exception e)
        {

            Console.WriteLine("-> Message: {0}\n-> Source: {1}\n-> StackTrace: {2}\n-> TargetSite: {3}\n",
                e.Message, e.Source, e.StackTrace, e.TargetSite);
        }

        #endregion


        #region Başka bir örnek


        int bolunecek, bolen;

        try
        {
            Console.Write("-> Bölünecek Değeri Girin: ");

            bolunecek = Convert.ToInt32(Console.ReadLine());

            Console.Write("-> Bölen Değeri Girin: ");

            bolen = Convert.ToInt32(Console.ReadLine());

            double sonuc = (bolunecek / bolen);

            Console.WriteLine("-> {0} değerinin {1} değerine bölümünün sonucu: {3}", bolunecek, bolen, sonuc);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("\n-> Hata! Sıfıra bölüm işlemi gerçekleştirilemez.\n-> Hata Mesajı: {0}\n", e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("\n-> Hata! Sadece Int32 türünde veri girişi yapabilirsiniz.\n-> Hata Mesajı: {0}\n", e.Message);
        }
        catch (OverflowException e)
        {
            Console.WriteLine("\n-> Hata! Değişgen sınırların aştınız.\n-> Hata Mesajı: {0}\n", e.Message);
        }
        catch (Exception e) // Geri kalan tüm hata durumlarını kapsar
        {
            Console.WriteLine("\n-> Beklenmedik Bir Hata!\n-> Hata Mesajı: {0}\n", e.Message);
        }
        finally
        {
            Console.WriteLine("-> Finally Bloğu Çalışıyor.\n");
        }

        #endregion

        Console.ReadKey();
    }
}
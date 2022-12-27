internal class Program
{
    private static void Main(string[] args)
    {
        // Araba galerim var. Galerimde arabalar var...
        //Tanımlanmış class'dan bir örnek nesne yarat 
        // <Sinif Adi> <Nesne adı> = new <Sınıf adı>

        CarGallery carGallery= new CarGallery();       //CarGallery sınıfından yeni bir carGallery nesnesi oluşturduk. Nesnem tanımlanmış olan sınıftan kendini örnekledi.(instance aldı) bellekte nesne                                                  yaratıldı.
        //nesnemizin özelliklerine ulaşalım.


        carGallery.Colour = "Füme";
        carGallery.Brand = "Mercedes";                 //bellekte boş olarak duran yeri veri doldurduk.
        carGallery.Model = "C200";
        Console.WriteLine("Arabanın markası:  " + carGallery.Brand  + "     "+ "Arabanın modeli:   " + carGallery.Model + "       " + "Arabanın rengi:" + carGallery.Colour );

        Console.WriteLine(carGallery.Price.ToString());   //fiyatını da sınıf içinde default olarak tanımlanmış propertiyden(özellikten) alacak.
        Console.ReadKey();
    }
    public class CarGallery //CarGallery isminde bir class tanımlanıyor. Class'ın sahip olduğu bilgiler burada tanımlanıp tutuluyor. 
                            // Syntax : <erişim belirleyici > class <sınıfın adı>
    {

        //prop + tab + tab yazarsan otomatik gösterir.tiplerine göre tanımla str ise str int ise int.
        public string? Brand { get; set; } //Marka
        public string? Model { get; set; } //Model
        public string? MClass { get; set; }  // Sinif ( B,C,SUV)
        public int?  MPower { get; set; } // Motor gücü 90,140 Beygir
        public int?  MVolume { get; set; } //Motor hacmi 1400,2000 cc
        public int? MSerial { get; set; } //Motor Seri no
        public int GasType { get; set; } //Yakıt türü
        public int GearType { get; set; } //Vites türü
        public int CaseType { get; set; } //Kasa tipi
        public int ProducedYear { get; set; } //Üretildiği yıl
        public string Colour { get; set; } //renk bilgisi

        public int Price = 100000;          // {get ve set } yazmadığımız için main kısmında carGallery.Price yazdığımızda price çıkmıyor. class'a özel tanımlandı çünkü. Bazı bilgilerin private main kısmında değiştirilmesini istemediğim için get ve seti yazmam. 

     
    }
}
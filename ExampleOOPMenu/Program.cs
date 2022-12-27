using Microsoft.Win32.SafeHandles;
using RestMenu;                   //classtaki namespaci yazdık birlikte çalışabilmeleri için yazdık. //ekrana yazdırmak için hazırlıyoruz. bu program.cs kısmını
internal class Program
{
    private static void Main(string[] args)
    {


        // Kategori

        clsCategory clsCategory = new clsCategory();

        clsCategory.CatID = 1;
        clsCategory.CatName = "Çorbalar";

        Console.WriteLine("Kategori Listesi: ");
        Console.WriteLine("==================" + "\n\n");
        Console.WriteLine(clsCategory.CatID + "\t" + clsCategory.CatName);                     

        // Food

        clsMenu clsMenu = new clsMenu();
        clsMenu.MenuID = 1;
        clsMenu.MenuName = "P100 KY Restaurant Menu";
        clsMenu.FoodName = "Merci Çorba";
        clsMenu.FoodPrice = 40;

        clsMenu.CatID = 1;

        Console.WriteLine(clsMenu.MenuName + "Yemek Listesi: ");
        Console.WriteLine("=========================" + "\n\n");
        Console.WriteLine(clsMenu.MenuID + "\t" + clsMenu.FoodName + "\t" + clsMenu.FoodPrice);


        Console.ReadKey();    
    }
}
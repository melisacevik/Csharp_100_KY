using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMenu
{
    internal class clsMenu

    { 
        // ctor + tab + tab yaptığında class içinde constract metot açıyor ( yapıcı) 
        public clsMenu()                     //classlar new ile oluşturuluyor. constractlar class içinde oluşturuluyor. //sınıf içinde otomatik çalışır.
        {

        }
        public int  MenuID { get; set; } //menüdeki ürünün sıra numarası
        public string MenuName { get; set; } 
        public string  FoodName { get; set; } 
        public int  FoodPrice { get; set; } 

        public int CatID { get; set; }  //menüdeki ürünlerim hangi kategoride                     //clsCategoryde de tanımlamıştık burda da tanımlayacağız. Birbirleriyle çalışacaklar.

        



    }
}

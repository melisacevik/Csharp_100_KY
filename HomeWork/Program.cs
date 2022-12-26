internal class Program
{
    private static void Main(string[] args)
    {
        double ukenar = 1.0, kkenar = 1.0, alan = 1.0, cevre = 1.0;

        Console.WriteLine("Uzun kenari giriniz: ");
        ukenar = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Kisa kenari giriniz: ");
        kkenar = Convert.ToDouble(Console.ReadLine());

        alan = ukenar * kkenar;
        cevre = (ukenar + kkenar) * 2;

        Console.WriteLine("Cevre= {0} \nAlan= {1} ", cevre, alan);
        Console.ReadKey();

     
    }
}
//10 adet sayıdan oluşan liste oluştur
// linQ kullanarak bu sayılar ile ilgili isteneni yazdır
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main ()
    {
        //Rastgele 10 sayıdan bir liste 
        Random random = new Random();
        List<int> numbers = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(1, 100));
        }
        // listeyi yazdır 
        Console.WriteLine("Liste: ");
        // Çift olanlar
        var CiftSayi = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Çift Sayılar: " + string.Join(", ", CiftSayi));
        // Tek olanlar
        var TekSayi = numbers.Where(n => n % 2 != 0);
        Console.WriteLine("Tek Sayılar: " + string.Join(", ", TekSayi));
        //negatif olanlar
        var NegatifSayi = numbers.Where(n => n < 0);
        Console.WriteLine("Negatif Sayılar: " + string.Join(", ", NegatifSayi));
        //pozitif olanlar
        var PozitifSayi = numbers.Where(n => n > 0);
        Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", PozitifSayi));
        //15 den büyük ve 22 den küçük sayılar
        var karma = numbers.Where(n => n > 15 && n < 22);
        Console.WriteLine("15 den büyük ve 22 den küçük sayılar: " + string.Join(", ", karma));
        // hepsisnin karesi
        var total = numbers.Select(n => n * n);
        Console.WriteLine("Kareleri: " + string.Join(", ", total));
    }
}
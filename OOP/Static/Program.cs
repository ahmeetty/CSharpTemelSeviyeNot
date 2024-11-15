// See https://aka.ms/new-console-template for more information

#region Static Nedir
/*
 
C#'da static, bir sınıf, metod, değişken veya özellik için kullanılan bir anahtar kelimedir. static anahtar kelimesi, bir öğenin örneklenmeden (nesne oluşturulmadan) doğrudan sınıf üzerinden erişilebilir olduğu anlamına gelir.
Bu, bellekte yalnızca bir tane var olan ve tüm örnekler tarafından paylaşılan bir üyeyi temsil eder.

 */

#region Static Anahtar Kelimesinin Kullanım Alanları

#region Static Sınıflar

// static sınıflar, örneklenemeyen (nesne oluşturulamayan) sınıflardır. Tüm üyeleri de static olmak zorundadır. Örneğin, System.Math sınıfı bir static sınıftır, bu yüzden Math sınıfındaki özellikler ve metodlar doğrudan sınıf adıyla çağrılabilir

// Örneğin;

//public static class Hesaplayici
//{
//    public static int Topla(int a, int b)
//    {
//        return a + b;
//    }
//}

//// Kullanım
//int sonuc = Hesaplayici.Topla(5, 3); // Çıktı: 8

// Static sınıflardan instance alınamaz

// Static sınıf içerisinde static olmayan eleman bulunamaz.


#endregion

#region Static Metodlar

// Bir metod static olarak tanımlandığında, bu metoda nesne oluşturmadan doğrudan sınıf adı üzerinden erişilebilir. static metodlar, sadece static üyelerle etkileşime girebilir.

// Kullanımı;

//public class Ornek
//{
//    public static void Selamla()
//    {
//        Console.WriteLine("Merhaba!");
//    }
//}

//// Kullanım
//Ornek.Selamla(); // Çıktı: Merhaba!


#endregion

#region Static Değişkenler

// static bir değişken, sınıfın tüm örnekleri tarafından paylaşılır ve bellekte yalnızca bir defa tutulur. Sınıfın tüm örnekleri bu değişkene erişebilir ve değişkenin değerini görebilir.

// Örneğin;

//public class Sayac
//{
//    public static int sayi = 0;

//    public Sayac()
//    {
//        sayi++;
//    }
//}

//// Kullanım
//new Sayac();
//new Sayac();
//Console.WriteLine(Sayac.sayi); // Çıktı: 2 (çünkü iki kez Sayac oluşturduk)


#endregion

#region Static Özellikler

// Static özellikler de nesne oluşturmadan erişilebilen, yalnızca bir defa bellekte tutulan özelliklerdir. Özellikle sınıfa ait bazı ayar veya durum bilgilerini tutmak için kullanılır.

// Kullanımı;

//public class Ayarlar
//{
//    public static string Dil { get; set; } = "Türkçe";
//}

//// Kullanım
//Console.WriteLine(Ayarlar.Dil); // Çıktı: Türkçe
//Ayarlar.Dil = "İngilizce";
//Console.WriteLine(Ayarlar.Dil); // Çıktı: İngilizce


#endregion


#endregion

#endregion
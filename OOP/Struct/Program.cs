// See https://aka.ms/new-console-template for more information



#region Struct Nedir

/*
 
C#'da struct (yapı), sınıflara benzeyen ama daha hafif ve performans açısından daha verimli olan bir veri yapısıdır. 
Özellikle küçük ve değiştirilemeyen veri gruplarını saklamak için kullanılır. struct, değer tipidir ve bellekte doğrudan saklanır; yani class (sınıf) gibi referans tipi değildir, bu yüzden struct kullanıldığında bellek yönetimi daha hızlı olur.

Struct tanımlama ve sınıfa tanımlama aşağıdaki gibidir Örneğin;

 */

//struct Ders
//{

//    public string DersAdi { get; set; }
//    public string Kitabi { get; set; }
//    public int Kredi { get; set; }
//    public int DersSaati { get; set; }
//}

//class Ogrenci
//{

//    public string Adi { get; set; }
//    public string Soyadi { get; set; }
//    public string OkulNo { get; set; }
//    public string Sinifi { get; set; }
//    public Ders Dersi { get; set; } // Burda kendi oluşturduğumuz strcut'ı eklemiş olduk.

//}

// Herhangi bir kalıtım veya interface gibi terimler alınmayacağını düşünüyorsam bir durumun (ders) gibi daha yeni oluşturduğumuz bunu struct olarak tanımlarız.
// Çünkü ramde daha az yer kaplar ve maliyet açısından düşük , kompleks bir yapı değildir.
// Struct sınıfın basitleştirilmiş halidir.


#endregion

#region Record Structs Nedir

/*
 
 
* C#'da record struct yapısı, değer türleriyle çalışırken verilerin daha etkili ve sade bir şekilde temsil edilmesini sağlar.

* record class gibi davranış gösterir, ancak struct olarak tanımlandığından dolayı değer tipi olarak çalışır.

* record struct, genellikle immutable (değiştirilemez) değer tipleri oluşturmak için kullanılır ve özellikle küçük, değiştirilmeyen veri taşıma nesnelerinde faydalıdır.
 
 
 */

#region Record Structs Kullanım Yerleri ve Görevleri

/*
 
- Veri Taşıma Nesnesi (DTO): record struct, genellikle DTO (Data Transfer Object) olarak kullanılan, yalnızca veri taşıyan nesneler oluşturmak için idealdir. Bu sayede kodu sade ve anlaşılır tutar.

- İmmutability (Değiştirilemezlik): record struct'lar varsayılan olarak init yalnızca-property'lere sahiptir, bu da bir kez atandıktan sonra nesne örneğinin değiştirilemez olduğu anlamına gelir.
 
- Eşitlik ve Karşılaştırma Desteği: record struct'lar, otomatik olarak tüm özelliklerine göre eşitlik ve karşılaştırma işlemlerini destekler. Bu da iki record struct nesnesini özelliklerine göre karşılaştırmanıza olanak tanır.
 
- Bellek ve Performans Avantajı: Değer türü olduğu için yığın (stack) belleğinde tutulur, bu da daha hızlı performans ve bellek avantajı sağlar. Özellikle büyük miktarda veriyi hafızada tutmadan işlem yapmanız gereken durumlarda etkilidir.


 */



#endregion


#region Record Struct Kullanım Örneği

//public record struct Point(int X, int Y);

//class Program
//{
//    static void Main()
//    {
//        var point1 = new Point(10, 20);
//        var point2 = new Point(10, 20);

//        Console.WriteLine(point1 == point2); // true
//        Console.WriteLine(point1); // Output: Point { X = 10, Y = 20 }
//    }
//}


#endregion

#endregion
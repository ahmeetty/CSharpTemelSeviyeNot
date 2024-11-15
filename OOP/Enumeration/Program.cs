// See https://aka.ms/new-console-template for more information


#region Enumeration Nedir

/*
  
* C#'da enumeration (enum) bir veri türüdür ve sayısal sabitleri temsil eden adlandırılmış bir sabitler kümesi tanımlamak için kullanılır.

* Enum, özellikle belirli bir seçenekler listesini temsil eden durumlarda kullanışlıdır. Bir enum kullanarak kodunuzun okunabilirliğini artırabilir ve belirli bir grup değeri daha kolay yönetebilirsiniz.

Örneğin bir enum tanımlayalım ;
 
enum Gunler
{
    Pazartesi,
    Sali,
    Carsamba,
    Persembe,
    Cuma,
    Cumartesi,
    Pazar
}

// Aşağıda da yukarıda verdiğimiz örneğin kullanım biçimini göstericem.

Gunler bugun = Gunler.Cuma;

Console.WriteLine($"Bugün günlerden: {bugun}");  // Çıktı: Bugün günlerden: Cuma
Console.WriteLine((int)bugun);                   // Çıktı: 4 (enum içindeki sıradaki değeri)



* Bu şekilde enum tanımlanmaktadır. Bunu bir örnek üzerinde nasıl kullancağımızı gösterelim.
* 
* ** Enumlar string değer alamazlar sayısal yani int değerler üzerine kurulmuş bir yapıdır.



*** Enumlara Özel Değer Atama Aşağıdaki Gibi Olmaktadır.
 
enum Hatalar // Hatalar diye bir enum'umuz olsun.
{
    Basarisiz = 0,
    Basarili = 1,
    Bilinmiyor = -1
}


* Enum'lar yalnızca tamsayı değerlerini temsil eder; ondalıklı değerleri içermez.

* Enums C#'da arka planda int türünde saklanır, ancak istenirse byte, sbyte, short, ushort, uint, long veya ulong türünde de tanımlanabilir.

* Not: Enum'lar kullanıcının seçeceği seçenekler için oluşturulan bir yapı değildir.
Yani enum'lar developer'ın işini kolaylaştırmak için kullandığı bir yapıdır. Yani uygulamada kullanıcıya cinsiyet seçtirmek istiyorsak bunun için enum tanımlanmaz.

* Enum içerisinde 2 tane parametre vardır;

 *  GetName: Verilen enum seçeneğinin değerini dönderir.

 * GetNames: Geriye string dizisi dönderir. Geriye belirtilen enum tipinin içerisindeki tüm seçenekleri string olarak geri dönderir.
 * 

 */




#endregion
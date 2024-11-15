// See https://aka.ms/new-console-template for more information




#region Inheritance (Kalıtım)

#region Giriş
/*
 
KALITIM NEDİR ? 

* Kalıtım OOP'nin en önemli özelliğidir.
* Üretilen nesneler farklı nesnelere özelliklerini aktarabilmekte ve böylece hiyerarşik bir düzenleme yapılabilmektedir.
*  Nesne tabanlı programlamada benzer aynı olgudaki nesnelerin aynı olanmemberları özellikleri içerikleri eğer ki bu şekilde her sınıf içerisinde tekrar tekrar tanımlanmışsa bu aykırı bir durumdur.
*  Aynı olguda olan sınıfların tekrar eden memberları bir başka sınıfta toplansın ve oradan ilgili sınıflara kalıtımsal olarak aktarılsın.

// C# Programlama Dilinde Hangi Yapılar Kalıtım Alabilirler

* C# programlama dilinde kalıtım sınıflara özel bir niteliktir.
* Yani bir sınıf sade ve sadece bir sınıftan kalıtım alabilir.
* Peki recordlar alabilirmi ? Evet alabilirler fakat sadece kendi aralarında kalıtım alabilmektedirler. Kaltım alabildekleri tek istisnai sınıf ise ileride göreceğimiz object sınıfıdır.
* Ayrıca sornaki derslerimizde göeceğimiz absract class, interface ve struct gibi yapılarında kendilerine göre kalıtımsal operasyonları mevcuttur.


// C#'ta KALITIM NASIL ALINIR ?

: Operatörü

* C#'da iki sınıf arasında kalıtımsal ilişki kurabilmek için : operatörü kullanılmaktadır.
* Hatta bilsekte bilmesekte kalıtımsal tüm ilişkiler : operatörü tarafından yapılmaktadır.

// KALITIM MODELİ TANITIMI 


//class Araba
//{
//    public string Marka{ get; set; }
//    public string Model { get; set; }
//    public int KM { get; set; }

//    class Opel:Araba // İşte bu şekilde kalıtım modelini uygulamış olduk.
//    {

//    }

//}



 
 */

#endregion

#region Gelişme

/*
 
 * Base/Parent Class : Kalıtım veren sınıf.
 * Derived/Child Class : Kalıtım alan sınıf.
 
 
 *  Base class birden fazla derived classın basesi olabilir.
 *  Fakat bir derived classın sadece  1 tane base classı olur.
 
 * C# programalma dilinde birden fazla sınıftan kalıtım alamayız sade ve sadece 1 tane sınıftan kalıtım alınabilir.
 * 
 
 */

#region Kalıtımda Nesne Üretim Sırası
// Bir sınıftan nesne üretimi yapılırken kalıtım aldığı üst sınıflar varsa eğer önce o sınıflardan sırayla nesne üretilir.


#endregion

#region Bir Sınıftan Base Class Constructor'ına Ulaşım

// Madem ki herhangi bir sınıftan nesne üretimi gerçekletilirken öncelikle base class'ından nesne üretiliyor bu demektir ki önce base class'ın constructor'ı tetikleniyor

// Haliyle bizler nesne üretimi esnasında base class'ta üretilicek olan nesnein istediğimiz constructor'larını tetikleyebilmeli yahut varsa parametre bu değerleri verebilmeliyiz.

// İşte bunun için base keywörd'ünü kullanmaktayız.

//class MyClass
//{
//    public MyClass(int a)
//    {


//    }
//    public MyClass()
//    {
//       // Eğer ki base classta boş parametreli constructor varsa derived class direkt olarak bu boş parametreye gideceği için default olarak o yüzden yukarıda parametresi olan constructor için base keywördü ile değer atamamıza gerek yoktur.

//    }
//}
//class MyClass2 : MyClass
//{
//    public MyClass2() : base (5)  //İşte burada this keywördünü kullandığımız gibi base yi kullanıp  base olan sınıftaki parametreye değer vermiş oluyoruz.
//    {


//    }
//}


#endregion


#endregion

#region Sonuç

#region Name Heiding (İsim Saklama) Sorunsalı

// Kalıtım durumlarında atalardaki herhangi bir member ile aynı isimde member'a sahip olan nesneler olabilmektedir.

//class A
//{
//    public int X { get; set;}


//}

//class B :A
//{
//    public int X { get; set;} // Burada bir uyarı vericektir aynı ad'da iki tane x olduğu için eğer ki new fonksiyonunu kullanırsak bu uyarı kalkıcaktır fakat kullanmak zorunlu değildir.

//}

#endregion

#endregion


#endregion
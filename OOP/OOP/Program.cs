// See https://aka.ms/new-console-template for more information

#region Object Oriented Programming (Nesne Yönelimli/Tabanlı Programlama)

#region Nesne Tabanlı Programlama
/*
 
- Yazılım geliştirme süreçlerini oldukca kısaltan ve sistematik hale getiren bir tekniktir, Nesne Tabanlı Programlama..
 
- Gerçek hayatı, programlama için simüle eden nesneleri baz alan programlama tekniğidir.

- Herşey bir nesnedir. Sen,ben,personel,ürün,satiş,araba 

- Gerçek bir sistem nesnel parçalara ayrılır ve bu parçalar(nesneler) arasında ilişkiler kurulur.

- Nesneler kendi aralarında haberleşebilirler.
 */

#region Nesne Kavramı
// Nesne denilen kavram bir veri bütünüdür.

// Yani buna insan örneğini verebiliriz. Gözümüz,adımız,soyadımız,kulağımız bu verilerin hepsini tutan ve bağlayabilen şeye nesne denir. Yazılımda da böyledir üzerinde veriler tutarsın ve üzerinde işlemler yapabilirsin.

// Nesne içerisinde lüzumsuz yapılara yer vermyene yapılardır. Kompleks değerlerdir.

// new MyClass(); // Nesne oluşturma böyle yapılmaktadır.
// new Random(); // Nesne oluşturma böyle yapılmaktadır.
// new MyClass(); // Nesne oluşturma böyle yapılmaktadır.
// new MyClass(); // Nesne oluşturma böyle yapılmaktadır.


//MyClass m = new MyClass(); // Burda hangi türde nesne oluşturacağımız tanımlandığı için bu şekilde de kullanılabilmektedir.
//#endregion
//class MyClass
//{

//    public int A { get; set; }

//    public void X()
//    {


//    }
//}

#endregion

#region Nesnenin Anatomisi

/*
 
- Nesne tabanlı programlamada en küçük esas parça nesne/obje/object'dir.

- Nesneler içerisind veri tutabilecekleri alanlar barındırırlar. Biz bu alanlara field diyeceğiz.

- Nesneler içerisinde field'larda ki değerleri işleyebilmesi için fonksiyonlar mevcuttur.

- Nesneleri sınıf içerisinde oluşturabiliriz sadece başka bi yerde nesne oluşturamayız. Tüm nesneler esasında bir sınıf modellemesinin örneğidir.

- Nesnelerin oluşturulabilmesi için öncelikle modellenmesi gerekmektedir.

- Nesne modeli class ile gerçekleştirilir.
 
- Nesneler HEAP'te tutulur.
 */


#endregion

#region Class Kavramı 

/*
 
 - OOP'de bir object oluşturabilmek için öncelikle o objenin modellenmesi tanımlanması gerekmektedir.

- Bir objenin modelini tanımını oluşturabilmek için class yapısı kullanılır.
 
- Classlar bir referans türüdür.

- Bir class tanımlanasında tanımlanan yerde (namespace/dışı, class) aynı isimde birden fazla class tanımlanmaz.

 

 */


#region Class İçerisinde Tanımlanan Class Sınıf Elemanı mıdır ?

// Bir class içerisine tanımlanmış classlar tanımlanmış olduğu classın elemanı değildir. Yani metot gibi başka bir sınıf içerisinde çağırmaya kalktığımızda gelmezler.

// Gelmeleri için önce tanımlanmış oldukları classın ismini sonra . operatörü ile o classa ulaşabiliriz.

#endregion

#region Class Elemanlarına Açıklama Satırı Nasıl Eklenir ?

//Random random = new Random();
//MyClass myClass = new MyClass();

// Summary kullanarak herhangi bir classa metoda parametreye açıklama yazabiliyoruz mauseyi üstüne götürünce görebiliriz.
// Tanımlarken tanımlayacağımız şeyin üstünde olması gerekir.

/// <summary>
/// Bu bir örnek classtır.    
/// </summary>
//class MyClass
//{

//}

#endregion


#region Sınıf Modelinden Referans Noktası Oluşturma 

// Bir class tanımlandığında o class adı bir türdür. Haliyle o türü kullanabilmek için direk olarak class adını kullanmamız yeterlidir.


//MyClass w; // Bu şekilde tanımlama yapabilmekteyiz alttaki başlıkta bulunan sınıfın adını kullandım.

// Atadığımız bir değer olmadığı için referans yoktur şuan bunda. Null değere sahiptir.

// Referans türlü değişkenler özünde nullable olduğu için burda null değerini direkt olarak alabilmektedir stack yapılarıan göre.

#endregion

#region Sınıf İle Nesne Modeli Tasarlama

//class MyClass
//{
//    int a = 5;
//    int b = 5;

//    void X()
//    {

//        Console.WriteLine(a + " " + b);
//    }

//    public int Y()
//    {
//        return a * b;
//    }

//}

#endregion






#endregion

#region Class Members 

#region Field 

/* Nesne içerisinde veri depoladığımız/tuttuğumuz alanlardır.
 * Class içerisinde ki değişkenlerdir. Yani class içerisinde saf bi şekilde bir değişken tanımlandığını görüyorsak o bir field'dır.
 * Herhangi bir türden olabilir.
 * Field'lar türüne özgü varsayılan değeri alırlar. Yani herhangi bir null değeri almamaktadır.
 * Fakat class yada metot içerisinde olsaydı bir değer buna default değer atanmicak sadece field içerisindekine defautl değer atanır türüne özgü bir şekilde.
 * 
 */
//Myclass m1 = new Myclass(); // Myclass'dan bir nesne oluşturmak bu kodlama ile gerçekleştirilir.
//Myclass m2 = new Myclass(); // Myclass'dan bir nesne oluşturmak bu kodlama ile gerçekleştirilir.
//m1.a = 5;
//m2.a = 25; //Her nesnede değerler ona özel çoğaltılabilir. Yani 2 farklı nesne de tanımlanmış aynı fielde farklı değerler verilebilmektedir.

//class Myclass
//{

// public int a; //Field sade ve sadece classın içinde tanımlanmış değişkendir. Yani her gördüğümüz değişken bir field olamaz.
// public string b; //Field sade ve sadece classın içinde tanımlanmış değişkendir. Yani her gördüğümüz değişken bir field olamaz.

//}

#endregion

#region Property 

/*
 * Nesne içerisinde özellik/property sağlar.
 * Property esasında özünde bir metotdur. Yani programatik/algoritmik kodlarımızı inşa ettiğimiz bir metot.
 * Lakin fiziksel olarak metottan farklı parametre almakta ve içerisinde get ve set olmak üzere iki adet blok almaktadır.
 * Property'nin işlevsel açıdan metottan farkı yoktur, lakin davranışsal olarak nesne üzerinde bir değer okuma ve değer atama işlemlerinde kullanılır.

 //public int X()
//{
                           // Metot tanımalaması
//    return 0;
//}

*********** Property Tanımlaması *********


//public int X
//{

//    get
//    {

//        return 0;

//        // propertyi çağırdığımızda get bloğu tetiklenir.
//    }
//    set
//    {
//        //Değer atadığımızda set bloğu tetiklenir.
//        // atanan veri buradan yakalanır.

//    }
//}


 
 */

#region Property Çalısma Prensibi
/*
 
 * Biz yazılımcılar nesnelerimiz içerisindeki field'lara direkt erişilmesini istemeyiz.

* Dolayısıyla field'lar da ki verileri kontrollü bir şekilde dışarıya açmak isteriz.

* İşte böyle bir durumda metotları kullanabiliriz.
* Fakat böyle bir durumda C# metot yerine property yapıları geliştirmiştir.
* Yani property yapıları özünde nesne içerisindeki bir field'ın dışarıya kontrollü açılmasını ve kontrollü bir şekilde dışarıdan değer almasını sağlayan yapılardır.
* İşte propertylerin bu işlevine Encapsulation(Kapsülleme/Sarmalama) diyeceğiz.
 
 
 */

#region Property İmzaları 

/*
Property yapısı oluşturabilmenin yapısal olarak birkaç farklı yolu/farklı imzası vardır.

* Full Property
* Prop
* Auto Property Initializers
* Ref Readonyl Returns
* Computed(Hesaplanmış) Properties
* Expression-Bodied Property
* Read Only Property
* Init-Only Properties ve Init Accessor

 */

#region Full Property
// En asde property yapılanmasıdır.
// İçerisinde get ve set blokları tanımkanmaktadır.

/*

 Yazılışı : [erişim belirleyicisi] [geri dönüş değeri] [property adı]

{

get {}  Property'den veri istendiğinde tetiklenir.

set {} Property'e veri gönderildiğinde tetiklenir. Gönderilen veriyi value keywördüyle yakalar.


}

* Full property de set bloğu tanımlanmazsa sadece okunabilir (read only) bilakis get bloğu tanımlanmazsa sadece yazılabilir (write only) olacaktır.

* Property hangi türden bir field'ı temsil e diyorsa o türden olmalıdır.
* Propertyler temsil ettikleri field'ların isimlerinin baş harfi büyük olacak şekilde isimlendirilir.

 */

// Kullanış biçimi//

//MyClass myClass = new MyClass();
//Console.WriteLine(myClass.Yasi);
//myClass.Yasi = 15;
//Console.WriteLine(myClass.Yasi);
//class MyClass
//{

//    int yasi;
//    string b;

//    public int Yasi
//    {

//        get
//        {

//            // Property üzerinden değer talep edildiğinde bu blok tetiklenmektedir.
//            // Yani değer buradan gönderilir.
//            return yasi;
//        }
//        set
//        {
//            yasi = value;
//        }



//    }
//}




#endregion

#region Prop

// Bir property her ne kadar encapsulation yapsada temsil ettiği field'da ki dataya hiç mğdahale etmeden erişilmesini ve veri atanmasını sağlıyorsa böyle bir durumda kullanılan property imzasıdır.

// Yazımı aşağıdaki gibidir.

// [erişim belirleyicisi] [geri dönüş değeri] [property adı] {get; set;}

// Prop propertyler compile edildiklerinde arka planda kendi field'larını oluştururlar. Dolayısıyla bir field tanımlamaya gerek yoktur.


#endregion

#region Auto Property Initializers
// Bir property'nin ilk değerini nesne ayağa kaldırılır kaldırılmaz aşağıdaki gibi verebiliriz.
// Bu özellik sayesinde read only olan proplara hızlıca değer atanabilmektedir.
//class InsanEntity
//{
//    public string Adi { get; set; } = "Ahmet";
//    public string Soyadi { get; set; } = "Yılmaz";

//    public int Yasi { get; set; } = 20;
//}

#endregion

#region Ref Readonyl Returns
// Ref readonly returns bir sınıf  içerisindeki field'ı referansyıla döndürmemizi sağlayan ve bir yandan da bu değişkenin değerini read only yapan özelliktir.
#endregion

#region  Computed(Hesaplanmış) Properties

//class sınıf
//{
//    int s1 = 5;
//    int s2 = 6;
//    public int Topla
//    {
//        get
//        {
//            return s1 + s2;
//        }
//    }
//}


#endregion

#region Expression-Bodied Property
// Tanımlanan property'de Lambda Expression kullanmamızı sağlayan söz dizimidir.
//Radonly de geçerlidir sadece.
//class falan
//{

//    public string Cinsiyet
//    {
//        get             //Bu normal kullanımı.
//        {
//            return "Erkek";


//        }
//    }

//    public string Cinsiyett => "Erkek"; // Bu da Expression Bodied tarzı.

//}

#endregion

#region Init-Only Properties ve Init Accessor
// Init-Only Properties nesnenin sadece ilk yaratılış anında propertylerine değer atamaktadır.
// Böylece iş kuralı gereği run time'da değeri değişmemsi gereken nesneler için bir önlem alınmaktadır.

#endregion

#endregion

#region Encapsulation (Kapsülleme/Sarmalama)

// Encapsulation, bir nesne içerisindeki dataların(field'lardaki verilerin) dışarıya kontrollü bir şekilde açılması ve kontrollü bir şekilde veri almasıdır.


#endregion

#region Indexer 
// Nesneye indexer özelliği kazandıran fıtrat olarak property ile birebir aynı olan elemandır.

// [erişim belirleyicisi] [geri dönüş değeri]this [parametreler]
// {

// get {}

// set {}


//}



#endregion

#region This Keywördür 
// C# da this keywördü 3 amaçla kullanılır.

#region 1. Sınıfın Nesnesini Temsil Eder
//MyClass m1 = new MyClass();
//MyClass m2 = new MyClass();

//class MyClass
//{
//    public void x()
//    {

//        this.x();
//    }
//}
#endregion
#region 2. Aynı İsimde Field İle Metot Parametrelerini Ayırmak İçin Kullanılır
// this keywördü ilgili class yapılanmasının o an ki nesnesine karşılık gelir.
// this kullanmak zorunda değiliz.
// Parametre olmadığı durumlarda zaten compiler otomatik olarak int a olan değere gider. Bu yüzden ek olarak this keywördü tanımlamamıza gerek yoktur.

//class MyClass
//{
//    int a;
//    public void X(int a)
//    { 

//        a // Bu ise parametreye gider yani x e tanımlanmıs olan
//    this.a  // Bu int olan fieldda ki a ya gideer
//    }
//}
#endregion
#region 3. Bir Constructer'dan Başka Bir Constructer'ı Çağırmak İçin Kullanılır
// Bunu ileride görücez şuanlık sadece bahsedelim.
// Genel olarak çağırma işlemi için kullanılır this keywördü.

#endregion


#endregion


#endregion




#endregion


#endregion

#region Nesne Kopyalama Davranışları 

#region Shallow Copy 
// Nesne bi taneyken birden fazla referansı varsa buna Shallow Copy denir.

//MyClass m1 = new MyClass();
//MyClass m2 = m1;                        
//MyClass m3 = m2;
//MyClass m4 = new MyClass();

// m1 m2 m3 hepsi bir nesneye referans olmuştur. m4 ise kendi nesnesini oluşturup ona referans olmuştur.

#endregion

#region Deep Copy
// Değer türlü değişkenlerde default davranış deep copydir.

//int a = 5;
//int b = a;  // Bunlar birbirlerine bağlı değildir bu değerler kopyalandığından dolayı a yı değişek b b yi değişek anın değeri değişmeyecektir.

//a++;
//b += 20;



// Nesne Kopyalama

//MyClass m1 = new MyClass();
//MyClass m2 = m1; // Shallow
//MyClass m3 = m1.Clone(); // Deep



//class MyClass
//{
//    public MyClass Clone()
//    {
//        return (MyClass)this.MemberwiseClone(); //MemberwiseClone : Bir sınıfın içerisinde o sınıftan üretilmiş olan o anki nesneyi klonlamamızı sağlayan bir fonksiyondur.


//    }

//}

#endregion




#endregion

#region Derinlemesine Encapsulation Nedir

// Encapsulation nesnelerimizde ki field'ların kontrollü bir şekilde dışarıya açılmasıdır.

// Bir başka deyişle nesnelerimizi başkalarının yanlış kullanımlarından korumak için kontrolsüz deişime kapatmaktır.

// Encapsulation metot ve property ile uygulanabilmektedir.



// Eskiden Böyle Aşağıdaki Gibi Tanımlanıyordu

//MyClass m = new MyClass();
//m.ASet(15);
//Console.WriteLine(m.AGet());

//class MyClass
//{
//    int a;
//    public int AGet()
//    {
//        return this.a;
//    }

//    public void ASet(int value)
//    {    
//    this.a = value; 
//    }
//}



// Yeni Kullanımı Bu Şekilde 

//MyClass m = new MyClass();
//m.A = 1;
//class MyClass
//{
//    public int A;

//    public int MyProperty
//    {
//        get { return A; }
//        set { A = value; }
//    }


//}


#endregion

#region Records Nedir OOP'de ki Yeri Neresidir?
// Record'ı anlayabilmek için ön hazırlık ;

#region Init-Only Properties
/*
C# 9.0'da herhangi bir nesnenin propertylerine ilk değerlerinin verilmesi ve sonraki sürecte bu değerlerin değiştirilmemesini garanti altına almamızı sağlayan 
Inıt-Only Properties özelliği gelmiştir.

Yani şöyle örneklendirmek gerekirse aşağıdaki property de set bloğunu kaldırdığımızda read only oluyordu yani değer atayamıyorduk yukarıda çağırıp. Ama Inıt-Only Properties ile 
ilk değeri verip bide read only yapıyor.

- İnit get keywördü olmaksızın kullanılamaz. Ayrıca yapısı gereği bu semantikte set bloğuda kullanılamaz.
 
 */

// Readonly olan bir fonksiyona ya tanımlandığı yerden bir kereye mahsus değer verilebilir yada consructor içerisinde değer verilebilmektedir.

// İnit only Properties Tanımalaması
//class Cv
//{
//    public string Name { get; init; } = "Ahmet Yılmaz";
//    public int Age { get; init; }
//    public Cv()
//    {
//        Age = 20;
//    }

//}

//MyClass my = new MyClass();
//{


//}
//class MyClass                                // Bu getteronly olarak tanımalamadır.
//{
//    public int MyProperty { get; } = 3;

//    }

#endregion

#region Records Nedir 
// Eğer ki tek bir property'De Sabitlik/Değişmemezlik/Salt okunurluk/ Readonlylik/Sadece Okunabilirlik amaç ediniliyorsa Inıt-Only Properties özelliği kullanılır.
// Eğer ki objeyi bütünsel olarak değişmez yapmak istiyorsak o zaman daha fazlasına ihtiyacımız olacaktır. İşte bu ihtiyaca istinaden Records türü geliştirilmiştir.

// Record bir objenin topyekün olarak sabit/değişmez olarak kalmasını sağlamakta ve bu durumu güvence altına almaktadır.
// Recordlar bir classtır. Sadece nesnelerinden ziyade değerleri ön plana çıkmış bir class.

//MyRecord m3 = new MyRecord()
//{

//    MyProperty = 5
//};


//MyRecord m4 = new MyRecord()
//{

//    MyProperty = 5
//};

//Console.WriteLine(m3.Equals(m4));



//MyClass m1 = new MyClass()
//{
//    MyProperty = 5
//};

//MyClass m2 = new MyClass()
//{
//    MyProperty = 5
//};

//Console.WriteLine(m1.Equals(m2));



//record MyRecord  
//{
//    public int MyProperty { get; set; }
//                       //Sınıfla birebir aynı olduğu için sınıfta tanımlayabildiğimiz herşeyi record'Da da tanımlayabilmekteyiz.
//                                        //Sınıftan tek farkı oluşturdğumuz propertylerde hepsini init yapıcaz. Recordda daha fazla init yapılanmasını kullanmaktayız.
//}

//class MyClass
//{
//    public int MyProperty { get; set; }
//}
#endregion

#endregion

#region Özel Sınıf Elemanları
#region Constructor 
/*
 
Constructor bir nesne üretimi sürecinde ilk tetiklenen metottur.
 
 MyClass ahmet = new MyClass(); burada nesne tanımlarken "()" şurda ki metod constructor'dır ve bunu tetiklemek zorundayız başka şekilde tanımlayamayız.
 
* Constructor, özel bir sınıf elemanıdır.
* Özel olsada fıtrat olarak bir metottur.
* Lakin bildiğimiz metot imzalarından bir nebze farka sahiptir.
* Constructor'ların;
* Metot adı sınıf adıyla aynı olmalıdır! (Özel sınıf elemanlarının dışında hiçbir memeber sınıf adıyla aynı olamaz!)
* Geri dönüş değeri olmaz/belirtilmez!
* Erişim belirleyicisi public olmalıdır! (private olduğu durum ayriyetten incelenecektir)
* Her sınıfın içerisinde biz tanımlamasak bile default olarak bir constructor vardır.
 

new MyClass(5);
new MyClass(10);
new MyClass();
new MyClass();
new MyClass();
class MyClass
{

    MyClass(int a)
    {

        Console.WriteLine("Bir adet myclass nesnesi oluşturulmuştur." + a);

    }
    public void X()
    {
        new MyClass(5);
    }

}

 */
#region This Keywördü İle Constructor İlişlisi

//new MyClass(5);
//class MyClass
//{
//    public MyClass()
//    {
//        Console.WriteLine($"1. Constructor ");   
//    }
//    public MyClass (int a ) : this()
//    {
//        Console.WriteLine($"2. Constructor : a = {a}");
//    }

//}
// Burada this keywördü constructorlar arasında atlamayı birini önce çalıştırmamızı sağlayan keywörddür.
#endregion

#region Record ve Constructor İlişkisi 

//record MyRecord
//{

//    public MyRecord()
//    {


//    }
//    public MyRecord(int a ) : this()
//    {

//    }

//    // Recordlarda ne gördüusek burada  da  aynı kurallar geçerlidir.

//}

#endregion



#endregion

#region Destructor/Finalizer Fonksiyon
/*
 
* Bir class'tan üretilmiş olan nesne imha edilirken otomatik çağırılan metottur.
* C# programlama dilinde Destructor sadece class yapılanmasında kullanılabilir ve bir class sade ve sadece bir Destructor içerebilmektedir.
* Destructor yıkıcı metod olarak geçer.
 
 */

#region Garbage Collector

// Uygulamada lüzummsuz olan nesneleri toplamak için Garbage Collector isimli bir mekanizma devreye girer.
// Esasında Garbage Collector'ın ne zaman iş göreceği tahmin edilemez. Kafasına göre takılır.
// Dolayısıyla biz geliştiricilerin bu mekanizmaya müdahale etmesi önerilmez.

#endregion

#region Destructor Tanımalama 


//~MyClass(){ 

//    İşlemler
//}

#region Örnek 1 

//X();
//GC.Collect(); //Garbage Collector devreye sokulmuş oldu.
//Console.ReadLine();

//static void X()
//{
//    MyClass m = new MyClass();

//}

//class MyClass
//{
//    public MyClass()
//    {                               //Constructor

//         Console.WriteLine("Nesne Üretilmiştir");

//    }

//    ~MyClass() 
//    {                            //Destructor

//        Console.WriteLine("Nesne İmha Ediliyorr...");
//    }

//}

#endregion

#region Örnek 2 
//int sayi = 100;
//while (sayi >= 1)
//{
//    new MyClass(sayi--);
//}
//Console.WriteLine("*******************");
//GC.Collect();

//Console.ReadLine();
//class MyClass
//{
//    int no;
//    public MyClass(int no)
//    {
//        this.no = no;
//        Console.WriteLine($"{no}. nesne oluşturulmuştur.");
//    }

//    ~MyClass()
//    {
//        Console.WriteLine($"{no} nesne imha edilmiştir.");

//    }



//}



#endregion

#endregion

#region Deconstruct Metodu Nedir
// Bir sınıf içerisinde "Deconstruct" ismiyle tanımlanan metot cmpiler tarafından özel olarak algılanmakta ve sınıfın nesnesi üzerinden geriye hızlıca Tuple bir değer döndürmemizi sağlamaktadır.

//Person person = new Person
//{
//    Name = "Ahmet",
//        Age = 15
//};

//var (x,y) = person;

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public void Deconstruct(out string name, out int age)
//    {
//        name = Name;
//        age = Age;
//    }
//}


#endregion

#endregion

#region Static Constructor 
// Bir sınıftan nesne üretilirken ilk tetiklenen fonksiyon constructor değil static constructor'dır. Fakat belirli durumlara istinaden öyledir.

// Constructor ilgili sınıftan her nesne üretilirken tetiklenen fonksiyondur.

// Static Constructor ise ilgili sınıftan ilk nesne üretilirken tetiklenen fonksiyondur.

//new MyClass();
//new MyClass();
//new MyClass();

//class MyClass
//{
//    public MyClass()
//    {

//        Console.WriteLine("Constructor tetiklenmiştir.");

//    }


//    static MyClass() // Static constructor'da geri dönüş değeri ve erişim berlileyicisi bildirilmez (public,private)
//                     // Overloading(Çoklu yükleme) yapılmaz. Bir sınıf içerisinde sade ve sadece bir tane tanımlanabilir. Yani parametre almaz.
//                     // İsmi sınıf ismiyle aynı olacaktır.
//    {
//        Console.WriteLine("Static Constructor tetiklenmiştir.");

//    }

//}


#endregion

#endregion

#region Positional Record (Konumsal Kayıt)
// Normal Record'lar Object Initializer'lar ile ilk değerleri verilerek üretilebilen readonly datalardı.

// Positional Recordlar ie esasında Record'lar içerisinde tanımlama yapabildiğimiz constructor ve deconstructor kullanımlarını daha da özelliştirerek kullanılmasını sağlamaktadırlar.


//MyRecord m = new MyRecord("kqmplqşögq", "fkwpfeşlgw");
//var (n, s) = m;
//record MyRecord(string name, string surname) // Bu semantik Positional record özelliğidir.
//                                             // Bir record üzerinde constructor ve deconstructor yapılanmasını hızlı bir şekişde oluşturmamızı sağlayan bir semantik sağlamaktadır.
//                                             //  Positional Record kullanırken parametrelerin karsılıkları olan propertyleri manuel oluşturmak zorunda değiliz.
//                                             // Bu propertyler oluşturulurken init olacak şekilde oluşturulur.
//{

//}



#endregion

#region Nesneler Arası İlişki Türleri



#endregion



#endregion

#region Referans Nesne İlişkisi 

#region Referans Nedir
//RAM'İN Stack bölgesinde tanımlanan ve Heap bölgesindeki nesneleri işaretleyen/referans eden değişkenlerdir/noktalardır.

// Referanslar illa bir nesne referans etmek zorunda değillerdir.

// Eğerki bir referans herhangi bir nesne işaretlemiyorsa null değerini alır default olarak.


// Referans tanımlayıp içerisindeki değerlere değer atama şekilleri;

//MyClass m = new MyClass()
//{
//    MyProperty0 = 2,
//    MyProperty1 = 1,  // Buna Object Initializer denir.
//    MyProperty2 = 2

//};

//MyClass m2 = new MyClass();
//m2.MyProperty0 = 3;                  // Bu iki şekilde değer atanabilmektedir nesne içindeki propertylere ama biz ilk olan şekli kullanıcaz.

//class MyClass
//{
//    public int MyProperty0 { get; set; }
//    public int MyProperty1 { get; set; }
//    public int MyProperty2 { get; set; }

//}

#endregion

#region Stack - Heap İlişkisi

// MyClass m = new MyClass(); // Burda MyClass adında bir sınıf var. Bu sınıf içerisine new operatörü ile bir nesne oluşturulmuş ve bu nesne "m" ile referans edilmiştir.

// Burdaki konseptin sol tarafı referansı temsil etmektedir. Yani bu referans stackde oluşmaktadır. Sağ taraf ise new operatörü ile referans edilmektedir.

// Eğer ki bir nesneyi referansla işaretlemezsek ilgili nesneyi kullanamayız.


//MyClass m = new MyClass();
//m.MyProperty = 10;

//MyClass m2 = null;
//m2.MyProperty = 20;   //Null olan yani nesnesi olmayan referanslar üzerinden herhangi bir memberı çağırıp çalıştırdığımızda bu durumda NullReferance hatası verecektir.

//class MyClass
//{
//    public int MyProperty { get; set; }

//}

#endregion

#region Referanssız Nesneler 
// Bir nesne oluşturulduğu an herhangi bir referansla işaretlenmezse eğer Heap'e yerleştirilir.
// Lakin bu nesneye tarafımızca birdaha erişemeyiz. Haliyle ilgili nesneyle aramızddaki tek diyalog oluşturma anıdır.
// Eğer ki bir nesne referanssızsa bu nesne sistemde memoryde luzumsuz yer kaplayacağından dolayı belli bir süre sonra Garbage Collector dediğimiz çöp toplayıcısı tarafından temizlenecektir.
// Garbage Collector : Heap'De referanssız olan nesneleri imha etmekten sorumlu bir yapılanmadır.
// Referanssız nesne;
//new MyClass();
//class MyClass
//{

//}

#endregion


#endregion

#region Nesneler Arası İlişki Türleri

// Nesneler arasında terminolojik olarak nitelendirilebilir ilişki türleri mevcuttur. Bu ilişkişer ; kalıtım, referans ve ya soyutlama gibi durumların getiri olan mantıksal izahatlerdir.

// Nesneler arası ilişki türleri;

// is - a ilişkisi

// has - a ilişkisi

// can - do ilişkisi

#region is - a İlişkisi Nedir ?

// is - a ilişkisi tamamıyle kalıtımla alakalıdır. C# programlama dilinde, iki sınıf arasında : operatörü ile gerçekleştirilen kalıtım neticesinde ortaya bir is - a ilişkisi çıkmaktadır.

// Örneği şöyle;

//class İnsan
//{

//}

//class Erkek : İnsan
//{

//}

// Burada yapılmış olan kalıtım tamamen is a ilişkisidir yani kalıtım denilince akıla is a ilişkisi gelmelidir.

#endregion

#region has - a İlişkisi Nedir?

// Bir sınıfın başka bir sınıfın nesnesine dair sahiplik ifadesinde bulunan ilişkidir. Bir yandan komposizyon/composition ilişkisi de denmektedir.

// Örneğin;

//class Araba 
//{

//}

//class Ford :Araba // Burada ise kalıtım olduğu için is a ilişkisi vadır.
//{
//    Motor motor;  // Burada has a ilişkisi vardır. Başka bir sınıfın özelliğini içinde sahiplenme durumu has a ilişkisidir.

//}

//class Motor
//{

//}

#endregion

#region can - do İlişkisi Nedir?

// Sonaki derslerimizde göreceğimiz infterface yapılanmasının getirisi olan bir ilişki türüdür.

// Tabi ki can - do ilişkisini anlayabilmek için öncelikle interface yapılanması hakkında fikir sahibi olunması gerekmektedir.

// Kısaca interface; bir sınıfın imzasıdır. Yani bir sınıfın içerisinde olacak olan tüm member'ların şablonunu/arayüzünü oluşturduğumuz bir kontrattır. Herhangi bir interface'i uygulayan class o interface içerisinde tanımlanmış member imzalarını kendisinde oluşturmak zorundadır. Aksi takdirde compiler hata verecektir. Biz bunları interface konusunda A'dan Z'ye incelicez.

// İnterface'ler içlerindeki memberların imzalarını class'lara uyguladıklarından dolayı o interface'ler ilgili nesnelerin yapabilecekleri kabiliyetleri göstermekteddir.

// Yani can - do ilişkisi bir nesnenin davranışlarını kabiliyetlerini belirtmektedir.

// Bu davranış kabiliyetlerin intirface içerisinde tanımlanmaktadır.

//interface IAraba
//{
//    void Gazla();
//    void Frenle();     // Bu şekilde imzalar interface içerisinde tutulmaktadır bu da can do ilişkisidir.
//}
//class Opel : IAraba
//{
//    public void Gazla()
//    {

//    }
//    public void Frenle()
//    {

//    }

//}


#endregion


#region Association Nedir?

// Association sınıflar arasındaki bağlantının zayıf biçimine verilen addır.

// Bu bağlantı oldukca gevşektir. Yani sınıflar kendi aralarında ilişkilidr lakin birbirinden de bağımsızlardır.

// Parça - bütün ilişkisi yoktur.

// Örneğin bir otobüsteki yolcular ile otobüs arasındaki ilişki Association'dır. Nihayetinde hepsi aynı yöne gitmektedir. Lakin bir yolcu indiğinde bu durum otobüsün ve diğer yolcuların durumunu değiştirmez.


#endregion

#region Aggregation ve Composition Nedir?

// Nesneleri birleştirip daha büyük nesne yapmaya verilen isimlerdir.
// Yani her ikisi de birleştirilmiş nesnelerden bütünsel nesneler yapma durumlarını ifade eder.
// Her ikisinde de Association'da olmayan parça - bütün ilişkisi söz konusudur.
// Her ikisinde de sahiplik ilişkisi( has- a ) vardır.

// Aggregation sahip olunan nesnenin sahip olan nesneden bağımsız bir şekilde var olabilmesi durumudur.

// Composition sahip olunan nesnenin sahip olan nesneden bağımsız bir şekilde var olamaması durumudur.

#endregion

#endregion


#endregion
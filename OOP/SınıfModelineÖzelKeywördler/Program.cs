// See https://aka.ms/new-console-template for more information

#region This Keywördü

// Bir sınıfın uygulamanın herhangi bir noktasında üretilmiş olan instance'larını/object'lerini/ nesnelerini sınıf içerisinde temsil etmemizi sağlayan bir keywörddür.

// this keywördü bir sınıf içerisinde bulunan birden fazla constructor overload'ıu arasında zıplamamızı yahut atlamamızı sağlayan bir keywörd'dür.


//new MyClass();
//new MyClass();
//new MyClass();

//class MyClass
//{

//     public MyClass()
//    {
//        Console.WriteLine("Boş constructor");
//    }

//    public MyClass(int a) : this()
//    {
//        Console.WriteLine("a parametrsini alna constructor");
//    }

//    public MyClass(int a,string b) : this(a)
//    {
//        Console.WriteLine("a ve b parametleri olan constructor");

//    }
//}

// Bu şekilde this keywördü kullanılmaktadır.

#endregion

#region  Base Keywördü

// base keywördü bir instance'ın base class'ını sınıf modeli içerisinde temsil eden bir keywörddür.


//class MyClass 
//{
//    public void Ahmet()
//    {
//        Console.WriteLine("ahmet");
//    }
//}

//class MyClass2 : MyClass
//{
//    public MyClass2()
//    {
//        base.Ahmet();
//    }
//}


#endregion

#region Readonly Keywördü

// Bir class içerisinde tanımlanmış olan değişkenin yahut referansın sadece okunabilir olmasını sağlayan bir keywörd'dür.

// Readonly keywördü ile işaretlenmiş olan referansların değerleri ya tanımlama noktasında ya da constructor da verilebilir.

// Const yapılanmalar readonly ile karıştırılabilir. Aralarındaki fark şöyledir;

// const tanımlandığı yerde verilmelidir. Fakat readonly de tanımla ve constructor içerisinde değer atama işlemi gerçekleştirilebilir ikisi arasındaki temel farklardan biride budur.


//class MyClass
//{
//    readonly object x = 5;   //Tanımlama yapıldığında verilen değer.

//    public MyClass()
//    {

//        x = 55;   //Constructor yapılanmada verilen değer.
//    }
//}

#endregion

#region Sealed Keywördü

// Bir sınıfın miras vermesini yahut bir başka deyişle başka bir sınıf tarafından miras alınmasını engelleyen bir keywörd'dür.

//sealed class A
//{

//}

//class B : A
//{

//}
// Bir sınıfın kalıtımsal süreçte miras vermesini ve almasını bu şekilde engellemiş olduk.

// Sadece sınıflarda ve sadece "override" edilmiş metotlarda kullanılabilir.


#region Metot Üzerinde sealed Keywörd'ünün İşlevi

// Kalıtımsal durumlarda atalardan gelen ve birinci dereceden alt sınıf tarafından override edilmiş virtual memberların hiyerarşideki sonrali sınıflar tarafından override edilmesini ilgili memberı sealed ile işareyetleyerek engelleyebiliriz.

// Yani;

//class A
//{
//    virtual public void Ahmet()
//    {


//    }
//}
//class B :A
//{

//     sealed public override void Ahmet()
//    {
//        Console.WriteLine("Ahmwt");
//    }
//}

//class C : B
//{
//    public override void Ahmet()
//    {
//        Console.WriteLine("Merhaba");  
//    }
//}

#endregion

#endregion

#region Partial Yapılar 
// Bir class'ın struct'ın yahut interface'in aynı yahut farklı dosyalarda birden fazla parçasının tasarlanmasını lakin bu parçaların özünde bir bütün olarak kullanılmasını sağlayan kodun daha organize ve kolay okunabilirliğini arttıran özelliktir.

//partial class MyClass
//{

//}
//partial class MyClass
//{

//}

// Bu tanımlamalar fiziksel olarak farklı olsalar da copiler açısından bir bütünün parçalarıdır.

// Bu tanımlar ister aynı ister farklı dosya içerisinde tanımlanabilir.

// Tabi unutmamak lazımdır ki fiziksel olarak farklı olan bu tanımların birbirlerinin parçaları olabilmesi için aynı namspace içerisinde aynı isimde ve aynı yapıda olmaları gerekmektedir.

// ******* Partial Yapılanmaların Kullanım Amaçları ********

// Kod Bölümleme: Büyük ve karmaşık yapıdaki sınıfların daha okunabilir ve düzenlenebilir parçalara bölmek için kullanılabilir.

// İş Bölümü: Ekilerin aynı sınıfın arklı kısımlarını aynı anda geliştirebilmeleri için kullanılabilir.

// Code Generator: Code Generator sistemleri tarafından yazdığınız kodun ezilmemesi için kullanılabilir.



//partial record Ahmet
//{


//}

//partial record Ahmet
//{


//}

// Recordlar da partial olarak tanımlanabilir.

// Absract classlarda da kullanılabilir.

// Interfacelerde de kullanılabilir.

// Structlarda da kullanılabilir.

#region Partial Metotlar Nelerdir

// Partial metotlar sınıfın parçasında geliştircinin metot bildiriminde bulunmasını sağlar. Başka bir parçasında ise diğer geliştirici tarafından bu metot tanımlanabilir. Bunun yaralı olduğu iki senaryo vardır;

// Template Code

// Geliştirilen kodda metotlara dair bir şekilde oluşturmak için kullanılabilir.

// Bir şabloun uygulanıp uygulanmayacağına dair geliştiricinin karar vermesine olanak tanır.

// Eğer lablonu tanımlanan metot uygulanmazsa derleyici tarafından metotdun imzası ve o metoda dair yapılan tüm çağrılar tetiklenmeler kaldırılır.

//partial class MyClass
//{

//    public MyClass()
//    {
//        X();
//        Y();
//        Z();


//    }

//    partial void X();
//    partial void Y();
//    partial void Z();

//    partial void Y()
//    {
//        Console.WriteLine("Y Tetiklendi");
//    }

//}


// Source Generator

// Source Generator sistemleri ile sınıflarda tanımlanmış olan partial metot imzalarına karşılık gövdeler oluşturulabilir.
// Geliştirici uygulanacak metodun partial bir şeklde şablonunu ekledikten sonra source generator derleme sırasında bu metodun uygulanmasını sağlar.



#endregion

#endregion
// See https://aka.ms/new-console-template for more information


#region Absract Class Nedir
/*
 
 Kalıtımda sınıflar arasında ilişki sağlayabiliyorduk. Absract Class ise bu niyeti kullandığımız kalıtımsal davranışı daha farklı manevralarla kullanabilmek için düşünülmüş ve geliştirilmiş olan nesnel
yapı olarak tanımlayabiliriz.

Absract class özünde kalıtımsal davranuş göstererek bir sınıf üzerinde implemantasyon yapmamızı sağlayan özel bir yapılanmadır.

Absract ckass bşzkere yaru somut bir sınıf vermektedir. 

Yarı somut sınıftan kastedilen içerisinde normal memberlar barındarabileceği gibi kendileri uygulama sınıfları zoraki uygulatabileceği memberlarında imzalarını barındıran bir yapılanmadır.

Yazılım sürecinde absract class kullanmak zoraki değildir ve ya ihtiyaca bağlı değildir. Absract Class tercihen kullanılır.

 
 */

#region Absract Class'ın Yapısal Özellikleri

// Absract class'ın ilk bilinmesi gereken özelliği her ne kadar absract lsa da özünde bir class'tır Yani referans türlü bir yapıanmadır. 

// Dolayısıyla absract class türünden belleğin stack bölgesinde bir referans noktası edinilebilir ve bu referansla heap'te ki uygun nesneler işaretlenebilir.

//MyClass a;
//abstract class MyClass
//    {


//}

// Kendi irademizle absract classtan nesne üretemesekte absract classın nesnesi olur fakat biz üretemeyiz bu nesneyi oluşturmanın tek yolu da kalıtımsal yapıdır.


// Absract Classı diğer classa implemt etme;

//abstract class MyAbsractClass
//{
//    public void Z()
//    {

//    }

//    public int MyProperty { get; set; }

//    abstract public void X();
//    abstract public void Y(int a, string b);
//    abstract public int B {  get; set; }

//}

//class MyClass : MyAbsractClass  // Buradali myclassa Concrate Class olur.
//{
//    public override int B { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//    public override void X()
//    {
//        throw new NotImplementedException();
//    }

//    public override void Y(int a, string b)
//    {
//        throw new NotImplementedException();
//    }
//}


#endregion

#endregion
// See https://aka.ms/new-console-template for more information


#region Polimorfizm (Çok Biçimlilik)

#region Bölüm 1

// Polimorfizm esasında kalıtım gibi bir biyolojik terimdir.

// OOP'De ise polimorfizm'e : Bir nesnenin birden fazla farklı türdeki referans  tarafından işaretlenebilmesi polimorfizm'dir.

// Polimorfizm OOP tasarımlarında geliştirilen koda daha manevrasal bir şekilde netelik kazandıran ve yaklaşım sergilememizi sağalayan bir özelliktir.

// Polimorfizm programalamada ki temel prensip olan sol/sağ Prensibini

//A a = new A(); aşıp eldeki nesnenin birden fazla referansla işaretlenebilmesini sağlar.

// Bir nesnenin birden fazla referansla işaretlenmesi o nesnenin birden fazla türün davranışlarını gösterebilmesini sağlar.

// Bir nesnenin başka bir nesne ile işaretlenebilmesi referans edilebilmesi için kesinlikle arada kalıtımsal bir ilişki olması gerekmektedir.

// Yani başa bir deyişle nesne tabanlı prpgramlamada polimorfizm uygulamak istiyorsanız türler arasında kalıtım uygulanmış olmalıdır.

// Yada  Nesne Tabanlı Programlama'da Polimorfizm aralarında kalıtımsal ilişki ollan sınıflarda uygulanabilir. Aksi mümkün değildir.

//MyClass2 a = new MyClass();
//class MyClass : MyClass2  // Burada çok biçimlilik kalıtım sayesinde vardır.
//{

//}

//class  MyClass2
//{

//}


// Peki polimorfizm bir nesne yönetiminde neye yarar?

// Daha önce de söylediğimiz gibi bir nesnenin birden fazla referansla işaretlenmesi o nesnenin birden fazla türün davranışlarını gösterebilmesini sağlar.

#endregion

#region Bölüm 2

// Static Polimorfizm: Hangi fonksiyonun çalışacağına derleme zamanında karar verilir.

// Dinamik Polimorfizm: Çalışma zamanında sergilenen polimorfizmdir.

#region Polimorfizm Durumlarında Tür Dönüşümleri

// Polimorfizm OOP'de bir nesnenin kalıtımsal açıdan ataları olan refenranslar tarafından işaretlenebilmesidir. Haliyle ilgili nesne bu ataları olan referans türlerine göre dönüştürülebilmektedir.

// Polimorfizm durumlarında tür dönüşümünü gerçekleştirebilmek için Cast ya da as operatörüleri kullanılabilir.

//A a = new C();

//C c = (C)a; // Burada görüldüğü üzere A türünden olan a referansındaki özünde C türünden nesne kendi türünden bir referansla işaretlenmiştir.

//class A
//{
//    public string X { get; set; }

//}
//class B : A
//{
//    public string Y { get; set; }
//}

//class C :B
//{
//    public string Z { get; set; }
//}

#region Cast
// Kalıtımsal bir işlem olmadığında cast operatörü hata vericektir.
//C c = (C)a
// Şu işlemi yapabilmemiz için A ve c arasında bir bağ olması kalıtımsal bir bağ olması gerekmektedir.
#endregion

#region as

// cast gibi kalıtımsal ilişki olan türler arasında referans dönüşümü yapabilmemizi sağlayan operatördür.

//A a = new C();
// Dönüşüm esnasında hiyerarşik olarak tüm türlere dönüşüm sağlar.Lakin kalıtımsal ilişkide olunmayan türlerde derleyici hatası verecektir.

//C c = a as c;

// as operatörü ile bu işlem yapıldığında hata vermez null değeri döndürür.



#endregion

#region  is

// is operatörü kalıtımsal ilişkiye sahip nesnelerin Polimorfizm özelliğine nazaran fiziksel olarak hangi türde olduğunu veren bir operatördür.


#endregion






#endregion

#endregion


#endregion
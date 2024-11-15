// See https://aka.ms/new-console-template for more information


#region Sanal Yapılar Virtual Override 

// Sanal yapılar, bir sınıf içerisinde bildirilmiş olan ve o snıftan türeyen alt sınıflarda da tekrar bildirilebilen yapılardır.

// Bu yapılar metot yada property olabilir.

// Name Heiding ile benzer olabilir fakat karıştırılmamalıdır. Fakat sanal yapılarda olay bir sınıfta bildirilen sanal yapı (metot ya da property) bu sınıftan türeyen yorunlarında ezilebilmekte yani devre dışı bırakılıp yeniden oluşturulabilmektedir.

// Yani sanal yapılanmalarda Name Heiding'de olduğu gibi bir isimsel çakışmadan ziyade üstten gelen bir yapının işlevini iptal edip yeniden yapılandırmak vardır.

// Static yapılar virtual olamaz !

// Bir sınıfta sanal yapı oluşturmak istiyorsanız bunu sadece virtual keywördünü kullanmamız yeterli olucaktır.

//class MyClass
//{
//    public virtual void MyMethod()
//    {

//    }
//}



// Bir class'ta virtual ile işaretlenerek sanal hale getirilmiş bir member bu classtan miras alan torunlarında ezilmek yeniden yazılmak isteniyorsa eğer ilgili classta override keywördü işaretlenmiş bir vaziyette tekrardan aynı member oluşturulur.

//class MyClass
//{
//    public virtual void MyMethod()
//    {

//    }
//}

//class MyClass2
//{
//    public override void MyMethod()
//    {


//    }
//}

#region Örnek

//Obje o = new Obje();
//o.Bilgi();

//Kalem k = new Kalem();
//k.Bilgi();

//Terlik t = new Terlik();
//t.Bilgi();
//class Obje
//{
//    public  virtual void Bilgi()
//    {
//        Console.WriteLine("Ben bir objeyim");
//    }
//}


//class Kalem : Obje
//{
//    public override void Bilgi()
//    {
//        Console.WriteLine("Ben bir Kalemim");
//    }
//}

//class Terlik : Obje
//{
//    public override void Bilgi()
//    {
//        Console.WriteLine("Ben bir terliğim");
//    }
//}

#endregion


#endregion
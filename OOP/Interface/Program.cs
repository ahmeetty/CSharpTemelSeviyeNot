
// See https://aka.ms/new-console-template for more information


#region Interface Nedir

/*
 
 Programlama sürecinde interface yapılanmaları nesnelere direkt olarak bir arayüz oluşturulmasını ve bu arayüz üzerinden geliştirici ile nesne arasındaki etkileşimin daha da kolaylaştırılmasını sağlayan 
bir araçtır.

Hatta sadee geliştirici ile nesne arasında ki süreci kolaylıştırmamakta ayrıca bir programın farklı bir programla yahut bileşenle etkileşimini de kolaylaştırmaktadır.

Interface biz sözleşmedir. Bir interface tanımladığımız zaman bu interfaceyi kullanacak olan sınıflar tanımlanan imzaları zoraki olarak kullanmak zorundadır.

 Interface'nin kullanım amacı farklı nesneler ve ya bileşenler arasında iletişimi kolaylaştırmak, bir standarta tabi kılmak birbirleriyle uyumlu hale getirmek için kullanılır.

Interface'ler referans türlü değişkenlerdir.
 
 */


#region Tanımlama ve İnşa Etme 

// Tanımlama şekli ;

//interface MyInterface
//{

//}

// Tanımlanmış İnterface İçerisine İmzaların Oluşturulma Kuralları

//interface IAhmet
//{
//    void AMethod();
//    int BMethod();                  // Görüldüğü üzere interface içerisine metod ve ya property imzaları tanımlanabilmektedir.
//                                    // Sadece imzalar tanımlanabilir metod ve propertylerin kendileri tanımlanmaz. 
//    int CProperty { get; set; }

//}
#endregion

#region Interface Kullanımı

//Interaface kullanmak için kalıtımdaki gibi : operatörü kullanılmaktadır.

//interface Iahmet
//{


//}

//class MyClass : Iahmet
//{

//}

// Interaceler sınıfların imzasıdır.

#endregion

#region Interface'ler de Çoklu Kalıtım Durumu

// C#'da malumunuz bir sınıf sade ve sadece tek bir sınıftan kalıtım alabilmektedir.

// Fakat bir sınıf aynı anda birden fazla interface alabilmektedir.

//class MyClass : IA, IB, IC
//{ 


//}

// Interfaceler kendi aralarında kalıtım görevi sağlıyorsa inheritance denir implemantion değil.


// Bir class başka bir classtan kalıtım alırken aynı anda bir interface de tanımlanabilmektedir.

//class MyClass : MyClass2 , IA
//{

//}

// Önce classtan kalıtım almalıdır interface sonradan tanımlanmalıdır yoksa hata verecektir.


#endregion

#region Explıcıty Implement & Name Hıdıng

// Bir sınıf aşağıdaki gibi aynı imzaya sahip iki interfaceden gelen değerleri alabilir.

// Compiler bu durumda her ikisini kendi memberıymış gibi kullanır buna name hıdıng durumu denir.

//interface IA
//{
//    double Ahmet();
//}

//interface IB
//{

//    double Ahmet();
//}

//class MyClass : IA, IB
//{
//    public double Ahmet()
//    {
//        return 0;
//    }
//}

// Fakat böyle durumlar da  ilgili memberları kendi interfacelerine göre ayırmak isteyebiliriz işte buna Explicity Implement denir.

//class MyClass : IA, IB
//{
//  double IA.Ahmet()
//    {                              // Bu şekilde belirlenir.

//        return 0;
//    }

//    double IB.Ahmet()
//    {
//        return 0;
//    }


//}


#endregion

#region Default Implementatıon

/*
 
Normalde interface içerisine sadece imzaları bulundurabiliyorduk. Fakat C# 8.0 ile gelen default ımplementatıon ile artık gövdelerini de
interface içerisine tanımlayabilmekteyiz.
 
 */

//class MyClass : IA
//{
//    public void X()
//    {
//        throw new NotImplementedException();
//    }
//}

//interface IA
//{
//    public void X();
//    public void Y()
//    {
//        Console.WriteLine("Default Imp. Y");   // Burada gövdeyi de tanımlamış olduk.
//    }
//}

#endregion

#endregion
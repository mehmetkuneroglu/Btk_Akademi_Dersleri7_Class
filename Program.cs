using Btk_Akademi_Dersleri7_Class;
using System.Threading.Channels;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Liste 1");
        Console.WriteLine();
        var liste1 = new List<Ogretim_Elemani>()
        {
            new Ogretim_Elemani(200,"Hakkı","Bulut",true),
            new Ogretim_Elemani(201,"Sibel","Can",false),
            new Ogretim_Elemani(202,"Ferdi","Tayfur",true),
            new Ogretim_Elemani(203,"Seda","Sayan",false),
            new Ogretim_Elemani(204,"Orhan","Baba",true),
            new Ogretim_Elemani(205,"Emel","Sayın",false)
        };
        #region
        liste1.ForEach(ogr=> Console.WriteLine(ogr));
        Console.WriteLine();

        var liste2 = liste1;
        Console.WriteLine("Liste 2");
        Console.WriteLine();
        liste2.ForEach(ogr => Console.WriteLine(ogr));
        #endregion

        Console.WriteLine("Devam etmek için bir tuşa basın");
        Console.ReadKey();

        Console.WriteLine();
        Console.WriteLine("Ekleme ve silme yapıldı");

        
        liste2.Add(new Ogretim_Elemani(206,"ilyas","Yalçın",true));
        liste1.RemoveAt(0);
        Console.WriteLine();
        Console.WriteLine("Liste 1");
        Console.WriteLine();
        liste1.ForEach(ogr => Console.WriteLine(ogr));
        Console.WriteLine();
        Console.WriteLine("Liste 2");
        Console.WriteLine();
        liste2.ForEach(ogr=> Console.WriteLine(ogr));
        Console.WriteLine();
        Console.WriteLine("class yapıları referans tipli yapılar olduğundan listelerin");
        Console.WriteLine("birisinde yapılan değişiklik her ikisini de etkiler");

        Console.ReadKey();

    }

    private static void classYapisiOrnegi1()
    {
        //tanımlanan class ın çağrılması
        Ogretim_Elemani orgGor = new Ogretim_Elemani();
        // clas içine değer gönderme
        orgGor.SicilNo = 101;
        orgGor.Adi = "Ahmet";
        orgGor.Soyadi = "Yalçın";
        orgGor.Cinsiyet = true;
        Console.WriteLine(orgGor);

        // clas içine değer gönderme 2
        orgGor = new Ogretim_Elemani()
        {
            SicilNo = 102,
            Adi = "Mehmet",
            Soyadi = "Yalçın",
            Cinsiyet = true
        };
        Console.WriteLine(orgGor);

        // class içine değere gönderme 3
        orgGor = new Ogretim_Elemani(103, "Ahmet", "Aras", true);

        // ekrana yazdırma
        Console.WriteLine(orgGor);
    }
}
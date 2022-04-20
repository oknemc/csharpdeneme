string adi = "Okan";
int yas = 20;

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "c#";
kurs1.Egitmen = "Okan Emecen";
kurs1.IzlenmeOrani = 46;


Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Oğuz Emecen";
kurs2.IzlenmeOrani = 64;


Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Phyton";
kurs3.Egitmen = "Uğur Çınar";
kurs3.IzlenmeOrani = 865;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "HTML";
kurs4.Egitmen = "Tugay Çınar";
kurs4.IzlenmeOrani = 865;

//Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };
foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen + ":" + kurs.IzlenmeOrani);
}
class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}
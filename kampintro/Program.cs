//type safety - tip güvenliği

string kategoriEtiketi = "Kategori";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 7.32;
double dolarBugun = 7.32;

if (dolarDun<dolarBugun)
{
    Console.WriteLine("Dolar Azaldı");
}
else if (dolarDun>dolarBugun)
{
    Console.WriteLine("Dolar Yükseldi");
}
else
{
    Console.WriteLine("Dolar Eşit");
}
 

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Sisteme Giris Yapildi");
}
else
{
    Console.WriteLine("Sisteme giris yapmadi");
}
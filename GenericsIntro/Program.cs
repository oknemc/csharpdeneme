using GenericsIntro;

MyList<string> isimler = new MyList<string>();
isimler.Add("Okan");

Console.WriteLine(isimler.Length);

isimler.Add("Oğuz");

Console.WriteLine(isimler.Length);

foreach (var isim in isimler.Items)
{
    Console.WriteLine(isim);
}


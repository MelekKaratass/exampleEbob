Console.WriteLine("Lütfen 1. sayıyı giriniz");
int sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 2. sayıyı giriniz");
int sayi2 = int.Parse(Console.ReadLine());
int orjsayi1 = sayi2, orjsayi2 = sayi1;

sayi1 = (sayi1 < 0) ? -sayi1 : sayi1;
sayi2 = (sayi2 < 0) ? -sayi2 : sayi2;
while (sayi1 != sayi2)
{
    if (sayi1 > sayi2)
    {
        sayi1 -= sayi2;
    }
    else
    {
        sayi1 -= sayi2;
    }
}

Console.WriteLine("EBOB {0},{1}= {2}", orjsayi1, orjsayi2, sayi1);
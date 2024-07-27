// Lokasyonlar ve fiyatlar
int bodrumFiyati = 4000;
int marmarisFiyati = 3000;
int cesmeFiyati = 5000;
int lokasyonFiyati = 0;
Console.WriteLine("Merhaba!");
// Tatil yerini belirledik
yerBaslangic:
Console.WriteLine("Tatil planı fiyatlarımız:\nBodrum Tatili 4000TL\nMarmaris Tatili 3000TL\nÇeşme Tatili 5000TL");

Console.WriteLine("Gitmek istediğiniz tatil lokasyonu seçiniz: Bodrum, Marmaris, Çeşme");
string lokasyon = Console.ReadLine().ToLower();

if (lokasyon == "bodrum")
    lokasyonFiyati = bodrumFiyati;
else if (lokasyon == "marmaris")
    lokasyonFiyati = marmarisFiyati;
else if (lokasyon == "çeşme")
    lokasyonFiyati = cesmeFiyati;
else
{
    Console.WriteLine("Hatalı bir lokasyon girdiniz. Geçerli lokasyonlar: Bodrum, Marmaris, Çeşme");
    goto yerBaslangic;
}
// Kişi sayısını belirledik.
kisiBaslangic:
Console.Write("Kaç kişi için tatil planlamak istiyorsunuz? ");
int kisiSayisi = int.Parse(Console.ReadLine());
if (kisiSayisi < 1)
{
    Console.WriteLine("Geçersiz kişi sayısı girdiniz.");
    goto kisiBaslangic;
}
Console.WriteLine(" ");
// Burada kullanıcıya seçtiği lokasyon hakkında bilgi verdik.
if (lokasyon == "bodrum")
    Console.WriteLine(" Bodrum, Türkiye'nin Ege kıyısında yer alan popüler bir tatil beldesidir.\n Muhteşem plajları, tarihi kalıntıları ve canlı gece hayatıyla ünlüdür.\n Bodrum Kalesi, antik tiyatro ve sualtı arkeoloji müzesi gibi turistik yerlere ev sahipliği yapar.\n Aynı zamanda yat turizmi için önemli bir merkezdir.\n Keyifli bir tatil için ideal bir destinasyondur.");
else if (lokasyon == "marmaris")
    Console.WriteLine(" Marmaris, Türkiye'nin Muğla ilinde yer alan bir tatil beldesidir.\n Ege ve Akdeniz'in buluştuğu noktada, doğal güzellikleri ve berrak deniziyle ünlüdür.\n Plajları, yat limanı, su sporları ve gece hayatıyla ziyaretçilere geniş bir yelpazede aktiviteler sunar.\n Marmaris Kalesi ve çevresindeki tarihi yerler de gezilebilir.\n Hem dinlenmek hem de eğlenmek isteyenler için ideal bir tatil destinasyonudur.");
else if (lokasyon == "çeşme")
    Console.WriteLine(" Çeşme, Türkiye'nin İzmir iline bağlı popüler bir tatil beldesidir.\n Ege Denizi kıyısında yer alır ve güzel plajları, termal suları ve rüzgar sörfü için ideal koşullarıyla bilinir.\n Çeşme Kalesi, Alaçatı'nın taş evleri ve dar sokakları, butik otelleri ve şirin kafeleri gibi tarihi ve kültürel zenginliklere sahiptir.\n Ayrıca, Ege mutfağının lezzetlerini tadabileceğiniz birçok restoran bulunur.\n Çeşme, huzurlu bir tatil arayanlar için mükemmel bir seçenektir.");
Console.WriteLine(" ");

// Burada kişiye hangi yolla seyhat etmek istediğini belirledik.
yolBaslangic:
int yolFiyati = 0;
Console.WriteLine("Hangi yolla seyhat etmek istersiniz ?\n1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\n2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)\n(1 Veya 2 olarak belirtiniz.)");
int seyhatYolu = int.Parse(Console.ReadLine());
if (seyhatYolu == 1)
{
    Console.WriteLine("Kara yolunu tercih ettiğiniz için teşekkür ederiz.");
    yolFiyati = 1500;
}
else if (seyhatYolu == 2)
{
    Console.WriteLine("Hava yolunu tercih ettiğiniz için teşekkür ederiz.");
    yolFiyati = 4000;
}
else
{
    Console.WriteLine("Yanlış bir giriş yaptınız.\nLütfen Tekrar giriniz?");
    goto yolBaslangic;
}
Console.WriteLine(" ");

//Burada toplam fiyatı heasplayarak kullanıcıya bildirdik.

int toplamFiyat =  kisiSayisi * (yolFiyati + lokasyonFiyati);
Console.WriteLine($"Tatil planınızın toplam bedeli {toplamFiyat}TL'dir");
Console.WriteLine(" ");

//Burada başka bir plan yapmak isteyip istemediğini sorup ona göre isterse dögüyü komple başa aldık yoksa naik bir şekilde uğurladık.
Console.WriteLine("Son olarak başka bir tatil planlmayı düşünüyormusunuz?\n(Evet/Hayır)");
string sonSoru = Console.ReadLine().ToLower();
if (sonSoru == "evet") 
{
    goto yerBaslangic;
}
else
    Console.WriteLine("Bizi tercih ettiğiniz için teşekkür eder iyi günler dileriz.");

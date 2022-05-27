**1. Ödev**

$$\mathit{N} + 1$$

Yarış kaygan ve ağır bir zeminde olduğu için, yarışmacılar zaman zaman
kayabilmekte veya daha ağır hareket etmektedir. Her turda, her bir
yarışmacı bir kez hareket edecektir. Aşağıdaki tabloda yarışmacıların
hangi hareketi yüzde kaç olasılıkla gerçekleştirdiği verilmiştir.
Herhangi bir yarışmacının başlangıç karesinden daha geriye kaymasına
veya gitmesine müsaade edilmeyecektir.

  ----------------- ----------------- ----------------- --------------------
  Yarışmacı         Hareket Tipi      Yüzde             Gerçekleştirilecek
                                                        Hareket

  Çakal             Koşma             $$\% 30$$         3 ileri

                    Yürüme            $$\% 50$$         2 ileri

                    Kayma             $$\% 20$$         4 geri

  DeveKuşu          Koşma             $$\% 50$$         3 ileri

                    Hızlı Koşma       $$\% 20$$         6 ileri

                    Kayma             $$\% 30$$         4 geri

  MekanikFil        Yürüme            $$\% 40$$         2 ileri

                    Koşma             $$\% 10$$         3 ileri

                    Bekleme           $$\% 50$$         $$-$$

  SalyanBot         Sürünme           $$\% 100$$        1 ileri
  ----------------- ----------------- ----------------- --------------------

Ayrıca yarışmacılar arasında, türlerinden kaynaklanan davranış
ilişkileri olacaktır.

$$\% 50$$

1.  Mekanik Fil, bir Devekuşunu arkadan başlayarak bir Devekuşuyla aynı
    pozisyona gelirse, Devekuşunun ayağına %20 olasılıkla basarak
    Devekuşunu sakatlayarak paralize edecektir. Paralize olan bir
    Devekuşu, yarışın geri kalanında hiç hareket etmeyecektir.

2.  SalyanBotlar sürünme hareketi sonunda ulaştıkları yeni konumda
    bulunan hayvanları % 25 ihtimalle çarparlar. Çarpılan bir hayvan
    anlık olarak şoka girer ve geriye doğru devrilir. Bu durumda, hayvan
    bir konum geri gider. Çarpılma bunun dışında bir etki yaratmaz;
    hayvan yarış boyunca hareket etmeye devam edebilir.

Herhangi bir yarışmacı bitiş çizgisini geçtiği anda yarışma sona ermiş
olacaktır ve tüm yarışmacılar o anda bulundukları pozisyona göre
sıralanarak, konumlarıyla beraber ekrana çıktı olarak verilecektir. Her
konum için, o konumda bulunan yarışmacıların numaraları ve isimleri
yazdırılacaktır. Arka arkaya 2 yarışmanın çıktı örneği aşağıdaki
gibidir.

![](media/2022_05_27_605a0059f87aece48684g-1.jpeg){width="4.083333333333333in"
height="0.9895833333333334in"}

YENIDDENA

![](media/image-ca5328911ae6de54886c804c81466058832810e3.jpeg){width="2.5729166666666665in"
height="1.2395833333333333in"}

Ödev ekinde \"yarismacilar.txt\" ve \"YarismaTest.cs\" dosyaları
mevcuttur.

\"yarismacilar.txt\" dosyasının her satırında farklı bir yarışmacıya ait
bilgiler yer almaktadır. Satırda, aralarında birer boşluk olacak şekilde
\"yarismaciNo isim tür\" bilgileri yer alacaktır. Yani, satır sayısı
kadar yarışmacı vardır.

\"Yarisma\" sınıfının yaratııı (constructor) metodunda, örnek
dosyasadaki gibi formatlanmış bilgiler okunarak ilgili yarismaci
nesneleri yaratılmalıdır. Yaratıcı metodun tanımı aşağıdaki gibi
yapılmalıdır.

public Yarisma(string yarismaciDosyasiYolu, uint pistUzunlugu)

Projenizin ürettiği çalıştırılabilir (.exe uzantılı) dosyanızın
bulunduğu konuma \"yarismacilar.txt\" isimli dosyayi ekleyin ve
YarismaTest sınıfını projenize ekleyerek çalıştırın. Hata ayıklamayı
böylece gerçekleştirebilirsiniz.

Ödevinize puan verilirken, yalnızca örnek olarak verilen yarışmacı
dosyası çalıştırılmayacaktır. Doğru formata sahip herhangi bir yarışmacı
dosyası, herhangi bir pist uzunluğu ile çalıştırılabilir.

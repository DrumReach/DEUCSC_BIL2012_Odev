\section{Ödev}

Bu soruda hayvanlar ve robotların katılım sağlayabileceği bir yarışı simüle edeceğiz. Tüm yarışmacılar, yarışma oluşturulurken tanımlanacak toplam $N+1$ konumluk bir pistin 0. konumundan yarışa başlayacaktır. Her konum, yarış boyunca yarışmacıların bulunabileceği yerleri ifade eder. N. konuma ilk varan ya da geçen, yarışmayı kazanacaktır.

Yarış kaygan ve ağır bir zeminde olduğu için, yarışmacılar zaman zaman kayabilmekte veya daha ağır hareket etmektedir. Her turda, her bir yarışmacı bir kez hareket edecektir. Aşağıdaki tabloda yarışmacıların hangi hareketi yüzde kaç olasılıkla gerçekleştirdiği verilmiştir. Herhangi bir yarışmacının başlangıç karesinden daha geriye kaymasına veya gitmesine müsaade edilmeyecektir.

\begin{tabular}{|l|l|l|l|}
\hline Yarışmacı & Hareket Tipi & Yüzde & Gerçekleştirilecek Hareket \\
\hline Çakal & Koşma & $\% 30$ & 3 ileri \\
\hline & Yürüme & $\% 50$ & 2 ileri \\
\hline & Kayma & $\% 20$ & 4 geri \\
\hline \hline DeveKuşu & Koşma & $\% 50$ & 3 ileri \\
\hline & Hızlı Koşma & $\% 20$ & 6 ileri \\
\hline & Kayma & $\% 30$ & 4 geri \\
\hline \hline MekanikFil & Yürüme & $\% 40$ & 2 ileri \\
\hline & Koşma & $\% 10$ & 3 ileri \\
\hline & Bekleme & $\% 50$ & $-$ \\
\hline SalyanBot & Sürünme & $\% 100$ & 1 ileri \\
\hline
\end{tabular}

Ayrıca yarışmacılar arasında, türlerinden kaynaklanan davranış ilişkileri olacaktır.

1) Çakal, bir Devekuşunu arkadan başlayarak bir Devekuşuyla aynı pozisyona gelirse, $\% 50$ olasılıkla Devekuşunu avlayarak paralize edecektir. Paralize olan bir Devekuşu, yarışın geri kalanında hiç hareket etmeyecektir.

2) Mekanik Fil, bir Devekuşunu arkadan başlayarak bir Devekuşuyla aynı pozisyona gelirse, Devekuşunun ayağına \%20 olasılıkla basarak Devekuşunu sakatlayarak paralize edecektir. Paralize olan bir Devekuşu, yarışın geri kalanında hiç hareket etmeyecektir.

3) SalyanBotlar sürünme hareketi sonunda ulaştıkları yeni konumda bulunan hayvanları \% 25 ihtimalle çarparlar. Çarpılan bir hayvan anlık olarak şoka girer ve geriye doğru devrilir. Bu durumda, hayvan bir konum geri gider. Çarpılma bunun dışında bir etki yaratmaz; hayvan yarış boyunca hareket etmeye devam edebilir.

Herhangi bir yarışmacı bitiş çizgisini geçtiği anda yarışma sona ermiş olacaktır ve tüm yarışmacılar o anda bulundukları pozisyona göre sıralanarak, konumlarıyla beraber ekrana çıktı olarak verilecektir. Her konum için, o konumda bulunan yarışmacıların numaraları ve isimleri yazdırılacaktır. Arka arkaya 2 yarışmanın çıktı örneği aşağıdaki gibidir.

![](https://cdn.mathpix.com/cropped/2022_05_27_605a0059f87aece48684g-1.jpg?height=95&width=392&top_left_y=1113&top_left_x=411)

YENIDDENA

![](https://cdn.mathpix.com/cropped/2022_05_27_605a0059f87aece48684g-1.jpg?height=119&width=247&top_left_y=1321&top_left_x=411)



Ödev ekinde "yarismacilar.txt" ve "YarismaTest.cs" dosyaları mevcuttur.

"yarismacilar.txt" dosyasının her satırında farklı bir yarışmacıya ait bilgiler yer almaktadır. Satırda, aralarında birer boşluk olacak şekilde "yarismaciNo isim tür" bilgileri yer alacaktır. Yani, satır sayısı kadar yarışmacı vardır.

"Yarisma" sınıfının yaratııı (constructor) metodunda, örnek dosyasadaki gibi formatlanmış bilgiler okunarak ilgili yarismaci nesneleri yaratılmalıdır. Yaratıcı metodun tanımı aşağıdaki gibi yapılmalıdır.

public Yarisma(string yarismaciDosyasiYolu, uint pistUzunlugu)

Projenizin ürettiği çalıştırılabilir (.exe uzantılı) dosyanızın bulunduğu konuma "yarismacilar.txt" isimli dosyayi ekleyin ve YarismaTest sınıfını projenize ekleyerek çalıştırın. Hata ayıklamayı böylece gerçekleştirebilirsiniz.

Ödevinize puan verilirken, yalnızca örnek olarak verilen yarışmacı dosyası çalıştırılmayacaktır. Doğru formata sahip herhangi bir yarışmacı dosyası, herhangi bir pist uzunluğu ile çalıştırılabilir.


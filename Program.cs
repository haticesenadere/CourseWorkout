using System;

namespace courseWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DERS ESNASINDA YAPTIĞIMIZ ÇALIŞMALAR");

            Console.WriteLine("  1. Bir dizinin toplamını, çarpımını, en küçük ve en büyük elemanlarını, ortalamasını hesaplayın.  ");
            Console.WriteLine("  2-  İki sayıyı kıyaslayarak büyüklük ve eşitlik durumlarını kontrol edin.  ");
            Console.WriteLine("  3- Haftanın hangi günlerinde ders olduğunu kontrol eden bir program yazın.  ");
            Console.WriteLine("  4-  Belirlenen yaş aralıklarına uygun isimlendirme yapın (örneğin, çocuk, genç, yetişkin vb.).   ");
            Console.WriteLine("  5-  Bir dizideki en küçük sayıyı bulan algoritmayı oluşturun.  ");
            Console.WriteLine("  6-   Verilen şartlara göre öğrencinin uygun olup olmadığını değerlendirin.  ");
            Console.WriteLine("  7-  Kullanıcıdan alınan üç sayının toplamını ve çarpımını hesaplayan program yazın.   ");
            Console.WriteLine("  8-  Girilen bir cümleyi, ilk harften başlayarak her harfi bir öncekinin altına gelecek şekilde yazdıran program oluşturun. ");
            Console.WriteLine("  9- Kullanıcının otoparkta kaldığı süreye göre ücret hesaplayan bir uygulama geliştirin.  ");
            Console.WriteLine("  10- Belirlenen bağış miktarını farklı kişilere veya kurumlara bölerek dağıtımını sağlayan bir program yazın.   ");
            Console.WriteLine("  11-  Belirli bir miktar kalana kadar bağış yapmayı yöneten bir algoritma geliştirin.  ");
            Console.WriteLine("  12- Kullanıcıdan alınan verilerle bir dizi oluşturup ekrana yazdıran program yazın.  ı ");
            Console.WriteLine("  13-  Sınıf mevcudu kadar öğrenci ismi alarak bir liste oluşturun.   ");
            Console.WriteLine("  14-   Araçların giriş-çıkışlarını takip eden bir otopark yönetim sistemi tasarlayın.  ");
            Console.WriteLine("  15-  Akademi Öğrenci Kayıt Formu");
            Console.WriteLine("  16-Kullanıcının girdiği bir sayının çift mi, tek mi olduğunu belirleyen program yazın.   ");
            Console.WriteLine("  17-   Girilen sayıları küçükten büyüğe veya büyükten küçüğe sıralayan bir algoritma oluşturun.  ");
            Console.WriteLine("  18-   Girilen metindeki harfleri büyük veya küçük hale getiren bir program geliştirin.  ");
            Console.WriteLine("  19-  Haftanın günlerine göre ders var mı yok mu kontrol eden bir uygulama yazın.   ");
            Console.WriteLine("  20-   Girilen plaka koduna göre hangi şehre ait olduğunu bulan program oluşturun.  ");
            Console.WriteLine("  21-  100 TL’yi 5 kişiye eşit olarak dağıtan bir uygulama yazın.  ");

            Console.Write("Görmek istediğiniz sorunun numarasını girin: ");

            int qNum = Convert.ToInt32(Console.ReadLine());



            if (qNum == 1)
            {
                Console.WriteLine(" Bir dizinin toplamı çarpımı küçüğü büyüğü ortalamasını al.");


                int i, toplam = 0, carpim = 1, enBuyuk, enKucuk;
                double ortalama;
                int[] sayilar = new int[5];
                Console.WriteLine("Lütfen 5 adet sayı giriniz:");
                for (i = 0; i < 5; i++)
                {
                    Console.Write($"Sayi {i + 1} ");
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());
                    toplam = toplam + sayilar[i];
                    carpim = carpim * sayilar[i];

                }


                enBuyuk = sayilar[0];
                enKucuk = sayilar[0];
                for (i = 0; i < sayilar.Length; i++)
                {

                    if (sayilar[i] > enBuyuk)
                    {
                        enBuyuk = sayilar[i];
                    }
                    if (sayilar[i] < enKucuk)
                    {
                        enKucuk = sayilar[i];
                    }
                }
                ortalama = (double)toplam / sayilar.Length;

                Console.WriteLine("Toplam: " + toplam);
                Console.WriteLine("Çarpım: " + carpim);
                Console.WriteLine("En Büyük Sayı: " + enBuyuk);
                Console.WriteLine("En Küçük Sayı: " + enKucuk);
                Console.WriteLine("Ortalama: " + ortalama);



            }
            if (qNum == 2)
            {
                Console.WriteLine(" İki sayi kıyaslaması yap.");
                int sayi1;
                int sayi2;

                Console.WriteLine("Bir sayi giriniz.");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bir sayi giriniz.");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                if (sayi1 > sayi2)
                {
                    Console.WriteLine("Birinci girilen sayi daha büyüktür. " + "Birinci sayi" + sayi1 + "İkinci sayi" + sayi2);
                    Console.WriteLine("Birinci girilen sayi daha büyüktür. Birinci Sayi  {0} İkinci Sayi  {1} ", sayi1, sayi2);
                }
                if (sayi1 < sayi2)
                {
                    Console.WriteLine("Birinci girilen sayi daha büyüktür. " + "Birinci sayi" + sayi1 + "İkinci sayi" + sayi2);
                    Console.WriteLine("Birinci girilen sayi daha büyüktür. Birinci Sayi  {0} İkinci Sayi  {1} ", sayi1, sayi2);
                }
                if (sayi1 == sayi2)
                {
                    Console.WriteLine("Birinci girilen sayi daha büyüktür. " + "Birinci sayi" + sayi1 + "İkinci sayi" + sayi2);
                    Console.WriteLine("Birinci girilen sayi daha büyüktür. Birinci Sayi  {0} İkinci Sayi  {1} ", sayi1, sayi2);
                }
            }

            if (qNum == 3)
            {
                Console.WriteLine(" Haftanın hangi günlerinde ders var ? ");
                Console.Write("Gün Giriniz : ");
                string gun = Console.ReadLine();

                string gun1 = "Cumartesi";
                string gun2 = "pazar";

                if (gun == gun1 || gun == gun2)
                {
                    Console.WriteLine("Bugün kursta ders var. ");
                }
                else
                {
                    Console.WriteLine("Bugün ders yok");
                }

            }

            if (qNum == 4)


            {
                Console.WriteLine(" Yaş Aralıklarının isimlendirmesini yap");

                Console.WriteLine("Bir sayi giriniz.");
                int age = Convert.ToInt32(Console.ReadLine());


                if (age < 3)
                {
                    Console.WriteLine("Bu insan bir  bebek");

                }
                else if (age <= 12)
                {
                    Console.WriteLine("Bu insan bir çocuk");
                }
                else if (age <= 18)
                {
                    Console.WriteLine("Bu insan bir  ergen");
                }
                else if (age <= 24)
                {
                    Console.WriteLine("Bu insan bir  ergen");

                }
                else
                {
                    Console.WriteLine("Tamamen yetişkin ");
                }

            }

            if (qNum == 5)
            {
                Console.WriteLine("Dizinde ki en küçük sayıyı bulunuz.");
                int[] sayilar = new int[5];

                Console.WriteLine("Lütfen 5 adet sayı giriniz:");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Sayı {i + 1}: ");
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());
                }

                int küçük = sayilar[0];

                for (int i = 1; i < sayilar.Length; i++)
                {
                    if (küçük > sayilar[i])
                    {
                        küçük = sayilar[i];
                    }
                }

                Console.WriteLine("Dizideki en küçük sayı: " + küçük);

            }
            if (qNum == 6)
            {
                Console.WriteLine(" Acun Medya Öğrenci şartlarını teyit ediniz.");

                Console.WriteLine("Yaşınızı giriniz. ");
                int age = Convert.ToInt32(Console.ReadLine());


                if (age > 18 && age < 35)
                {
                    Console.WriteLine(" Bilgisiyarınız var mı? ");
                    string computer = Console.ReadLine();
                    if (computer == "evet")
                    {
                        Console.WriteLine(" Lise Mezunu musun? ");
                        string highSchool = Console.ReadLine();
                        if (highSchool == "evet")
                        {
                            Console.WriteLine(" Tebrikler. Kabul edildi. ");
                        }
                    }

                }
                else
                {
                    Console.WriteLine(" Başvurunuz olumsuz.  ");
                }
            }
            if (qNum == 7)

            {
                Console.WriteLine(" 3 Sayının Toplama ve Çarpma işlemlerini yapınız.  ");
                int toplam = 0;
                int çarpma = 1;
                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine("Bir sayi giriniz.");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    toplam += sayi;
                    çarpma *= sayi;



                }
                Console.WriteLine("sayiların toplamı" + toplam + "sayilarin çarpımı" + çarpma);
            }


            if (qNum == 8)
            {
                Console.WriteLine("Klavyeden girilecek olan bir cümleyi ilk harften başlayarak bir harf arttırarak alt alta ekrana yazdıran programın C# kodunu yazınız.");
                Console.WriteLine("Bir metin giriniz");
                string answer = Console.ReadLine();

                for (int i = 0; i < answer.Length; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(answer[j]);

                    }
                    Console.WriteLine();
                }
            }


            if (qNum == 9)
            {

                Console.WriteLine("Otopark Ücret Hesaplama Uygulaması");
                int capacity = 3;
                int totalCarCount = 0;
                while (totalCarCount != capacity)
                {
                    Console.WriteLine(totalCarCount + 1 + ". Araç için Günü Girin");
                    string dayInfo = Console.ReadLine();

                    if (dayInfo == "CUMARTESİ" || dayInfo == "PAZAR")
                    {
                        Console.WriteLine("OTOPARK KAPALI");
                        continue;
                    }

                    Console.WriteLine(totalCarCount + 1 + ". Araç için otopark süresini girin");
                    int time = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(totalCarCount + 1 + ". Araç için araç tipini girin");
                    string vehicleType = Console.ReadLine();

                    int price = 0;

                    if (time <= 3)
                    {
                        price = 120;
                    }
                    else if (time < 24)
                    {
                        price = (time - 3) * 20 + 120;
                    }
                    else
                    {
                        price = 400;
                    }

                    if (vehicleType == "TIR" || vehicleType == "OTOBÜS")
                    {
                        price = price * 2;
                    }
                    else if (vehicleType == "ENGELLİ")
                    {
                        price = 0;
                    }
                    Console.WriteLine("Ödenen Tutar:" + price);

                    //totalCarCount = totalCarCount + 1;
                    totalCarCount++;

                }

                Console.WriteLine("OTOPARKIMIZ DOLDU");

            }
            if (qNum == 10)
            {
                Console.WriteLine("100000 TL'lik Bağış Uygulaması ");
                int maxdonation = 100000;
                int totaldonation = 0;

                while (totaldonation < maxdonation)
                {
                    Console.WriteLine("Ne kadar bağış yapmak isterseniz?");
                    int donation = Convert.ToInt32(Console.ReadLine());

                    if (totaldonation + donation > maxdonation)
                    {
                        Console.WriteLine("Bağış kapasitesi aşılıyor. Lütfen daha düşük bir miktar giriniz.");
                    }
                    else
                    {
                        totaldonation += donation;
                    }
                }
            }

            if (qNum == 11)
            {
                Console.WriteLine("10.000 TL kalana kadar bağış yapma uygulaması");

                int totaldonation = 100000;
                int minDonation = 10000;

                while (totaldonation > minDonation)
                {
                    Console.WriteLine("Ne kadar bağış yapmak isterseniz?");
                    int donation = Convert.ToInt32(Console.ReadLine());

                    if (totaldonation - donation < minDonation)
                    {
                        Console.WriteLine("Bağış kapasitesini aşmamak için lütfen daha düşük bir miktar giriniz.");
                    }
                    else
                    {
                        totaldonation -= donation;
                    }
                }

                Console.WriteLine("Bağış için yeterli kapasite doldu. Teşekkürler.");

            }


            if (qNum == 12)
            {
                Console.WriteLine("Dizi oluşturma uygulaması");
                int[] numList = new int[4];
                // diziye eleman atama
                numList[0] = 90;
                numList[1] = 105;
                numList[2] = 120;
                numList[3] = 140;
                // numList[4] = 5; // Bu satır hata verir, çünkü dizinin boyutu 4.

                Console.WriteLine("Dizideki elemanlar:");
                for (int i = 0; i < numList.Length; i++)
                {
                    Console.WriteLine(numList[i]);
                }

                // dizideki elemanı değiştirme
                numList[3] = 1680;
                Console.WriteLine("Değiştirilen dizi elemanı: " + numList[3]);

                Console.WriteLine("Sınıf mevcudu nedir?");
                int count = Convert.ToInt32(Console.ReadLine());

                // Öğrenci isimlerini saklamak için dizi tanımlama
                string[] nameList = new string[count];

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{i + 1}. öğrencinin adını girin");
                    nameList[i] = Console.ReadLine();
                }

                Console.WriteLine("Öğrencilerin isimleri:");
                foreach (var student in nameList)
                {
                    Console.WriteLine(student);
                }



            }




            if (qNum == 13)

            {
                Console.WriteLine("Sınıfın mevcudu adedince listeye isim ekleme.");
                Console.WriteLine("sınıf mevcudu nedir");
                int count = Convert.ToInt32(Console.ReadLine());
                // int dizisi tanımlama
                string[] nameList = new string[count];

                for (int i = 0; i < count; i++)
                {

                    Console.WriteLine($"{i + 1}.öğrencinin adını girin");

                    string name = Console.ReadLine();

                    nameList[i] = name;
                }

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("öğrencinin ismi" + nameList[i]);
                }




            }
            if (qNum == 14)
            {
                Console.WriteLine("Otopark Kontrol Sistemi ");
                for (int i = 0; i < 5; i++)
                {

                    Console.WriteLine("Araç  için otopark saatini giriniz.");
                    int carTime = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Araba Tipini Giriniz");
                    string carType = Console.ReadLine();

                    Console.WriteLine("Gününüzü Girin.");
                    string carDay = Console.ReadLine();

                    if (carDay == "CUMARTESİ" || carDay == "PAZAR")
                    {

                        Console.WriteLine(" Otoparkımız kapalı");
                        continue;
                    }

                    int price = 0;

                    if (carTime <= 3)
                    {
                        price = 120;
                    }
                    else if (carTime >= 3)
                    {
                        price = (carTime - 3) * 20 + 120;
                    }
                    else
                    {
                        price = 400;
                    }


                    if (carType == "TIR" || carType == "OTOBÜS")
                    {
                        price = price * 2;
                    }
                    else if (carType == "ENGELLİ")
                    {
                        price = 0;
                    }
                    Console.WriteLine($"Ödenen Tutar {price}");

                    //if ( carType == "TIR"  || carType == "OTOBÜS"  && carType == "ENGELLİ")
                    //{
                    //    price = 0;

                    //}
                }
            }

            if (qNum == 15)
            {
                ////Öğrenci Kayıt Sistemi Acun Medya İçin:
                ///*
                // 1- Öğrencincinin Adı Soyadı
                // 2- Cinsiyeti (E,K) olarak alınacak.
                // 3- Gün Ay Yıl olarak doğum tarihi alınacak. 
                // 4- Adresi alınacak.
                // 5- Burs alıp almadığı sorulacak. (E/H)
                // 6- Eğer Burs alıyorsa ve yaşı 25'den büyükse kurs ücreti 25.678
                // 7- Eğer Burs almıyorsa ve yaşı 18'den büyükse kurs ücreti 18.789
                //sonucunu dönen bir uygulama yazın.
                // */

                Console.WriteLine("Acun Medya Akademi Öğrenci Kayıt Sistemi");
                Console.WriteLine("Ad Soyad Giriniz");
                string namesurname = Console.ReadLine();

                Console.WriteLine("Cinsiyetinizi Girin (K/E)");
                char gender = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Doğum tarihini giriniz");
                ushort birtday = Convert.ToUInt16(Console.ReadLine());

                Console.WriteLine("Adresinizi giriniz");
                string adress = Console.ReadLine();

                Console.WriteLine("Burs Alıyor musunuz? (0/1)");
                int scholar = Convert.ToInt32(Console.ReadLine());
                bool truescholar = Convert.ToBoolean(scholar);

                if (truescholar && DateTime.Now.Year - birtday > 25)
                {

                    Console.WriteLine("kurs ücretinizi 25.678");
                }
                else if (!truescholar && DateTime.Now.Year - birtday > 18)
                {
                    Console.WriteLine("kurs ücretiniz 18.789");
                }
                else
                {
                    Console.WriteLine("Maalesef burs tanımlayamıyoruz");
                }

                int age = DateTime.Now.Year - birtday;

                Console.WriteLine($"İsminiz: {namesurname}  cinsiyetiniz: {gender}  doğum tarihiniz {birtday} yaşınız{age}  adresiniz  {adress} ");




            }

            
            if (qNum == 16)
            {
                Console.WriteLine("Çİft mi Tek mi Sayı Kontrolü ");
                Console.Write("Bir sayı giriniz");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.Write("Çift sayı'dir. ");
                }
                else
                {
                    Console.Write("Sayi tek sayidir. ");
                }
            }

            if (qNum == 17)
            {
                Console.WriteLine("Küçükten Büyüğe - Büyükten Küçüğe Sayı Sıralaması ");
                //küçükten büyüğe sıralamada bir normal şekilde hareket ediyoruz.
                int numInt = 1;
                Console.WriteLine(numInt);

                long numLong = numInt;
                Console.WriteLine(numLong);

                float numFloat = numLong;
                Console.WriteLine(numFloat);

                double numDouble = numFloat;
                Console.WriteLine(numDouble);



                //büyükten küçüğe sıralama yaparken değişkene tanımı buradaki gibib olmalı

                double maxDouble = 13.123456189123456789;
                Console.WriteLine(maxDouble);

                float maxFloat = (float)maxDouble;
                Console.WriteLine(maxFloat);

                int numİnt = (int)maxFloat;
                Console.WriteLine(numİnt);
            }

            if (qNum == 18)
            {
                Console.WriteLine("Küçük -Büyük Harf kullanımı");
                string word = "merhaba";

                Console.WriteLine(word.ToLower());
                Console.WriteLine(word.ToUpper());

                string firstname = "sena";
                string lastname = " dere";

                string name = firstname + lastname;
                Console.WriteLine(name);

                string firstname1 = "ümmühan";
                string lastname1 = " dere";

                string name1 = string.Concat(firstname1, lastname1);
                Console.WriteLine(name1);

            }
            if (qNum == 19)
            {
                Console.WriteLine("Günlük Ders Kontrolü ");
                DayOfWeek today = DateTime.Now.DayOfWeek;
                Console.WriteLine(today);
                string dayToday = today.ToString();
                Console.WriteLine(dayToday);


                if (today == DayOfWeek.Sunday || today == DayOfWeek.Saturday)
                {
                    Console.WriteLine("Evet bugün dersiniz var.");
                }
                else
                {
                    Console.WriteLine("Bugün dersin yok.");

                }

                var classmesage = (today == DayOfWeek.Sunday || today == DayOfWeek.Saturday) ? "Bugün Dersim var." : "Bugün dersim yok.";

                Console.WriteLine(classmesage);

            }

            if (qNum == 20)
            {
                Console.WriteLine("Plakaya göre il");

                Console.WriteLine("İl Plakasını girin");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Adana");
                        break;
                    case 2:
                        Console.WriteLine("Adıyaman");
                        break;
                    case 3:
                        Console.WriteLine("Afyonkarahisar");
                        break;
                    case 4:
                        Console.WriteLine("Ağrı");
                        break;
                    default:
                        break;

                }
            }


            if (qNum == 21)
            {
                //Elimde 100 TL para var. Bunu maximum 5 kişiye 
                //dağıtmak istiyorum. Kişiler istedikleri tutarı
                //kendi talep ediyor olacak.
                int maxValue = 100;

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i + 1 + ". Kişinin Talep Ettiği Tutarı Girin");
                    int requiredAmnt = Convert.ToInt32(Console.ReadLine());

                    int temp = maxValue - requiredAmnt;

                    while (temp < 0)
                    {
                        Console.WriteLine("Toplam Tutarı Aştınız:");
                        Console.WriteLine(i + 1 + ". Kişinin Talep Ettiği Tutarı Girin");
                        requiredAmnt = Convert.ToInt32(Console.ReadLine());
                        temp = maxValue - requiredAmnt;
                    }

                    maxValue -= requiredAmnt;

                    if (maxValue <= 0)
                    {
                        break;
                    }
                }
            }

        }

    }
}



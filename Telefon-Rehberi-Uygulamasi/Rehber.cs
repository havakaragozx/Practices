namespace TelefonRehberi
{
    public class Rehber
    {
        public static void Kaydet(List<Kisi> kisiler)
        {
            Console.WriteLine("İsim : ");
            string isim = Console.ReadLine();
            Console.WriteLine("Soyisim : ");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Telefon : ");
            string telefonNo = Console.ReadLine();
            kisiler.Add(new Kisi() { Isim = isim, Soyisim = soyisim, TelefonNo = telefonNo });
            RehberGoster(kisiler);
        }

        private static void RehberGoster(List<Kisi> kisiler)
        {
            foreach (var kisi in kisiler)
            {
                Console.WriteLine("İsim ={0}/n Soyisim={1} /n Telefon={2} ", kisi.Isim, kisi.Soyisim, kisi.TelefonNo);
            }
        }

        public static void Sil(List<Kisi> kisiler)
        {
            Console.WriteLine("Silmek istediğiniz kişinin adını ve soyadını giriniz: ");
            string silinecek = Console.ReadLine();
            bool kisiKontrol = false;
            foreach (var kisi in kisiler.ToList())
            {
                kisiKontrol = true;
                if (kisi.Isim == silinecek || kisi.Soyisim == silinecek)
                {
                    Console.WriteLine("{} isimli kisi rehberden silinecek , onaylıyor musunuz?(e/h)", kisi);
                    string cevap = Console.ReadLine().ToLower();
                    if (cevap == "e")
                    {
                        kisiler.Remove(kisi);
                    }
                    else if (cevap == "h")
                    {
                        Console.WriteLine("Silme işlemi iptal edildi.");
                        break;
                    }
                    break;

                }
            }
            if(!kisiKontrol){
                 System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                System.Console.WriteLine("* Yeniden denemek için      : (2)");

                int giren = int.Parse(Console.ReadLine());
                if (giren == 2)
                {
                    Sil(kisiler);
                }
                if (giren == 1)
                {
                    System.Console.WriteLine("silme işlemi sonlandırılıyor..");

                }
            }
            RehberGoster(kisiler);

        }

        public static void Güncelleme(List<Kisi> kisiler){
             System.Console.WriteLine("Lütfen numarasını değiştirmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string girdi = Console.ReadLine();
            bool Kisivarmı = false;
            foreach (var item in kisiler.ToList())
            {
                if (item.Isim == girdi || item.Soyisim == girdi)
                {
                    Kisivarmı = true;
                    System.Console.WriteLine("{0} isimli kişinin numarası güncellenmek üzere, onaylıyor musunuz ?(y/n)", item.Isim);
                    string YesNo = Console.ReadLine().ToLower();
                    if (YesNo == "y")
                    {
                        System.Console.WriteLine("yeni numarayı giriniz:");
                        string YeniNumara = Console.ReadLine();
                        item.TelefonNo = YeniNumara;
                    }
                    else if (YesNo == "n")
                    {
                        System.Console.WriteLine("güncelleme işlemi iptal edildi..");
                        break;
                    }
                    break;
                }
            }
            if (!Kisivarmı)
            {
                System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* güncellemeyi sonlandırmak için : (1)");
                System.Console.WriteLine("* Yeniden denemek için      : (2)");

                string input = Console.ReadLine();
                if (input == "2")
                {
                    Güncelleme(kisiler);
                }
                if (input == "1")
                {
                    System.Console.WriteLine("Güncelleme işlemi sonlandırılıyor..");

                }
            }
                RehberGoster(kisiler);
        }
public static void RehberListeleme(List<Kisi> KisiListesi)
        {
            System.Console.WriteLine("Rehberi A-Z Şeklinde sıralamak istiyorsanız (1)");
            System.Console.WriteLine("Rehberi Z-A Şeklinde sıralamak istiyorsanız (2)");
            string girdi = Console.ReadLine();
            if (girdi == "1")
            {
                System.Console.WriteLine("Telefon Rehberi (A-Z)");
                System.Console.WriteLine("**********************************************");
                var SiraliRehberListesi = KisiListesi.OrderBy(Kisi => Kisi.Isim);
                //                           from Kisi in KisiListesi
                //                           orderby Kisi.Isim
                //                           select Kisi;
                 foreach (var Kisi in SiraliRehberListesi)
                {
                    Console.WriteLine(" isim= {0} \n soyisim = {1} \n telefon no = {2} \n     - ", Kisi.Isim, Kisi.Soyisim, Kisi.TelefonNo);
                    System.Console.WriteLine(".\n.");
                }
            }
            if (girdi == "2")
            {
                System.Console.WriteLine("Telefon Rehberi (Z-A)");
                System.Console.WriteLine("**********************************************");
                var SiraliRehberListesi = from Kisi in KisiListesi
                                          orderby Kisi.Isim descending
                                          select Kisi;
                foreach (var Kisi in SiraliRehberListesi)
                {

                    Console.WriteLine(" isim= {0} \n soyisim = {1} \n telefon no = {2} \n     - ", Kisi.Isim, Kisi.Soyisim, Kisi.TelefonNo);
                    System.Console.WriteLine(".\n.");
                }
            }

        }

  public static void RehberdeArama(List<Kisi> KisiListesi)
        {

            System.Console.WriteLine("arama yapmak istediğiniz tipi seçiniz");
            System.Console.WriteLine("**********************************************");
            System.Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine("Telefon numarasına göre arama yapmak için: (2) ");

            int Secsayı = int.Parse(Console.ReadLine());
            if (Secsayı == 1)
            {
                System.Console.WriteLine("Lütfen Aramak istediğiniz kişiye ait isim veya soyisim giriniz");
                string girilen = Console.ReadLine();
                foreach (var item in KisiListesi)
                {
                    if (item.Isim.ToLower() == girilen.ToLower() || item.Soyisim.ToLower() == girilen.ToLower())
                    {
                        System.Console.WriteLine("isim: {0}", item.Isim);
                        System.Console.WriteLine("Soyisim: {0}", item.Soyisim);
                        System.Console.WriteLine("Telefon Numarası: {0}", item.TelefonNo);
                        System.Console.WriteLine("    -    ");
                    }

                }

            }
            else if (Secsayı == 2)
            {
                System.Console.WriteLine("Lütfen Aramak istediğiniz kişiye ait telefon numarası giriniz ");
                string girilenNo = Console.ReadLine();
                foreach (var item in KisiListesi)
                {
                    if (girilenNo == item.TelefonNo)
                    {
                        System.Console.WriteLine("isim: {0}", item.Isim);
                        System.Console.WriteLine("Soyisim: {0}", item.Soyisim);
                        System.Console.WriteLine("Telefon Numarası: {0}", item.TelefonNo);
                        System.Console.WriteLine("    -    ");
                        System.Console.WriteLine(".\n.");

                    }
                }
            }
            else
            {
                System.Console.WriteLine("hatalı seçim..");
            }


        }


    }
}
   

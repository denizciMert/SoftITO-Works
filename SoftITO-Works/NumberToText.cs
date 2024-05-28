namespace SoftITO_Works
{
    public class NumberToText
    {
        /*
                private static void Main()
                {
                    Console.Write("Bir sayı giriniz: ");
                    if (int.TryParse(Console.ReadLine(), out int sayi))
                    {
                        Console.WriteLine("Yazı olarak: " + SayiYaziyaCevir(sayi));
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir sayı girdiniz.");
                    }
                }
        */

        private static string SayiYaziyaCevir(int sayi)
        {
            if (sayi == 0)
                return "sıfır";

            if (sayi < 0)
                return "eksi " + SayiYaziyaCevir(-sayi);

            int[] basamaklarHesaplanacak = new int[] { 1000000000, 100000000, 10000000, 1000000, 100000, 10000, 1000, 100, 10, 1 };
            List<int> basamaklarBolundu = [];
            int basamakSayısı = 0;
            foreach (int basamak in basamaklarHesaplanacak)
            {
                int a = sayi / basamak;
                if (a >= 1)
                {
                    a = int.Parse(a.ToString().Substring(basamakSayısı));
                    basamaklarBolundu.Add(a);
                    basamakSayısı++;
                }
            }

            string[,] basamakText =
            {
            { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" },
            { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" },
        };
            string[] basamakSonu = ["yüz", "bin", "milyon", "milyar"];
            List<string> yazdırmaListesi = [];
            foreach (int i in basamaklarBolundu)
            {
                if (i != 0)
                {
                    yazdırmaListesi.Add(basamakText[(basamakSayısı - 1) % 2, i]);
                    if (basamakSayısı == 3)
                    {
                        yazdırmaListesi.Add(basamakSonu[0]);
                    }
                    else if (basamakSayısı == 4)
                    {
                        yazdırmaListesi.Add(basamakSonu[1]);
                    }
                    else if (basamakSayısı == 5)
                    {
                        yazdırmaListesi.Add(basamakSonu[2]);
                    }
                    else if (basamakSayısı == 9)
                    {
                        yazdırmaListesi.Add(basamakSonu[3]);
                    }
                    basamakSayısı--;
                }
            }

            return string.Join(" ", yazdırmaListesi);
        }

        /*class Program
    {
        static void Main()
        {
            Console.Write("Bir sayı giriniz: ");
            if (int.TryParse(Console.ReadLine(), out int sayi))
            {
                Console.WriteLine("Yazı olarak: " + SayiYaziyaCevir(sayi));
            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
            }
        }

        static string SayiYaziyaCevir(int sayi)
        {
            if (sayi == 0)
                return "sıfır";

            if (sayi < 0)
                return "eksi " + SayiYaziyaCevir(-sayi);

            string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string[] yuzler = { "", "yüz", "iki yüz", "üç yüz", "dört yüz", "beş yüz", "altı yüz", "yedi yüz", "sekiz yüz", "dokuz yüz" };

            List<string> parts = new List<string>();

            int basamak = 0;

            while (sayi > 0)
            {
                int mod = sayi % 1000;
                sayi /= 1000;

                if (mod > 0)
                {
                    if (basamak == 1 && mod == 1)
                    {
                        parts.Insert(0, "bin");
                    }
                    else
                    {
                        string part = string.Empty;
                        part = birler[mod % 10];
                        mod /= 10;

                        if (mod > 0)
                        {
                            part = onlar[mod % 10] + (string.IsNullOrEmpty(part) ? "" : " ") + part;
                            mod /= 10;
                        }

                        if (mod > 0)
                        {
                            part = yuzler[mod % 10] + (string.IsNullOrEmpty(part) ? "" : " ") + part;
                        }

                        if (basamak > 0)
                        {
                            string[] basamakText = { "", "bin", "milyon", "milyar" };
                            part += " " + basamakText[basamak];
                        }

                        parts.Insert(0, part);
                    }
                }

                basamak++;
            }

            return string.Join(" ", parts).Trim();
        }
    }*/
    }
}

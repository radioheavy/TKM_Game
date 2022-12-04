using System;

namespace TextBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oyun başlangıç mesajı
            Console.WriteLine("Merhaba, oyuna hoş geldiniz!");
            Console.WriteLine("Bir taş, kağıt, makas oyunu oynamaya hazır mısınız? (e/h)");
            string cevap = Console.ReadLine();

            // Oyun başla
            while (cevap == "e")
            {
                // Kullanıcıdan taş, kağıt veya makas seçmesini iste
                Console.WriteLine("Lütfen taş (t), kağıt (k) veya makas (m) seçiniz:");
                string secim = Console.ReadLine();

                // Bilgisayarın seçimini rastgele belirle
                Random rastgele = new Random();
                int randomNo = rastgele.Next(1, 4);
                string bilgisayarSecim = "";

                if (randomNo == 1)
                    bilgisayarSecim = "t";
                else if (randomNo == 2)
                    bilgisayarSecim = "k";
                else if (randomNo == 3)
                    bilgisayarSecim = "m";

                // Sonuçları hesapla
                Console.WriteLine("Bilgisayarın seçimi: " + bilgisayarSecim);

                if (secim == bilgisayarSecim)
                    Console.WriteLine("Berabere!");
                else if (secim == "t" && bilgisayarSecim == "m")
                    Console.WriteLine("Kazandınız!");
                else if (secim == "t" && bilgisayarSecim == "k")
                    Console.WriteLine("Kaybettiniz!");
                else if (secim == "k" && bilgisayarSecim == "t")
                    Console.WriteLine("Kazandınız!");
                else if (secim == "k" && bilgisayarSecim == "m")
                    Console.WriteLine("Kaybettiniz!");
                else if (secim == "m" && bilgisayarSecim == "t")
                    Console.WriteLine("Kaybettiniz!");
                else if (secim == "m" && bilgisayarSecim == "k")
                    Console.WriteLine("Kazandınız!");

                // Yeni oyun oynamak isteyip istemediğini sorman
                Console.WriteLine("Yeni oyun oynamak ister misiniz? (e/h)");
                cevap = Console.ReadLine();
            }

            // Oyunu bitir 
            Console.WriteLine("Oyun bitti. Güle güle!");
        }
    }
}
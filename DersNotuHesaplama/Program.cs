namespace Odev._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen ders adını giriniz:");
            string dersAdi = Console.ReadLine();

        NotGiris:

            Console.WriteLine("Lütfen vize notunuzu giriniz:");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen final notunuzu giriniz:");
            int final = Convert.ToInt32(Console.ReadLine());
            double ortalama = (vize * 0.4) + (final * 0.6);

            if (vize >= 0 && vize <= 100 && final >= 0 && final <= 100)
            {
                Console.WriteLine($"{dersAdi} dersinden dönem sonu puanınız: ");

                if (ortalama >= 0 && ortalama <= 50)
                {
                    Console.WriteLine("dönem sonu puanınız: D");
                }
                else if (ortalama >= 50 && ortalama <= 59)
                {
                    Console.WriteLine("dönem sonu puanınız :C2");
                }
                else if (ortalama >= 60 && ortalama <= 64)
                {
                    Console.WriteLine("döenm sonu puanınız : C1");
                }
                else if (ortalama >= 65 && ortalama <= 69)
                {
                    Console.WriteLine("dönem sonu puanınız: B2");
                }
                else if (ortalama >= 70 && ortalama <= 74)
                {
                    Console.WriteLine("dönem sonu puanınız:B1");
                }
                else if (ortalama >= 75 && ortalama >= 84)
                {
                    Console.WriteLine("dönem sonu puanınız: A2");
                }
                else
                {
                    Console.WriteLine("dönem sonu puanınız: A1");
                }
                Console.WriteLine(ortalama < 50 ? "kaldınız" : "geçtiniz");
            }
            else
            {
                Console.WriteLine("lütfen 0 ile 100 arasında bir not giriniz.");
                goto NotGiris;
            }
        }
    }
}


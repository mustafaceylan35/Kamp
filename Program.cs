namespace Kamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ögrencisayısı = 12001;
            double faizoranı = 1.89;
            bool Girdimi = true;
            double dolardun = 18.99;
            double dolarbugun=18.98;

            Console.WriteLine(ögrencisayısı);
            Console.WriteLine(faizoranı);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(Girdimi);

            if (dolardun<dolarbugun)
            {
                Console.WriteLine("artış butonu ekle");
            }
            else if (dolardun>dolarbugun)
            {
                Console.WriteLine("azalış butonu ekle.");

            }
            else
            {
                Console.WriteLine("sabit butonunu ekle.");
            }


            if (Girdimi == true)
            {
                Console.WriteLine("Kullanıcı girdi");
            }
            else
            {
                Console.WriteLine("Sisteme giriş yapılmadı. ");
            }

            Console.ReadLine();
        }
    }
}
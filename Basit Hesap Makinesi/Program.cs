using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basit_Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim, x, y, sonuc;

            Console.WriteLine("Lütfen işlem seçiniz; \n 1-) Toplama \n 2-) Çıkarma \n 3-) Çarpma \n 4-) Bölme");
            secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {

                case 1:
                    Console.WriteLine("İlk sayınızı giriniz:");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("İkinci sayınızı giriniz:");
                    y = Convert.ToInt32(Console.ReadLine());
                    sonuc = x + y;
                    Console.WriteLine(sonuc);
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("İlk sayınızı giriniz:");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("İkinci sayınızı giriniz:");
                    y = Convert.ToInt32(Console.ReadLine());
                    sonuc = x - y;
                    Console.WriteLine(sonuc);
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("İlk sayınızı giriniz:");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("İkinci sayınızı giriniz:");
                    y = Convert.ToInt32(Console.ReadLine());
                    sonuc = x * y;
                    Console.WriteLine(sonuc);
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("İlk sayınızı giriniz:");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("İkinci sayınızı giriniz:");
                    y = Convert.ToInt32(Console.ReadLine());
                    sonuc = x / y;
                    Console.WriteLine(sonuc);
                    Console.ReadLine();
                    break;

            }
        }
    }
}

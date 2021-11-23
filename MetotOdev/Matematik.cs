using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOdev
{
    class Matematik
    {
        public bool Yeniden()
        {
            Console.WriteLine("Devam etmek istiyor musunuz.(E/H)");
            string secim = Console.ReadLine();
            if (secim.ToLower() == "e")
                return true;
            else
            {
                return false;
            }

        }
        public void Menu()
        {

            Console.WriteLine("Menu");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkartma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.Write("Lütfen bir değer seçiniz :");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine("\nToplama Sectiniz");

                    Topla(sayiGir(), sayiGir());
                    break;
                case 2:
                    Console.WriteLine("\nÇıkartma Sectiniz");
                    Cikart(sayiGir(), sayiGir());
                    break;
                case 3:
                    Console.WriteLine("\nÇarpma Sectiniz");
                    Carp(sayiGir(), sayiGir());
                    break;
                case 4:
                    Console.WriteLine("\nBölme Sectiniz");
                    Bol(sayiGir(), sayiGir());
                    break;
                default:
                    Console.WriteLine("\nYanlış değer girdiniz.");
                    break;
            }
        }
        private static int sayiGir()
        {
            Console.Write("Sayı girinz : ");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;

        }
        private static void Topla(double x, double y)
        {

            double sonuc = x + y;
            EkranaYazdir("+", x, y, sonuc);
        }
        private static void Cikart(double x, double y)
        {
            double sonuc = x - y;
            EkranaYazdir("-", x, y, sonuc);
        }
        private static void Carp(double x, double y)
        {
            double sonuc = x * y;
            EkranaYazdir("*", x, y, sonuc);
        }
        private static void Bol(double x, double y)
        {
            double sonuc = x / y;
            sonuc = Math.Round(sonuc,2);
            EkranaYazdir("/", x, y, sonuc);
        }
        private static void EkranaYazdir(string islem, double x, double y, double sonuc)
        {
            Console.WriteLine(x + " " + islem + " " + y + " = " + sonuc);
        }
    }
}

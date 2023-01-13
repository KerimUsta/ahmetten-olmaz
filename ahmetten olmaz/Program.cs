using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ahmetten_olmaz
{


    internal class Program
    {

        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Kayıt İşlemleri";
            char sec;
            do
            {
                sec = menu();
                if (sec == '1')
                {
                    Console.Clear();
                    Dortgen d1 = new Dortgen();
                    d1.KenarGir(1);
                    d1.KenarGir(2);
                    d1.Alanhesapla();
                    Console.WriteLine(d1.Alan);
                    Console.Read();
                }
                else if (sec == '2')
                {
                    Console.Clear();
                    DiktortgenPrizma d2 = new DiktortgenPrizma();
                    d2.KenarGir(1);
                    d2.KenarGir(2);
                    d2.KenarGir(3);
                    d2.Alanhesapla();
                    Console.WriteLine(d2.Alan);
                    Console.Read();
                }
                else if (sec == '3')
                {
                    Console.Clear();
                    DiktortgenPrizma d2 = new DiktortgenPrizma();
                    d2.KenarGir(1);
                    d2.KenarGir(2);
                    d2.KenarGir(3);
                    d2.Hacimhesapla();
                    Console.WriteLine(d2.Hacim);
                    Console.Read();
                }
            } while (sec != '4');
        }
        static char menu()
        {
            Console.Clear();
            Console.Write("Alan/Hacim Hesaplama\n----------------\n");
            Console.Write("1-Dikdörtgen Alanı\n2-Dikdörtgen Prizma Alanı\n3-Dikdörtgen Prizma Hacmi\n");
            Console.Write("4-Çıkış");
            char secenek = Console.ReadKey().KeyChar;
            return secenek;
        }
    }
    class Dortgen
    {
        protected int k1, k2, alan;
        public int Alan
        {
            get { return alan; }
        }
        public virtual void KenarGir(int kenar)
        {
            Console.Write("{0}.Kenar:", kenar);
            int k = int.Parse(Console.ReadLine());
            if (kenar == 1)
            {
                k1 = k;
            }
            else if (kenar == 2)
            {
                k2 = k;
            }
        }
        public virtual void Alanhesapla()
        {
            alan = k1 * k2;
        }
    }
    class DiktortgenPrizma : Dortgen
    {
        public int Hacim
        {
            get { return hacim; }
        }
        protected int k3, hacim;
        public override void KenarGir(int kenar)
        {
            Console.Write("{0}.Kenar:", kenar);
            int k = int.Parse(Console.ReadLine());
            if (kenar == 1)
            {
                k1 = k;
            }
            else if (kenar == 2)
            {
                k2 = k;
            }
            else if (kenar == 3)
            {
                k3 = k;
            }
        }
        public void Hacimhesapla()
        {
            hacim = k1 * k2 * k3;
        }

        public override void Alanhesapla()
        {
            alan = 2 * (2 * k1 + 2 * k2 + 2 * k3);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkinciSoru
{
    class Program
    {
        static void Main(string[] args)
        {
            Matris test = new Matris();
            test.MatrisYazdir();
            test.MatrisButunToplam();
            Console.Read();
        }
    }

    class Matris
    {
        int Satir { get; set; }
        int Sutun { get; set; }
        int[,] MyMatris { get; set; }

        public Matris()
        {
            Satir = 2;
            Sutun = 3;
            MyMatris = new int[Satir, Sutun];
            for(int i = 0; i < Satir; i++)
            {
                for(int j = 0; j < Sutun; j++)
                {
                    Console.Write("{0}/{1}: ", i, j);
                    MyMatris[i,j] = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }
        }

        public void MatrisYazdir()
        {
            for (int i = 0; i < Satir; i++)
            {
                for (int j = 0; j < Sutun; j++)
                {
                    Console.Write("{0} ", MyMatris[i,j]);
                }
                Console.WriteLine();
            }
        }

        public void MatrisSatirToplam()
        {
            int toplam = 0;
            for (int i = 0; i < Satir; i++)
            {
                for (int j = 0; j < Sutun; j++)
                {
                    toplam += MyMatris[i, j];
                }
                Console.WriteLine("{0}. Satir: {1}", i, toplam);
                toplam = 0;
            }
        }

        public void MatrisSutunToplam()
        {
            int toplam = 0;
            for (int i = 0; i < Sutun; i++)
            {
                for (int j = 0; j < Satir; j++)
                {
                    toplam += MyMatris[j, i];
                }
                Console.WriteLine("{0}. Sutun: {1}", i, toplam);
                toplam = 0;
            }
        }

        public void MatrisButunToplam()
        {
            int toplam = 0;
            for (int i = 0; i < Satir; i++)
            {
                for (int j = 0; j < Sutun; j++)
                {
                    toplam += MyMatris[i, j];
                }
            }
            Console.WriteLine("Bütün toplam: {0}", toplam);
        }
    }
}

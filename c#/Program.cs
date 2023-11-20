
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Latihan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nama, ktp, namakamar = "";
            int lama, kamar, harga = 0, biaya = 0;
            double diskon = 0, bayar = 0;
            Console.WriteLine("Program Menghitung Pembayaran Kamar Hotel Kepu");
            Console.WriteLine("==============================================");

            Console.Write("Masukkan Nama Anda : ");
            nama = Console.ReadLine();

            Console.Write("Masukkan KTP Anda : ");
            ktp = Console.ReadLine();

            Console.Write("Lama Anda Menginap : ");
            lama = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. VIP");
            Console.WriteLine("2. Deluxe");
            Console.WriteLine("3. Standar");
            Console.Write("Pilihan Kamar : ");
            kamar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if (kamar==1)
            {
                namakamar = "VIP";
                harga = 1000000;
                if (lama>=2 && lama<=3)
                {
                    diskon = harga * 0.05;
                }
                else if (lama >= 4 && lama <= 6)
                {
                    diskon = harga * 0.1;
                }
                else if (lama >7)
                {
                    diskon = harga * 0.15;
                }
            }

            else if (kamar == 2)
            {
                namakamar = "Deluxe";
                harga = 800000;
                if (lama >= 2 && lama <= 3)
                {
                    diskon = harga * 0.05;
                }
                else if (lama >= 4 && lama <= 6)
                {
                    diskon = harga * 0.1;
                }
                else if (lama > 7)
                {
                    diskon = harga * 0.15;
                }
            }

            else if (kamar == 3)
            {
                namakamar = "Standar";
                harga = 500000;
                if (lama >= 2 && lama <= 3)
                {
                    diskon = harga * 0.05;
                }
                else if (lama >= 4 && lama <= 6)
                {
                    diskon = harga * 0.1;
                }
                else if (lama > 7)
                {
                    diskon = harga * 0.15;
                }
            }
            biaya = harga * lama;
            bayar = biaya - diskon;

            Console.WriteLine("Nama : "+nama);
            Console.WriteLine("No KTP : " + ktp);
            Console.WriteLine("Lama Menginap : " + lama + " Malam");
            Console.WriteLine("Tipe Kamar : " + namakamar);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Harga Kamar : Rp." + harga);
            Console.WriteLine("Tipe Kamar : " + namakamar);
            Console.WriteLine("Jumlah Biaya : Rp." + biaya);
            Console.WriteLine("Diskon : Rp." + diskon);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Jumlah Bayar : Rp." + bayar);

            Console.ReadKey();
        }
    }
}

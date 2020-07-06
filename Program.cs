using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        static List<Produk> list = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            bool loop = true;
            while (true)
            {
                int menu;
                TampilMenu();
                Console.Write("\n Pilih Menu : ");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4:
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine(" Pilih Menu Aplikasi\n");
            Console.WriteLine(" 1. Tambah Produk");
            Console.WriteLine(" 2. Hapus Produk");
            Console.WriteLine(" 3. Tampilkan Produk");
            Console.WriteLine(" 4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();
            Produk produk = new Produk();
            Console.WriteLine(" Tambah Data Produk\n");
            Console.Write(" Kode Produk : ");
            produk.Kode = Console.ReadLine();
            Console.Write(" Nama Produk : ");
            produk.Nama = Console.ReadLine();
            Console.Write(" Harga Beli  : ");
            produk.Beli = double.Parse(Console.ReadLine());
            Console.Write(" Harga Jual  : ");
            produk.Jual = double.Parse(Console.ReadLine());
            list.Add(produk);
            Console.WriteLine("\n Tekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            int nomor = -1;
            int hapus = -1;
            Console.Clear();
            TampilProduk();
            Console.WriteLine(" Hapus Data Produk");
            Console.Write(" Kode Produk : ");
            string kode = Console.ReadLine();
            foreach (Produk produk in list)
            {
                nomor++;
                if (produk.Kode == kode)
                {
                    hapus = nomor;
                }
            }
            if (hapus != -1)
            {
                list.RemoveAt(hapus);
                Console.WriteLine("\n Data produk berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\n Kode produk tidak ditemukan");
            }
            Console.WriteLine("\n Tekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            int nourut = 0;
            Console.WriteLine(" Data Produk");
            foreach (Produk produk in list)
            {
                nourut++;
                Console.WriteLine(" {0}. Kode Produk : {1}, Nama Produk : {2}, Harga Beli : {3}, Harga Jual : {4}", nourut, produk.Kode, produk.Nama, produk.Beli, produk.Jual);
            }
            if (nourut < 1)
            {
                Console.WriteLine(" Data Produk Kosong");
            }
            Console.WriteLine("\n Tekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

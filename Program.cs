using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> list = new List<Mahasiswa>();
        static Mahasiswa mhs = new Mahasiswa();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi!\n");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            mhs = new Mahasiswa();
            Console.WriteLine("Tambah data Mahasiswa\n");
            Console.Write("NIM\t: ");
            mhs.Nim = Console.ReadLine();
            Console.Write("Nama\t: ");
            mhs.Nama = Console.ReadLine();
            Console.Write("Jenis Kelain [L/P]   : ");
            mhs.Jenis_kelamin = Console.ReadLine() == "L" ? "Laki-laki" : "Perempuan";
            Console.Write("IPK\t: ");
            mhs.Ipk = (float)Convert.ToDouble(Console.ReadLine());
            list.Add(mhs);


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;
            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", no, mhs.Nim, mhs.Nama, mhs.Jenis_kelamin, mhs.Ipk);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

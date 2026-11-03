
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // FOR
        Console.WriteLine("Contoh For");

        // 1. angka 1 sampai 5
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        // 2. angka 1 sampai 10
        {
            for (int angka = 1; angka <= 10; angka++)
            {
                Console.WriteLine(angka);
            }
        }

        // 3. bilangan genap
        {
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        // 4. perkalian 5
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("5 x " + i + " = " + (5 * i));
            }
        }

        // 5. menjumlahkan angka
        {
            int hasil = 0;

            for (int i = 1; i <= 10; i++)
            {
                hasil = hasil + i;
            }

            Console.WriteLine("Hasilnya: " + hasil);
        }


        // WHILE
        Console.WriteLine("\nContoh While");

        // 1.
        {
            int angka = 1;

            while (angka <= 5)
            {
                Console.WriteLine(angka);
                angka++;
            }
        }

        // 2.
        {
            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        // 3. angka ganjil
        {
            int i = 1;

            while (i <= 15)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }

        // 4. hitung mundur
        {
            int hitung = 5;

            while (hitung >= 1)
            {
                Console.WriteLine(hitung);
                hitung--;
            }
        }

        // 5. jumlah angka 1-10
        {
            int angka = 1;
            int total = 0;

            while (angka <= 10)
            {
                total += angka;
                angka++;
            }

            Console.WriteLine("Total = " + total);
        }


        // DO WHILE
        Console.WriteLine("\nContoh Do While");

        // 1.
        {
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 5);
        }

        // 2.
        {
            int angka = 1;

            do
            {
                Console.WriteLine(angka);
                angka++;
            }
            while (angka <= 10);
        }

        // 3. bilangan genap
        {
            int i = 2;

            do
            {
                Console.WriteLine(i);
                i += 2;
            }
            while (i <= 20);
        }

        // 4. hitung mundur
        {
            int i = 10;

            do
            {
                Console.WriteLine(i);
                i--;
            }
            while (i >= 1);
        }

        // 5. menampilkan pesan
        {
            int ulang = 1;

            do
            {
                Console.WriteLine("Belajar pemrograman C#");
                ulang++;
            }
            while (ulang <= 5);
        }


        // FOREACH
        Console.WriteLine("\nContoh Foreach");

        // 1. nama teman
        {
            string[] teman = { "Rafli", "Nabila", "Dimas", "Keisha" };

            foreach (string nama in teman)
            {
                Console.WriteLine(nama);
            }
        }

        // 2. nama buah
        {
            string[] buah = { "Salak", "Duku", "Rambutan", "Sawo", "Melon" };

            foreach (string namaBuah in buah)
            {
                Console.WriteLine(namaBuah);
            }
        }

        // 3. menampilkan angka
        {
            int[] angka = { 14, 27, 35, 48, 59 };

            foreach (int x in angka)
            {
                Console.WriteLine(x);
            }
        }

        // 4. menghitung total nilai
        {
            int[] nilai = { 88, 76, 92, 85 };
            int total = 0;

            foreach (int n in nilai)
            {
                total += n;
            }

            Console.WriteLine("Total nilai = " + total);
        }

        // 5. daftar kegiatan
        {
            string[] kegiatan = { "Membaca", "Menulis", "Menggambar", "Mengoding" };

            foreach (string aktivitas in kegiatan)
            {
                Console.WriteLine(aktivitas);
            }
        }


        // ARRAY
        Console.WriteLine("\nContoh Array");

        // 1. daftar nama
        {
            string[] siswa = { "Farel", "Zahra", "Rizky", "Putri", "Bagas" };

            for (int i = 0; i < siswa.Length; i++)
            {
                Console.WriteLine(siswa[i]);
            }
        }

        // 2. daftar suhu
        {
            int[] suhu = { 28, 30, 27, 31, 29 };

            for (int i = 0; i < suhu.Length; i++)
            {
                Console.WriteLine(suhu[i]);
            }
        }

        // 3. menghitung total nilai
        {
            int[] nilai = { 82, 91, 78, 86, 94 };
            int total = 0;

            for (int i = 0; i < nilai.Length; i++)
            {
                total += nilai[i];
            }

            Console.WriteLine("Jumlah nilai = " + total);
        }

        // 4. mencari angka terbesar
        {
            int[] stok = { 12, 45, 23, 67, 34 };
            int terbesar = stok[0];

            for (int i = 1; i < stok.Length; i++)
            {
                if (stok[i] > terbesar)
                {
                    terbesar = stok[i];
                }
            }

            Console.WriteLine("Angka terbesar = " + terbesar);
        }

        // 5. menampilkan kota dari belakang
        {
            string[] kota = { "Surabaya", "Malang", "Sidoarjo", "Gresik", "Mojokerto" };

            for (int i = kota.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(kota[i]);
            }
        }


        // LIST
        Console.WriteLine("\nContoh List");

        // 1. daftar perangkat komputer
        {
            List<string> perangkat = new List<string>();

            perangkat.Add("Keyboard");
            perangkat.Add("Mouse");
            perangkat.Add("Monitor");

            foreach (string alat in perangkat)
            {
                Console.WriteLine(alat);
            }
        }

        // 2. daftar buah
        {
            List<string> buah = new List<string>();

            buah.Add("Markisa");
            buah.Add("Jambu Kristal");
            buah.Add("Belimbing");
            buah.Add("Manggis");

            foreach (string namaBuah in buah)
            {
                Console.WriteLine(namaBuah);
            }
        }

        // 3. menghapus nama anggota
        {
            List<string> anggota = new List<string>();

            anggota.Add("Arkan");
            anggota.Add("Salma");
            anggota.Add("Vino");

            anggota.Remove("Salma");

            foreach (string nama in anggota)
            {
                Console.WriteLine(nama);
            }
        }

        // 4. daftar harga barang
        {
            List<int> harga = new List<int>();

            harga.Add(5000);
            harga.Add(10000);
            harga.Add(15000);
            harga.Add(20000);

            foreach (int uang in harga)
            {
                Console.WriteLine(uang);
            }
        }

        // 5. jumlah perlengkapan sekolah
        {
            List<string> barang = new List<string>();

            barang.Add("Buku gambar");
            barang.Add("Spidol");
            barang.Add("Kertas HVS");
            barang.Add("Pensil warna");

            Console.WriteLine("Jumlah barang = " + barang.Count);
        }
    }
}

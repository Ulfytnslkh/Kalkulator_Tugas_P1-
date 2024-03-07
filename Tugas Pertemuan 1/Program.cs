using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Pertemuan_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menampilkan judul dan menu pada aplikasi kalkulator
            Console.WriteLine("==== Aplikasi Kalkulator ====");
            Console.WriteLine();
            Console.WriteLine("Pilih menu kalkulator : ");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();


            Console.Write("Input nomor menu (1....4) : ");//Meminta pengguna untuk memasukan pilihan menu
            

            string menu = Console.ReadLine();//Deklarasi variabel menu untuk proses casting


            switch (menu)//swicth case untuk melakukan operasi yang di pilih berdasarkan menu
            {
                case "1":
                    //operasi penambahan 
                    Console.WriteLine();//untuk baris kosong
                    Console.Write("Inputkan nilai a : ");
                    int a = Convert.ToInt32(Console.ReadLine());// proses casting variabel a
                    Console.Write("Inputkan nilai b : ");
                    int b = Convert.ToInt32(Console.ReadLine());//proses casting variabel b
                    Console.WriteLine();
                    Console.Write("Hasil Penambahan : {0}", a + b);
                    Console.WriteLine();
                    break;

                case "2":
                    //oprasi pengurangan
                    Console.WriteLine();
                    Console.Write("Inputkan nilai a : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan nilai b : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Hasil Penguarangan : {0}", a - b);
                    Console.WriteLine();
                    break;

                case "3":
                    //operasi perkalian
                    Console.WriteLine();
                    Console.Write("Inputkan nilai a : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan nilai b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Hasil Perkalian : {0}", a * b);
                    Console.WriteLine();
                    break;

                case "4":
                    //operasi pembagian
                    Console.WriteLine();
                    Console.Write("Inputkan nilai a : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan nilai b : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    //menangani pembagian dengan nol dengan memeriksa apakah b tidak sama dengan nol 
                    if (b != 0)
                    {
                        Console.Write("Hasil Pembagian : {0}", Convert.ToDouble(a) / Convert.ToDouble(b));
                    }
                    else
                    {
                        Console.WriteLine("Pembagian nol tidak diizinkan");
                    }
                    Console.WriteLine();
                    break;

                default:
                    //Menangani menu yang tidak ada dalam pilihan
                    Console.WriteLine();
                    Console.Write("Maaf, menu yang anda pilih tidak tersedia");
                    Console.WriteLine();
                    break;

            }

           
            //Menunggu input pengguna sebelum menutup program
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        


    }
}

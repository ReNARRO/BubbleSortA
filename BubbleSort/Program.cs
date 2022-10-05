﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        //Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //Fungsi / Method untuk menerima masukan
        public void read()
        {
            //Menerima angka untuk menentukan bayaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine(" Masukan elemen array ");
            Console.WriteLine("------------------------");

            //Penguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) //for n - 1 passes
            {
                //Pada pass i, bandingkan n - i elemn pertama dengan elemen selanjutnya
                for (int j = 0; j < n; j++)
                {
                    if (a[j] > a[j]+1) //Jika elemn tidak dalam urutan yang benar
                    {
                        // tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Creating the object of the BubbleSort class
            Program mylist = new Program();

            //Pemanggilan fungsi untuk menerima elemen array
            mylist.read();
            //Pemanggilan fungsi untuk mengurutkan array
            mylist.BubbleSortArray();
            //Pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();
            //exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}

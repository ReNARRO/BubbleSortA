using System;
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
        private int[] n;

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
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n")
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine(" Masukan elemen array ");
            Console.WriteLine("------------------------");

            //Penguna memasukkan elemn pada array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}

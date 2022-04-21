using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {

            string nama;

            int nip, gpokok, gtunjangan, gtotal;



            Console.Write("Masukkan Nama  = ");

            nama = (Console.ReadLine());

            Console.Write("Masukkan NIP  = ");

            nip = int.Parse(Console.ReadLine());

            Console.Clear();
            gpokok = 0;
            gtotal = gtunjangan + gpokok;



            Console.WriteLine("Nama  : " + nama);

            Console.WriteLine("NIP  : " + nip);

            Console.WriteLine("Gaji Pokok : " + "Rp" + gpokok);

            Console.WriteLine("Tunjangan : " + "Rp" + gtunjangan);

            Console.WriteLine(" ");

            Console.WriteLine("Total gaji  = " + "Rp" + gtotal);



            Console.ReadKey();

        }

    }

}
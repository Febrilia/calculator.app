using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            // int a = 10; //declarasi variabel a, dgn nilai awal 10;
            // int b = 6; // declarasi variabel b, dgn nilai awal 6;

            private double tambah (double a, double b){
                return ( a + b );
            }
            
            private double kurang (double a, double b){
                return ( a - b );
            }
            
            private double kali (double a, double b){
                return ( a * b );
            }
            
            private double bagi (double a, double b){
                return ( a / b );
            }
        }
          
        public void Main ()
        {
            double bil1, bil2;
            char pilihan;
            Console.WriteLine("---Program Kalkulator Sederhana---");
            Console.WriteLine("==================================");
            Console.WriteLine("         Masukkan Pilihan        ");
            Console.WriteLine("==================================");
            Console.WriteLine("A. Tambah");
            Console.WriteLine("B. Kurang");
            Console.WriteLine("C. Kali");
            Console.WriteLine("D. Bagi");
            Console.WriteLine("==================================");
            Console.WriteLine(" Masukkan Pilihan    : ");
            pilihan = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine(); // tambahkan baris kosong

            if ( pilihan == 'A' || pilihan == 'a') {
            bil1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan bilangan kedua : ");
            bil2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Hasilnya Adalah : "+tambah(bil1,bil2)+);
            }

            else if (pilihan == 'B' || pilihan == 'b') {
            bil1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan bilangan kedua : ");
            bil2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Hasilnya Adalah : "+kurang(bil1,bil2)+);
            }

            else if (pilihan == 'C' || pilihan == 'c') {
            bil1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan bilangan kedua : ");
            bil2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Hasilnya Adalah : "+kali(bil1,bil2)+);
            }

            else if (pilihan == 'D' || pilihan == 'd') {
            bil1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan bilangan kedua : ");
            bil2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Hasilnya Adalah : "+(bil1,bil2)+);
            }
			
            Console.WriteLine("\nTekan sembarangan key untuk keluar");
            Console.Readkey();
        }
    }
}

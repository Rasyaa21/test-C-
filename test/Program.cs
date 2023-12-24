using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace classmeet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pesanan, harga = 0, jumlahBarang, nomimal, uang = 0, kembalian = 0, uangRepeatPayment = 0;
            string cont, repeatPayment;
            bool running = true;
            while (running)
            {
                Console.WriteLine("================ATK===============");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Buku \t\t Rp 5.000");
                Console.WriteLine("2. Pensil \t\t Rp 2.000");
                Console.WriteLine("3. Penghapus \t\t Rp 1.500");
                Console.WriteLine("4. Pulpen \t\t Rp 3.000");
                Console.WriteLine("==================================");

                Console.Write("Masukan pesanan : ");
                pesanan = int.Parse(Console.ReadLine());
                Console.Write("masukan jumlah barang : ");
                jumlahBarang = int.Parse(Console.ReadLine());
                
                if (pesanan == 1)
                {
                    harga += 5000;
                }
                else if (pesanan == 2)
                {
                    harga += 2000;
                }
                else if (pesanan == 3)
                {
                    harga += 1500;
                }
                else if (pesanan == 4)
                {
                    harga += 3000;
                }
                else
                {
                    Console.WriteLine("input tidak ada");
                    break;
                }
                nomimal = harga * jumlahBarang;
                Console.WriteLine($"total belanjaan adalah Rp.{nomimal}");
                Console.Write("masukan jumlah uang yang akan dibayar : Rp. ");
                uang = int.Parse(Console.ReadLine());

                if (uang >= nomimal)
                {
                    kembalian = uang - nomimal;
                    Console.WriteLine($"pembayaran berhasil kembalian = Rp.{kembalian}. terimakasih telah berbelanja");
                }   
                else
                {
                    while (true) 
                    { 
                    Console.Write("uang tidak cukup. harap melakukan pembayaran kembali : (y/n) ");
                    repeatPayment = Console.ReadLine().ToLower();
                    if (repeatPayment == "y")
                    {
                        Console.Write("masukan nominal uang yang akan ditambah : ");
                        uangRepeatPayment = int.Parse(Console.ReadLine());
                        uang = uang + uangRepeatPayment;
                        if (uang >= nomimal)
                        {
                            kembalian = uang - nomimal;
                            Console.WriteLine($"pembayaran berhasil kembalian = Rp.{kembalian}. terimakasih telah berbelanja");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("masukan uang kembali");
                            continue;
                        }
                    }
                    }
                }
                Console.Write("apakah anda ingin membeli lagi : (y/n) ");
                cont = Console.ReadLine().ToLower();
                if (cont == "y")
                {
                    uang = 0;
                    nomimal = 0;
                    kembalian = 0;
                    uangRepeatPayment = 0;
                    harga = 0;
                    Console.Clear();
                    continue;
                    
                }
                else if (cont == "n")
                {
                    Console.WriteLine("terimakasih telah berbelanja");
                    break;
                }
                
                else
                {
                    while (true)
                    {
                        Console.Write("inputan salah silahkan coba kembali : ");
                        cont = Console.ReadLine().ToLower();
                        if(cont == "y")
                        {
                            break;
                            Console.Clear();
                            running = true;
                        }
                        else if (cont == "n")
                        {
                            Console.WriteLine("terimakasih telah berbelanja");
                            running = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
    }
}
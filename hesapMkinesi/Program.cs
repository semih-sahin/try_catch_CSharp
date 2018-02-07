/*
 
    HESAP MAKINESI UYGULAMASI // Semih Sahin
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapMkinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("-KULLANIM KILAVUZU-");
            Console.WriteLine("1 - ilk once sayiyi gir ve enter tusuna bas.");
            Console.WriteLine("2 - sonra isaret gir(*,/,+,-)");
            Console.WriteLine("3 - ikinci sayiyi gir");
            Console.WriteLine("---------------------------------------------");
            A10:
            Console.ForegroundColor = ConsoleColor.Green;
            try
            {
                A20:
                try
                {
                    sayi1 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    A13:
                    string x = Console.ReadLine();
                    switch (x)
                    {
                        case "+":
                            Console.Clear();
                            A123:
                            try
                            {
                                sayi2 = Convert.ToDouble(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, (sayi1 + sayi2));
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Sayi giriniz lutfen. SAYI SAYI!!!");
                                goto A123;
                            }
                            break;

                        case "-":
                            Console.Clear();
                            A1233:
                            try
                            {
                                sayi2 = Convert.ToDouble(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, (sayi1 - sayi2));
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Sayi giriniz lutfen. SAYI SAYI!!!");
                                goto A1233;
                            }
                            break;

                        case "/":
                            Console.Clear();
                            A1223:
                            try
                            {
                                sayi2 = Convert.ToDouble(Console.ReadLine());
                                Console.Clear();
                                if (sayi2 == 0)
                                {
                                    Console.WriteLine("bir sayi sifira bolunemez!!!");
                                    break;
                                }
                                Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, (sayi1 / sayi2));
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Sayi giriniz lutfen. SAYI SAYI!!!");
                                goto A1223;
                            }
                            break;

                        case "*":
                            Console.Clear();
                            A1123:
                            try
                            {
                                sayi2 = Convert.ToDouble(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, (sayi1 * sayi2));
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Sayi giriniz lutfen. SAYI SAYI!!!");
                                goto A1123;
                            }
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("+,-,/,* isaretlerinden birini gir.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            goto A13;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("SAYI GIRIN LUTFEN!!!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto A20;
                    throw;
                }
               

            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HATA OLUSTU. ISLEMI BASA ALIYORUZ...");
                goto A10;
            }
            Console.WriteLine("GULE GULE!!! :)");
            Console.ReadKey();
        }
    }
}

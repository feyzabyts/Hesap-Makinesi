using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapmak_mutex_
{
    internal class Program
    {
        static void Main(string[] args)
        {

         //   ConsoleKeyInfo basilanTuss;



                ArrayList sayilar = new ArrayList();
                ArrayList islemTürü = new ArrayList();
            double sonuc = 0;
            double sayi1;
            char islem;
            ConsoleKeyInfo tus =Console.ReadKey();
            try
            {
                do
                {

                    Console.WriteLine("sayi gir");
                    sayi1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("yapmak istediğin işlemi seç");
                    islem = Convert.ToChar(Console.ReadLine());
                    sayilar.Add(sayi1);


                    if (islem == '+')
                    {
                        sonuc += sayi1;
                        islemTürü.Add(islem);
                    }
                    else if (islem == '*')
                    {
                        sonuc *= sayi1;
                        islemTürü.Add(islem);
                    }
                    else if (islem == '/')
                    {
                        sonuc /= sayi1;
                        islemTürü.Add(islem);
                    }
                    else if (islem == '-')
                    {
                        sonuc -= sayi1;
                        islemTürü.Add(islem);
                    }


                    sayilar.Add(sonuc);

                    Console.WriteLine("Sonuc:{0}", sonuc);

                } while (tus.Key != ConsoleKey.Escape);
            }

            catch(FormatException e)
            {
                Console.WriteLine("Lütfen bir sayı veya ( *  -  +  / )  bu karakterleri giriniz! "+ e.Message);
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine("Sayı sıfıra bölünemez! "+ e.Message);
            }
            catch 
            {
                Console.WriteLine("Beklenmeyen bir hata oluştu!");
            }
            
            Console.ReadLine();

        }
    }
}

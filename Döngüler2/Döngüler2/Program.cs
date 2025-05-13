using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogruSifre = "CSharp123";
            string girilenSifre;
            int deneme = 0;

            // do-while ile en az bir deneme garantisi
            do
            {
                Console.Write("Şifrenizi girin: ");
                girilenSifre = Console.ReadLine();
                deneme++;

                if (girilenSifre == dogruSifre)
                {
                    Console.WriteLine("Giriş başarılı!");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı şifre.");
                }

            } while (deneme < 3);

            if (girilenSifre != dogruSifre)
            {
                Console.WriteLine("3 kez hatalı giriş yaptınız. Hesabınız kilitlendi.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maaşconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int iMaas, iMik, iTop;
            Console.WriteLine("lütfen aldıgınız maası giriniz:");
            iMaas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen satış miktarınızı giriniz:");
            iMik = Convert.ToInt32(Console.ReadLine());

            if (iMik >= 1 && iMik <= 10)
            {
                iMik = iMik * 5;
            }
            else if (iMik > 10 && iMik <= 25)
            {
                iMik = iMik * 11;
            }
            else if (iMik > 25 && iMik <= 40)
            {
                iMik = iMik * 17;
            }
            else
            {
                iMik = iMik * 30;
            }

            iTop = iMik + iMaas;
            Console.WriteLine("Alınan toplam maas : " + iTop);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager 
    {
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)// parantez içi interface oldugu için hepsi için ayrı ayrı kredi hesaplama yapılabılır.
        {
            //Başvuran bilgilerini değerlendirme
            //

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); böyle olur ise tüm krediler konut kredi oranından hepsi hesaplanır.
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}

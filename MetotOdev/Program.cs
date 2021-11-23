using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOdev
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region 
            /*
             matematik adında class oluşturalacak
             bir menü hazırlanıcak metot ile
             menüde 
             1-toplama
             2-çıkartma
             3-bölme
             4-çarpma
             lütfen bir değer seciniz
             
             */
            #endregion
            Matematik mat = new Matematik();
            
            bool giris = true;
            while (giris)
            {
                mat.Menu();
                
                giris=mat.Yeniden();
                Console.Clear();
            }
        }
    }

    
}

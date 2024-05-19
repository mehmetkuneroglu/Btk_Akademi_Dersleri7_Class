using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_Akademi_Dersleri7_Class
{
    public class Ogretim_Elemani
    {
        public Ogretim_Elemani() // default constructor -yapılandırıcı metot
        {
        }

        public Ogretim_Elemani(int sicilNo, string adi, string soyadi, bool cinsiyet)  //tanımlı yapılandırıcı metot ve aşırı yükleme
        {
            SicilNo = sicilNo;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }


        public override string? ToString()  // ezme işlemi
        {
            return $"{SicilNo,-5}" +
                $"{Adi,-10}" +
                $"{Soyadi,-10}" +
                string.Format("{0,-9}", Cinsiyet == true ? "Bay" : "Bayan");
        }
    }

}

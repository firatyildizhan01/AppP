using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Ogrenci
    {
        string ad;
        string soyad;
        string memleket;
        int yas;
        char cinsiyet;
        string kimlik;
        public string AD
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }
        public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value; }
        }
        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }
        public char CİNSİYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value;}
        }
        public Ogrenci()
        {
            ad = "YUSUF";
            soyad = "gffdgd";
            memleket = "KAYSERİ";
            yas = 34;
            cinsiyet = 'k';
        }
            






     }       
}


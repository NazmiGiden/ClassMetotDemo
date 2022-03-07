using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class Musteri
    {
        private int Id { get; set; }
        public int ID
        {
            get
            {
                return Id;
            }
            set
            {
                this.Id = value;
            }
        }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        private long TcKimlik { get; set; }

        public long TCKIMLIK
        {
            get
            {
                return TcKimlik;
            }
            set
            {
                this.TcKimlik = value;
            }
        }

    }
}

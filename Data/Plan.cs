using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_Uygulamasi.Data
{
    class Plan
    {
        private string baslik;
        private string icerik;
        private TeamPerson atananKisi;
        private string buyukluk;
        
        public string _baslik { get { return baslik; } set { this.baslik = value; } }
        public string _icerik { get { return icerik; } set { this.icerik = value; } }
        public TeamPerson _atanankisi { get { return atananKisi; } set { this.atananKisi = value; } }
        public string _buyukluk { get { return buyukluk; } set { this.buyukluk = value; } }

        public Plan(string baslik,string icerik,TeamPerson atanan,string buyukl)
        {
            this.baslik = baslik;
            this.icerik = icerik;
            this.atananKisi = atanan;
            this.buyukluk = buyukl;
        }
    }
}

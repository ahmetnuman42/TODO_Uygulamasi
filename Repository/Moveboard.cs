using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO_Uygulamasi.Data;
using TODO_Uygulamasi.DataBase;

namespace TODO_Uygulamasi.Repository
{
    class Moveboard:IGenericOperations
    {
        public void moveBoard()
        {
            again:
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız : ");
            string girilenbaslik = Console.ReadLine();
            Plan plan = Cards.Todo.FirstOrDefault(x => x._baslik == girilenbaslik);
            if (plan == null)
            {
                tusla:
                Console.WriteLine("Aradığınız kriterlere uygun kart bulunamadı. Lütfen bir seçim yapınız");
                Console.WriteLine("*Taşımayı sonlandırmak için: (1)");
                Console.WriteLine("*Yeniden denemek için: (2)");
                string alinan = Console.ReadLine();
                if (alinan == "1")
                {
                    return;
                }
                else if (alinan == "2")
                {
                    goto again;
                }
                else
                {
                    Console.WriteLine("Geçersiz bir tuşlama yaptınız tekrar deneyin.");
                    goto tusla;
                }
            }
            else
            {
                yine:
                Console.WriteLine("Bulunan Kart bilgileri");
                Console.WriteLine("Baslik      :{0}", plan._baslik);
                Console.WriteLine("İçerik      :{0}", plan._icerik);
                Console.WriteLine("Atanan Kisi :{0}", plan._atanankisi.Name);
                Console.WriteLine("Büyüklük    :{0}", plan._buyukluk);
                Console.WriteLine("BUlunduğu Board: TODO");
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz ");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) INPROGRESS");
                Console.WriteLine("(3) DONE");
                string secim = Console.ReadLine();
                if (secim == "1") {
                    Console.WriteLine("Başarı ile taşındı");
                }
                else if (secim == "2")
                {
                    Cards.Inprogress.Add(plan);
                    Cards.Todo.Remove(plan);
                    Console.WriteLine("Taşıma başarı ile gerçekleştirildi.");
                }
                else if (secim == "3")
                {
                    Cards.Done.Add(plan);
                    Cards.Done.Remove(plan);
                    Console.WriteLine("Taşıma başarı ile gerçekleştirildi.");
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bi rakam giriniz.");
                    goto yine;
                }
            }
        }
    }
}

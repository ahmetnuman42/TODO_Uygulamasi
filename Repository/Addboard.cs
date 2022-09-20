using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO_Uygulamasi.Data;
using TODO_Uygulamasi.DataBase;
using TODO_Uygulamasi.Enums;
using static TODO_Uygulamasi.Enums.Buyuklukler;

namespace TODO_Uygulamasi.Repository
{
    class Addboard:IGenericOperations
    {          
        public void addBoard()
        {
            Console.WriteLine("Başlık giriniz                             :");
            string girilenB = Console.ReadLine();
            Console.WriteLine("İçerik giriniz                             :");
            string girileni = Console.ReadLine();
            Console.WriteLine("Büyüklük seçiniz XS(1),S(2),M(3),L(4),XL(5):");
            int girilenbu = Convert.ToInt32(Console.ReadLine());
            var buyukderecesi = (buyuklukler) girilenbu;            
            TeamPerson secilen=Kisisec();
            if (secilen == null)
            {
                Console.WriteLine("hatalı işlem yaptınız");
                return;
            }
            Plan yeni = new Plan(girilenB, girileni, secilen,buyukderecesi.ToString());           
            Cards.Todo.Add(yeni);
            Console.WriteLine("Başarıyla eklendi");
            
        }
        public TeamPerson Kisisec()
        {
            Console.WriteLine("Kişi seçiniz(ID sini giriniz)              :");
            TODO_Uygulamasi.DataBase.Cards deneme = new Cards();
            foreach (var item in  TeamPerson.tanimlikisiler)
            {
                Console.WriteLine("ID:{0} Name:{1}", item.ID, item.Name);
            }
            int girilen = Convert.ToInt32(Console.ReadLine());            
            TeamPerson secilen = TeamPerson.tanimlikisiler.FirstOrDefault(x => x.ID == girilen);
            
            return secilen;
        }
    }
}

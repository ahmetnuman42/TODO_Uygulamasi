using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO_Uygulamasi.Data;
using TODO_Uygulamasi.DataBase;

namespace TODO_Uygulamasi.Repository
{
    class Deleteboard:IGenericOperations
    {
        public void deleteBoard()
        {
            again:
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız : ");
            string girilenbaslik = Console.ReadLine();
            Plan plan= Cards.Todo.FirstOrDefault(x => x._baslik == girilenbaslik);
            if (plan == null)
            {
                tusla:
                Console.WriteLine("Aradığınız kriterlere uygun kart bulunamadı. Lütfen bir seçim yapınız");
                Console.WriteLine("*Silmeyi sonlandırmak için: (1)");
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
            else { 
            Cards.Todo.Remove(plan);
            Console.WriteLine("Başarıyla silinmiştir");
            }
        }
    }
}

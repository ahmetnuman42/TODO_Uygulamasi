using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO_Uygulamasi.DataBase;

namespace TODO_Uygulamasi.Repository
{
    class Listboard:IGenericOperations
    {
        public void listBoard()
        {
            Console.WriteLine("          TODO Line        ");
            Console.WriteLine("***************************");
          //  TODO_Uygulamasi.DataBase.Cards kart = new Cards();
            foreach (var item in Cards.Todo)
            {
                Console.WriteLine("Baslik      :{0}",item._baslik);
                Console.WriteLine("İçerik      :{0}",item._icerik);
                Console.WriteLine("Atanan Kisi :{0}",item._atanankisi.Name);
                Console.WriteLine("Büyüklük    :{0}",item._buyukluk);
                Console.WriteLine("************************");
            }
            if (Cards.Inprogress == null)
            {
                Console.WriteLine("In Progress-Line ");
                Console.WriteLine("************************");
                Console.WriteLine("Boş");
            }
            else {
                Console.WriteLine("In Progress-Line ");
                Console.WriteLine("************************");
                foreach (var item in Cards.Inprogress)
            {
                Console.WriteLine("Baslik      :{0}", item._baslik);
                Console.WriteLine("İçerik      :{0}", item._icerik);
                Console.WriteLine("Atanan Kisi :{0}", item._atanankisi.Name);
                Console.WriteLine("Büyüklük    :{0}", item._buyukluk);
                Console.WriteLine("************************");
            }
            }
            if (Cards.Done == null)
            {
                Console.WriteLine("Done-Line ");
                Console.WriteLine("************************");
                Console.WriteLine("Boş");
            }
            else
            {
                Console.WriteLine("Done-Line ");
                Console.WriteLine("************************");
                foreach (var item in Cards.Done)
                {
                    Console.WriteLine("Baslik      :{0}", item._baslik);
                    Console.WriteLine("İçerik      :{0}", item._icerik);
                    Console.WriteLine("Atanan Kisi :{0}", item._atanankisi.Name);
                    Console.WriteLine("Büyüklük    :{0}", item._buyukluk);
                    Console.WriteLine("************************");
                }
            }
        }
    }
}

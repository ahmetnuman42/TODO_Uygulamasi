using System;
using System.Text.RegularExpressions;
using TODO_Uygulamasi.Data;
using TODO_Uygulamasi.DataBase;
using TODO_Uygulamasi.Repository;

namespace TODO_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board listelemek");
            Console.WriteLine("(2) Board'a kart eklemek");
            Console.WriteLine("(3) Board'dan kart silmek");
            Console.WriteLine("(4) Kart taşımak");
            TeamPerson kisi = new TeamPerson(0, "Ahmet");
            TeamPerson kisi1 = new TeamPerson(1, "Mehmet");
            TeamPerson kisi2 = new TeamPerson(2, "Veli");
            TeamPerson.tanimlikisiler.Add(kisi);
            TeamPerson.tanimlikisiler.Add(kisi1);
            TeamPerson.tanimlikisiler.Add(kisi2);
            
            bas:
            string girilen = Console.ReadLine();
            Listboard list = new Listboard();
            switch (girilen)
            {
                case "1":                    
                    list.listBoard();
                    break;
                case "2":
                    Addboard add = new Addboard();
                    add.addBoard();
                    list.listBoard();
                    break;
                case "3":
                    Deleteboard delete = new Deleteboard();
                    delete.deleteBoard();
                    list.listBoard();
                    break;
                case "4":
                    Moveboard move = new Moveboard();
                    move.moveBoard();
                    list.listBoard();
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir rakam giriniz");
                    goto bas;                    
            }


        }

       
    }
}

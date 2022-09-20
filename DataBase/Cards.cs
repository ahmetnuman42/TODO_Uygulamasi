using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO_Uygulamasi.Data;

namespace TODO_Uygulamasi.DataBase
{
    class Cards
    {
       // public List<Plan> kartt;
        //public TeamPerson TeamPerson = new TeamPerson();
        public static List<Plan> Todo;
        public static List<Plan> Inprogress;
        public static List<Plan> Done;
        
        static Cards()
        {
            
            Todo = new List<Plan>()
            {                
                new Plan ("Proje","Projemi bitirmem lazım",new TeamPerson(0,"Ahmet"),"XS"),
                new Plan ("Ödev","Patika ödevlerini yapmam lazım",new TeamPerson(1,"Mehmet"),"S"),
                new Plan ("Güncelleme yapılacak","Veritabanı update edilmesi lazım",new TeamPerson(2,"Veli"),"L")                
            };
            Inprogress = new List<Plan>()
            {
                new Plan ("Deneme","abi bu iyimiş",new TeamPerson(0,"Ahmet"),"XS"),               
            };
            Done = new List<Plan>()
            {
                new Plan ("Sağlık","Doktora gidilecek",new TeamPerson(0,"Ahmet"),"XS"),
            };

        }
    }
}

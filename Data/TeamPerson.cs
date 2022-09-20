using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_Uygulamasi.Data
{
    class TeamPerson
    {
        public int ID;
        public string Name;
        public static List<TeamPerson> tanimlikisiler=new List<TeamPerson>();       
            
        public TeamPerson(int no,string namee)
        {
            this.ID = no;
            this.Name = namee;   
            
        }
        public static List<TeamPerson> Kisiler{ get {return tanimlikisiler;} }
        
       
    }
}

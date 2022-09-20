using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_Uygulamasi.Repository
{
    interface IGenericOperations
    {
        public void addBoard() { }
        public void deleteBoard() { }
        public void listBoard() { }
        public void editBoard() { }
        public void moveBoard() { }
    }
}

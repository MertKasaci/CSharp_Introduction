using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        //Bir field aşağıdaki gibi tanımlanır.
        //public string FirstName;

        //Bir property aşağıdaki şekilde oluşturulur.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}

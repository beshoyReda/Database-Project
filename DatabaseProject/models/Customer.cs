using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject.models
{
    public class Customer
    {
        public string FirstName { get;  }
        public string LastName { get;  }
        public int Balance { get; set; }
        public string ID { get; }
        public string Address { get; set; }
        public string DoB { get; set; }
        public string username { get; }
        public string password { get; }
        public string phone { get; set; }

        public Customer()
        {

        }
        public Customer(string firstname, string lastname, int balance, string id, string address, string dob, string user, string pass, string phonen)
        {
            FirstName = firstname;
            LastName = lastname;
            Balance = balance;
            ID = id;
            Address = address;
            DoB = dob;
            username = user;
            password = pass;
            phone = phonen;
        }
    }
}

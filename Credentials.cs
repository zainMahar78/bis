using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bi3
{
    internal class Credentials
    {
       public string name;
       public string password;
       public string role;
        public Credentials(string Aname, string Apassword, string Arole)
        {
           name = Aname;
            password = Apassword;
            role = Arole;
        }
    }
}

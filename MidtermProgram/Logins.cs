using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProgram
{
    class Logins
    {
        private int _ID;
        private string _username;
        private string _password;
        private int _superUser;
     
        
        public Logins(int id, string userName, string password, int superUser)
        {
            ID = id;
            Username = userName;
            Password = password;
            SuperUser = superUser;
        }
      
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

     

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int SuperUser
        {
            get { return _superUser; }
            set { _superUser = value; }
        }

        public Logins() { 
        
        }

        public Logins(int id, string password, int superuser)
        {
            _ID = id;
            _password = password;
            _superUser = superuser;
        }
     
    }
}

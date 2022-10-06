using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BELog
    {
        private string U_Id;
        public string UserId
        {
            get { return U_Id; }
            set { U_Id = value; }
        }
        private string U_password;
        public string Password
        {
            get { return U_password; }
            set { U_password = value; }
        }
        
        private string U_name;

        public string Name
        {
            get { return U_name; }
            set { U_name = value; }
        }
        
        
    }
}

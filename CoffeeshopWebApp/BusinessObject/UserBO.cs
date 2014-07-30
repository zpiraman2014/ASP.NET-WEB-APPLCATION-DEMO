using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class UserBO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string user_type { get; set; }

        public UserBO(int id,string name,string password,string email,string user_type)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.email = email;
            this.user_type = user_type;
        }
    }
}

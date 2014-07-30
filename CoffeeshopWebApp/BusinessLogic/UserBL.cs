using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using DataAccess;

namespace BusinessLogic
{
    public class UserBL
    {
        public UserBO GetUserByUserPass(string user, string pass)
        {
            UserDA userda = new UserDA();
            return userda.GetUserByUserPass(user, pass);
        }

        public bool CheckUser(string user)
        {
            UserDA userda = new UserDA();
            return userda.CheckUser(user);
        }

        public void InsertNewUser(UserBO user)
        {
            UserDA userda = new UserDA();
            userda.InsertUser(user);
        }
    }
}

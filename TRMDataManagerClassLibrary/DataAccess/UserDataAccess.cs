﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDataManager.Library.Internal.DataAccess;
using TRMDataManagerClassLibrary.Models;

namespace TRMDataManager.Library.DataAccess
{
    public class UserDataAccess
    {
        public List<UserModel> GetUserById(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id = Id };

            var output =  sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "TRMDataBase");
       
            return output;
        }
    }
}

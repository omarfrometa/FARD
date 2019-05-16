using System;
using FARD.Data.Entities;

namespace FARD.Data.StoredProcedures
{
    public class sp_get_users: User
    {
        public string picture { get; set; }
    }
}

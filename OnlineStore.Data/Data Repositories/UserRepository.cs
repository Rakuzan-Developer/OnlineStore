using OnlineStore.Data.Contracts;
using OnlineStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace OnlineStore.Data.Data_Repositories
{
    public class UserRepository : RepositoryBase<User,int>,IUserRepository
    {
        public UserRepository(DbContext dbContext)
            :base(dbContext)
        {
             
        }
    }
}

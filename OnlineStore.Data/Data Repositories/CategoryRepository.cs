using OnlineStore.Data.Contracts;
using OnlineStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace OnlineStore.Data.Data_Repositories
{
    class CategoryRepository : RepositoryBase<Category,int>,ICategoryRepository 
    {

        public CategoryRepository(DbContext dbContext)
            :base(dbContext)
        {
                
        }
    }
}

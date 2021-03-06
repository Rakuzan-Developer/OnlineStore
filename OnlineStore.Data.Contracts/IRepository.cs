﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Data.Contracts
{
    public interface IRepository<TEntity,TKey>
        where TEntity:class
    {
        Task<TEntity> GetAsync(TKey Id);

        IQueryable<TEntity> GetAll(int skip, int take);

        IQueryable GetAll(int skip, int take, Expression<Func<TEntity,bool>> predicate);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TKey id);

        void Delete(TEntity entity);

        Task SaveChangeAsync();

    }
}

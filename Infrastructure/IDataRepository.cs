﻿using System.Linq;

namespace Infrastructure
{
    public interface IDataRepository
    {


        IQueryable<TEntity> Query<TEntity>() where TEntity : class;

        void Add<TEntity>(TEntity entity) where TEntity : class;
        void Remove<TEntity>(TEntity entity) where TEntity : class;
        void Update<TEntity>(TEntity entity) where TEntity : class;
    }
}

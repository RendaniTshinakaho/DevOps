﻿using System;
using System.Linq;

namespace QueryIt.IRepository
{
    public interface IRepository<T>:IDisposable
    {
        void Add(T newEntity);
        void Delete(T entity);
        T FindById(int id);
        IQueryable<T> FindAll();
        int Commit();
    }
}
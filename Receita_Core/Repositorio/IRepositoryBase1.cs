using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace ApiReceita.Repository
{
    public interface IRepositoryBase1<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        T Find(params object[] key);
        T First(Expression<Func<T, bool>> predicate);

        void Adicionar(T entity);
        void Atualizar(T entity);
        void Deletar(Func<T, bool> predicate);
        void Commit();
        void Dispose();
    }
}
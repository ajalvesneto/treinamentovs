using SEFAZ.CursoMVC.Domain.Interfaces.Repository;
using SEFAZ.CursoMVC.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected CursoMVCContext db;
        protected DbSet<TEntity> DbSet;

        public Repository(CursoMVCContext context) {
            db = context;
            DbSet = db.Set<TEntity>();
        }

        public TEntity Adicionar(TEntity obj)
        {
           return DbSet.Add(obj);
        }

        public TEntity Atualizar(TEntity obj)
        {
            var entry = db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            return obj;
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TEntity ObterporId(Guid guid)
        {
            return DbSet.Find(guid);
        }

        public IEnumerable<TEntity> ObterTodos(List<TEntity> obj)
        {
            return DbSet.ToList();
        }

        public void Remover(TEntity obj)
        {
            DbSet.Remove(obj);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();

        }
    }
}

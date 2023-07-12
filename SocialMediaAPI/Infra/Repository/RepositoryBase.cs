using Dapper.Contrib.Extensions;
using SocialMediaAPI.Infra.Interface;
using System.Data;

namespace SocialMediaAPI.Infra.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        protected readonly IDbConnection _dbConnection;

        protected RepositoryBase(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void Add(T entity)
        {
            _dbConnection.Insert(entity);
        }

        public void Delete(T entity)
        {
            _dbConnection.Delete(entity);
        }

        public T GetById(int id)
        {
            return _dbConnection.Get<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbConnection.GetAll<T>();
        }

        public void Update(T entity)
        {
            _dbConnection.Update(entity);
        }
    }
}

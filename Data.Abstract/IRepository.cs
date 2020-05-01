using System.Linq;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Abstract
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(int id);

        Task Create(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);
    }
}
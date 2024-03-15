using Course_project.Common;
using Repository.Data;
using Service.Services.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepositories<T> where T : BaseEntity
    {
        public void Create(T entity)
        {
            AppDbContext<T>.datas.Add(entity);
        }

        public void Delete(T entity)
        {
            AppDbContext<T>.datas.Remove(entity);
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetAllById(int id)
        {
            
        }

        public List<T> GetAllWithpression(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}

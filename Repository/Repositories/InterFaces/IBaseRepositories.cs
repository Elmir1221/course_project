using Course_project.Common;
using Course_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.InterFaces
{
    public interface IBaseRepositories<T> where T : BaseEntity
    {
        void Create(T entity);

        void Delete(T entity);

        void Edit(T entity);
        T GetAllById(int id);

        List<T> GetAllWithExpression(Func<T, bool> predicate);
    }
}

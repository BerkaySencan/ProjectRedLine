using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    interface IEntityRepository<T>
    {
        List<T> getAll();
        T get(T entity);
        void add(T entity);
        void delete(T entity);
        void update(T entity);


    }
}

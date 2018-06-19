using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.BASE
{
    interface IBaseController<T> where T : class
    {
        void Add(T entity);

        IList<T> ListAll();

        IList<T> ListByName(string name);

        T SearchForId(int id);

        void Edit(T entity);

        void Delete(int id);
    }
}

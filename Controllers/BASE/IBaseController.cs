using System.Collections.Generic;

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

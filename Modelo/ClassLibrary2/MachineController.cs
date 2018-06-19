using Controllers.BASE;
using System;
using System.Collections.Generic;
using Model;
using Controllers.DAL;


namespace Controllers
{
    public class MachineController : IBaseController<Machine>
    {
        private Context context = new Context();

        public void Add(Machine entity)
        {
            context.Machines.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Machine entity)
        {
            throw new NotImplementedException();
        }

        public IList<Machine> ListAll()
        {
            throw new NotImplementedException();
        }

        public IList<Machine> ListByName(string name)
        {
            throw new NotImplementedException();
        }

        public Machine SearchForId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

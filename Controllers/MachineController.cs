using Controllers.BASE;
using System.Collections.Generic;
using Model;
using Controllers.DAL;
using System;
using System.Linq;

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
            Machine machi = SearchForId(id);

            if (machi != null)
            {
                context.Entry(machi).State = System.Data.Entity.EntityState.Deleted;
            }

            context.SaveChanges();
        }

        public void Edit(Machine entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;           
        }

        public IList<Machine> ListAll() => context.Machines.ToList();

        public IList<Machine> ListByName(string name) => context.Machines.Where(mach => mach.Name == name).ToList();

        public Machine SearchForId(int id) => context.Machines.Find(id);

    }
}

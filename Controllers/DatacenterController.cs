using Controllers.BASE;
using Controllers.DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class DatacenterController : IBaseController<Datacenter>
    {
        private Context context = new Context();

        public void Add(Datacenter entity)
        {
            context.Datacenters.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Datacenter dat = SearchForId(id);

            if (dat != null)
            {
                context.Entry(dat).State = System.Data.Entity.EntityState.Deleted;
            }

            context.SaveChanges();
        }

        public void Edit(Datacenter entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public IList<Datacenter> ListAll() => context.Datacenters.ToList();

        public IList<Datacenter> ListByName(string name) => context.Datacenters.Where(dat => dat.Name == name).ToList();

        public Datacenter SearchForId(int id) => context.Datacenters.Find(id);
    }
}

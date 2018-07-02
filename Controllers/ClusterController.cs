using Controllers.BASE;
using Model;
using System;
using System.Collections.Generic;
using Controllers.DAL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class ClusterController : IBaseController<Cluster>
    {
        private Context context = new Context();

        public void Add(Cluster entity)
        {
            context.Clusters.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Cluster clust = SearchForId(id);

            if (clust != null)
            {
                context.Entry(clust).State = System.Data.Entity.EntityState.Deleted;
            }

            context.SaveChanges();
        }

        public void Edit(Cluster entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public IList<Cluster> ListAll() => context.Clusters.ToList();


        public IList<Cluster> ListByName(string name) => context.Clusters.Where(clust => clust.Name == name).ToList();

        public Cluster SearchForId(int id) => context.Clusters.Find(id);
    }
}

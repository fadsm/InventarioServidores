using System.Data.Entity;
using Model;

namespace Controllers.DAL
{
    class Context : DbContext
    {
        public Context() : base("strConn")
        {
            // Padrao (se nao existir base de dados, cria)
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Contexto>());

            // Apaga e recria a base toda vez que o projeto eh executado
            //Database.SetInitializer(new DropCreateDatabaseAlways<Contexto>());

            // Apaga e recria a base de dados se houver alteracoes nas modelos
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Contexto>());
        }

        public DbSet<Machine> Machines { get; set; }
        public DbSet<Cluster> Clusters { get; set; }
        public DbSet<Datacenter> Datacenters { get; set; }

    }
}

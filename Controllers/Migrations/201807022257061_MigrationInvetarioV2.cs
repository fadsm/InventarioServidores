namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationInvetarioV2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clusters", "DatacenterID", "dbo.Datacenters");
            DropForeignKey("dbo.Machines", "ClusterID", "dbo.Clusters");
            DropIndex("dbo.Clusters", new[] { "DatacenterID" });
            DropIndex("dbo.Machines", new[] { "ClusterID" });
            RenameColumn(table: "dbo.Clusters", name: "DatacenterID", newName: "_Datacenter_DatacenterID");
            RenameColumn(table: "dbo.Machines", name: "ClusterID", newName: "_Cluster_ClusterID");
            AddColumn("dbo.Clusters", "DatacenterIDFK", c => c.Int(nullable: false));
            AddColumn("dbo.Machines", "ClusterIDFK", c => c.Int(nullable: false));
            AlterColumn("dbo.Clusters", "_Datacenter_DatacenterID", c => c.Int());
            AlterColumn("dbo.Machines", "_Cluster_ClusterID", c => c.Int());
            CreateIndex("dbo.Clusters", "_Datacenter_DatacenterID");
            CreateIndex("dbo.Machines", "_Cluster_ClusterID");
            AddForeignKey("dbo.Clusters", "_Datacenter_DatacenterID", "dbo.Datacenters", "DatacenterID");
            AddForeignKey("dbo.Machines", "_Cluster_ClusterID", "dbo.Clusters", "ClusterID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Machines", "_Cluster_ClusterID", "dbo.Clusters");
            DropForeignKey("dbo.Clusters", "_Datacenter_DatacenterID", "dbo.Datacenters");
            DropIndex("dbo.Machines", new[] { "_Cluster_ClusterID" });
            DropIndex("dbo.Clusters", new[] { "_Datacenter_DatacenterID" });
            AlterColumn("dbo.Machines", "_Cluster_ClusterID", c => c.Int(nullable: false));
            AlterColumn("dbo.Clusters", "_Datacenter_DatacenterID", c => c.Int(nullable: false));
            DropColumn("dbo.Machines", "ClusterIDFK");
            DropColumn("dbo.Clusters", "DatacenterIDFK");
            RenameColumn(table: "dbo.Machines", name: "_Cluster_ClusterID", newName: "ClusterID");
            RenameColumn(table: "dbo.Clusters", name: "_Datacenter_DatacenterID", newName: "DatacenterID");
            CreateIndex("dbo.Machines", "ClusterID");
            CreateIndex("dbo.Clusters", "DatacenterID");
            AddForeignKey("dbo.Machines", "ClusterID", "dbo.Clusters", "ClusterID", cascadeDelete: true);
            AddForeignKey("dbo.Clusters", "DatacenterID", "dbo.Datacenters", "DatacenterID", cascadeDelete: true);
        }
    }
}

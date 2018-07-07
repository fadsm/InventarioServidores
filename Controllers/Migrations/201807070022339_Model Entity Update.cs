namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelEntityUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clusters", "_Datacenter_DatacenterID", "dbo.Datacenters");
            DropForeignKey("dbo.Machines", "_Cluster_ClusterID", "dbo.Clusters");
            DropIndex("dbo.Clusters", new[] { "_Datacenter_DatacenterID" });
            DropIndex("dbo.Machines", new[] { "_Cluster_ClusterID" });
            RenameColumn(table: "dbo.Clusters", name: "_Datacenter_DatacenterID", newName: "DatacenterID");
            RenameColumn(table: "dbo.Machines", name: "_Cluster_ClusterID", newName: "ClusterID");
            AlterColumn("dbo.Clusters", "DatacenterID", c => c.Int(nullable: false));
            AlterColumn("dbo.Machines", "ClusterID", c => c.Int(nullable: false));
            CreateIndex("dbo.Clusters", "DatacenterID");
            CreateIndex("dbo.Machines", "ClusterID");
            AddForeignKey("dbo.Clusters", "DatacenterID", "dbo.Datacenters", "DatacenterID", cascadeDelete: true);
            AddForeignKey("dbo.Machines", "ClusterID", "dbo.Clusters", "ClusterID", cascadeDelete: true);
            DropColumn("dbo.Clusters", "DatacenterIDFK");
            DropColumn("dbo.Datacenters", "OrganizationUnit");
            DropColumn("dbo.Machines", "Manufacturer");
            DropColumn("dbo.Machines", "ClusterIDFK");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Machines", "ClusterIDFK", c => c.Int(nullable: false));
            AddColumn("dbo.Machines", "Manufacturer", c => c.String());
            AddColumn("dbo.Datacenters", "OrganizationUnit", c => c.String());
            AddColumn("dbo.Clusters", "DatacenterIDFK", c => c.Int(nullable: false));
            DropForeignKey("dbo.Machines", "ClusterID", "dbo.Clusters");
            DropForeignKey("dbo.Clusters", "DatacenterID", "dbo.Datacenters");
            DropIndex("dbo.Machines", new[] { "ClusterID" });
            DropIndex("dbo.Clusters", new[] { "DatacenterID" });
            AlterColumn("dbo.Machines", "ClusterID", c => c.Int());
            AlterColumn("dbo.Clusters", "DatacenterID", c => c.Int());
            RenameColumn(table: "dbo.Machines", name: "ClusterID", newName: "_Cluster_ClusterID");
            RenameColumn(table: "dbo.Clusters", name: "DatacenterID", newName: "_Datacenter_DatacenterID");
            CreateIndex("dbo.Machines", "_Cluster_ClusterID");
            CreateIndex("dbo.Clusters", "_Datacenter_DatacenterID");
            AddForeignKey("dbo.Machines", "_Cluster_ClusterID", "dbo.Clusters", "ClusterID");
            AddForeignKey("dbo.Clusters", "_Datacenter_DatacenterID", "dbo.Datacenters", "DatacenterID");
        }
    }
}

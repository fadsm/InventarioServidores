namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationInventario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clusters",
                c => new
                    {
                        ClusterID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Manufacturer = c.String(),
                        DatacenterID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClusterID)
                .ForeignKey("dbo.Datacenters", t => t.DatacenterID, cascadeDelete: true)
                .Index(t => t.DatacenterID);
            
            CreateTable(
                "dbo.Datacenters",
                c => new
                    {
                        DatacenterID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                        OrganizationUnit = c.String(),
                    })
                .PrimaryKey(t => t.DatacenterID);
            
            CreateTable(
                "dbo.Machines",
                c => new
                    {
                        MachineID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Ip = c.String(),
                        OperatingSystem = c.String(),
                        Manufacturer = c.String(),
                        ClusterID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MachineID)
                .ForeignKey("dbo.Clusters", t => t.ClusterID, cascadeDelete: true)
                .Index(t => t.ClusterID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Machines", "ClusterID", "dbo.Clusters");
            DropForeignKey("dbo.Clusters", "DatacenterID", "dbo.Datacenters");
            DropIndex("dbo.Machines", new[] { "ClusterID" });
            DropIndex("dbo.Clusters", new[] { "DatacenterID" });
            DropTable("dbo.Machines");
            DropTable("dbo.Datacenters");
            DropTable("dbo.Clusters");
        }
    }
}

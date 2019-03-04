namespace MyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mydb1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.VehicleStatus", name: "Vehicle_Id", newName: "VehicleId_Id");
            RenameIndex(table: "dbo.VehicleStatus", name: "IX_Vehicle_Id", newName: "IX_VehicleId_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.VehicleStatus", name: "IX_VehicleId_Id", newName: "IX_Vehicle_Id");
            RenameColumn(table: "dbo.VehicleStatus", name: "VehicleId_Id", newName: "Vehicle_Id");
        }
    }
}

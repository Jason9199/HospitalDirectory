namespace HospitalDirectory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateHospitals : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Hospitals (Name, Street, City, State, ZipCode, CreatedOn, LastModified) VALUES ('Saint Anthony Hospital', '1000 N Lee Ave', 'Oklahoma City', 'OK', 73102, GetDate(), null)");
            Sql("INSERT INTO Hospitals (Name, Street, City, State, ZipCode, CreatedOn, LastModified) VALUES ('Mercy Hospital', '4300 W Memorial Rd.', 'Oklahoma City', 'OK', 73120, GetDate(), null)");
            Sql("INSERT INTO Hospitals (Name, Street, City, State, ZipCode, CreatedOn, LastModified) VALUES ('Oklahoma Heart Hospital', '4050 W Memorial Rd.', 'Oklahoma City', 'OK', 73120, GetDate(), null)");
            Sql("INSERT INTO Hospitals (Name, Street, City, State, ZipCode, CreatedOn, LastModified) VALUES ('Integris Baptist Medical Center', '3300 Northwest Expressway', 'Oklahoma City', 'OK', 73112, GetDate(), null)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Hospitals");
        }
    }
}

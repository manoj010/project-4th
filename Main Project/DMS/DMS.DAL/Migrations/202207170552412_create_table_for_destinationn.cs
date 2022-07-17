namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_for_destinationn : DbMigration
    {
        public override void Up()
        {
            Sql(@"create table destinationn(
                id int NOT NULL primary key identity(1,1),
                dname nvarchar(255) NOT NULL,
                dtime nvarchar(255) NOT NULL,
                location nvarchar(255) NOT NULL,
                price int NOT NULL,
                description nvarchar(255) NOT NULL,
                photo nvarchar(255) NOT NULL,
                photo_name nvarchar(255) NOT NULL
            )");
        }
        
        public override void Down()
        {
        }
    }
}

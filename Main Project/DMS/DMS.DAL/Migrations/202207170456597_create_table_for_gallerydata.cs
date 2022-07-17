namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_for_gallerydata : DbMigration
    {
        public override void Up()
        {
            Sql(
                @"create table gallerydata(
                id int NOT NULL primary key identity(1,1),
                photo nvarchar(255) NOT NULL,
                photo_name nvarchar(255) NOT NULL,
                destination_name nvarchar(255) NOT NULL
                )");
        }
        
        public override void Down()
        {
        }
    }
}

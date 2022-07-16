namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_for_gallery : DbMigration
    {
        public override void Up()
        {
            Sql(@"create table gallery(
                id int NOT NULL primary key identity(1,1),
                photo_path nvarchar(255) NOT NULL,
                destination_name nvarchar(255) NOt NUll
            )");
        }
        
        public override void Down()
        {
        }
    }
}

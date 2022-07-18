namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_for_contactus : DbMigration
    {
        public override void Up()
        {
            Sql(@"create table contactus(
                name nvarchar(255),
                email nvarchar(255) NOT NULL,
                feedback nvarchar(255) primary key NOT NULL

            )");
        }
        
        public override void Down()
        {
        }
    }
}

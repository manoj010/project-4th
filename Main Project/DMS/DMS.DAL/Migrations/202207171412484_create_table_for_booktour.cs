namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_for_booktour : DbMigration
    {
        public override void Up()
        {
            Sql(@"create table booktour(
                fullname nvarchar(255) NOT NULL,
                email nvarchar(255) NOT NULL,
                phonenumber int primary key NOT NULL,
                message nvarchar(255) NOT NULL
            )");
        }
        
        public override void Down()
        {
        }
    }
}

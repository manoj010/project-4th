namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_for_booktours : DbMigration
    {
        public override void Up()
        {
            Sql(@"create table booktours(
                dname nvarchar(255) NOT NULL,
                fullname nvarchar(255) NOT NULL,
                email nvarchar(255) NOT NULL,
                phonenumber nvarchar(50) primary key NOT NULL,
                message nvarchar(255) NOT NULL
            )");
        }
        
        public override void Down()
        {
        }
    }
}

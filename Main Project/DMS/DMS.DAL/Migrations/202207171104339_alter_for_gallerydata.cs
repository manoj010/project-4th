namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alter_for_gallerydata : DbMigration
    {
        public override void Up()
        {
            Sql(@"alter table gallerydata
                drop column photo_name
            ");
        }
        
        public override void Down()
        {
        }
    }
}

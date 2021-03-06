namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (ID,NAME) VALUES (1,'Jazz')");
            Sql("INSERT INTO GENRES (ID,NAME) VALUES (2,'Rock')");
            Sql("INSERT INTO GENRES (ID,NAME) VALUES (3,'Blues')");
            Sql("INSERT INTO GENRES (ID,NAME) VALUES (4,'Country')");
        }

        public override void Down()
        {
            Sql("DELETE FROM GENRES WHERE ID IN (1,2,3,4)");
        }
    }
}

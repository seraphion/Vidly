namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdateCustomerBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("update Customers set Birthdate = '01.01.1980' where Id = 1");
        }

        public override void Down()
        {
        }
    }
}

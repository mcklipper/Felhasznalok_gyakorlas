using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Felhasznalok.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migration)
        {
            migration.Sql("INSERT INTO Users (Name, Email) VALUES ('Egri Patrik', 'egripatrik@gmail.com')");
            migration.Sql("INSERT INTO Users (Name, Email) VALUES ('Bende Attila', 'bendeati@gmail.com')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

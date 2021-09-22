using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactRepository.Migrations
{
    public partial class phase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_contexts",
                table: "contexts");

            migrationBuilder.RenameTable(
                name: "contexts",
                newName: "contacts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contacts",
                table: "contacts",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_contacts",
                table: "contacts");

            migrationBuilder.RenameTable(
                name: "contacts",
                newName: "contexts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contexts",
                table: "contexts",
                column: "Id");
        }
    }
}

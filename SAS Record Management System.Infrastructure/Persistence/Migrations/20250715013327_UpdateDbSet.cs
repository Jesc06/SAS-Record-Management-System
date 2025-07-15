using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAS_Record_Management_System.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentAccountRegistrations",
                table: "StudentAccountRegistrations");

            migrationBuilder.RenameTable(
                name: "StudentAccountRegistrations",
                newName: "StudentAccountRegistrations_Db");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentAccountRegistrations_Db",
                table: "StudentAccountRegistrations_Db",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentAccountRegistrations_Db",
                table: "StudentAccountRegistrations_Db");

            migrationBuilder.RenameTable(
                name: "StudentAccountRegistrations_Db",
                newName: "StudentAccountRegistrations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentAccountRegistrations",
                table: "StudentAccountRegistrations",
                column: "Id");
        }
    }
}

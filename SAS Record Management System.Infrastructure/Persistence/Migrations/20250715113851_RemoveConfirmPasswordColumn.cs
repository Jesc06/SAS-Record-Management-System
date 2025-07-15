using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAS_Record_Management_System.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveConfirmPasswordColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "StudentAccountRegistrations_Db");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "StudentAccountRegistrations_Db",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

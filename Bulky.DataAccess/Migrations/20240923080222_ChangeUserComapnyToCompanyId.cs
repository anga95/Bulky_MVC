using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserComapnyToCompanyId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Company",
                table: "AspNetUsers",
                newName: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "AspNetUsers",
                newName: "Company");
        }
    }
}

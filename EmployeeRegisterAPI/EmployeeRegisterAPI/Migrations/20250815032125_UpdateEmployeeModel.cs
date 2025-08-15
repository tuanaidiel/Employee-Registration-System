using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeRegisterAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CGPA",
                table: "Employees",
                newName: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "Employees",
                newName: "CGPA");
        }
    }
}

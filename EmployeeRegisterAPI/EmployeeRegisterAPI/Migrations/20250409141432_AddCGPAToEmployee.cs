using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeRegisterAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCGPAToEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CGPA",
                table: "Employees",
                type: "decimal(3,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CGPA",
                table: "Employees");
        }
    }
}

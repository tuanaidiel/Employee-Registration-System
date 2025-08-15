using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeRegisterAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixStaffIdDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StaffId",
                table: "Employees",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "StaffId",
                table: "Employees",
                type: "decimal(3,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");
        }
    }
}

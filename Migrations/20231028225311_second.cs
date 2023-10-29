using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassSupplies.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassroomSupply",
                table: "ClassroomSupply");

            migrationBuilder.RenameTable(
                name: "ClassroomSupply",
                newName: "ClassroomSupplies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassroomSupplies",
                table: "ClassroomSupplies",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassroomSupplies",
                table: "ClassroomSupplies");

            migrationBuilder.RenameTable(
                name: "ClassroomSupplies",
                newName: "ClassroomSupply");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassroomSupply",
                table: "ClassroomSupply",
                column: "Id");
        }
    }
}

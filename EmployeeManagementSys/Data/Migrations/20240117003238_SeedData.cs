using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagementSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Name", "Position", "Salary" },
                values: new object[,]
                {
                    { "18c2d30e-5d7a-4742-a4f2-b4ce59ac956e", "Jane Ahmetaj", 6, 70000.0 },
                    { "2e78304b-5966-490b-9322-2ca460835b94", "Hannah Taylor", 6, 100000.0 },
                    { "472567c2-c909-4e8e-ac44-6ed6b26f5086", "John Doe", 5, 80000.0 },
                    { "47cb89b8-83d8-4a45-9ae0-bbc12363ea41", "Otis Wilson", 14, 90000.0 },
                    { "5e158ad1-a672-45ad-88e3-bf9738e2a316", "Sahair Ramadan", 6, 90000.0 },
                    { "6c4040df-093b-4cff-9a9b-91d52a047831", "Gary Gray", 18, 150000.0 },
                    { "97f2cd8d-c6c9-42a4-9299-b0923b5bed09", "Antonio Fisher", 5, 300000.0 },
                    { "9d33d95b-cdbb-46ce-a9b1-851766fa3c19", "Ann Smith", 0, 1000000.0 },
                    { "c76faf76-9466-450a-94eb-c0e8a4044adc", "Bill Gates", 2, 200000.0 },
                    { "e86f4275-4072-499f-9c6c-c5045e392ec4", "Noah Smith", 6, 130000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "18c2d30e-5d7a-4742-a4f2-b4ce59ac956e");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "2e78304b-5966-490b-9322-2ca460835b94");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "472567c2-c909-4e8e-ac44-6ed6b26f5086");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "47cb89b8-83d8-4a45-9ae0-bbc12363ea41");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "5e158ad1-a672-45ad-88e3-bf9738e2a316");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "6c4040df-093b-4cff-9a9b-91d52a047831");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "97f2cd8d-c6c9-42a4-9299-b0923b5bed09");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "9d33d95b-cdbb-46ce-a9b1-851766fa3c19");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "c76faf76-9466-450a-94eb-c0e8a4044adc");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: "e86f4275-4072-499f-9c6c-c5045e392ec4");
        }
    }
}

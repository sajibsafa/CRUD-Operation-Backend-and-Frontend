using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class createproducttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                schema: "Emp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    RatingPrice = table.Column<int>(type: "int", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellPrice = table.Column<int>(type: "int", nullable: false),
                    CountriesId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Country_CountriesId",
                        column: x => x.CountriesId,
                        principalSchema: "Emp",
                        principalTable: "Country",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Emp",
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 55, DateTimeKind.Unspecified).AddTicks(2076), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Emp",
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 55, DateTimeKind.Unspecified).AddTicks(2108), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Emp",
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 56, DateTimeKind.Unspecified).AddTicks(8559), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Emp",
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 56, DateTimeKind.Unspecified).AddTicks(8589), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.InsertData(
                schema: "Emp",
                table: "Product",
                columns: new[] { "Id", "BarCode", "CountriesId", "CountryId", "Created", "CreatedBy", "Description", "LastModified", "LastModifiedBy", "ProductName", "RatingPrice", "SellPrice", "Status" },
                values: new object[] { 1, "1234", null, 1, new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 57, DateTimeKind.Unspecified).AddTicks(2740), new TimeSpan(0, 6, 0, 0, 0)), null, "Taka", null, null, "Computer", 400, 1, 1 });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 58, DateTimeKind.Unspecified).AddTicks(232), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 58, DateTimeKind.Unspecified).AddTicks(254), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 10, 18, 12, 23, 7, 58, DateTimeKind.Unspecified).AddTicks(256), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Product_CountriesId",
                schema: "Emp",
                table: "Product",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductName",
                schema: "Emp",
                table: "Product",
                column: "ProductName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product",
                schema: "Emp");

            migrationBuilder.UpdateData(
                schema: "Emp",
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 9, 26, 9, 51, 35, 157, DateTimeKind.Unspecified).AddTicks(2409), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Emp",
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 9, 26, 9, 51, 35, 157, DateTimeKind.Unspecified).AddTicks(2456), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Emp",
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 9, 26, 9, 51, 35, 158, DateTimeKind.Unspecified).AddTicks(9874), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Emp",
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 9, 26, 9, 51, 35, 158, DateTimeKind.Unspecified).AddTicks(9895), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 9, 26, 9, 51, 35, 159, DateTimeKind.Unspecified).AddTicks(9470), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 9, 26, 9, 51, 35, 159, DateTimeKind.Unspecified).AddTicks(9488), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTimeOffset(new DateTime(2023, 9, 26, 9, 51, 35, 159, DateTimeKind.Unspecified).AddTicks(9491), new TimeSpan(0, 6, 0, 0, 0)));
        }
    }
}

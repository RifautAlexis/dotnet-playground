using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class initialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false, defaultValue: 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Firstname", "Lastname", "Password", "Position" },
                values: new object[,]
                {
                    { new Guid("16cab7ab-cc60-469f-af19-9606cf772335"), 27, "developer.01@myCompany.com", "Harun", "Clayton", "@password06", 2 },
                    { new Guid("1dc79443-1c1d-449f-867f-c33393980d20"), null, "developer.03@myCompany.com", "Rebekah", "Matthams", "@password08", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Firstname", "Lastname", "Password" },
                values: new object[] { new Guid("3c797159-3414-4ba1-b48a-d9bbeac022d5"), 45, "hr.03@myCompany.com", "Montgomery", "Garcia", "@password03" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Firstname", "Lastname", "Password", "Position" },
                values: new object[] { new Guid("4b5e77fc-1a65-4742-9a81-7e8fe4c0ec6f"), null, "developer.05@myCompany.com", "Jordan", "Mcpherson", "@password10", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Firstname", "Lastname", "Password" },
                values: new object[] { new Guid("58cce921-676b-4b7d-a700-cfed0b2a9e35"), 25, "hr.01@myCompany.com", "Vinnie", "Cherry", "@password01" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Firstname", "Lastname", "Password", "Position" },
                values: new object[,]
                {
                    { new Guid("6f9d186f-7833-4dc8-87cc-3e5cfe080081"), 32, "manager.01@myCompany.com", "Max", "Rush", "@password04", 1 },
                    { new Guid("9dc474d3-b9ab-4f78-86f4-0a4cf4811733"), 33, "developer.02@myCompany.com", "Glenn", "Carrillo", "@password07", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Firstname", "Lastname", "Password" },
                values: new object[] { new Guid("b43193fb-81cd-4f64-85b3-880dd371cea3"), null, "hr.02@myCompany.com", "Rose", "Gonzales", "@password02" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Firstname", "Lastname", "Password", "Position" },
                values: new object[,]
                {
                    { new Guid("c87b72e3-48e0-44d8-bbb1-d583053e27b5"), 51, "developer.04@myCompany.com", "Simeon", "Ferrell", "@password09", 2 },
                    { new Guid("fc07af7a-261b-463f-b40e-e69413923ab4"), 44, "manager.02@myCompany.com", "Zohaib", "Wright", "@password05", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

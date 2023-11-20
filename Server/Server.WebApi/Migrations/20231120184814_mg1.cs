using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Date", "Description", "Title", "Year" },
                values: new object[,]
                {
                    { new Guid("7f4d1d04-c42a-4b57-ae8c-b7ab7b7006a7"), "09.2011 - 08.2013", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent dapibus dolor felis, eu ultrices elit molestie.", "Visual Art", "2 Years" },
                    { new Guid("c23d48c6-b8f5-4c92-acb6-fbd6db146f56"), "09.2011 - 08.2013", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent dapibus dolor felis, eu ultrices elit molestie.", "Visual Art", "2 Years" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CoverImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("13337844-51a3-4bd1-a77c-1ebafd533eec"), "project3.png", "My Portfolio Projesi" },
                    { new Guid("82b4b5fa-0604-4f4f-b4d8-968d53041f01"), "project2.png", "e-Finans Projesi" },
                    { new Guid("c32efe08-95eb-4def-bdf4-724e513939cd"), "project1.png", "e-Muhasebe Projesi" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Image", "ImageUrl", "Order" },
                values: new object[,]
                {
                    { new Guid("03c75630-dc09-4e12-9dec-c417c959d791"), null, "https://upload.wikimedia.org/wikipedia/commons/e/ea/Docker_%28container_engine%29_logo_%28cropped%29.png", 4 },
                    { new Guid("504d00ca-ad1a-464d-9ada-0e2c9ee872ea"), null, "https://pluralsight2.imgix.net/paths/images/domain-driven-design-6d10f953a0.png", 3 },
                    { new Guid("6a2c4bb6-fb6e-4a6c-ad18-c009ae55590c"), null, "https://blog.ninja-squad.com/assets/images/angular_gradient.png", 2 },
                    { new Guid("ec766cb5-6ccb-417e-b8c1-ccfcc5c75c2e"), null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/.NET_Core_Logo.svg/2048px-.NET_Core_Logo.svg.png", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}

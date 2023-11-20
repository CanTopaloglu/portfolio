using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("7f4d1d04-c42a-4b57-ae8c-b7ab7b7006a7"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("c23d48c6-b8f5-4c92-acb6-fbd6db146f56"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("13337844-51a3-4bd1-a77c-1ebafd533eec"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("82b4b5fa-0604-4f4f-b4d8-968d53041f01"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("c32efe08-95eb-4def-bdf4-724e513939cd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("03c75630-dc09-4e12-9dec-c417c959d791"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("504d00ca-ad1a-464d-9ada-0e2c9ee872ea"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6a2c4bb6-fb6e-4a6c-ad18-c009ae55590c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ec766cb5-6ccb-417e-b8c1-ccfcc5c75c2e"));

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Date", "Description", "Title", "Year" },
                values: new object[,]
                {
                    { new Guid("62d8203e-e8d2-4ac2-b0f1-d0d6019b2929"), "09.2011 - 08.2013", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent dapibus dolor felis, eu ultrices elit molestie.", "Visual Art", "2 Years" },
                    { new Guid("e9248301-4ce0-495b-b906-a7bc17dab60d"), "09.2011 - 08.2013", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent dapibus dolor felis, eu ultrices elit molestie.", "Visual Art", "2 Years" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CoverImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("4de1544d-4ff9-4b32-a6ed-83737105fae3"), "project1.png", "e-Muhasebe Projesi" },
                    { new Guid("57627ddd-3d20-4750-9a35-0cc4a9e6e457"), "project2.png", "e-Finans Projesi" },
                    { new Guid("6a0cf375-86cf-4bb2-929f-118ea40aec27"), "project3.png", "My Portfolio Projesi" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Image", "ImageUrl", "Order" },
                values: new object[,]
                {
                    { new Guid("479a49ef-2010-4793-9fc9-a9094f4ac186"), null, "https://pluralsight2.imgix.net/paths/images/domain-driven-design-6d10f953a0.png", 3 },
                    { new Guid("ccf9baf7-ff88-4f54-815c-df31019b1a81"), null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/.NET_Core_Logo.svg/2048px-.NET_Core_Logo.svg.png", 1 },
                    { new Guid("ede82b51-ce69-4fd2-853c-64b8f8dd4a05"), null, "https://blog.ninja-squad.com/assets/images/angular_gradient.png", 2 },
                    { new Guid("ef090539-d04c-4a58-a4de-188f28241343"), null, "https://upload.wikimedia.org/wikipedia/commons/e/ea/Docker_%28container_engine%29_logo_%28cropped%29.png", 4 }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "Icon", "Link", "Name" },
                values: new object[,]
                {
                    { new Guid("8747e3bd-67db-4029-9969-0b1ff33415c6"), "fa-brands fa-youtube fs-30", "https://www.youtube.com/channel/UC6Pw9YDMHq3EeNhIF8FMemw", "Youtube" },
                    { new Guid("a27c71ee-8b9e-4860-a79d-a236fe93cb08"), "fa-brands fa-linkedin fs-30", "https://www.linkedin.com/in/taner-saydam-b26336222/", "LinkedIn" },
                    { new Guid("e50fdbb6-9846-44e3-93a2-248df1546ea2"), "fa-brands fa-github fs-30", "https://github.com/TanerSaydam", "GitHub" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("62d8203e-e8d2-4ac2-b0f1-d0d6019b2929"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("e9248301-4ce0-495b-b906-a7bc17dab60d"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("4de1544d-4ff9-4b32-a6ed-83737105fae3"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("57627ddd-3d20-4750-9a35-0cc4a9e6e457"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("6a0cf375-86cf-4bb2-929f-118ea40aec27"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("479a49ef-2010-4793-9fc9-a9094f4ac186"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ccf9baf7-ff88-4f54-815c-df31019b1a81"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ede82b51-ce69-4fd2-853c-64b8f8dd4a05"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ef090539-d04c-4a58-a4de-188f28241343"));

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
    }
}

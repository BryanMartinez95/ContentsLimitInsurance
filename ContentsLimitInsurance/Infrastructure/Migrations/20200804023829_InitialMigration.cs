using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentsLimitInsurance.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    Value = table.Column<double>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AssetCategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assets_AssetCategories_AssetCategoryId",
                        column: x => x.AssetCategoryId,
                        principalTable: "AssetCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AssetCategories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"), false, "Electronics" });

            migrationBuilder.InsertData(
                table: "AssetCategories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { new Guid("3b2320c7-8267-4b98-9593-702b1eb2e2cf"), false, "Clothing" });

            migrationBuilder.InsertData(
                table: "AssetCategories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), false, "Kitchen" });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("5a124f35-67fc-4f7a-81bb-4160b2d1af1b"), new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Living Room", "TV", 2000.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("4b576cad-3f93-4a6f-86dd-30c70c748ab6"), new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Living Room", "Playstation", 400.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("e0a6554c-8b98-443e-8d68-a0ecb28c35c5"), new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bedroom", "Stereo", 1600.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("144343cd-e05d-4dd8-98da-762a38110de9"), new Guid("3b2320c7-8267-4b98-9593-702b1eb2e2cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bedroom", "Shirts", 1100.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("a86d0eaf-1deb-42ee-a49c-8e568087de6d"), new Guid("3b2320c7-8267-4b98-9593-702b1eb2e2cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bedroom", "Jeans", 1100.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("4d753d18-bc26-4502-8204-bcd6a8694604"), new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kitchen", "Pots and Pans", 3000.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("5e888336-cc2d-4a83-b485-6494c39ed31f"), new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kitchen", "Flatware", 500.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("aa52d401-5b50-4ef7-8b8b-5a07dfc579a0"), new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kitchen", "Knife Set", 500.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("5505dcd8-619e-47cf-ad46-fd6d30a8be8e"), new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kitchen", "Misc", 1000.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetCategoryId",
                table: "Assets",
                column: "AssetCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "AssetCategories");
        }
    }
}

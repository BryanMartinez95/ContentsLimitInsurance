using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentsLimitInsurance.Migrations
{
    public partial class InitialCreate : Migration
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
                values: new object[] { new Guid("e97b124c-b09f-4bd1-93c1-b748032d37fe"), new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Living Room", "TV", 0.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("d816f69f-fdee-426f-82ad-cae9da9657a9"), new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Living Room", "Playstation", 0.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("dd7cf440-df22-46d5-ba1b-5e56f15bd581"), new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bedroom", "Stereo", 0.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("11a963a8-2308-4e6c-9043-ecb28363f8e6"), new Guid("3b2320c7-8267-4b98-9593-702b1eb2e2cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bedroom", "Shirts", 0.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("0edf63d2-d93c-4b76-b902-d7beaad4566f"), new Guid("3b2320c7-8267-4b98-9593-702b1eb2e2cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bedroom", "Jeans", 0.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("e5b4d8cf-1c15-49e2-93a3-29064d91847e"), new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kitchen", "Pots and Pans", 0.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("6c25f943-04ae-4366-b9c7-ea43497e424c"), new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kitchen", "Flatware", 0.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("4a04e950-7c79-4558-b810-1b46a15cf2b9"), new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kitchen", "Knife Set", 0.0 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "DatePurchased", "IsDeleted", "Location", "Name", "Value" },
                values: new object[] { new Guid("cdbc989b-7545-486e-b7c4-26a453444e9a"), new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Kitchen", "Misc", 0.0 });

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

using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StorageSystem.Migrations
{
    /// <inheritdoc />
    public partial class databaseSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "item",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "storagebin",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_storagebin", x => x.id);
                    table.ForeignKey(
                        name: "FK_storagebin_item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "item",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item_storagebin",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    StorageBinId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_storagebin", x => new { x.ItemId, x.StorageBinId });
                    table.ForeignKey(
                        name: "FK_item_storagebin_item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "item",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_item_storagebin_storagebin_StorageBinId",
                        column: x => x.StorageBinId,
                        principalTable: "storagebin",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_item_storagebin_StorageBinId",
                table: "item_storagebin",
                column: "StorageBinId");

            migrationBuilder.CreateIndex(
                name: "IX_storagebin_ItemId",
                table: "storagebin",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "item_storagebin");

            migrationBuilder.DropTable(
                name: "location");

            migrationBuilder.DropTable(
                name: "storagebin");

            migrationBuilder.DropTable(
                name: "item");
        }
    }
}

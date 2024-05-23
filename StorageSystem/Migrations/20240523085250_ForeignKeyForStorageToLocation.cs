using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageSystem.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeyForStorageToLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_storagebin_item_ItemId",
                table: "storagebin");

            migrationBuilder.DropIndex(
                name: "IX_storagebin_ItemId",
                table: "storagebin");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "storagebin");

            migrationBuilder.AddColumn<int>(
                name: "locationId",
                table: "storagebin",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "location",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ItemStorageBin",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "integer", nullable: false),
                    StorageBinsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStorageBin", x => new { x.ItemsId, x.StorageBinsId });
                    table.ForeignKey(
                        name: "FK_ItemStorageBin_item_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "item",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemStorageBin_storagebin_StorageBinsId",
                        column: x => x.StorageBinsId,
                        principalTable: "storagebin",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_storagebin_locationId",
                table: "storagebin",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStorageBin_StorageBinsId",
                table: "ItemStorageBin",
                column: "StorageBinsId");

            migrationBuilder.AddForeignKey(
                name: "FK_storagebin_location_locationId",
                table: "storagebin",
                column: "locationId",
                principalTable: "location",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_storagebin_location_locationId",
                table: "storagebin");

            migrationBuilder.DropTable(
                name: "ItemStorageBin");

            migrationBuilder.DropIndex(
                name: "IX_storagebin_locationId",
                table: "storagebin");

            migrationBuilder.DropColumn(
                name: "locationId",
                table: "storagebin");

            migrationBuilder.DropColumn(
                name: "name",
                table: "location");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "storagebin",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_storagebin_ItemId",
                table: "storagebin",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_storagebin_item_ItemId",
                table: "storagebin",
                column: "ItemId",
                principalTable: "item",
                principalColumn: "id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageSystem.Migrations
{
    /// <inheritdoc />
    public partial class updateTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemStorageBin_item_ItemsId",
                table: "ItemStorageBin");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemStorageBin_storagebin_StorageBinsId",
                table: "ItemStorageBin");

            migrationBuilder.DropTable(
                name: "item_storagebin");

            migrationBuilder.RenameColumn(
                name: "StorageBinsId",
                table: "ItemStorageBin",
                newName: "binId");

            migrationBuilder.RenameColumn(
                name: "ItemsId",
                table: "ItemStorageBin",
                newName: "itemId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemStorageBin_StorageBinsId",
                table: "ItemStorageBin",
                newName: "IX_ItemStorageBin_binId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemStorageBin_item_itemId",
                table: "ItemStorageBin",
                column: "itemId",
                principalTable: "item",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemStorageBin_storagebin_binId",
                table: "ItemStorageBin",
                column: "binId",
                principalTable: "storagebin",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemStorageBin_item_itemId",
                table: "ItemStorageBin");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemStorageBin_storagebin_binId",
                table: "ItemStorageBin");

            migrationBuilder.RenameColumn(
                name: "binId",
                table: "ItemStorageBin",
                newName: "StorageBinsId");

            migrationBuilder.RenameColumn(
                name: "itemId",
                table: "ItemStorageBin",
                newName: "ItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemStorageBin_binId",
                table: "ItemStorageBin",
                newName: "IX_ItemStorageBin_StorageBinsId");

            migrationBuilder.CreateTable(
                name: "item_storagebin",
                columns: table => new
                {
                    itemId = table.Column<int>(type: "integer", nullable: false),
                    binId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_storagebin", x => new { x.itemId, x.binId });
                    table.ForeignKey(
                        name: "FK_item_storagebin_item_itemId",
                        column: x => x.itemId,
                        principalTable: "item",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_item_storagebin_storagebin_binId",
                        column: x => x.binId,
                        principalTable: "storagebin",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_item_storagebin_binId",
                table: "item_storagebin",
                column: "binId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemStorageBin_item_ItemsId",
                table: "ItemStorageBin",
                column: "ItemsId",
                principalTable: "item",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemStorageBin_storagebin_StorageBinsId",
                table: "ItemStorageBin",
                column: "StorageBinsId",
                principalTable: "storagebin",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

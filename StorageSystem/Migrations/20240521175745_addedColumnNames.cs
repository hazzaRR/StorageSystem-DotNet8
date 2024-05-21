using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageSystem.Migrations
{
    /// <inheritdoc />
    public partial class addedColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_item_storagebin_item_ItemId",
                table: "item_storagebin");

            migrationBuilder.DropForeignKey(
                name: "FK_item_storagebin_storagebin_StorageBinId",
                table: "item_storagebin");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "item_storagebin",
                newName: "itemId");

            migrationBuilder.RenameColumn(
                name: "StorageBinId",
                table: "item_storagebin",
                newName: "binId");

            migrationBuilder.RenameIndex(
                name: "IX_item_storagebin_StorageBinId",
                table: "item_storagebin",
                newName: "IX_item_storagebin_binId");

            migrationBuilder.AddForeignKey(
                name: "FK_item_storagebin_item_itemId",
                table: "item_storagebin",
                column: "itemId",
                principalTable: "item",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_item_storagebin_storagebin_binId",
                table: "item_storagebin",
                column: "binId",
                principalTable: "storagebin",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_item_storagebin_item_itemId",
                table: "item_storagebin");

            migrationBuilder.DropForeignKey(
                name: "FK_item_storagebin_storagebin_binId",
                table: "item_storagebin");

            migrationBuilder.RenameColumn(
                name: "itemId",
                table: "item_storagebin",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "binId",
                table: "item_storagebin",
                newName: "StorageBinId");

            migrationBuilder.RenameIndex(
                name: "IX_item_storagebin_binId",
                table: "item_storagebin",
                newName: "IX_item_storagebin_StorageBinId");

            migrationBuilder.AddForeignKey(
                name: "FK_item_storagebin_item_ItemId",
                table: "item_storagebin",
                column: "ItemId",
                principalTable: "item",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_item_storagebin_storagebin_StorageBinId",
                table: "item_storagebin",
                column: "StorageBinId",
                principalTable: "storagebin",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

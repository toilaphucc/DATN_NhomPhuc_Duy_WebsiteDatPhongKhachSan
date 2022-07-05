using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATN_WebDatPhongKhachSan.Migrations
{
    public partial class KhoiTaoDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Favorites",
                newName: "CustomerID");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerID",
                table: "PaymentAccounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerID",
                table: "Favorites",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_OwnerID",
                table: "Rooms",
                column: "OwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeID",
                table: "Rooms",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentAccounts_CustomerID",
                table: "PaymentAccounts",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_UserID",
                table: "Owners",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerID",
                table: "Invoices",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_OwnerID",
                table: "Invoices",
                column: "OwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_PaymentAccountID",
                table: "Invoices",
                column: "PaymentAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_RentalTypeID",
                table: "Invoices",
                column: "RentalTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_RoomID",
                table: "Invoices",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_CustomerID",
                table: "Favorites",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_OwnerID",
                table: "Favorites",
                column: "OwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Custommers_UserID",
                table: "Custommers",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Custommers_Users_UserID",
                table: "Custommers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Custommers_CustomerID",
                table: "Favorites",
                column: "CustomerID",
                principalTable: "Custommers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Owners_OwnerID",
                table: "Favorites",
                column: "OwnerID",
                principalTable: "Owners",
                principalColumn: "OwnerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Custommers_CustomerID",
                table: "Invoices",
                column: "CustomerID",
                principalTable: "Custommers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Owners_OwnerID",
                table: "Invoices",
                column: "OwnerID",
                principalTable: "Owners",
                principalColumn: "OwnerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_PaymentAccounts_PaymentAccountID",
                table: "Invoices",
                column: "PaymentAccountID",
                principalTable: "PaymentAccounts",
                principalColumn: "PaymentAccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_RentalTypes_RentalTypeID",
                table: "Invoices",
                column: "RentalTypeID",
                principalTable: "RentalTypes",
                principalColumn: "RentalTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Rooms_RoomID",
                table: "Invoices",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Users_UserID",
                table: "Owners",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentAccounts_Custommers_CustomerID",
                table: "PaymentAccounts",
                column: "CustomerID",
                principalTable: "Custommers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Owners_OwnerID",
                table: "Rooms",
                column: "OwnerID",
                principalTable: "Owners",
                principalColumn: "OwnerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeID",
                table: "Rooms",
                column: "RoomTypeID",
                principalTable: "RoomTypes",
                principalColumn: "RoomTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Custommers_Users_UserID",
                table: "Custommers");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Custommers_CustomerID",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Owners_OwnerID",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Custommers_CustomerID",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Owners_OwnerID",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_PaymentAccounts_PaymentAccountID",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_RentalTypes_RentalTypeID",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Rooms_RoomID",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Users_UserID",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentAccounts_Custommers_CustomerID",
                table: "PaymentAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Owners_OwnerID",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeID",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_OwnerID",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomTypeID",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_PaymentAccounts_CustomerID",
                table: "PaymentAccounts");

            migrationBuilder.DropIndex(
                name: "IX_Owners_UserID",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_CustomerID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_OwnerID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_PaymentAccountID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_RentalTypeID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_RoomID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_CustomerID",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_OwnerID",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Custommers_UserID",
                table: "Custommers");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "PaymentAccounts");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Favorites");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Favorites",
                newName: "UserID");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATN_WebDatPhongKhachSan.Migrations
{
    public partial class ThemDatabaseLanDau : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Custommers",
                table: "Custommers");

            migrationBuilder.DropColumn(
                name: "RentalTypeID",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "UtilitiesName",
                table: "Utilitiess",
                newName: "TagName");

            migrationBuilder.RenameColumn(
                name: "UtilitiesID",
                table: "Utilitiess",
                newName: "TagID");

            migrationBuilder.RenameColumn(
                name: "UtilitiesID",
                table: "Rooms",
                newName: "TagID");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Rooms",
                newName: "OwnerID");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Rooms",
                newName: "AmountRoom");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "PaymentAccounts",
                newName: "CustommerID");

            migrationBuilder.AddColumn<string>(
                name: "RoomCode",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "PaymentAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerID",
                table: "Owners",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentAccountID",
                table: "Invoices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RentalTypeID",
                table: "Invoices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerID",
                table: "Custommers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                column: "OwnerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Custommers",
                table: "Custommers",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Custommers",
                table: "Custommers");

            migrationBuilder.DropColumn(
                name: "RoomCode",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "PaymentAccounts");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "PaymentAccountID",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "RentalTypeID",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Custommers");

            migrationBuilder.RenameColumn(
                name: "TagName",
                table: "Utilitiess",
                newName: "UtilitiesName");

            migrationBuilder.RenameColumn(
                name: "TagID",
                table: "Utilitiess",
                newName: "UtilitiesID");

            migrationBuilder.RenameColumn(
                name: "TagID",
                table: "Rooms",
                newName: "UtilitiesID");

            migrationBuilder.RenameColumn(
                name: "OwnerID",
                table: "Rooms",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "AmountRoom",
                table: "Rooms",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "CustommerID",
                table: "PaymentAccounts",
                newName: "UserID");

            migrationBuilder.AddColumn<Guid>(
                name: "RentalTypeID",
                table: "Rooms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Custommers",
                table: "Custommers",
                column: "UserID");
        }
    }
}

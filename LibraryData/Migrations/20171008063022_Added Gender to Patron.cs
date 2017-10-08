using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryData.Migrations
{
    public partial class AddedGendertoPatron : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "TelephoneNumber",
                table: "Patrons");

            migrationBuilder.AlterColumn<int>(
                name: "LibraryCardId",
                table: "Patrons",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Patrons",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Patrons",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Patrons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Patrons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "Patrons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "Patrons");

            migrationBuilder.AlterColumn<int>(
                name: "LibraryCardId",
                table: "Patrons",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Patrons",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Patrons",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Patrons",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "TelephoneNumber",
                table: "Patrons",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

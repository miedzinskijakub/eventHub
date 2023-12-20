using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eventHub.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_AspNetUsers_userId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalEvent_AspNetUsers_UserId",
                table: "PersonalEvent");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Event",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_userId",
                table: "Event",
                newName: "IX_Event_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "PersonalEvent",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Event",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_AspNetUsers_UserId",
                table: "Event",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalEvent_AspNetUsers_UserId",
                table: "PersonalEvent",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_AspNetUsers_UserId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalEvent_AspNetUsers_UserId",
                table: "PersonalEvent");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Event",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_UserId",
                table: "Event",
                newName: "IX_Event_userId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "PersonalEvent",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_AspNetUsers_userId",
                table: "Event",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalEvent_AspNetUsers_UserId",
                table: "PersonalEvent",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

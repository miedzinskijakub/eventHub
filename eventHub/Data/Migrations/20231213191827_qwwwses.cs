using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eventHub.Data.Migrations
{
    public partial class qwwwses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Event",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Event_userId",
                table: "Event",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_AspNetUsers_userId",
                table: "Event",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_AspNetUsers_userId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_userId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Event");
        }
    }
}

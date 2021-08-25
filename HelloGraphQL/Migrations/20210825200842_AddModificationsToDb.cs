using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloGraphQL.Migrations
{
    public partial class AddModificationsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_LinkGroups_LinkGroup_ID1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_LinkGroup_ID1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "LinkGroup_ID1",
                table: "Links");

            migrationBuilder.CreateIndex(
                name: "IX_Links_LinkGroup_ID",
                table: "Links",
                column: "LinkGroup_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_LinkGroups_LinkGroup_ID",
                table: "Links",
                column: "LinkGroup_ID",
                principalTable: "LinkGroups",
                principalColumn: "LinkGroup_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_LinkGroups_LinkGroup_ID",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_LinkGroup_ID",
                table: "Links");

            migrationBuilder.AddColumn<int>(
                name: "LinkGroup_ID1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Links_LinkGroup_ID1",
                table: "Links",
                column: "LinkGroup_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_LinkGroups_LinkGroup_ID1",
                table: "Links",
                column: "LinkGroup_ID1",
                principalTable: "LinkGroups",
                principalColumn: "LinkGroup_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

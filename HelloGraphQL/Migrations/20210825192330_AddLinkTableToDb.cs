using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloGraphQL.Migrations
{
    public partial class AddLinkTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Link_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link_Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link_Desription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkGroup_ID = table.Column<int>(type: "int", nullable: false),
                    LinkGroup_ID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Link_ID);
                    table.ForeignKey(
                        name: "FK_Links_LinkGroups_LinkGroup_ID1",
                        column: x => x.LinkGroup_ID1,
                        principalTable: "LinkGroups",
                        principalColumn: "LinkGroup_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Links_LinkGroup_ID1",
                table: "Links",
                column: "LinkGroup_ID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");
        }
    }
}

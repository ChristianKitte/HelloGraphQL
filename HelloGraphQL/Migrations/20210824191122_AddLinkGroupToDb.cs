using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloGraphQL.Migrations
{
    public partial class AddLinkGroupToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LinkGroups",
                columns: table => new
                {
                    LinkGroup_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkGroup_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkGroup_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkGroups", x => x.LinkGroup_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkGroups");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;


#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class mig_category_name_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MessageCategoryies_MessageCategoryID",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageCategoryies",
                table: "MessageCategoryies");

            migrationBuilder.RenameTable(
                name: "MessageCategoryies",
                newName: "MessageCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageCategories",
                table: "MessageCategories",
                column: "MessageCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryID",
                table: "Contacts",
                column: "MessageCategoryID",
                principalTable: "MessageCategories",
                principalColumn: "MessageCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryID",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageCategories",
                table: "MessageCategories");

            migrationBuilder.RenameTable(
                name: "MessageCategories",
                newName: "MessageCategoryies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageCategoryies",
                table: "MessageCategoryies",
                column: "MessageCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MessageCategoryies_MessageCategoryID",
                table: "Contacts",
                column: "MessageCategoryID",
                principalTable: "MessageCategoryies",
                principalColumn: "MessageCategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

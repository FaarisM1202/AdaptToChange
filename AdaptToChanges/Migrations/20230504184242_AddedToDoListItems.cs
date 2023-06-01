using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdaptToChange.Migrations
{
    /// <inheritdoc />
    public partial class AddedToDoListItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ToDoListItems",
                table: "ToDoLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToDoListItems",
                table: "ToDoLists");
        }
    }
}

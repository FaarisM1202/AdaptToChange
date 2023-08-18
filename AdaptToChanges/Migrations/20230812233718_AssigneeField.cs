using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdaptToChange.Migrations
{
    /// <inheritdoc />
    public partial class AssigneeField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Assignee",
                table: "ToDoLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assignee",
                table: "ToDoLists");
        }
    }
}

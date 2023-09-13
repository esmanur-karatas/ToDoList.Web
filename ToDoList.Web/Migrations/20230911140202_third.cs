using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Web.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskDescription",
                table: "Todo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TaskDescription",
                table: "Todo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

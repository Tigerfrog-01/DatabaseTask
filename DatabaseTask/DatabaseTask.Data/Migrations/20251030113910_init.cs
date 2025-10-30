using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kindergarten");

            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.DropTable(
                name: "Que");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group",
                table: "Group");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Absence",
                table: "Absence");

            migrationBuilder.DropColumn(
                name: "Bevarage",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Dessert",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "GroupType",
                table: "Group");

            migrationBuilder.RenameTable(
                name: "Group",
                newName: "Groups");

            migrationBuilder.RenameTable(
                name: "Absence",
                newName: "Absense");

            migrationBuilder.RenameColumn(
                name: "SideSnack",
                table: "Menu",
                newName: "MorningSnack");

            migrationBuilder.RenameColumn(
                name: "MainMeal",
                table: "Menu",
                newName: "DinnerSnack");

            migrationBuilder.RenameColumn(
                name: "TotalChildren",
                table: "Groups",
                newName: "Type");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFood",
                table: "Menu",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Portions",
                table: "Menu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "JobTitle",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "JobTitle",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Child",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "AbsenseId",
                table: "Child",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ChildGroupHistoryId",
                table: "Child",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "QueueId",
                table: "Child",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AbsenseId",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChildCount",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ChildGroupHistoryId",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MenuId",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "QueueId",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Absense",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Absense",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Absense",
                table: "Absense",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ChildGroupHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildGroupHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Queue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queue", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Child_AbsenseId",
                table: "Child",
                column: "AbsenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Child_ChildGroupHistoryId",
                table: "Child",
                column: "ChildGroupHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Child_QueueId",
                table: "Child",
                column: "QueueId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_AbsenseId",
                table: "Groups",
                column: "AbsenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ChildGroupHistoryId",
                table: "Groups",
                column: "ChildGroupHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_MenuId",
                table: "Groups",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_QueueId",
                table: "Groups",
                column: "QueueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Absense_AbsenseId",
                table: "Child",
                column: "AbsenseId",
                principalTable: "Absense",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Child_ChildGroupHistory_ChildGroupHistoryId",
                table: "Child",
                column: "ChildGroupHistoryId",
                principalTable: "ChildGroupHistory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Queue_QueueId",
                table: "Child",
                column: "QueueId",
                principalTable: "Queue",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Absense_AbsenseId",
                table: "Groups",
                column: "AbsenseId",
                principalTable: "Absense",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_ChildGroupHistory_ChildGroupHistoryId",
                table: "Groups",
                column: "ChildGroupHistoryId",
                principalTable: "ChildGroupHistory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Menu_MenuId",
                table: "Groups",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Queue_QueueId",
                table: "Groups",
                column: "QueueId",
                principalTable: "Queue",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Child_Absense_AbsenseId",
                table: "Child");

            migrationBuilder.DropForeignKey(
                name: "FK_Child_ChildGroupHistory_ChildGroupHistoryId",
                table: "Child");

            migrationBuilder.DropForeignKey(
                name: "FK_Child_Queue_QueueId",
                table: "Child");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Absense_AbsenseId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_ChildGroupHistory_ChildGroupHistoryId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Menu_MenuId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Queue_QueueId",
                table: "Groups");

            migrationBuilder.DropTable(
                name: "ChildGroupHistory");

            migrationBuilder.DropTable(
                name: "Queue");

            migrationBuilder.DropIndex(
                name: "IX_Child_AbsenseId",
                table: "Child");

            migrationBuilder.DropIndex(
                name: "IX_Child_ChildGroupHistoryId",
                table: "Child");

            migrationBuilder.DropIndex(
                name: "IX_Child_QueueId",
                table: "Child");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_AbsenseId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_ChildGroupHistoryId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_MenuId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_QueueId",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Absense",
                table: "Absense");

            migrationBuilder.DropColumn(
                name: "DateFood",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Portions",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "AbsenseId",
                table: "Child");

            migrationBuilder.DropColumn(
                name: "ChildGroupHistoryId",
                table: "Child");

            migrationBuilder.DropColumn(
                name: "QueueId",
                table: "Child");

            migrationBuilder.DropColumn(
                name: "AbsenseId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "ChildCount",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "ChildGroupHistoryId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "QueueId",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Group");

            migrationBuilder.RenameTable(
                name: "Absense",
                newName: "Absence");

            migrationBuilder.RenameColumn(
                name: "MorningSnack",
                table: "Menu",
                newName: "SideSnack");

            migrationBuilder.RenameColumn(
                name: "DinnerSnack",
                table: "Menu",
                newName: "MainMeal");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Group",
                newName: "TotalChildren");

            migrationBuilder.AddColumn<string>(
                name: "Bevarage",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Dessert",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "StartDate",
                table: "JobTitle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "EndDate",
                table: "JobTitle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Child",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "GroupType",
                table: "Group",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "StartDate",
                table: "Absence",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "EndDate",
                table: "Absence",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group",
                table: "Group",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Absence",
                table: "Absence",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Kindergarten",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChildId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kindergarten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kindergarten_Child_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Child",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Que",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Que", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalWorkers = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kindergarten_ChildId",
                table: "Kindergarten",
                column: "ChildId");
        }
    }
}

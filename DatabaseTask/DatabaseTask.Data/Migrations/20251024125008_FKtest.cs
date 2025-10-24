using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class FKtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ChildId",
                table: "Kindergarten",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kindergarten_ChildId",
                table: "Kindergarten",
                column: "ChildId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kindergarten_Child_ChildId",
                table: "Kindergarten",
                column: "ChildId",
                principalTable: "Child",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kindergarten_Child_ChildId",
                table: "Kindergarten");

            migrationBuilder.DropIndex(
                name: "IX_Kindergarten_ChildId",
                table: "Kindergarten");

            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "Kindergarten");
        }
    }
}

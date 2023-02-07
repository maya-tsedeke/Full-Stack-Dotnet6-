using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Hash = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: false),
                    Salt = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_TodoList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TodoList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_TodoList_tbl_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "tbl_Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_TodoList_tbl_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "tbl_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TodoList_CreatedBy",
                table: "tbl_TodoList",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TodoList_UpdatedBy",
                table: "tbl_TodoList",
                column: "UpdatedBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_TodoList");

            migrationBuilder.DropTable(
                name: "tbl_Users");
        }
    }
}

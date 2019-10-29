using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MaxAttributeMVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MaxAttribute",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false).Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    ObjectName = table.Column<string>(nullable: true),
                    AttributeName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    Purpose = table.Column<string>(nullable: true),
                    RequirementId = table.Column<string>(nullable: true),
                    Approved = table.Column<bool>(nullable: false),
                    DataSource = table.Column<string>(nullable: true),
                    HaveData = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ApprovedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaxAttribute", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaxAttribute");
        }
    }
}

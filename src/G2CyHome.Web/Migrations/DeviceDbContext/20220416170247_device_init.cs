using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Migrations
{
    public partial class device_init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "systems_label",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false, comment: "唯一标识")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: true, comment: "标签名称"),
                    remark = table.Column<string>(type: "varchar(1000) CHARACTER SET utf8mb4", maxLength: 1000, nullable: true, comment: "备注"),
                    deleted_time = table.Column<DateTime>(type: "datetime(6)", nullable: true, comment: "删除时间"),
                    created_time = table.Column<DateTime>(type: "datetime(6)", nullable: false, comment: "创建时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_systems_label", x => x.id);
                },
                comment: "标签管理");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "systems_label");
        }
    }
}

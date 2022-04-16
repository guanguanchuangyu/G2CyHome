using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Migrations
{
    public partial class device_type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "systems_devicetype",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false, comment: "唯一标识")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true, comment: "类型名称"),
                    logo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true, comment: "类型logo"),
                    pic_path = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true, comment: "类型图片"),
                    remark = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true, comment: "备注信息"),
                    deleted_time = table.Column<DateTime>(type: "datetime(6)", nullable: true, comment: "删除时间"),
                    created_time = table.Column<DateTime>(type: "datetime(6)", nullable: false, comment: "创建时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_systems_devicetype", x => x.id);
                },
                comment: "设备类型");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "systems_devicetype");
        }
    }
}

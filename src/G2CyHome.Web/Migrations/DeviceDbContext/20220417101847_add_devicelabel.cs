using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Migrations
{
    public partial class add_devicelabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "systems_room",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false, comment: "唯一标识")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false, comment: "房间名称"),
                    floor = table.Column<int>(type: "int", nullable: false, comment: "所在楼层"),
                    remark = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: true, comment: "备注信息"),
                    logo = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: true, comment: "房间logo"),
                    pic_path = table.Column<string>(type: "varchar(1000) CHARACTER SET utf8mb4", maxLength: 1000, nullable: true, comment: "房间图片"),
                    order = table.Column<int>(type: "int", nullable: false, comment: "排序"),
                    deleted_time = table.Column<DateTime>(type: "datetime(6)", nullable: true, comment: "删除时间"),
                    created_time = table.Column<DateTime>(type: "datetime(6)", nullable: false, comment: "创建时间"),
                    creator_id = table.Column<int>(type: "int", nullable: true, comment: "创建人id"),
                    last_updater_id = table.Column<int>(type: "int", nullable: true, comment: "更新者编号"),
                    last_updated_time = table.Column<DateTime>(type: "datetime(6)", nullable: true, comment: "最后更新时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_systems_room", x => x.id);
                },
                comment: "房间管理");

            migrationBuilder.CreateTable(
                name: "devices_devicerecord",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, comment: "唯一标识"),
                    name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true, comment: "设备名称"),
                    device_identity = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false, comment: "设备标识"),
                    status = table.Column<int>(type: "int", nullable: false, comment: "设备状态"),
                    control_mode = table.Column<int>(type: "int", nullable: false, comment: "控制方式"),
                    descript = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true, comment: "设备描述"),
                    room_id = table.Column<int>(type: "int", nullable: false, comment: "所属房间"),
                    devicetype_id = table.Column<int>(type: "int", nullable: false, comment: "设备类型id"),
                    deleted_time = table.Column<DateTime>(type: "datetime(6)", nullable: true, comment: "删除时间"),
                    created_time = table.Column<DateTime>(type: "datetime(6)", nullable: false, comment: "创建时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_devices_devicerecord", x => x.id);
                    table.UniqueConstraint("AK_devices_devicerecord_device_identity", x => x.device_identity);
                    table.ForeignKey(
                        name: "FK_Device_Room",
                        column: x => x.room_id,
                        principalTable: "systems_room",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Device_Type",
                        column: x => x.devicetype_id,
                        principalTable: "systems_devicetype",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "设备记录");

            migrationBuilder.CreateTable(
                name: "devices_sensordata",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false, comment: "唯一标识")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    device_identity = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true, comment: "设备标识"),
                    data = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true, comment: "数据信息"),
                    created_time = table.Column<DateTime>(type: "datetime(6)", nullable: false, comment: "创建时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_devices_sensordata", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sensor_identity",
                        column: x => x.device_identity,
                        principalTable: "devices_devicerecord",
                        principalColumn: "device_identity",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "传感器数据");

            migrationBuilder.CreateTable(
                name: "systems_devicelabel",
                columns: table => new
                {
                    DeviceId = table.Column<Guid>(type: "char(36)", nullable: false),
                    LabelId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_device_label", x => new { x.DeviceId, x.LabelId });
                    table.ForeignKey(
                        name: "FK_devicelabel_device",
                        column: x => x.DeviceId,
                        principalTable: "devices_devicerecord",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_devicelabel_label",
                        column: x => x.LabelId,
                        principalTable: "systems_label",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Device_RoomId",
                table: "devices_devicerecord",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_Device_TypeId",
                table: "devices_devicerecord",
                column: "devicetype_id");

            migrationBuilder.CreateIndex(
                name: "IX_Sensor_Identity",
                table: "devices_sensordata",
                column: "device_identity");

            migrationBuilder.CreateIndex(
                name: "IX_Devicelabel_LabelId",
                table: "systems_devicelabel",
                column: "LabelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "devices_sensordata");

            migrationBuilder.DropTable(
                name: "systems_devicelabel");

            migrationBuilder.DropTable(
                name: "devices_devicerecord");

            migrationBuilder.DropTable(
                name: "systems_room");
        }
    }
}

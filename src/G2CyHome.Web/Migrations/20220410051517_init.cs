using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace G2CyHome.Web.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auth_EntityInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: false),
                    TypeName = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: false),
                    AuditEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PropertyJson = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth_EntityInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Auth_Function",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    Area = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    Controller = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    Action = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    IsController = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsAjax = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessType = table.Column<int>(type: "int", nullable: false),
                    IsAccessTypeChanged = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AuditOperationEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AuditEntityEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CacheExpirationSeconds = table.Column<int>(type: "int", nullable: false),
                    IsCacheSliding = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsSlaveDatabase = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsLocked = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth_Function", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Auth_Module",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: false),
                    Remark = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    Code = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: false),
                    OrderCode = table.Column<double>(type: "double", nullable: false),
                    TreePathString = table.Column<string>(type: "varchar(2000) CHARACTER SET utf8mb4", maxLength: 2000, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth_Module", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Auth_Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Identity_Organization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: false),
                    Remark = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identity_Organization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organ_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Identity_Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Identity_Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: false),
                    NormalizedName = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    Remark = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    IsAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsSystem = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsLocked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identity_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Identity_User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Remark = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    UserName = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: false),
                    NickName = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    Email = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    NormalizeEmail = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    HeadImg = table.Column<string>(type: "varchar(1000) CHARACTER SET utf8mb4", maxLength: 1000, nullable: true),
                    SecurityStamp = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    IsSystem = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsLocked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identity_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Systems_AuditOperation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    FunctionName = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: false),
                    UserId = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: true),
                    UserName = table.Column<string>(type: "varchar(300) CHARACTER SET utf8mb4", maxLength: 300, nullable: true),
                    NickName = table.Column<string>(type: "varchar(300) CHARACTER SET utf8mb4", maxLength: 300, nullable: true),
                    Ip = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    OperationSystem = table.Column<string>(type: "varchar(300) CHARACTER SET utf8mb4", maxLength: 300, nullable: true),
                    Browser = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    UserAgent = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    ResultType = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "varchar(1000) CHARACTER SET utf8mb4", maxLength: 1000, nullable: true),
                    Elapsed = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Systems_AuditOperation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Systems_KeyValue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Key = table.Column<string>(type: "varchar(512) CHARACTER SET utf8mb4", maxLength: 512, nullable: false),
                    ValueJson = table.Column<string>(type: "text", nullable: true),
                    ValueType = table.Column<string>(type: "varchar(1000) CHARACTER SET utf8mb4", maxLength: 1000, nullable: true),
                    Display = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: true),
                    Remark = table.Column<string>(type: "varchar(1000) CHARACTER SET utf8mb4", maxLength: 1000, nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsLocked = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Systems_KeyValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Systems_Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: false),
                    Text = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: false),
                    Icon = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    Url = table.Column<string>(type: "varchar(2000) CHARACTER SET utf8mb4", maxLength: 2000, nullable: true),
                    Target = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    Acl = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    OrderCode = table.Column<double>(type: "double", nullable: false),
                    Data = table.Column<string>(type: "varchar(2000) CHARACTER SET utf8mb4", maxLength: 2000, nullable: true),
                    TreePathString = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 3000, nullable: true),
                    IsEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsSystem = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Systems_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Systems_Menu_Systems_Menu_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Systems_Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Auth_ModuleFunction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    FunctionId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth_ModuleFunction", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Func_FunctionId",
                        column: x => x.FunctionId,
                        principalTable: "Auth_Function",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Fk_Func_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Auth_Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auth_EntityRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    EntityId = table.Column<Guid>(type: "char(36)", nullable: false),
                    Operation = table.Column<int>(type: "int", nullable: false),
                    FilterGroupJson = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 5000, nullable: true),
                    IsLocked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth_EntityRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auth_EntityRole_Auth_EntityInfo_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Auth_EntityInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Auth_EntityRole_Identity_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Identity_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auth_ModuleRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth_ModuleRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuleRole_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Auth_Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Identity_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identity_RoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    ClaimValue = table.Column<string>(type: "varchar(1000) CHARACTER SET utf8mb4", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identity_RoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaim_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Identity_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auth_EntityUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EntityId = table.Column<Guid>(type: "char(36)", nullable: false),
                    FilterGroupJson = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 5000, nullable: true),
                    IsLocked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth_EntityUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityUser_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Auth_EntityInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "Identity_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auth_ModuleUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Disabled = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth_ModuleUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuleUser_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Auth_Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleUser_UserId",
                        column: x => x.UserId,
                        principalTable: "Identity_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identity_LoginLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Ip = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    UserAgent = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    LogoutTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identity_LoginLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoginLog_UserId",
                        column: x => x.UserId,
                        principalTable: "Identity_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identity_UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: false),
                    ClaimValue = table.Column<string>(type: "varchar(1000) CHARACTER SET utf8mb4", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identity_UserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaim_UserId",
                        column: x => x.UserId,
                        principalTable: "Identity_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identity_UserDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RegisterIp = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identity_UserDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identity_UserDetail_Identity_User_UserId",
                        column: x => x.UserId,
                        principalTable: "Identity_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identity_UserLogin",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    ProviderKey = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    Avatar = table.Column<string>(type: "varchar(1000) CHARACTER SET utf8mb4", maxLength: 1000, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identity_UserLogin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identity_UserLogin_Identity_User_UserId",
                        column: x => x.UserId,
                        principalTable: "Identity_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identity_UserRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsLocked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identity_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Identity_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_UserId",
                        column: x => x.UserId,
                        principalTable: "Identity_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identity_UserToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    Value = table.Column<string>(type: "varchar(2000) CHARACTER SET utf8mb4", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identity_UserToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserToken_UserId",
                        column: x => x.UserId,
                        principalTable: "Identity_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Systems_AuditEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: false),
                    TypeName = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: false),
                    EntityKey = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    OperateType = table.Column<int>(type: "int", nullable: false),
                    OperationId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Systems_AuditEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Audit_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Systems_AuditOperation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Systems_AuditProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    DisplayName = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    FieldName = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    OriginalValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 5000, nullable: true),
                    NewValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 5000, nullable: true),
                    DataType = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: true),
                    AuditEntityId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Systems_AuditProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditProperty_Id",
                        column: x => x.AuditEntityId,
                        principalTable: "Systems_AuditEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ClassFullNameIndex",
                table: "Auth_EntityInfo",
                column: "TypeName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "EntityRoleIndex",
                table: "Auth_EntityRole",
                columns: new[] { "EntityId", "RoleId", "Operation" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EntityRole_RoleId",
                table: "Auth_EntityRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EntityUserIndex",
                table: "Auth_EntityUser",
                columns: new[] { "EntityId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_EntityUser_UserId",
                table: "Auth_EntityUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "AreaControllerActionIndex",
                table: "Auth_Function",
                columns: new[] { "Area", "Controller", "Action" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Auth_Module_ParentId",
                table: "Auth_Module",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleFunctionId",
                table: "Auth_ModuleFunction",
                column: "FunctionId");

            migrationBuilder.CreateIndex(
                name: "ModuleFunctionIndex",
                table: "Auth_ModuleFunction",
                columns: new[] { "ModuleId", "FunctionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModuleRole_RoleId",
                table: "Auth_ModuleRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "ModuleRoleIndex",
                table: "Auth_ModuleRole",
                columns: new[] { "ModuleId", "RoleId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Auth_ModuleUser_UserId",
                table: "Auth_ModuleUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "ModuleUserIndex",
                table: "Auth_ModuleUser",
                columns: new[] { "ModuleId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoginLog_UserId",
                table: "Identity_LoginLog",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Organ_ParentId",
                table: "Identity_Organization",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Identity_Role",
                columns: new[] { "NormalizedName", "DeletedTime" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaim_RoleId",
                table: "Identity_RoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Identity_User",
                columns: new[] { "NormalizeEmail", "DeletedTime" });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Identity_User",
                columns: new[] { "NormalizedUserName", "DeletedTime" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaim_UserId",
                table: "Identity_UserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Identity_UserDetail_UserId",
                table: "Identity_UserDetail",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_UserId",
                table: "Identity_UserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UserLoginIndex",
                table: "Identity_UserLogin",
                columns: new[] { "LoginProvider", "ProviderKey" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "Identity_UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "UserRoleIndex",
                table: "Identity_UserRole",
                columns: new[] { "UserId", "RoleId", "DeletedTime" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserTokenIndex",
                table: "Identity_UserToken",
                columns: new[] { "UserId", "LoginProvider", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuditEntity_OperationId",
                table: "Systems_AuditEntity",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditP_AuditEntityId",
                table: "Systems_AuditProperty",
                column: "AuditEntityId");

            migrationBuilder.CreateIndex(
                name: "KeyIndex",
                table: "Systems_KeyValue",
                column: "Key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Systems_Menu_ParentId",
                table: "Systems_Menu",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auth_EntityRole");

            migrationBuilder.DropTable(
                name: "Auth_EntityUser");

            migrationBuilder.DropTable(
                name: "Auth_ModuleFunction");

            migrationBuilder.DropTable(
                name: "Auth_ModuleRole");

            migrationBuilder.DropTable(
                name: "Auth_ModuleUser");

            migrationBuilder.DropTable(
                name: "Identity_LoginLog");

            migrationBuilder.DropTable(
                name: "Identity_Organization");

            migrationBuilder.DropTable(
                name: "Identity_RoleClaim");

            migrationBuilder.DropTable(
                name: "Identity_UserClaim");

            migrationBuilder.DropTable(
                name: "Identity_UserDetail");

            migrationBuilder.DropTable(
                name: "Identity_UserLogin");

            migrationBuilder.DropTable(
                name: "Identity_UserRole");

            migrationBuilder.DropTable(
                name: "Identity_UserToken");

            migrationBuilder.DropTable(
                name: "Systems_AuditProperty");

            migrationBuilder.DropTable(
                name: "Systems_KeyValue");

            migrationBuilder.DropTable(
                name: "Systems_Menu");

            migrationBuilder.DropTable(
                name: "Auth_EntityInfo");

            migrationBuilder.DropTable(
                name: "Auth_Function");

            migrationBuilder.DropTable(
                name: "Auth_Module");

            migrationBuilder.DropTable(
                name: "Identity_Role");

            migrationBuilder.DropTable(
                name: "Identity_User");

            migrationBuilder.DropTable(
                name: "Systems_AuditEntity");

            migrationBuilder.DropTable(
                name: "Systems_AuditOperation");
        }
    }
}

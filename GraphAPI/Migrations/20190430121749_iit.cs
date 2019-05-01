using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphAPI.Migrations
{
    public partial class iit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfigurationType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedAt = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 1000, nullable: true),
                    UpdatedAt = table.Column<long>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mast",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedAt = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 1000, nullable: true),
                    UpdatedAt = table.Column<long>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Lat = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Lon = table.Column<decimal>(type: "decimal(18,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mast", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlobalConfiguration",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedAt = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 1000, nullable: true),
                    UpdatedAt = table.Column<long>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Min = table.Column<float>(nullable: true),
                    Max = table.Column<float>(nullable: true),
                    ConfigTypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalConfiguration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GlobalConfiguration_ConfigurationType_ConfigTypeId",
                        column: x => x.ConfigTypeId,
                        principalTable: "ConfigurationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MastConfiguration",
                columns: table => new
                {
                    ConfigTypeId = table.Column<Guid>(nullable: false),
                    MastId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedAt = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 1000, nullable: true),
                    UpdatedAt = table.Column<long>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Min = table.Column<float>(nullable: true),
                    Max = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MastConfiguration", x => new { x.MastId, x.ConfigTypeId });
                    table.UniqueConstraint("AK_MastConfiguration_ConfigTypeId_MastId", x => new { x.ConfigTypeId, x.MastId });
                    table.ForeignKey(
                        name: "FK_MastConfiguration_ConfigurationType_ConfigTypeId",
                        column: x => x.ConfigTypeId,
                        principalTable: "ConfigurationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MastConfiguration_Mast_MastId",
                        column: x => x.MastId,
                        principalTable: "Mast",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ConfigurationType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("853bf959-2fab-4b6b-9390-98a53c8e210f"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, "HeightThreshold", 9223372036854775807L, null },
                    { new Guid("8c8132ce-b561-4925-96bb-15a32c5dcdcd"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, "StaggerThreshold", 9223372036854775807L, null },
                    { new Guid("4912c143-c04e-4d70-8f7c-c95bb279fdcf"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, "ArcThreshold", 9223372036854775807L, null },
                    { new Guid("63229215-56a9-48eb-b5be-72edb90d7a53"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, "ArcingIntensityThreshold", 9223372036854775807L, null },
                    { new Guid("a77d6b66-0a44-497e-bcf4-7ca57f105499"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, "SustainedStaggerDistanceThreshold", 9223372036854775807L, null },
                    { new Guid("d3666b8d-a0cd-4db0-86a1-a76df3f871f7"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, "SustainedArcingIntensityThreshold", 9223372036854775807L, null },
                    { new Guid("b015c95f-f687-455c-9f12-99e6a43362e0"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, "SustainedArcingNumberOfArcsThreshold", 9223372036854775807L, null },
                    { new Guid("db7b21a5-6e92-45e9-b92b-493df455fc2c"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, "SustainedArcingDistanceThreshold", 9223372036854775807L, null }
                });

            migrationBuilder.InsertData(
                table: "Mast",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Lat", "Lon", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("6705669e-00fd-4f56-8138-0421b75f4f56"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, 16.069968m, 108.232043m, 9223372036854775807L, null },
                    { new Guid("d35b4e13-2fdd-46b3-9898-e85036bad865"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, 16.069954m, 108.232043m, 9223372036854775807L, null },
                    { new Guid("fc9bb638-95a1-48f6-bc9c-ebbb17db90d7"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, 16.069968m, 108.232023m, 9223372036854775807L, null },
                    { new Guid("498f054e-65c8-4cd0-8c8e-07d5a3e5d6fa"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, 16.069971m, 108.232023m, 9223372036854775807L, null }
                });

            migrationBuilder.InsertData(
                table: "GlobalConfiguration",
                columns: new[] { "Id", "ConfigTypeId", "CreatedAt", "CreatedBy", "IsDeleted", "Max", "Min", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("5bac22e3-1d3c-45d5-b03a-738b734457a2"), new Guid("853bf959-2fab-4b6b-9390-98a53c8e210f"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, 3.4f, 2.3f, 9223372036854775807L, null },
                    { new Guid("cb3897b5-625f-46be-b44b-1c1b8a70a527"), new Guid("8c8132ce-b561-4925-96bb-15a32c5dcdcd"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, 3.43f, 2.35f, 9223372036854775807L, null },
                    { new Guid("23d98649-6626-40de-9685-1b1f7c37084a"), new Guid("4912c143-c04e-4d70-8f7c-c95bb279fdcf"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, 4.4f, 3.3f, 9223372036854775807L, null },
                    { new Guid("4aa8fd18-80fb-4228-b8dd-409e7aa387c9"), new Guid("63229215-56a9-48eb-b5be-72edb90d7a53"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, 4.45f, 3.35f, 9223372036854775807L, null },
                    { new Guid("a0c626ca-72a2-4aa4-b721-4933aa9e3d8e"), new Guid("a77d6b66-0a44-497e-bcf4-7ca57f105499"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, 5.45f, 4.35f, 9223372036854775807L, null },
                    { new Guid("d353e98d-f8e2-4d0a-b823-a683d74a99bd"), new Guid("d3666b8d-a0cd-4db0-86a1-a76df3f871f7"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, 4.44f, 3.37f, 9223372036854775807L, null },
                    { new Guid("52bc54d0-c766-441f-9b88-f1d9dfc6e293"), new Guid("b015c95f-f687-455c-9f12-99e6a43362e0"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, 4.41f, 3.33f, 9223372036854775807L, null },
                    { new Guid("6f7b3f57-0530-497a-8094-650453f1354b"), new Guid("db7b21a5-6e92-45e9-b92b-493df455fc2c"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, 4.48f, 3.32f, 9223372036854775807L, null }
                });

            migrationBuilder.InsertData(
                table: "MastConfiguration",
                columns: new[] { "MastId", "ConfigTypeId", "CreatedAt", "CreatedBy", "IsDeleted", "Max", "Min", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("6705669e-00fd-4f56-8138-0421b75f4f56"), new Guid("853bf959-2fab-4b6b-9390-98a53c8e210f"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, 3.35f, 2.35f, 9223372036854775807L, null },
                    { new Guid("d35b4e13-2fdd-46b3-9898-e85036bad865"), new Guid("853bf959-2fab-4b6b-9390-98a53c8e210f"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, null, null, 9223372036854775807L, null },
                    { new Guid("d35b4e13-2fdd-46b3-9898-e85036bad865"), new Guid("db7b21a5-6e92-45e9-b92b-493df455fc2c"), 9223372036854775807L, "99999999-9999-9999-9999-999999999999", false, null, null, 9223372036854775807L, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GlobalConfiguration_ConfigTypeId",
                table: "GlobalConfiguration",
                column: "ConfigTypeId");

            migrationBuilder.CreateIndex(
                name: "INDEX_MAX",
                table: "GlobalConfiguration",
                column: "Max");

            migrationBuilder.CreateIndex(
                name: "INDEX_MIN",
                table: "GlobalConfiguration",
                column: "Min");

            migrationBuilder.CreateIndex(
                name: "INDEX_LAT",
                table: "Mast",
                column: "Lat");

            migrationBuilder.CreateIndex(
                name: "INDEX_LON",
                table: "Mast",
                column: "Lon");

            migrationBuilder.CreateIndex(
                name: "INDEX_MAX",
                table: "MastConfiguration",
                column: "Max");

            migrationBuilder.CreateIndex(
                name: "INDEX_MIN",
                table: "MastConfiguration",
                column: "Min");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GlobalConfiguration");

            migrationBuilder.DropTable(
                name: "MastConfiguration");

            migrationBuilder.DropTable(
                name: "ConfigurationType");

            migrationBuilder.DropTable(
                name: "Mast");
        }
    }
}

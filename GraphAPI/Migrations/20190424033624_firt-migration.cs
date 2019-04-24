using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphAPI.Migrations
{
    public partial class firtmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    LastFound = table.Column<DateTime>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faces",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Img = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    LastFound = table.Column<DateTime>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faces_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plates",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    LastFound = table.Column<DateTime>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plates_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "CreateAt", "Email", "LastFound", "ModifyDate", "Name", "PhoneNumber" },
                values: new object[] { 1L, "Da Nang", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liemnguyenx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liem's Plate", "123456789" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "CreateAt", "Email", "LastFound", "ModifyDate", "Name", "PhoneNumber" },
                values: new object[] { 2L, "Da Nang", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liemnguyenx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liem's Plate", "123456789" });

            migrationBuilder.InsertData(
                table: "Faces",
                columns: new[] { "Id", "CreateAt", "Img", "LastFound", "Location", "ModifyDate", "OwnerId" },
                values: new object[,]
                {
                    { 3L, new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7624), "img1", new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7623), "Hue", new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7623), 1L },
                    { 1L, new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7071), "img1", new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(6434), "Nha Trang", new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(6028), 2L },
                    { 2L, new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7619), "img1", new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7616), "Quy Nhon", new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7612), 2L }
                });

            migrationBuilder.InsertData(
                table: "Plates",
                columns: new[] { "Id", "CreateAt", "LastFound", "Location", "ModifyDate", "Number", "OwnerId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3131), new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(2655), "Da Nang123", new DateTime(2019, 4, 24, 10, 36, 24, 187, DateTimeKind.Local).AddTicks(4976), "43-K1-12346", 1L },
                    { 2L, new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3588), new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3584), "Ha Noi 123", new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3580), "43-K1-12347", 1L },
                    { 3L, new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3593), new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3593), "HCM123", new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3592), "43-K1-12348", 2L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faces_OwnerId",
                table: "Faces",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Plates_OwnerId",
                table: "Plates",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faces");

            migrationBuilder.DropTable(
                name: "Plates");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}

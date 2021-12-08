using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KonicaReactApp.Migrations
{
    public partial class GetDocumentsByMainId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dokumentumok",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    extension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    main_id = table.Column<int>(type: "int", nullable: false),
                    source = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dokumentumok", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "esemeny",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_esemeny", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salt = table.Column<byte[]>(type: "varbinary(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "naplo",
                columns: table => new
                {
                    dokumentum_id = table.Column<int>(type: "int", nullable: false),
                    esemeny_id = table.Column<int>(type: "int", nullable: false),
                    happened_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_naplo_dokumentumok",
                        column: x => x.dokumentum_id,
                        principalTable: "dokumentumok",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_naplo_esemeny",
                        column: x => x.esemeny_id,
                        principalTable: "esemeny",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Client_IP_address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Login_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    Login_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Event_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logins_EventTypes",
                        column: x => x.Event_id,
                        principalTable: "EventTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Logins_Event_id",
                table: "Logins",
                column: "Event_id");

            migrationBuilder.CreateIndex(
                name: "IX_naplo_dokumentum_id",
                table: "naplo",
                column: "dokumentum_id");

            migrationBuilder.CreateIndex(
                name: "IX_naplo_esemeny_id",
                table: "naplo",
                column: "esemeny_id");

            var GetDocumentsByMainId = @"
                CREATE PROCEDURE GetDocumentsByMainId
	                @mainId int

                AS
                BEGIN

	                SET NOCOUNT ON;

	                SELECT id, title, extension, main_id, source, MIN(happened_at)  FROM dokumentumok
	                JOIN naplo ON dokumentumok.id = naplo.dokumentum_id
	                WHERE dokumentumok.main_id = @mainId
	                GROUP BY id, title, extension, main_id, source
                    ORDER BY MIN(happened_at)
                END";

            migrationBuilder.Sql(GetDocumentsByMainId);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "naplo");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "dokumentumok");

            migrationBuilder.DropTable(
                name: "esemeny");
        }
    }
}

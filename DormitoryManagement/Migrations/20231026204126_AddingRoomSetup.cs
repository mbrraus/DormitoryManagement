using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DormitoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddingRoomSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    BuildingId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floors_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    FloorId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("58c02d2e-8483-45fc-b0c3-5689642790bd"), "Building A" },
                    { new Guid("e3ab161e-9020-433a-8cc9-096a42e16702"), "Building B" }
                });

            migrationBuilder.InsertData(
                table: "Floors",
                columns: new[] { "Id", "BuildingId", "Number" },
                values: new object[,]
                {
                    { new Guid("0801c872-16b3-4202-9f32-36c287fce094"), new Guid("e3ab161e-9020-433a-8cc9-096a42e16702"), 1 },
                    { new Guid("2e3b8264-4ac0-4ea1-bc58-dc3437db31d5"), new Guid("58c02d2e-8483-45fc-b0c3-5689642790bd"), 2 },
                    { new Guid("7c20b0b1-019d-4727-8483-130e5a802882"), new Guid("58c02d2e-8483-45fc-b0c3-5689642790bd"), 1 },
                    { new Guid("ce898d7d-c8d8-4aed-a604-8e49b022f766"), new Guid("e3ab161e-9020-433a-8cc9-096a42e16702"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "FloorId", "Number" },
                values: new object[,]
                {
                    { new Guid("1a81f689-92d3-4813-bbce-645e9b360377"), new Guid("0801c872-16b3-4202-9f32-36c287fce094"), "302" },
                    { new Guid("20f2b16f-078d-43a0-8000-7b1ac89708c5"), new Guid("7c20b0b1-019d-4727-8483-130e5a802882"), "103" },
                    { new Guid("23b34d21-ecb5-4408-8d57-a567d8e0fec2"), new Guid("2e3b8264-4ac0-4ea1-bc58-dc3437db31d5"), "203" },
                    { new Guid("24788378-6e5e-40a0-8a22-c901d4052a89"), new Guid("0801c872-16b3-4202-9f32-36c287fce094"), "303" },
                    { new Guid("39efbe04-0b4b-4c2a-a6a5-81aeb4d5da86"), new Guid("7c20b0b1-019d-4727-8483-130e5a802882"), "101" },
                    { new Guid("4a2abfd8-e20d-4da6-84b0-8234f6fcae85"), new Guid("7c20b0b1-019d-4727-8483-130e5a802882"), "102" },
                    { new Guid("54266368-6b58-4a54-88b0-1fc368974d2f"), new Guid("ce898d7d-c8d8-4aed-a604-8e49b022f766"), "403" },
                    { new Guid("749410a0-c185-4df3-8469-ef28e8552feb"), new Guid("ce898d7d-c8d8-4aed-a604-8e49b022f766"), "402" },
                    { new Guid("7e1e65c5-011c-47d1-8aa6-9eb7813abe9f"), new Guid("2e3b8264-4ac0-4ea1-bc58-dc3437db31d5"), "204" },
                    { new Guid("99d3beec-1ff4-47bd-8a9a-ac20c48f6b78"), new Guid("ce898d7d-c8d8-4aed-a604-8e49b022f766"), "401" },
                    { new Guid("b6d1c8d8-08ea-4c3e-96a0-6835c828966f"), new Guid("2e3b8264-4ac0-4ea1-bc58-dc3437db31d5"), "202" },
                    { new Guid("b92c968f-e11a-4888-9f61-2a1668bc3642"), new Guid("0801c872-16b3-4202-9f32-36c287fce094"), "301" },
                    { new Guid("cb97ba0d-03a9-413f-8197-8154e7cf603c"), new Guid("0801c872-16b3-4202-9f32-36c287fce094"), "304" },
                    { new Guid("edf8f8cb-4ef3-4ed6-8bc1-4831dcca975c"), new Guid("2e3b8264-4ac0-4ea1-bc58-dc3437db31d5"), "201" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Floors_BuildingId",
                table: "Floors",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_FloorId",
                table: "Rooms",
                column: "FloorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "Buildings");
        }
    }
}

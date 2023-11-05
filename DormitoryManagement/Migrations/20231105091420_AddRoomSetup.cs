using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DormitoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddRoomSetup : Migration
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
                    { new Guid("32a28f1c-7d20-47e4-997d-f4c3bb974e23"), "Building B" },
                    { new Guid("9365f827-8055-41f0-8e7e-a32891b46d2e"), "Building A" }
                });

            migrationBuilder.InsertData(
                table: "Floors",
                columns: new[] { "Id", "BuildingId", "Number" },
                values: new object[,]
                {
                    { new Guid("1867af08-63c7-4517-bfbe-0c99c67318cf"), new Guid("9365f827-8055-41f0-8e7e-a32891b46d2e"), 1 },
                    { new Guid("70b54e27-bde1-468c-930a-f638c25f22df"), new Guid("9365f827-8055-41f0-8e7e-a32891b46d2e"), 2 },
                    { new Guid("75234197-e4a8-407e-85e8-80279350db7f"), new Guid("32a28f1c-7d20-47e4-997d-f4c3bb974e23"), 1 },
                    { new Guid("981a6210-5098-4cc1-9917-c42f777cfe9a"), new Guid("32a28f1c-7d20-47e4-997d-f4c3bb974e23"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "FloorId", "Number" },
                values: new object[,]
                {
                    { new Guid("11de0c6b-312e-4998-beb8-3ef73008902a"), new Guid("75234197-e4a8-407e-85e8-80279350db7f"), "304" },
                    { new Guid("3093a6d7-ddae-456c-9809-8acdbb405d7a"), new Guid("1867af08-63c7-4517-bfbe-0c99c67318cf"), "103" },
                    { new Guid("40601319-87b8-4100-8814-d61466ea0985"), new Guid("70b54e27-bde1-468c-930a-f638c25f22df"), "203" },
                    { new Guid("427c1c4a-5313-427a-97dc-110c965b0eab"), new Guid("1867af08-63c7-4517-bfbe-0c99c67318cf"), "102" },
                    { new Guid("8dea9c3a-672a-462a-bcc7-96fa2df682c0"), new Guid("70b54e27-bde1-468c-930a-f638c25f22df"), "202" },
                    { new Guid("aae92210-397b-4185-80c9-234e36d77089"), new Guid("75234197-e4a8-407e-85e8-80279350db7f"), "302" },
                    { new Guid("b8652abf-a18c-4105-be6e-8c249c68181e"), new Guid("75234197-e4a8-407e-85e8-80279350db7f"), "301" },
                    { new Guid("bb042b20-533f-44d2-b070-7aa05fc3ddb5"), new Guid("70b54e27-bde1-468c-930a-f638c25f22df"), "201" },
                    { new Guid("bb067df4-3b41-4637-9ce6-062e1bba9e19"), new Guid("981a6210-5098-4cc1-9917-c42f777cfe9a"), "401" },
                    { new Guid("c2c0560e-62f1-436e-8886-453d7bc4a359"), new Guid("70b54e27-bde1-468c-930a-f638c25f22df"), "204" },
                    { new Guid("c96dcd55-d7b2-4a56-90dc-11dc3c334a0e"), new Guid("75234197-e4a8-407e-85e8-80279350db7f"), "303" },
                    { new Guid("f08da799-7452-412f-b8e4-9aef82ce8444"), new Guid("981a6210-5098-4cc1-9917-c42f777cfe9a"), "403" },
                    { new Guid("f0be2115-a305-4d1c-87ce-a35f547b68aa"), new Guid("1867af08-63c7-4517-bfbe-0c99c67318cf"), "101" },
                    { new Guid("f6484657-34de-44c2-804b-737bfa0f67e2"), new Guid("981a6210-5098-4cc1-9917-c42f777cfe9a"), "402" }
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

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DormitoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                name: "InventoryItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItems", x => x.Id);
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
                    FloorId = table.Column<Guid>(type: "uuid", nullable: false),
                    AllowedPersons = table.Column<int>(type: "integer", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "RoomAssignment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomId = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomAssignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomAssignment_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomInventories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomId = table.Column<Guid>(type: "uuid", nullable: false),
                    InventoryItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExpectedQuantity = table.Column<int>(type: "integer", nullable: false),
                    ActualQuantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomInventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomInventories_InventoryItems_InventoryItemId",
                        column: x => x.InventoryItemId,
                        principalTable: "InventoryItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomInventories_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    RoomAssignmentId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_RoomAssignment_RoomAssignmentId",
                        column: x => x.RoomAssignmentId,
                        principalTable: "RoomAssignment",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("55d39593-b0da-4387-a0c9-bb2fe455efec"), "Building A" },
                    { new Guid("dcf76e4f-d322-44c0-bb5b-ceb43ab333dd"), "Building B" }
                });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), "Wardrobe" },
                    { new Guid("38792418-a30d-483c-843c-3a072addabbc"), "Desk" },
                    { new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), "Lamp" },
                    { new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), "Chair" },
                    { new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), "Bed" },
                    { new Guid("accf4824-a50e-4122-9777-a826c75288f4"), "Bookshelf" },
                    { new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), "Curtains" }
                });

            migrationBuilder.InsertData(
                table: "Floors",
                columns: new[] { "Id", "BuildingId", "Number" },
                values: new object[,]
                {
                    { new Guid("1e629824-4318-4c1d-ac46-a4b616e97ccd"), new Guid("dcf76e4f-d322-44c0-bb5b-ceb43ab333dd"), 1 },
                    { new Guid("2fdc137e-b97f-4679-b96b-1fda9e269e99"), new Guid("55d39593-b0da-4387-a0c9-bb2fe455efec"), 1 },
                    { new Guid("bf782ef9-b684-4d86-bd26-e8ed93e93971"), new Guid("55d39593-b0da-4387-a0c9-bb2fe455efec"), 2 },
                    { new Guid("e1585c2a-02e5-44c7-b86a-ee43e173593e"), new Guid("dcf76e4f-d322-44c0-bb5b-ceb43ab333dd"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "AllowedPersons", "FloorId", "Number" },
                values: new object[,]
                {
                    { new Guid("0174d0fd-fba9-46bf-8eb3-c5152d0eaa38"), 5, new Guid("1e629824-4318-4c1d-ac46-a4b616e97ccd"), "B1-01" },
                    { new Guid("03e3c78c-343b-4836-bae3-207f9436ba17"), 3, new Guid("e1585c2a-02e5-44c7-b86a-ee43e173593e"), "B2-01" },
                    { new Guid("07fe95f1-306c-42bc-a497-0f4975e86099"), 4, new Guid("e1585c2a-02e5-44c7-b86a-ee43e173593e"), "B2-05" },
                    { new Guid("08c722d2-f819-4ef8-9441-fafc536a158a"), 5, new Guid("e1585c2a-02e5-44c7-b86a-ee43e173593e"), "B2-10" },
                    { new Guid("0d9da574-4fd0-4392-9432-809db6df05f0"), 5, new Guid("2fdc137e-b97f-4679-b96b-1fda9e269e99"), "A1-08" },
                    { new Guid("0f0c2db7-0760-4b68-a7ea-92ab8f02087b"), 4, new Guid("bf782ef9-b684-4d86-bd26-e8ed93e93971"), "A2-03" },
                    { new Guid("1263221d-1089-46de-8072-5a7841fb7ef2"), 4, new Guid("2fdc137e-b97f-4679-b96b-1fda9e269e99"), "A1-07" },
                    { new Guid("1a024e28-3060-4d23-9c41-b5960c894f8f"), 4, new Guid("e1585c2a-02e5-44c7-b86a-ee43e173593e"), "B2-03" },
                    { new Guid("1fb6e404-0af3-41a6-98c9-f97a8765d299"), 5, new Guid("bf782ef9-b684-4d86-bd26-e8ed93e93971"), "A2-06" },
                    { new Guid("293f5ab3-f6a3-4456-9f07-0f4d4d879b17"), 4, new Guid("bf782ef9-b684-4d86-bd26-e8ed93e93971"), "A2-02" },
                    { new Guid("33e79c0e-5fb2-47a6-9599-e8c0c484c338"), 4, new Guid("2fdc137e-b97f-4679-b96b-1fda9e269e99"), "A1-01" },
                    { new Guid("3f3773d4-5437-46dd-8705-ad5c0e7df8aa"), 3, new Guid("e1585c2a-02e5-44c7-b86a-ee43e173593e"), "B2-08" },
                    { new Guid("43b1aadb-ced0-496a-b46a-f54732bf03eb"), 4, new Guid("1e629824-4318-4c1d-ac46-a4b616e97ccd"), "B1-05" },
                    { new Guid("4949b9c4-d8a1-4cf0-a875-5b52ae94ff91"), 3, new Guid("1e629824-4318-4c1d-ac46-a4b616e97ccd"), "B1-10" },
                    { new Guid("5fb6d4e2-5c3a-4d2c-84b4-61324910820a"), 5, new Guid("2fdc137e-b97f-4679-b96b-1fda9e269e99"), "A1-04" },
                    { new Guid("60104d45-1f95-47f7-ad6c-abbcfa3c5c5f"), 4, new Guid("bf782ef9-b684-4d86-bd26-e8ed93e93971"), "A2-10" },
                    { new Guid("63c3b25f-c73e-4738-8d85-1e945ae8cea3"), 3, new Guid("1e629824-4318-4c1d-ac46-a4b616e97ccd"), "B1-07" },
                    { new Guid("664efd94-8791-47e0-93f5-a90471a719ce"), 4, new Guid("2fdc137e-b97f-4679-b96b-1fda9e269e99"), "A1-05" },
                    { new Guid("735de6ab-bfd8-40c5-abd1-7706600bf428"), 3, new Guid("1e629824-4318-4c1d-ac46-a4b616e97ccd"), "B1-08" },
                    { new Guid("740f9a7a-5fb3-4731-89ac-3a3263b11299"), 5, new Guid("2fdc137e-b97f-4679-b96b-1fda9e269e99"), "A1-03" },
                    { new Guid("75c5cd05-a06a-40ec-80bb-0d370ccd7327"), 4, new Guid("e1585c2a-02e5-44c7-b86a-ee43e173593e"), "B2-09" },
                    { new Guid("79551927-0e12-4f75-9806-98d4f76ccc2f"), 3, new Guid("bf782ef9-b684-4d86-bd26-e8ed93e93971"), "A2-04" },
                    { new Guid("8db3a69a-e938-400a-b99b-1be55722a816"), 3, new Guid("bf782ef9-b684-4d86-bd26-e8ed93e93971"), "A2-05" },
                    { new Guid("92701ba7-6787-44b2-ab2b-364e75f85730"), 3, new Guid("1e629824-4318-4c1d-ac46-a4b616e97ccd"), "B1-09" },
                    { new Guid("a41f1d35-7849-47d8-9122-feebed9f0af2"), 3, new Guid("bf782ef9-b684-4d86-bd26-e8ed93e93971"), "A2-09" },
                    { new Guid("aae4ce69-2f3d-4dd8-9380-b1acf986f565"), 3, new Guid("e1585c2a-02e5-44c7-b86a-ee43e173593e"), "B2-07" },
                    { new Guid("acf42373-049d-4b01-b60b-2ff4821f3991"), 3, new Guid("e1585c2a-02e5-44c7-b86a-ee43e173593e"), "B2-04" },
                    { new Guid("b379d037-36eb-4a43-a2ad-df02ddd6c0c6"), 3, new Guid("2fdc137e-b97f-4679-b96b-1fda9e269e99"), "A1-09" },
                    { new Guid("b64f485b-7269-428f-86b6-18644500d0c8"), 5, new Guid("2fdc137e-b97f-4679-b96b-1fda9e269e99"), "A1-06" },
                    { new Guid("b9003860-62dd-42f5-b510-760d3e715ac2"), 3, new Guid("bf782ef9-b684-4d86-bd26-e8ed93e93971"), "A2-07" },
                    { new Guid("c46a33c4-5aa5-4d99-83e8-6d266d94fe51"), 5, new Guid("1e629824-4318-4c1d-ac46-a4b616e97ccd"), "B1-03" },
                    { new Guid("c625aac5-d374-4c68-a883-4ee886edb9e4"), 3, new Guid("e1585c2a-02e5-44c7-b86a-ee43e173593e"), "B2-06" },
                    { new Guid("cb30ad96-44a2-4f05-9134-e891eb55177f"), 3, new Guid("bf782ef9-b684-4d86-bd26-e8ed93e93971"), "A2-08" },
                    { new Guid("e62620f7-4612-4b62-98d5-bff192d83494"), 5, new Guid("1e629824-4318-4c1d-ac46-a4b616e97ccd"), "B1-04" },
                    { new Guid("ea378932-757c-46eb-a9b7-074379b6c130"), 4, new Guid("bf782ef9-b684-4d86-bd26-e8ed93e93971"), "A2-01" },
                    { new Guid("f233b8ba-f83e-4a93-900a-9011f74bf290"), 3, new Guid("2fdc137e-b97f-4679-b96b-1fda9e269e99"), "A1-10" },
                    { new Guid("f5af0699-4280-4c91-a8d7-05873ed37854"), 4, new Guid("1e629824-4318-4c1d-ac46-a4b616e97ccd"), "B1-02" },
                    { new Guid("f77269e4-005e-41bb-bb4f-6f0c3bc07c78"), 3, new Guid("1e629824-4318-4c1d-ac46-a4b616e97ccd"), "B1-06" },
                    { new Guid("f8e81dcb-ed4a-4456-91a8-5c0e922dff41"), 4, new Guid("2fdc137e-b97f-4679-b96b-1fda9e269e99"), "A1-02" },
                    { new Guid("fddd9a83-f51d-4880-a4a0-79a97671b538"), 4, new Guid("e1585c2a-02e5-44c7-b86a-ee43e173593e"), "B2-02" }
                });

            migrationBuilder.InsertData(
                table: "RoomInventories",
                columns: new[] { "Id", "ActualQuantity", "ExpectedQuantity", "InventoryItemId", "RoomId" },
                values: new object[,]
                {
                    { new Guid("02712cb9-a446-440d-8b1e-0bcb169025cf"), 2, 2, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("f5af0699-4280-4c91-a8d7-05873ed37854") },
                    { new Guid("02b857ef-8951-4afe-8a45-f497c7e82ea2"), 2, 2, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("293f5ab3-f6a3-4456-9f07-0f4d4d879b17") },
                    { new Guid("02c32697-0203-4dd4-af1f-86b6aef7eac2"), 4, 4, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("0f0c2db7-0760-4b68-a7ea-92ab8f02087b") },
                    { new Guid("0348f3b3-ec82-468f-8a40-ad65ba1546a9"), 1, 1, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("1263221d-1089-46de-8072-5a7841fb7ef2") },
                    { new Guid("04e18ddd-9575-41c3-960c-a99b60c566e4"), 1, 1, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("75c5cd05-a06a-40ec-80bb-0d370ccd7327") },
                    { new Guid("06993abc-f971-41fd-a999-3b971751dc92"), 3, 3, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("acf42373-049d-4b01-b60b-2ff4821f3991") },
                    { new Guid("0af7b0b8-69ef-4897-8782-95adc692dfac"), 4, 4, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("fddd9a83-f51d-4880-a4a0-79a97671b538") },
                    { new Guid("0dcaec02-180e-4bec-86b3-c4d034d82e7f"), 2, 1, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("c46a33c4-5aa5-4d99-83e8-6d266d94fe51") },
                    { new Guid("0eb12141-fcd7-4c91-abf8-4fe7b5d65300"), 3, 3, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("8db3a69a-e938-400a-b99b-1be55722a816") },
                    { new Guid("131813ac-bfd5-435a-8e4b-9d7efe8fb8f1"), 4, 4, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("08c722d2-f819-4ef8-9441-fafc536a158a") },
                    { new Guid("151fdb39-6ec8-4495-8c71-26435c412473"), 1, 1, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("92701ba7-6787-44b2-ab2b-364e75f85730") },
                    { new Guid("1620f68e-d975-404d-aa15-cf3c167dfe47"), 3, 3, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("08c722d2-f819-4ef8-9441-fafc536a158a") },
                    { new Guid("18779bb3-ba10-4a5c-a50e-b1e71e9a0b8b"), 1, 1, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("63c3b25f-c73e-4738-8d85-1e945ae8cea3") },
                    { new Guid("1a9c4085-e112-41bb-a4f4-dabf397cac6c"), 1, 1, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("293f5ab3-f6a3-4456-9f07-0f4d4d879b17") },
                    { new Guid("1b0db42e-0a20-4bd3-8647-5574f6b91071"), 1, 1, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("aae4ce69-2f3d-4dd8-9380-b1acf986f565") },
                    { new Guid("1eaed6e5-091a-4a3e-98fe-e8e1e7291b1e"), 1, 1, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("740f9a7a-5fb3-4731-89ac-3a3263b11299") },
                    { new Guid("1ebcab0e-4eb7-4f3f-b20c-f298f1e312c5"), 2, 2, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("acf42373-049d-4b01-b60b-2ff4821f3991") },
                    { new Guid("20390396-6dfd-40f3-ba9b-0bad66a9e217"), 3, 3, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("f8e81dcb-ed4a-4456-91a8-5c0e922dff41") },
                    { new Guid("204ed047-4234-4f3d-bc34-1c59414d1560"), 1, 1, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("43b1aadb-ced0-496a-b46a-f54732bf03eb") },
                    { new Guid("2133fad8-4275-4549-999d-0dfa5b039411"), 2, 2, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("fddd9a83-f51d-4880-a4a0-79a97671b538") },
                    { new Guid("2178f6ff-e942-46a8-974e-1d4133bda5f8"), 4, 4, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("f233b8ba-f83e-4a93-900a-9011f74bf290") },
                    { new Guid("24367077-3967-45ec-93ac-fed749514441"), 3, 3, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("fddd9a83-f51d-4880-a4a0-79a97671b538") },
                    { new Guid("25d5e69d-cca2-44ec-80bd-103c7d63aa5f"), 3, 3, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("f5af0699-4280-4c91-a8d7-05873ed37854") },
                    { new Guid("26c8cd6a-abd5-448a-b3c9-ed1e84c18085"), 1, 1, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("ea378932-757c-46eb-a9b7-074379b6c130") },
                    { new Guid("2746e348-f3ad-431b-a971-dd3f9d5108fa"), 3, 4, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("79551927-0e12-4f75-9806-98d4f76ccc2f") },
                    { new Guid("2817b1c9-0317-44f8-9933-a6fdf413a182"), 3, 3, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("b9003860-62dd-42f5-b510-760d3e715ac2") },
                    { new Guid("284eaf12-adb7-41b5-85d6-5bc9fdbb3349"), 1, 1, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("1263221d-1089-46de-8072-5a7841fb7ef2") },
                    { new Guid("285b8b20-25da-4328-acc7-2f69473e304a"), 2, 2, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("63c3b25f-c73e-4738-8d85-1e945ae8cea3") },
                    { new Guid("2a46e0ba-44e7-40df-8595-bd62acb261d3"), 3, 3, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("c46a33c4-5aa5-4d99-83e8-6d266d94fe51") },
                    { new Guid("2b84507b-fc13-4a83-82ac-b793bc4b0d19"), 4, 4, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("75c5cd05-a06a-40ec-80bb-0d370ccd7327") },
                    { new Guid("2cbd6f57-f275-442a-8ccc-fb1f0ecab6cd"), 3, 3, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("a41f1d35-7849-47d8-9122-feebed9f0af2") },
                    { new Guid("2f313ab4-77d1-4464-94c1-28538b37e9dc"), 3, 3, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("03e3c78c-343b-4836-bae3-207f9436ba17") },
                    { new Guid("3006ad14-2617-427a-9f92-3d96d9125d0f"), 2, 2, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("b64f485b-7269-428f-86b6-18644500d0c8") },
                    { new Guid("31bb1106-50e5-48c0-be53-f8b1b2f74765"), 1, 1, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("aae4ce69-2f3d-4dd8-9380-b1acf986f565") },
                    { new Guid("33d952a0-1fba-455f-ba10-aa7ee367e7b9"), 3, 3, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("fddd9a83-f51d-4880-a4a0-79a97671b538") },
                    { new Guid("34635b16-7c33-4749-9613-bd94edc1d27a"), 2, 3, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("92701ba7-6787-44b2-ab2b-364e75f85730") },
                    { new Guid("35f279fe-b6f7-40a2-8eb8-da3a981dec50"), 2, 2, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("08c722d2-f819-4ef8-9441-fafc536a158a") },
                    { new Guid("363456f2-09a1-4a67-b080-eaef5466c10f"), 3, 3, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("e62620f7-4612-4b62-98d5-bff192d83494") },
                    { new Guid("381c302c-8e7c-4555-aba9-7a661b0c4045"), 4, 4, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("60104d45-1f95-47f7-ad6c-abbcfa3c5c5f") },
                    { new Guid("385386df-05b3-48d8-a177-681f1726651a"), 2, 2, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("f233b8ba-f83e-4a93-900a-9011f74bf290") },
                    { new Guid("39639cea-e888-4247-a883-0b1bfbd90f1f"), 2, 2, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("8db3a69a-e938-400a-b99b-1be55722a816") },
                    { new Guid("39bfd570-a6d9-4b02-bd39-68048b5c611f"), 1, 1, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("acf42373-049d-4b01-b60b-2ff4821f3991") },
                    { new Guid("3d2dddf1-55af-4a42-965f-5e5487fdff21"), 3, 3, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("b9003860-62dd-42f5-b510-760d3e715ac2") },
                    { new Guid("3d461496-ea35-464c-9d2a-48e8fde67775"), 3, 3, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("cb30ad96-44a2-4f05-9134-e891eb55177f") },
                    { new Guid("3d83b701-341f-46fb-94fd-79d9556b06c0"), 4, 1, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("33e79c0e-5fb2-47a6-9599-e8c0c484c338") },
                    { new Guid("3f4c7215-9149-4c42-a99c-5020bbf593ba"), 3, 3, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("f233b8ba-f83e-4a93-900a-9011f74bf290") },
                    { new Guid("4010ea4f-f6f2-4379-b015-549d464054b1"), 3, 3, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("740f9a7a-5fb3-4731-89ac-3a3263b11299") },
                    { new Guid("41de6083-cf03-40d4-b9d4-547300749280"), 1, 3, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("8db3a69a-e938-400a-b99b-1be55722a816") },
                    { new Guid("42e89444-fbca-4671-9633-a7c9cb1a1fc5"), 3, 3, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("664efd94-8791-47e0-93f5-a90471a719ce") },
                    { new Guid("46d50dd8-4429-41fb-814d-5e84d9f6b9dc"), 4, 4, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("0f0c2db7-0760-4b68-a7ea-92ab8f02087b") },
                    { new Guid("48db5631-18c4-401b-8422-e50ed68c1e6a"), 4, 4, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("1a024e28-3060-4d23-9c41-b5960c894f8f") },
                    { new Guid("49d40226-c63e-490b-9067-def030cbb7d6"), 2, 2, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("1263221d-1089-46de-8072-5a7841fb7ef2") },
                    { new Guid("4a382dac-7b30-4f31-9ed1-0b0cba42a6c0"), 4, 4, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("92701ba7-6787-44b2-ab2b-364e75f85730") },
                    { new Guid("4c69c086-dada-4ec4-8cd7-fb4e5d208f2f"), 4, 4, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("5fb6d4e2-5c3a-4d2c-84b4-61324910820a") },
                    { new Guid("4d4ca555-c078-4b31-9dae-f80f23cf0b02"), 1, 3, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("e62620f7-4612-4b62-98d5-bff192d83494") },
                    { new Guid("4dbef848-e038-4ff5-a9aa-a0c2eb16e7db"), 2, 2, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("f77269e4-005e-41bb-bb4f-6f0c3bc07c78") },
                    { new Guid("4de8b394-1996-480b-8f80-4fdf553f0ab5"), 4, 4, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("c625aac5-d374-4c68-a883-4ee886edb9e4") },
                    { new Guid("4de9c99d-84c5-4cf1-95ee-975843e74b22"), 2, 2, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("f5af0699-4280-4c91-a8d7-05873ed37854") },
                    { new Guid("4e9e314f-1c91-45fc-aff8-fac1bfcb862c"), 4, 4, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("b64f485b-7269-428f-86b6-18644500d0c8") },
                    { new Guid("4f368605-0738-4c9c-8518-7d3a4eea7256"), 3, 3, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("07fe95f1-306c-42bc-a497-0f4975e86099") },
                    { new Guid("4f5e7a6f-820d-4455-8e89-fda01a784eee"), 1, 1, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("92701ba7-6787-44b2-ab2b-364e75f85730") },
                    { new Guid("55eaa2a4-db6c-4e06-969e-450ed88fc4ab"), 3, 3, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("b64f485b-7269-428f-86b6-18644500d0c8") },
                    { new Guid("562e4b15-c4fd-4567-8376-f15c47363900"), 1, 1, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("33e79c0e-5fb2-47a6-9599-e8c0c484c338") },
                    { new Guid("564ec9fe-44ee-4d9a-92be-db9178bc06e5"), 3, 2, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("293f5ab3-f6a3-4456-9f07-0f4d4d879b17") },
                    { new Guid("572d7584-44f6-4286-80f9-aa2ddf5fad4f"), 1, 1, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("1263221d-1089-46de-8072-5a7841fb7ef2") },
                    { new Guid("590f3876-7e85-49ae-a006-3d069ac2104e"), 2, 2, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("acf42373-049d-4b01-b60b-2ff4821f3991") },
                    { new Guid("5c7fb7c7-824d-41e8-b20f-9bc266b2141e"), 4, 4, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("3f3773d4-5437-46dd-8705-ad5c0e7df8aa") },
                    { new Guid("648de209-d9be-4478-8754-8170580ee220"), 4, 4, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("0d9da574-4fd0-4392-9432-809db6df05f0") },
                    { new Guid("6508bb62-ed6c-4134-a0ce-47803aa35a7d"), 4, 4, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("07fe95f1-306c-42bc-a497-0f4975e86099") },
                    { new Guid("67d5a34b-540e-47e5-a265-e75997d367f0"), 3, 3, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("08c722d2-f819-4ef8-9441-fafc536a158a") },
                    { new Guid("67f59894-2845-4a23-9b53-afdc0f9be685"), 1, 1, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("43b1aadb-ced0-496a-b46a-f54732bf03eb") },
                    { new Guid("6f310106-f822-43b1-8bfc-2d847c2178ae"), 3, 4, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("fddd9a83-f51d-4880-a4a0-79a97671b538") },
                    { new Guid("6f8b3329-f493-437e-a049-eb40f806decc"), 3, 3, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("43b1aadb-ced0-496a-b46a-f54732bf03eb") },
                    { new Guid("736fcf56-1abc-48ef-a469-f8a48fc29947"), 4, 4, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("c625aac5-d374-4c68-a883-4ee886edb9e4") },
                    { new Guid("737f4005-68c7-42f0-b92c-c09e419f8032"), 1, 1, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("b379d037-36eb-4a43-a2ad-df02ddd6c0c6") },
                    { new Guid("79bc7164-aceb-49c0-81f6-5eb75f05bc21"), 2, 2, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("79551927-0e12-4f75-9806-98d4f76ccc2f") },
                    { new Guid("7c7b58d1-ae43-4ec8-821d-18d167c77368"), 1, 4, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("92701ba7-6787-44b2-ab2b-364e75f85730") },
                    { new Guid("7ed0e6cb-d9d0-4f61-a875-b18d66a86e5a"), 3, 3, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("f8e81dcb-ed4a-4456-91a8-5c0e922dff41") },
                    { new Guid("802fde50-18cf-4147-ba91-b11d5b24ba64"), 3, 3, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("1a024e28-3060-4d23-9c41-b5960c894f8f") },
                    { new Guid("8144e92a-d43a-47e2-bd3c-73a46c5c62b5"), 3, 3, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("cb30ad96-44a2-4f05-9134-e891eb55177f") },
                    { new Guid("8253f096-938f-48f9-a9b7-23150805329e"), 3, 3, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("5fb6d4e2-5c3a-4d2c-84b4-61324910820a") },
                    { new Guid("8319ec5a-2f68-44ed-8d36-3e94fef5bcd2"), 2, 2, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("b9003860-62dd-42f5-b510-760d3e715ac2") },
                    { new Guid("852000a5-37a9-4fbe-8db6-7a731565bf95"), 4, 4, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("8db3a69a-e938-400a-b99b-1be55722a816") },
                    { new Guid("86449c79-fe45-4df9-a064-2260d9c64b7e"), 4, 3, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("0174d0fd-fba9-46bf-8eb3-c5152d0eaa38") },
                    { new Guid("87086ef7-5cae-4ad6-b5a0-daed009f602c"), 3, 3, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("79551927-0e12-4f75-9806-98d4f76ccc2f") },
                    { new Guid("8851d3bd-55e7-4e55-a532-02ff9884153f"), 4, 4, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("33e79c0e-5fb2-47a6-9599-e8c0c484c338") },
                    { new Guid("889ef833-82bd-4084-b76c-cbe2eda480a5"), 4, 4, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("f77269e4-005e-41bb-bb4f-6f0c3bc07c78") },
                    { new Guid("88c3ed9f-ec98-4463-963e-28de85ca6c75"), 2, 2, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("f233b8ba-f83e-4a93-900a-9011f74bf290") },
                    { new Guid("8dd1face-723d-4dea-96df-22e912a493cf"), 1, 1, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("63c3b25f-c73e-4738-8d85-1e945ae8cea3") },
                    { new Guid("8e0e10a8-9e54-4a74-9ceb-686e2a6b261d"), 4, 4, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("a41f1d35-7849-47d8-9122-feebed9f0af2") },
                    { new Guid("8ff00f11-b653-43f7-8d36-9a7b89cdcc8b"), 4, 4, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("43b1aadb-ced0-496a-b46a-f54732bf03eb") },
                    { new Guid("9027e127-ed98-458a-8fda-cc2b8f4e1176"), 4, 4, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("c46a33c4-5aa5-4d99-83e8-6d266d94fe51") },
                    { new Guid("92299cbd-e4c5-4846-8894-cb117f12c6d4"), 4, 4, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("293f5ab3-f6a3-4456-9f07-0f4d4d879b17") },
                    { new Guid("9286580d-e8a1-4e55-85c1-e98690268d76"), 2, 2, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("1a024e28-3060-4d23-9c41-b5960c894f8f") },
                    { new Guid("9763326d-fec1-4da3-974b-a320af57059e"), 1, 2, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("b9003860-62dd-42f5-b510-760d3e715ac2") },
                    { new Guid("97a08d5e-3dd8-4f96-a965-d6f52cb99394"), 1, 1, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("1a024e28-3060-4d23-9c41-b5960c894f8f") },
                    { new Guid("9afd5e35-b02e-41be-9777-e45947887bd8"), 1, 1, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("ea378932-757c-46eb-a9b7-074379b6c130") },
                    { new Guid("9be7e501-d727-4e08-b450-07c9692c7fa7"), 3, 3, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("3f3773d4-5437-46dd-8705-ad5c0e7df8aa") },
                    { new Guid("9c560e92-f895-4d46-abf1-1b82ff02e04f"), 3, 3, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("3f3773d4-5437-46dd-8705-ad5c0e7df8aa") },
                    { new Guid("9d83f37f-0c88-4faa-b7e7-8533da8d2640"), 1, 1, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("b9003860-62dd-42f5-b510-760d3e715ac2") },
                    { new Guid("a0362abe-4600-4969-b278-05dc82ee57ea"), 4, 4, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("4949b9c4-d8a1-4cf0-a875-5b52ae94ff91") },
                    { new Guid("a06b2bca-9ab8-44b0-9cc5-d797c4692d32"), 3, 3, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("664efd94-8791-47e0-93f5-a90471a719ce") },
                    { new Guid("a113e2bf-0019-4984-9076-84e9f2200639"), 1, 1, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("e62620f7-4612-4b62-98d5-bff192d83494") },
                    { new Guid("a575eb48-ea53-4eee-893e-6fc1a61a4feb"), 3, 3, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("f8e81dcb-ed4a-4456-91a8-5c0e922dff41") },
                    { new Guid("a73c8147-1f42-4bbe-9b40-43c57f66cc17"), 4, 4, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("4949b9c4-d8a1-4cf0-a875-5b52ae94ff91") },
                    { new Guid("a7c474ab-1b5c-4819-ac59-256b90742493"), 3, 3, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("0f0c2db7-0760-4b68-a7ea-92ab8f02087b") },
                    { new Guid("a85238dd-50d5-4ae5-9cd3-a242fb549f75"), 1, 1, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("c625aac5-d374-4c68-a883-4ee886edb9e4") },
                    { new Guid("ac94c1e4-c154-407e-88ee-93c7bc0d8fd9"), 1, 1, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("1fb6e404-0af3-41a6-98c9-f97a8765d299") },
                    { new Guid("ae1fa8f7-9cc3-43f1-b7eb-492fabadb8ae"), 4, 4, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("fddd9a83-f51d-4880-a4a0-79a97671b538") },
                    { new Guid("aeaaf621-de28-40cf-a908-5c44eceaf4dc"), 3, 3, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("f233b8ba-f83e-4a93-900a-9011f74bf290") },
                    { new Guid("aeda9529-9d87-4f65-ac24-fc1aa84d7d80"), 3, 3, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("75c5cd05-a06a-40ec-80bb-0d370ccd7327") },
                    { new Guid("afb3a7f7-ca11-41b7-bdae-872ce3a4fe19"), 1, 1, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("664efd94-8791-47e0-93f5-a90471a719ce") },
                    { new Guid("b18d39e6-bd34-49e4-bcbf-b997be561849"), 3, 3, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("8db3a69a-e938-400a-b99b-1be55722a816") },
                    { new Guid("b1f248fc-6142-42d1-bbde-051d638ddc10"), 1, 1, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("f233b8ba-f83e-4a93-900a-9011f74bf290") },
                    { new Guid("b38479d7-2dc8-40ae-9d65-adbf2bc29c74"), 4, 4, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("5fb6d4e2-5c3a-4d2c-84b4-61324910820a") },
                    { new Guid("b4703892-5401-48de-9304-45277f0cc38e"), 1, 1, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("75c5cd05-a06a-40ec-80bb-0d370ccd7327") },
                    { new Guid("b67dd910-3f7b-4801-b311-e5572cd8b2ce"), 3, 1, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("75c5cd05-a06a-40ec-80bb-0d370ccd7327") },
                    { new Guid("b6bdf50a-5529-4cdd-a7b5-7992c49f04dd"), 2, 2, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("735de6ab-bfd8-40c5-abd1-7706600bf428") },
                    { new Guid("ba5408ca-a75b-4203-a8c8-4b47b63f4326"), 2, 2, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("f77269e4-005e-41bb-bb4f-6f0c3bc07c78") },
                    { new Guid("bbc4b289-4d9a-46d8-8eb2-4af2cc660bad"), 3, 3, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("3f3773d4-5437-46dd-8705-ad5c0e7df8aa") },
                    { new Guid("bbed5655-5e24-40b6-ad0d-7600218e5abc"), 1, 1, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("c46a33c4-5aa5-4d99-83e8-6d266d94fe51") },
                    { new Guid("bcb4e97e-0b3d-41b1-b565-828932ec4fad"), 3, 3, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("664efd94-8791-47e0-93f5-a90471a719ce") },
                    { new Guid("bcf9eae5-d166-40d7-955d-a308b1d854db"), 1, 3, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("c46a33c4-5aa5-4d99-83e8-6d266d94fe51") },
                    { new Guid("beb2e52f-e57b-4d3f-92aa-085060ef9e54"), 1, 1, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("a41f1d35-7849-47d8-9122-feebed9f0af2") },
                    { new Guid("c0d914ee-f519-44a4-a688-db16414b150b"), 4, 4, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("b64f485b-7269-428f-86b6-18644500d0c8") },
                    { new Guid("c2fd2aeb-be88-47a0-b1a9-7036b28cdf66"), 3, 3, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("33e79c0e-5fb2-47a6-9599-e8c0c484c338") },
                    { new Guid("c85aaf6c-063b-4ffd-9921-d0bbafa65956"), 1, 1, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("a41f1d35-7849-47d8-9122-feebed9f0af2") },
                    { new Guid("c967900d-76bd-4889-92a3-b722c002549c"), 3, 3, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("1fb6e404-0af3-41a6-98c9-f97a8765d299") },
                    { new Guid("cbcd1414-197a-4366-9e26-bc90afcb807d"), 1, 1, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("a41f1d35-7849-47d8-9122-feebed9f0af2") },
                    { new Guid("cc02dc16-4599-4ec3-9d08-0089c6b497c7"), 4, 4, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("5fb6d4e2-5c3a-4d2c-84b4-61324910820a") },
                    { new Guid("ce76abad-12c9-405f-a0f5-817e1ef6383e"), 1, 1, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("0d9da574-4fd0-4392-9432-809db6df05f0") },
                    { new Guid("ced0a90c-4dfa-4550-b3be-b4454ef3c4e3"), 4, 4, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("0d9da574-4fd0-4392-9432-809db6df05f0") },
                    { new Guid("cf42a7d8-41e9-4b99-ae58-06be48691245"), 1, 1, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("8db3a69a-e938-400a-b99b-1be55722a816") },
                    { new Guid("d056ff83-d7de-497e-bce0-e9bec270328c"), 4, 4, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("a41f1d35-7849-47d8-9122-feebed9f0af2") },
                    { new Guid("d15e23d8-70a9-424d-8894-139e0c1d96cf"), 2, 2, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("79551927-0e12-4f75-9806-98d4f76ccc2f") },
                    { new Guid("d2a984f1-ee53-4997-827e-917e34a47780"), 4, 4, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("cb30ad96-44a2-4f05-9134-e891eb55177f") },
                    { new Guid("d364cfc4-3a15-4d39-a31f-663f5ba95a37"), 1, 1, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("ea378932-757c-46eb-a9b7-074379b6c130") },
                    { new Guid("d453eb12-334d-4543-b3f8-2a43ce42583b"), 3, 3, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("92701ba7-6787-44b2-ab2b-364e75f85730") },
                    { new Guid("d4d6d824-48a0-4fbf-97f2-e41216ceab73"), 1, 1, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("75c5cd05-a06a-40ec-80bb-0d370ccd7327") },
                    { new Guid("d54bbfe3-7c60-4bb6-9d57-81cb3bc36336"), 2, 2, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("1a024e28-3060-4d23-9c41-b5960c894f8f") },
                    { new Guid("d86f6104-ab95-46af-a813-2c9702b7d8d0"), 3, 3, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("c46a33c4-5aa5-4d99-83e8-6d266d94fe51") },
                    { new Guid("d94730d3-ba34-48f3-bd1c-6a54704cd3b3"), 2, 2, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("1263221d-1089-46de-8072-5a7841fb7ef2") },
                    { new Guid("da2a6a49-cce3-4998-b0ac-5343618cd190"), 1, 1, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("03e3c78c-343b-4836-bae3-207f9436ba17") },
                    { new Guid("dd1a1f3a-6d59-4435-82bf-2fbc4cd42088"), 2, 2, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("60104d45-1f95-47f7-ad6c-abbcfa3c5c5f") },
                    { new Guid("ddc74259-df26-462f-b964-a6de5e858f53"), 2, 2, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("664efd94-8791-47e0-93f5-a90471a719ce") },
                    { new Guid("df770a8f-3132-4e57-a590-059b45c738ec"), 4, 4, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("4949b9c4-d8a1-4cf0-a875-5b52ae94ff91") },
                    { new Guid("df8c3c64-218f-42f0-81d9-c62875ebb4c3"), 1, 1, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("293f5ab3-f6a3-4456-9f07-0f4d4d879b17") },
                    { new Guid("dff72f35-b429-4bcb-ba3a-77d0a887b273"), 1, 1, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("63c3b25f-c73e-4738-8d85-1e945ae8cea3") },
                    { new Guid("e048a3cb-f957-44b3-bdfb-a6f4eb906cc9"), 2, 2, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("f5af0699-4280-4c91-a8d7-05873ed37854") },
                    { new Guid("e6f76fa2-25f8-476f-ae63-6b01c8996e67"), 2, 2, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("ea378932-757c-46eb-a9b7-074379b6c130") },
                    { new Guid("e81966ed-cb11-45ba-919a-241e22951d60"), 3, 3, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("f77269e4-005e-41bb-bb4f-6f0c3bc07c78") },
                    { new Guid("e8756169-ea27-4acb-bf40-aa6af23a9309"), 3, 3, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("0f0c2db7-0760-4b68-a7ea-92ab8f02087b") },
                    { new Guid("eb6187f4-4843-40c0-bbd1-8eda692b217d"), 1, 1, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("f8e81dcb-ed4a-4456-91a8-5c0e922dff41") },
                    { new Guid("ec2547e3-7df8-403d-a226-5368c2a225f1"), 3, 2, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("1263221d-1089-46de-8072-5a7841fb7ef2") },
                    { new Guid("ed7cba61-5d7a-4513-9195-082e72afaf3b"), 3, 1, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("f8e81dcb-ed4a-4456-91a8-5c0e922dff41") },
                    { new Guid("ed8df2ca-0f1f-45cd-a737-fbdfa0b8b600"), 2, 2, new Guid("38792418-a30d-483c-843c-3a072addabbc"), new Guid("0f0c2db7-0760-4b68-a7ea-92ab8f02087b") },
                    { new Guid("ee4d0c3e-9dbb-4f7a-a18f-c0d149050005"), 1, 4, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("ea378932-757c-46eb-a9b7-074379b6c130") },
                    { new Guid("f05446e2-750e-4dfb-ae64-5e3d49abd266"), 4, 4, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("0f0c2db7-0760-4b68-a7ea-92ab8f02087b") },
                    { new Guid("f11cafd9-1dab-4520-acf4-beb721951e11"), 3, 3, new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"), new Guid("f5af0699-4280-4c91-a8d7-05873ed37854") },
                    { new Guid("f1d7db20-64d2-407b-894c-47c489abaa27"), 1, 1, new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"), new Guid("735de6ab-bfd8-40c5-abd1-7706600bf428") },
                    { new Guid("f79f16c7-0aa5-4d84-9ef9-c4528cd16e00"), 4, 3, new Guid("accf4824-a50e-4122-9777-a826c75288f4"), new Guid("acf42373-049d-4b01-b60b-2ff4821f3991") },
                    { new Guid("f8eeabfa-1f3d-4e9a-a77f-5a9474c1568b"), 1, 1, new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"), new Guid("07fe95f1-306c-42bc-a497-0f4975e86099") },
                    { new Guid("fb82ec05-81aa-45c2-9cb3-ed1d7cdfcae7"), 4, 4, new Guid("c526cd14-b087-4a47-b311-810d99134cd2"), new Guid("acf42373-049d-4b01-b60b-2ff4821f3991") },
                    { new Guid("ff3b04cb-64d3-453e-be0b-621b8e0140dc"), 2, 3, new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"), new Guid("4949b9c4-d8a1-4cf0-a875-5b52ae94ff91") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Floors_BuildingId",
                table: "Floors",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomAssignment_RoomId",
                table: "RoomAssignment",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomInventories_InventoryItemId",
                table: "RoomInventories",
                column: "InventoryItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomInventories_RoomId",
                table: "RoomInventories",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_FloorId",
                table: "Rooms",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_RoomAssignmentId",
                table: "Student",
                column: "RoomAssignmentId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomInventories");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "InventoryItems");

            migrationBuilder.DropTable(
                name: "RoomAssignment");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "Buildings");
        }
    }
}

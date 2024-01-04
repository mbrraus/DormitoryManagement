using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DormitoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class demo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_RoomAssignment_RoomAssignmentId",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("02712cb9-a446-440d-8b1e-0bcb169025cf"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("02b857ef-8951-4afe-8a45-f497c7e82ea2"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("02c32697-0203-4dd4-af1f-86b6aef7eac2"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0348f3b3-ec82-468f-8a40-ad65ba1546a9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("04e18ddd-9575-41c3-960c-a99b60c566e4"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("06993abc-f971-41fd-a999-3b971751dc92"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0af7b0b8-69ef-4897-8782-95adc692dfac"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0dcaec02-180e-4bec-86b3-c4d034d82e7f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0eb12141-fcd7-4c91-abf8-4fe7b5d65300"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("131813ac-bfd5-435a-8e4b-9d7efe8fb8f1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("151fdb39-6ec8-4495-8c71-26435c412473"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1620f68e-d975-404d-aa15-cf3c167dfe47"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("18779bb3-ba10-4a5c-a50e-b1e71e9a0b8b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1a9c4085-e112-41bb-a4f4-dabf397cac6c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1b0db42e-0a20-4bd3-8647-5574f6b91071"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1eaed6e5-091a-4a3e-98fe-e8e1e7291b1e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1ebcab0e-4eb7-4f3f-b20c-f298f1e312c5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("20390396-6dfd-40f3-ba9b-0bad66a9e217"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("204ed047-4234-4f3d-bc34-1c59414d1560"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2133fad8-4275-4549-999d-0dfa5b039411"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2178f6ff-e942-46a8-974e-1d4133bda5f8"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("24367077-3967-45ec-93ac-fed749514441"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("25d5e69d-cca2-44ec-80bd-103c7d63aa5f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("26c8cd6a-abd5-448a-b3c9-ed1e84c18085"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2746e348-f3ad-431b-a971-dd3f9d5108fa"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2817b1c9-0317-44f8-9933-a6fdf413a182"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("284eaf12-adb7-41b5-85d6-5bc9fdbb3349"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("285b8b20-25da-4328-acc7-2f69473e304a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2a46e0ba-44e7-40df-8595-bd62acb261d3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2b84507b-fc13-4a83-82ac-b793bc4b0d19"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2cbd6f57-f275-442a-8ccc-fb1f0ecab6cd"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2f313ab4-77d1-4464-94c1-28538b37e9dc"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3006ad14-2617-427a-9f92-3d96d9125d0f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("31bb1106-50e5-48c0-be53-f8b1b2f74765"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("33d952a0-1fba-455f-ba10-aa7ee367e7b9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("34635b16-7c33-4749-9613-bd94edc1d27a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("35f279fe-b6f7-40a2-8eb8-da3a981dec50"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("363456f2-09a1-4a67-b080-eaef5466c10f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("381c302c-8e7c-4555-aba9-7a661b0c4045"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("385386df-05b3-48d8-a177-681f1726651a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("39639cea-e888-4247-a883-0b1bfbd90f1f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("39bfd570-a6d9-4b02-bd39-68048b5c611f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3d2dddf1-55af-4a42-965f-5e5487fdff21"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3d461496-ea35-464c-9d2a-48e8fde67775"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3d83b701-341f-46fb-94fd-79d9556b06c0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3f4c7215-9149-4c42-a99c-5020bbf593ba"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4010ea4f-f6f2-4379-b015-549d464054b1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("41de6083-cf03-40d4-b9d4-547300749280"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("42e89444-fbca-4671-9633-a7c9cb1a1fc5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("46d50dd8-4429-41fb-814d-5e84d9f6b9dc"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("48db5631-18c4-401b-8422-e50ed68c1e6a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("49d40226-c63e-490b-9067-def030cbb7d6"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4a382dac-7b30-4f31-9ed1-0b0cba42a6c0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4c69c086-dada-4ec4-8cd7-fb4e5d208f2f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4d4ca555-c078-4b31-9dae-f80f23cf0b02"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4dbef848-e038-4ff5-a9aa-a0c2eb16e7db"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4de8b394-1996-480b-8f80-4fdf553f0ab5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4de9c99d-84c5-4cf1-95ee-975843e74b22"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4e9e314f-1c91-45fc-aff8-fac1bfcb862c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4f368605-0738-4c9c-8518-7d3a4eea7256"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4f5e7a6f-820d-4455-8e89-fda01a784eee"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("55eaa2a4-db6c-4e06-969e-450ed88fc4ab"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("562e4b15-c4fd-4567-8376-f15c47363900"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("564ec9fe-44ee-4d9a-92be-db9178bc06e5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("572d7584-44f6-4286-80f9-aa2ddf5fad4f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("590f3876-7e85-49ae-a006-3d069ac2104e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5c7fb7c7-824d-41e8-b20f-9bc266b2141e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("648de209-d9be-4478-8754-8170580ee220"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6508bb62-ed6c-4134-a0ce-47803aa35a7d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("67d5a34b-540e-47e5-a265-e75997d367f0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("67f59894-2845-4a23-9b53-afdc0f9be685"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6f310106-f822-43b1-8bfc-2d847c2178ae"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6f8b3329-f493-437e-a049-eb40f806decc"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("736fcf56-1abc-48ef-a469-f8a48fc29947"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("737f4005-68c7-42f0-b92c-c09e419f8032"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("79bc7164-aceb-49c0-81f6-5eb75f05bc21"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7c7b58d1-ae43-4ec8-821d-18d167c77368"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7ed0e6cb-d9d0-4f61-a875-b18d66a86e5a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("802fde50-18cf-4147-ba91-b11d5b24ba64"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8144e92a-d43a-47e2-bd3c-73a46c5c62b5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8253f096-938f-48f9-a9b7-23150805329e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8319ec5a-2f68-44ed-8d36-3e94fef5bcd2"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("852000a5-37a9-4fbe-8db6-7a731565bf95"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("86449c79-fe45-4df9-a064-2260d9c64b7e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("87086ef7-5cae-4ad6-b5a0-daed009f602c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8851d3bd-55e7-4e55-a532-02ff9884153f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("889ef833-82bd-4084-b76c-cbe2eda480a5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("88c3ed9f-ec98-4463-963e-28de85ca6c75"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8dd1face-723d-4dea-96df-22e912a493cf"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8e0e10a8-9e54-4a74-9ceb-686e2a6b261d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8ff00f11-b653-43f7-8d36-9a7b89cdcc8b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9027e127-ed98-458a-8fda-cc2b8f4e1176"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("92299cbd-e4c5-4846-8894-cb117f12c6d4"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9286580d-e8a1-4e55-85c1-e98690268d76"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9763326d-fec1-4da3-974b-a320af57059e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("97a08d5e-3dd8-4f96-a965-d6f52cb99394"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9afd5e35-b02e-41be-9777-e45947887bd8"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9be7e501-d727-4e08-b450-07c9692c7fa7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9c560e92-f895-4d46-abf1-1b82ff02e04f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9d83f37f-0c88-4faa-b7e7-8533da8d2640"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a0362abe-4600-4969-b278-05dc82ee57ea"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a06b2bca-9ab8-44b0-9cc5-d797c4692d32"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a113e2bf-0019-4984-9076-84e9f2200639"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a575eb48-ea53-4eee-893e-6fc1a61a4feb"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a73c8147-1f42-4bbe-9b40-43c57f66cc17"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a7c474ab-1b5c-4819-ac59-256b90742493"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a85238dd-50d5-4ae5-9cd3-a242fb549f75"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ac94c1e4-c154-407e-88ee-93c7bc0d8fd9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ae1fa8f7-9cc3-43f1-b7eb-492fabadb8ae"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("aeaaf621-de28-40cf-a908-5c44eceaf4dc"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("aeda9529-9d87-4f65-ac24-fc1aa84d7d80"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("afb3a7f7-ca11-41b7-bdae-872ce3a4fe19"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b18d39e6-bd34-49e4-bcbf-b997be561849"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b1f248fc-6142-42d1-bbde-051d638ddc10"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b38479d7-2dc8-40ae-9d65-adbf2bc29c74"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b4703892-5401-48de-9304-45277f0cc38e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b67dd910-3f7b-4801-b311-e5572cd8b2ce"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b6bdf50a-5529-4cdd-a7b5-7992c49f04dd"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ba5408ca-a75b-4203-a8c8-4b47b63f4326"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("bbc4b289-4d9a-46d8-8eb2-4af2cc660bad"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("bbed5655-5e24-40b6-ad0d-7600218e5abc"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("bcb4e97e-0b3d-41b1-b565-828932ec4fad"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("bcf9eae5-d166-40d7-955d-a308b1d854db"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("beb2e52f-e57b-4d3f-92aa-085060ef9e54"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c0d914ee-f519-44a4-a688-db16414b150b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c2fd2aeb-be88-47a0-b1a9-7036b28cdf66"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c85aaf6c-063b-4ffd-9921-d0bbafa65956"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c967900d-76bd-4889-92a3-b722c002549c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("cbcd1414-197a-4366-9e26-bc90afcb807d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("cc02dc16-4599-4ec3-9d08-0089c6b497c7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ce76abad-12c9-405f-a0f5-817e1ef6383e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ced0a90c-4dfa-4550-b3be-b4454ef3c4e3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("cf42a7d8-41e9-4b99-ae58-06be48691245"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d056ff83-d7de-497e-bce0-e9bec270328c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d15e23d8-70a9-424d-8894-139e0c1d96cf"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d2a984f1-ee53-4997-827e-917e34a47780"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d364cfc4-3a15-4d39-a31f-663f5ba95a37"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d453eb12-334d-4543-b3f8-2a43ce42583b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d4d6d824-48a0-4fbf-97f2-e41216ceab73"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d54bbfe3-7c60-4bb6-9d57-81cb3bc36336"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d86f6104-ab95-46af-a813-2c9702b7d8d0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d94730d3-ba34-48f3-bd1c-6a54704cd3b3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("da2a6a49-cce3-4998-b0ac-5343618cd190"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("dd1a1f3a-6d59-4435-82bf-2fbc4cd42088"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ddc74259-df26-462f-b964-a6de5e858f53"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("df770a8f-3132-4e57-a590-059b45c738ec"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("df8c3c64-218f-42f0-81d9-c62875ebb4c3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("dff72f35-b429-4bcb-ba3a-77d0a887b273"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e048a3cb-f957-44b3-bdfb-a6f4eb906cc9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e6f76fa2-25f8-476f-ae63-6b01c8996e67"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e81966ed-cb11-45ba-919a-241e22951d60"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e8756169-ea27-4acb-bf40-aa6af23a9309"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("eb6187f4-4843-40c0-bbd1-8eda692b217d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ec2547e3-7df8-403d-a226-5368c2a225f1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ed7cba61-5d7a-4513-9195-082e72afaf3b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ed8df2ca-0f1f-45cd-a737-fbdfa0b8b600"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ee4d0c3e-9dbb-4f7a-a18f-c0d149050005"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f05446e2-750e-4dfb-ae64-5e3d49abd266"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f11cafd9-1dab-4520-acf4-beb721951e11"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f1d7db20-64d2-407b-894c-47c489abaa27"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f79f16c7-0aa5-4d84-9ef9-c4528cd16e00"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f8eeabfa-1f3d-4e9a-a77f-5a9474c1568b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("fb82ec05-81aa-45c2-9cb3-ed1d7cdfcae7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ff3b04cb-64d3-453e-be0b-621b8e0140dc"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("1d1b397c-0d07-4398-aca7-5c7ea4d2ca12"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("38792418-a30d-483c-843c-3a072addabbc"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("3fa8ac09-db05-4ef5-b341-e003d132dc58"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("436f3b3b-171c-49c9-996a-dd3b29cea176"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("6a9a0f85-fac2-4904-919e-be0d68e0e50a"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("accf4824-a50e-4122-9777-a826c75288f4"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("c526cd14-b087-4a47-b311-810d99134cd2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0174d0fd-fba9-46bf-8eb3-c5152d0eaa38"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("03e3c78c-343b-4836-bae3-207f9436ba17"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("07fe95f1-306c-42bc-a497-0f4975e86099"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("08c722d2-f819-4ef8-9441-fafc536a158a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0d9da574-4fd0-4392-9432-809db6df05f0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0f0c2db7-0760-4b68-a7ea-92ab8f02087b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1263221d-1089-46de-8072-5a7841fb7ef2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1a024e28-3060-4d23-9c41-b5960c894f8f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1fb6e404-0af3-41a6-98c9-f97a8765d299"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("293f5ab3-f6a3-4456-9f07-0f4d4d879b17"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("33e79c0e-5fb2-47a6-9599-e8c0c484c338"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3f3773d4-5437-46dd-8705-ad5c0e7df8aa"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("43b1aadb-ced0-496a-b46a-f54732bf03eb"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4949b9c4-d8a1-4cf0-a875-5b52ae94ff91"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5fb6d4e2-5c3a-4d2c-84b4-61324910820a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("60104d45-1f95-47f7-ad6c-abbcfa3c5c5f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("63c3b25f-c73e-4738-8d85-1e945ae8cea3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("664efd94-8791-47e0-93f5-a90471a719ce"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("735de6ab-bfd8-40c5-abd1-7706600bf428"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("740f9a7a-5fb3-4731-89ac-3a3263b11299"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("75c5cd05-a06a-40ec-80bb-0d370ccd7327"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("79551927-0e12-4f75-9806-98d4f76ccc2f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8db3a69a-e938-400a-b99b-1be55722a816"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("92701ba7-6787-44b2-ab2b-364e75f85730"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a41f1d35-7849-47d8-9122-feebed9f0af2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("aae4ce69-2f3d-4dd8-9380-b1acf986f565"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("acf42373-049d-4b01-b60b-2ff4821f3991"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b379d037-36eb-4a43-a2ad-df02ddd6c0c6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b64f485b-7269-428f-86b6-18644500d0c8"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b9003860-62dd-42f5-b510-760d3e715ac2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c46a33c4-5aa5-4d99-83e8-6d266d94fe51"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c625aac5-d374-4c68-a883-4ee886edb9e4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("cb30ad96-44a2-4f05-9134-e891eb55177f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e62620f7-4612-4b62-98d5-bff192d83494"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ea378932-757c-46eb-a9b7-074379b6c130"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f233b8ba-f83e-4a93-900a-9011f74bf290"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f5af0699-4280-4c91-a8d7-05873ed37854"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f77269e4-005e-41bb-bb4f-6f0c3bc07c78"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f8e81dcb-ed4a-4456-91a8-5c0e922dff41"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fddd9a83-f51d-4880-a4a0-79a97671b538"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("1e629824-4318-4c1d-ac46-a4b616e97ccd"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("2fdc137e-b97f-4679-b96b-1fda9e269e99"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("bf782ef9-b684-4d86-bd26-e8ed93e93971"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("e1585c2a-02e5-44c7-b86a-ee43e173593e"));

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("55d39593-b0da-4387-a0c9-bb2fe455efec"));

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("dcf76e4f-d322-44c0-bb5b-ceb43ab333dd"));

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameIndex(
                name: "IX_Student_RoomAssignmentId",
                table: "Students",
                newName: "IX_Students_RoomAssignmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("33ae80c6-7fc0-42ab-a76b-3cacb05ba055"), "Building B" },
                    { new Guid("501fec76-5f58-4c51-8139-fd588281c5ba"), "Building A" }
                });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), "Curtains" },
                    { new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), "Lamp" },
                    { new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), "Chair" },
                    { new Guid("a1662135-3952-4708-80ef-51d55f021e83"), "Desk" },
                    { new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), "Bookshelf" },
                    { new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), "Bed" },
                    { new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), "Wardrobe" }
                });

            migrationBuilder.InsertData(
                table: "Floors",
                columns: new[] { "Id", "BuildingId", "Number" },
                values: new object[,]
                {
                    { new Guid("116ddfeb-c97a-4722-9be2-ff66809f280a"), new Guid("501fec76-5f58-4c51-8139-fd588281c5ba"), 2 },
                    { new Guid("c6f65bed-0026-419d-be86-1aa857feea05"), new Guid("33ae80c6-7fc0-42ab-a76b-3cacb05ba055"), 2 },
                    { new Guid("d066ad2c-2296-4af8-be7f-8a24c9ec3ec0"), new Guid("501fec76-5f58-4c51-8139-fd588281c5ba"), 1 },
                    { new Guid("f6cf68c4-f88a-4c7f-9d11-2f814e86d74d"), new Guid("33ae80c6-7fc0-42ab-a76b-3cacb05ba055"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "AllowedPersons", "FloorId", "Number" },
                values: new object[,]
                {
                    { new Guid("03e28d8f-b005-4c02-b5df-c9cf7b22f6a0"), 4, new Guid("f6cf68c4-f88a-4c7f-9d11-2f814e86d74d"), "B1-10" },
                    { new Guid("0581bcb6-74ff-4cec-b635-8c2795e9a619"), 5, new Guid("f6cf68c4-f88a-4c7f-9d11-2f814e86d74d"), "B1-08" },
                    { new Guid("1ede5936-8fb6-44ab-a3bb-07e93373a938"), 5, new Guid("116ddfeb-c97a-4722-9be2-ff66809f280a"), "A2-07" },
                    { new Guid("21a83ab6-5db5-4c6a-995a-2626ce50125f"), 5, new Guid("116ddfeb-c97a-4722-9be2-ff66809f280a"), "A2-02" },
                    { new Guid("2686f8bb-a9ac-49b7-8346-0a9cc4312437"), 5, new Guid("d066ad2c-2296-4af8-be7f-8a24c9ec3ec0"), "A1-05" },
                    { new Guid("28d63794-5d9d-43f2-8e77-223c4954b40a"), 5, new Guid("d066ad2c-2296-4af8-be7f-8a24c9ec3ec0"), "A1-03" },
                    { new Guid("2b50d070-d2fe-4d59-9b1f-39c8fb5f4c1d"), 4, new Guid("f6cf68c4-f88a-4c7f-9d11-2f814e86d74d"), "B1-06" },
                    { new Guid("329aae01-ea68-44a6-8f3f-f1b3cd2c94f6"), 5, new Guid("f6cf68c4-f88a-4c7f-9d11-2f814e86d74d"), "B1-02" },
                    { new Guid("3778b172-9034-4352-afe4-0bf484f64a38"), 3, new Guid("116ddfeb-c97a-4722-9be2-ff66809f280a"), "A2-01" },
                    { new Guid("3eb80019-24d9-4d16-860f-0e187d8ebab3"), 3, new Guid("c6f65bed-0026-419d-be86-1aa857feea05"), "B2-04" },
                    { new Guid("44116861-9320-48d0-983a-ebc34d7db63a"), 3, new Guid("c6f65bed-0026-419d-be86-1aa857feea05"), "B2-07" },
                    { new Guid("47d56599-0983-4095-90a0-39da96a977d8"), 3, new Guid("116ddfeb-c97a-4722-9be2-ff66809f280a"), "A2-08" },
                    { new Guid("4944ad1e-d391-4630-b3c1-394a814f81cd"), 4, new Guid("f6cf68c4-f88a-4c7f-9d11-2f814e86d74d"), "B1-05" },
                    { new Guid("4c365784-45a9-45e9-af48-32486ce91d10"), 5, new Guid("116ddfeb-c97a-4722-9be2-ff66809f280a"), "A2-04" },
                    { new Guid("506cde12-375b-4c98-add8-a9c556c0cd43"), 5, new Guid("116ddfeb-c97a-4722-9be2-ff66809f280a"), "A2-03" },
                    { new Guid("539c44f4-db08-4194-909c-8431bdf84d70"), 4, new Guid("f6cf68c4-f88a-4c7f-9d11-2f814e86d74d"), "B1-03" },
                    { new Guid("626d2c60-3159-46ac-917f-5d472625ba9a"), 4, new Guid("d066ad2c-2296-4af8-be7f-8a24c9ec3ec0"), "A1-09" },
                    { new Guid("7893f9e2-6e8c-4c03-88d1-689ce811870e"), 3, new Guid("f6cf68c4-f88a-4c7f-9d11-2f814e86d74d"), "B1-07" },
                    { new Guid("89fa7d8e-3bf3-457a-9e92-19a900c518e6"), 4, new Guid("c6f65bed-0026-419d-be86-1aa857feea05"), "B2-02" },
                    { new Guid("9095fc58-5eb4-4fea-b82b-14ac4a15f582"), 5, new Guid("c6f65bed-0026-419d-be86-1aa857feea05"), "B2-03" },
                    { new Guid("92f25636-7747-45d6-93c3-8f3a2ea0b363"), 5, new Guid("f6cf68c4-f88a-4c7f-9d11-2f814e86d74d"), "B1-01" },
                    { new Guid("9782e598-14fa-4015-8be8-63d28b875535"), 5, new Guid("d066ad2c-2296-4af8-be7f-8a24c9ec3ec0"), "A1-06" },
                    { new Guid("9be26fc3-4b33-4695-9e0b-2e755e923c47"), 5, new Guid("116ddfeb-c97a-4722-9be2-ff66809f280a"), "A2-06" },
                    { new Guid("a002fa36-6fc9-4f72-ade2-7368b26f407d"), 5, new Guid("116ddfeb-c97a-4722-9be2-ff66809f280a"), "A2-05" },
                    { new Guid("af1ed84f-3c79-4f9d-9180-92df4137f4f3"), 5, new Guid("116ddfeb-c97a-4722-9be2-ff66809f280a"), "A2-10" },
                    { new Guid("b00c9f29-b75d-4cee-b2e9-203ecb31a6dc"), 4, new Guid("d066ad2c-2296-4af8-be7f-8a24c9ec3ec0"), "A1-01" },
                    { new Guid("b0fb1578-7877-4e78-8f5b-954a48aab2a7"), 4, new Guid("c6f65bed-0026-419d-be86-1aa857feea05"), "B2-05" },
                    { new Guid("b62d8ba8-2358-42ad-b651-e26c86bca8d8"), 5, new Guid("d066ad2c-2296-4af8-be7f-8a24c9ec3ec0"), "A1-02" },
                    { new Guid("b7995c37-ce6a-4358-8768-535d5e783952"), 5, new Guid("c6f65bed-0026-419d-be86-1aa857feea05"), "B2-01" },
                    { new Guid("beb459cd-e0db-4bbc-b0a6-e2dda75b22b3"), 3, new Guid("d066ad2c-2296-4af8-be7f-8a24c9ec3ec0"), "A1-07" },
                    { new Guid("c3d4fd42-aa0f-4bb9-82d9-f64f050d2171"), 4, new Guid("d066ad2c-2296-4af8-be7f-8a24c9ec3ec0"), "A1-08" },
                    { new Guid("ce1a5122-32dd-401c-ad6b-6bdd8d21784e"), 5, new Guid("d066ad2c-2296-4af8-be7f-8a24c9ec3ec0"), "A1-10" },
                    { new Guid("dab16462-6f16-4c73-9912-da66898f6a69"), 3, new Guid("f6cf68c4-f88a-4c7f-9d11-2f814e86d74d"), "B1-04" },
                    { new Guid("dad5f61c-cd47-435b-83c0-cac876c20048"), 5, new Guid("c6f65bed-0026-419d-be86-1aa857feea05"), "B2-10" },
                    { new Guid("dd40ea07-4759-47b1-96e5-150d82b398d6"), 3, new Guid("f6cf68c4-f88a-4c7f-9d11-2f814e86d74d"), "B1-09" },
                    { new Guid("e4da7945-5ce6-47e9-8425-705727fed8d2"), 4, new Guid("c6f65bed-0026-419d-be86-1aa857feea05"), "B2-06" },
                    { new Guid("f22cb64e-150c-4b9c-8da1-64a2bac43648"), 4, new Guid("116ddfeb-c97a-4722-9be2-ff66809f280a"), "A2-09" },
                    { new Guid("f7b60c6a-2e0c-49bf-9b4f-5c1c9bdddc83"), 4, new Guid("d066ad2c-2296-4af8-be7f-8a24c9ec3ec0"), "A1-04" },
                    { new Guid("f8374008-ab25-48a2-871f-252942d45ea6"), 3, new Guid("c6f65bed-0026-419d-be86-1aa857feea05"), "B2-08" },
                    { new Guid("fc6a598b-cd61-40ca-bd2a-2bad81868b82"), 3, new Guid("c6f65bed-0026-419d-be86-1aa857feea05"), "B2-09" }
                });

            migrationBuilder.InsertData(
                table: "RoomInventories",
                columns: new[] { "Id", "ActualQuantity", "ExpectedQuantity", "InventoryItemId", "RoomId" },
                values: new object[,]
                {
                    { new Guid("0015e953-052f-47f4-bc85-fa6558ef72c1"), 1, 4, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("af1ed84f-3c79-4f9d-9180-92df4137f4f3") },
                    { new Guid("02fe91f9-c0f8-4101-82cf-ba98b0e5b0b0"), 4, 4, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("a002fa36-6fc9-4f72-ade2-7368b26f407d") },
                    { new Guid("062de862-c545-48f7-84cd-4db196d802d6"), 4, 4, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("03e28d8f-b005-4c02-b5df-c9cf7b22f6a0") },
                    { new Guid("094e2dbc-9cbe-4596-aba8-cb0bcdb0e412"), 3, 4, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("1ede5936-8fb6-44ab-a3bb-07e93373a938") },
                    { new Guid("0bcb3d01-b8d1-4b6d-86fd-88fb6229f94c"), 2, 2, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("89fa7d8e-3bf3-457a-9e92-19a900c518e6") },
                    { new Guid("0d77fd07-1cf9-4aca-89a8-8bcbb6113ea6"), 4, 4, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("47d56599-0983-4095-90a0-39da96a977d8") },
                    { new Guid("0ec3466a-a916-4bc7-a2ee-1d74a7f25c4b"), 4, 4, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("c3d4fd42-aa0f-4bb9-82d9-f64f050d2171") },
                    { new Guid("1000480b-6940-4658-b1c7-32ec71c58217"), 1, 3, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("3eb80019-24d9-4d16-860f-0e187d8ebab3") },
                    { new Guid("14384f83-919a-4a03-b923-3f5d794cbf58"), 1, 1, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("b0fb1578-7877-4e78-8f5b-954a48aab2a7") },
                    { new Guid("18f05beb-6946-49b8-a2a8-7fcd60f2c1f8"), 2, 2, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("0581bcb6-74ff-4cec-b635-8c2795e9a619") },
                    { new Guid("19a8ed80-81e3-4de0-89d3-eb9189b93984"), 3, 3, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("f7b60c6a-2e0c-49bf-9b4f-5c1c9bdddc83") },
                    { new Guid("1c352896-4563-4167-884c-81e93e9611c8"), 2, 2, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("539c44f4-db08-4194-909c-8431bdf84d70") },
                    { new Guid("1c49fc8d-7ec1-4e92-b8c3-ebe3fc6e903c"), 1, 1, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("9be26fc3-4b33-4695-9e0b-2e755e923c47") },
                    { new Guid("2433be9d-88f6-4e9a-89b4-5b1d321e53d5"), 4, 1, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("dd40ea07-4759-47b1-96e5-150d82b398d6") },
                    { new Guid("257a3afa-33ad-4708-8f39-b2531f3bb475"), 1, 1, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("4944ad1e-d391-4630-b3c1-394a814f81cd") },
                    { new Guid("258dbe00-635f-495f-8942-ad5b35cff8af"), 3, 3, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("b0fb1578-7877-4e78-8f5b-954a48aab2a7") },
                    { new Guid("26c3534f-9a6a-43b4-90a7-231b658817a7"), 2, 4, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("f8374008-ab25-48a2-871f-252942d45ea6") },
                    { new Guid("277257c0-9574-4acb-9112-d47b3e14347a"), 4, 4, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("ce1a5122-32dd-401c-ad6b-6bdd8d21784e") },
                    { new Guid("2915733e-16fb-4684-974a-b13a7432ca98"), 2, 2, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("3778b172-9034-4352-afe4-0bf484f64a38") },
                    { new Guid("29552aa1-a0fd-43ca-9866-695f03bc9c76"), 2, 2, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("dad5f61c-cd47-435b-83c0-cac876c20048") },
                    { new Guid("2a330599-8978-463b-8e82-36839c4887c3"), 3, 3, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("9be26fc3-4b33-4695-9e0b-2e755e923c47") },
                    { new Guid("2cda3a75-2932-40e3-b27f-848a42eec2aa"), 2, 2, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("28d63794-5d9d-43f2-8e77-223c4954b40a") },
                    { new Guid("2e9d7f0f-1343-4eee-9f31-368ccb8d6c5b"), 2, 4, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("506cde12-375b-4c98-add8-a9c556c0cd43") },
                    { new Guid("30152919-6bb6-4fd0-98c6-bc9ee9544dab"), 1, 1, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("3778b172-9034-4352-afe4-0bf484f64a38") },
                    { new Guid("3261a97e-964c-4914-9049-552f4ad37703"), 1, 1, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("47d56599-0983-4095-90a0-39da96a977d8") },
                    { new Guid("3263004e-353b-459b-82b8-c2e4336f4e84"), 2, 2, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("28d63794-5d9d-43f2-8e77-223c4954b40a") },
                    { new Guid("3598d902-912b-48f8-9006-7cd727ed2ee5"), 2, 2, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("9be26fc3-4b33-4695-9e0b-2e755e923c47") },
                    { new Guid("35c33383-3faa-485f-80c6-f88d9ed0f6ce"), 2, 2, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("f22cb64e-150c-4b9c-8da1-64a2bac43648") },
                    { new Guid("35e8a50a-008c-410e-bc7a-331cc8f349cb"), 3, 3, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("44116861-9320-48d0-983a-ebc34d7db63a") },
                    { new Guid("376423b4-de23-4496-abf3-ebfa097c5cf3"), 4, 1, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("506cde12-375b-4c98-add8-a9c556c0cd43") },
                    { new Guid("382b6b6e-6b48-4392-9b23-5e038f5c441a"), 2, 2, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("b7995c37-ce6a-4358-8768-535d5e783952") },
                    { new Guid("3af0cb73-b650-412f-a932-67e109dbf811"), 4, 1, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("b00c9f29-b75d-4cee-b2e9-203ecb31a6dc") },
                    { new Guid("3d0c333a-dade-4a16-b658-b08e33372bd5"), 4, 4, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("e4da7945-5ce6-47e9-8425-705727fed8d2") },
                    { new Guid("3dbef502-b762-4daa-a909-8fa9c7fffbc2"), 2, 2, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("dd40ea07-4759-47b1-96e5-150d82b398d6") },
                    { new Guid("3fe6b4bb-3362-4204-ba2b-4fc04d94e31c"), 1, 3, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("3eb80019-24d9-4d16-860f-0e187d8ebab3") },
                    { new Guid("41b338ad-4248-417b-8360-51d0241b086a"), 4, 4, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("44116861-9320-48d0-983a-ebc34d7db63a") },
                    { new Guid("453a5846-08d6-46df-86d2-3e8557e3701d"), 2, 2, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("b62d8ba8-2358-42ad-b651-e26c86bca8d8") },
                    { new Guid("4a02a3d4-59a8-4152-926b-dbde361dc12d"), 2, 2, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("1ede5936-8fb6-44ab-a3bb-07e93373a938") },
                    { new Guid("4a9d37f9-5c73-4f12-a1cc-6243d3a0146c"), 4, 4, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("b00c9f29-b75d-4cee-b2e9-203ecb31a6dc") },
                    { new Guid("4e2dafc0-9169-4344-b466-7b09eb5c4ea0"), 1, 1, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("89fa7d8e-3bf3-457a-9e92-19a900c518e6") },
                    { new Guid("4e92d905-876c-4e03-abfc-381deee26c3e"), 1, 2, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("ce1a5122-32dd-401c-ad6b-6bdd8d21784e") },
                    { new Guid("4fbae7a6-f4b0-440a-98c2-a112168ca436"), 4, 4, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("3eb80019-24d9-4d16-860f-0e187d8ebab3") },
                    { new Guid("54cbb559-4d5a-4977-998d-01273e4c2e43"), 1, 1, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("4944ad1e-d391-4630-b3c1-394a814f81cd") },
                    { new Guid("55ae6656-28e7-4495-b6a0-e975957c8bed"), 3, 3, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("1ede5936-8fb6-44ab-a3bb-07e93373a938") },
                    { new Guid("56a1522d-8da9-4aad-99d7-58474be4c428"), 1, 1, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("c3d4fd42-aa0f-4bb9-82d9-f64f050d2171") },
                    { new Guid("57553f02-d667-47f0-8239-0f61468a6f02"), 4, 4, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("dab16462-6f16-4c73-9912-da66898f6a69") },
                    { new Guid("5afbd348-81d1-4408-bdbc-b5ea7a988272"), 4, 4, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("21a83ab6-5db5-4c6a-995a-2626ce50125f") },
                    { new Guid("5c0d63dc-ca87-42d3-8d3e-bc45e626ef69"), 1, 1, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("89fa7d8e-3bf3-457a-9e92-19a900c518e6") },
                    { new Guid("5d39a319-1d0e-412d-9757-97b322b18946"), 2, 2, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("1ede5936-8fb6-44ab-a3bb-07e93373a938") },
                    { new Guid("5ea691b9-8416-46ef-b3fe-61d23e92f9ad"), 4, 4, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("b7995c37-ce6a-4358-8768-535d5e783952") },
                    { new Guid("60017302-7a2b-4d66-8b37-c5b4db4cd6ac"), 1, 1, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("28d63794-5d9d-43f2-8e77-223c4954b40a") },
                    { new Guid("642904e9-e39d-4dd7-bca2-2c0ced90b11f"), 3, 3, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("1ede5936-8fb6-44ab-a3bb-07e93373a938") },
                    { new Guid("65a8547b-bf5f-46ed-855f-2e1ea6ccd7d6"), 2, 2, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("3778b172-9034-4352-afe4-0bf484f64a38") },
                    { new Guid("65eb320b-75c0-41ba-b067-f1950ae9defa"), 3, 3, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("9095fc58-5eb4-4fea-b82b-14ac4a15f582") },
                    { new Guid("66893851-581d-47a3-ae8b-5b00f96c0ed6"), 2, 2, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("9782e598-14fa-4015-8be8-63d28b875535") },
                    { new Guid("670137f0-18d3-4631-a50c-1ad6c3afe831"), 4, 2, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("fc6a598b-cd61-40ca-bd2a-2bad81868b82") },
                    { new Guid("688d0f98-d714-442b-a82b-157366979b9e"), 3, 3, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("0581bcb6-74ff-4cec-b635-8c2795e9a619") },
                    { new Guid("69195ed7-4b73-4ce8-a339-508ad13a5d7d"), 4, 4, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("b7995c37-ce6a-4358-8768-535d5e783952") },
                    { new Guid("6943f260-c7f3-470d-b379-48424d8769fa"), 1, 2, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("329aae01-ea68-44a6-8f3f-f1b3cd2c94f6") },
                    { new Guid("69553340-01bc-42f4-a988-60b240d456e6"), 2, 2, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("539c44f4-db08-4194-909c-8431bdf84d70") },
                    { new Guid("6ae5fe73-9f64-4064-83ef-e420598395ff"), 3, 3, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("f8374008-ab25-48a2-871f-252942d45ea6") },
                    { new Guid("6bc7f7a0-6765-4b3c-a1bc-582b9668f3f7"), 1, 1, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("af1ed84f-3c79-4f9d-9180-92df4137f4f3") },
                    { new Guid("713ab835-a123-424c-ada7-99d9e2c34669"), 3, 3, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("beb459cd-e0db-4bbc-b0a6-e2dda75b22b3") },
                    { new Guid("71b34b9b-d0fb-4f6b-bd14-28627869d0f3"), 1, 1, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("506cde12-375b-4c98-add8-a9c556c0cd43") },
                    { new Guid("72cdab94-1227-49d5-abd5-b4ce379d9750"), 1, 1, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("dad5f61c-cd47-435b-83c0-cac876c20048") },
                    { new Guid("7471a456-2e64-4dfd-8d3b-072adcc28baa"), 2, 2, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("a002fa36-6fc9-4f72-ade2-7368b26f407d") },
                    { new Guid("76ddfb79-735a-4c86-a1e5-5890108472ee"), 4, 4, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("b7995c37-ce6a-4358-8768-535d5e783952") },
                    { new Guid("77e7e70c-793a-42a1-8ac5-b4daad32621a"), 1, 1, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("9782e598-14fa-4015-8be8-63d28b875535") },
                    { new Guid("78f7f43d-2324-46d0-86d6-6d62e3bfec74"), 4, 4, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("2686f8bb-a9ac-49b7-8346-0a9cc4312437") },
                    { new Guid("795ef5a5-05ed-416d-84e0-e90b9b36cae5"), 1, 1, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("dd40ea07-4759-47b1-96e5-150d82b398d6") },
                    { new Guid("7f877a0f-e4cc-4068-a2b7-1463336abfec"), 1, 1, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("2b50d070-d2fe-4d59-9b1f-39c8fb5f4c1d") },
                    { new Guid("7faec89d-e34a-41a8-a097-9bcedd96a31a"), 3, 3, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("beb459cd-e0db-4bbc-b0a6-e2dda75b22b3") },
                    { new Guid("8293c7ef-bed4-4c3a-a1bb-040228468c4c"), 2, 2, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("44116861-9320-48d0-983a-ebc34d7db63a") },
                    { new Guid("82c9c19a-e442-4a23-a60a-068fcb8ace8a"), 4, 4, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("506cde12-375b-4c98-add8-a9c556c0cd43") },
                    { new Guid("84547cfa-ba96-4801-ba58-556e03169293"), 1, 1, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("b62d8ba8-2358-42ad-b651-e26c86bca8d8") },
                    { new Guid("84862751-c5b1-4417-aea9-f1f29007957f"), 2, 2, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("92f25636-7747-45d6-93c3-8f3a2ea0b363") },
                    { new Guid("8575d05f-5a4c-4e6a-ba25-5c534b2777e3"), 3, 3, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("b00c9f29-b75d-4cee-b2e9-203ecb31a6dc") },
                    { new Guid("8716d581-c411-43a0-9cee-1e94900a3cd1"), 3, 3, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("47d56599-0983-4095-90a0-39da96a977d8") },
                    { new Guid("87390588-b6b7-4768-8fc4-7e651730ea25"), 1, 1, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("af1ed84f-3c79-4f9d-9180-92df4137f4f3") },
                    { new Guid("88967749-5edc-4bcb-a9e7-b60db2a613b9"), 2, 2, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("9095fc58-5eb4-4fea-b82b-14ac4a15f582") },
                    { new Guid("88a03f84-e3f3-4b39-a4bd-16714f1292b7"), 1, 1, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("89fa7d8e-3bf3-457a-9e92-19a900c518e6") },
                    { new Guid("89cd54b1-46f8-4b8b-8537-508be725b1a7"), 3, 3, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("4944ad1e-d391-4630-b3c1-394a814f81cd") },
                    { new Guid("8a3642fc-d692-442b-bce9-6e2ef821b41e"), 2, 2, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("92f25636-7747-45d6-93c3-8f3a2ea0b363") },
                    { new Guid("8d25ac20-2aa0-4845-abef-eea47e7d5d84"), 4, 4, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("2686f8bb-a9ac-49b7-8346-0a9cc4312437") },
                    { new Guid("92e9610d-f735-4de0-980a-23134f1da52e"), 1, 4, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("f7b60c6a-2e0c-49bf-9b4f-5c1c9bdddc83") },
                    { new Guid("9309c2f5-e9f9-4084-a8ce-effddc5e56ae"), 3, 4, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("b7995c37-ce6a-4358-8768-535d5e783952") },
                    { new Guid("9356e455-3244-4a29-98ce-559bff768746"), 2, 2, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("9be26fc3-4b33-4695-9e0b-2e755e923c47") },
                    { new Guid("936dec68-1b0f-439e-9f6b-c30e5e5c1020"), 3, 3, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("dd40ea07-4759-47b1-96e5-150d82b398d6") },
                    { new Guid("9576a348-4300-471a-b625-c68b83e779a1"), 4, 4, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("fc6a598b-cd61-40ca-bd2a-2bad81868b82") },
                    { new Guid("95a5b99e-384f-48d1-84ac-e25dd4dc734b"), 3, 1, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("506cde12-375b-4c98-add8-a9c556c0cd43") },
                    { new Guid("96187699-00fa-4a93-9389-638b2758cb2f"), 4, 4, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("3778b172-9034-4352-afe4-0bf484f64a38") },
                    { new Guid("980a0a35-7124-44ee-9ddd-5e2030daccb5"), 2, 1, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("4c365784-45a9-45e9-af48-32486ce91d10") },
                    { new Guid("9a5cace8-2ff0-4217-9be9-dea280e942b9"), 4, 4, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("b62d8ba8-2358-42ad-b651-e26c86bca8d8") },
                    { new Guid("9bb1dfdd-ed93-4851-9b57-c7fcba64ee5d"), 2, 2, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("b0fb1578-7877-4e78-8f5b-954a48aab2a7") },
                    { new Guid("a23aaf58-067d-49ff-a06e-4715419cf358"), 2, 2, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("c3d4fd42-aa0f-4bb9-82d9-f64f050d2171") },
                    { new Guid("a38e2253-101c-4590-813c-c4e85a9eb2f9"), 3, 3, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("dd40ea07-4759-47b1-96e5-150d82b398d6") },
                    { new Guid("a6e4bc79-541d-4a54-9676-877fb2de2ca4"), 3, 3, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("03e28d8f-b005-4c02-b5df-c9cf7b22f6a0") },
                    { new Guid("a80464c8-864e-4467-b814-5a41c38fbc3b"), 4, 4, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("3778b172-9034-4352-afe4-0bf484f64a38") },
                    { new Guid("ac735216-3dd7-44b3-aee5-452966575097"), 4, 4, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("b0fb1578-7877-4e78-8f5b-954a48aab2a7") },
                    { new Guid("ae9ed55a-be61-4882-93cd-bd62dcfe82e6"), 3, 3, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("b7995c37-ce6a-4358-8768-535d5e783952") },
                    { new Guid("b060c64b-34bf-426a-a756-5643a4546aec"), 1, 1, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("dad5f61c-cd47-435b-83c0-cac876c20048") },
                    { new Guid("b3038a79-b779-45c6-bf76-8c5634778037"), 4, 4, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("b00c9f29-b75d-4cee-b2e9-203ecb31a6dc") },
                    { new Guid("b3f1c652-9749-4691-843d-b5f11aeb5e10"), 4, 1, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("21a83ab6-5db5-4c6a-995a-2626ce50125f") },
                    { new Guid("b6bd5fc0-d7aa-4e14-8312-78a088498770"), 4, 4, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("b62d8ba8-2358-42ad-b651-e26c86bca8d8") },
                    { new Guid("b6f9911f-3c5f-4740-b1a4-3e24d7c7c7c0"), 4, 4, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("9be26fc3-4b33-4695-9e0b-2e755e923c47") },
                    { new Guid("b86e32e1-f572-4029-8f3f-f97c7b00b242"), 4, 4, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("1ede5936-8fb6-44ab-a3bb-07e93373a938") },
                    { new Guid("b9dc8512-fbdb-4d77-81a7-8cb7619ca297"), 1, 3, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("539c44f4-db08-4194-909c-8431bdf84d70") },
                    { new Guid("bdae0a2c-1a78-41c5-bec5-472d26fc5aa1"), 4, 4, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("b00c9f29-b75d-4cee-b2e9-203ecb31a6dc") },
                    { new Guid("be0f7bc8-b223-4275-9928-74be3cd4069c"), 4, 4, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("e4da7945-5ce6-47e9-8425-705727fed8d2") },
                    { new Guid("c5064942-52c3-40c9-8abe-b059b16b5f04"), 2, 2, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("fc6a598b-cd61-40ca-bd2a-2bad81868b82") },
                    { new Guid("c6a10b44-b0c2-480f-92cc-139228bb3609"), 3, 3, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("506cde12-375b-4c98-add8-a9c556c0cd43") },
                    { new Guid("c9231e45-780f-4de7-bc79-326ff279d083"), 2, 2, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("2686f8bb-a9ac-49b7-8346-0a9cc4312437") },
                    { new Guid("cf137a30-1da4-4b25-aa48-cb8455dd3ea9"), 3, 3, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("dab16462-6f16-4c73-9912-da66898f6a69") },
                    { new Guid("d2c4c3c9-ec26-46fe-b1dd-58820783ea2c"), 2, 2, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("9be26fc3-4b33-4695-9e0b-2e755e923c47") },
                    { new Guid("d638758d-27a4-46ba-8559-25065bbc7fcc"), 1, 1, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("dab16462-6f16-4c73-9912-da66898f6a69") },
                    { new Guid("d7b37acd-2a79-4d7a-be9b-ebff6700255a"), 3, 3, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("dd40ea07-4759-47b1-96e5-150d82b398d6") },
                    { new Guid("dac5a9ad-2529-462e-9ff9-0aa22af8df22"), 1, 1, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("c3d4fd42-aa0f-4bb9-82d9-f64f050d2171") },
                    { new Guid("dcad5db1-aff4-4839-934f-86992a010e75"), 3, 3, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("ce1a5122-32dd-401c-ad6b-6bdd8d21784e") },
                    { new Guid("dcb154ea-f134-4672-9bfc-3a043d48d30f"), 1, 1, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("3eb80019-24d9-4d16-860f-0e187d8ebab3") },
                    { new Guid("dcd23fc2-b2f7-4a5d-89e5-7322b1a875dc"), 4, 4, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("f8374008-ab25-48a2-871f-252942d45ea6") },
                    { new Guid("ddf43ccf-98c2-4ae2-a6f7-499b76759843"), 4, 4, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("b62d8ba8-2358-42ad-b651-e26c86bca8d8") },
                    { new Guid("e36be619-5f7a-40bc-8771-9183245f843c"), 2, 2, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("44116861-9320-48d0-983a-ebc34d7db63a") },
                    { new Guid("e53b5134-a238-4cd9-a401-d0690c0a4971"), 4, 4, new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"), new Guid("b0fb1578-7877-4e78-8f5b-954a48aab2a7") },
                    { new Guid("e6667b50-c8f3-4374-93d1-f67b54441f7a"), 3, 3, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("af1ed84f-3c79-4f9d-9180-92df4137f4f3") },
                    { new Guid("e67f85fa-781f-4abf-9263-0b9116f50722"), 3, 3, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("3778b172-9034-4352-afe4-0bf484f64a38") },
                    { new Guid("e6dfcf34-5f21-4152-92a2-4bb1ecd3772f"), 4, 4, new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"), new Guid("c3d4fd42-aa0f-4bb9-82d9-f64f050d2171") },
                    { new Guid("e87a1229-cd67-409b-a8ff-020f4870a5f8"), 4, 4, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("ce1a5122-32dd-401c-ad6b-6bdd8d21784e") },
                    { new Guid("e8f504d1-68f5-44fa-bd62-8289e4120018"), 4, 4, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("dab16462-6f16-4c73-9912-da66898f6a69") },
                    { new Guid("ed1df2ba-1f7b-4264-829a-12cf9e396752"), 4, 4, new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"), new Guid("626d2c60-3159-46ac-917f-5d472625ba9a") },
                    { new Guid("ee28a7ca-ca75-4740-bb99-a60d4160a428"), 3, 3, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("4944ad1e-d391-4630-b3c1-394a814f81cd") },
                    { new Guid("ee50dee5-3466-451b-91ae-edbf019ba507"), 3, 3, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("dab16462-6f16-4c73-9912-da66898f6a69") },
                    { new Guid("ef33f8a4-d1a2-4fda-9e1b-cbd797e43a71"), 4, 4, new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"), new Guid("4c365784-45a9-45e9-af48-32486ce91d10") },
                    { new Guid("ef86e884-89b7-48bb-b891-a6f8ecfb7ce0"), 2, 2, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("0581bcb6-74ff-4cec-b635-8c2795e9a619") },
                    { new Guid("f4733132-e9bc-443a-964b-14f88b53a297"), 1, 1, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("4c365784-45a9-45e9-af48-32486ce91d10") },
                    { new Guid("f4bd0f65-f8ea-4988-bb0c-e3162d758722"), 3, 3, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("539c44f4-db08-4194-909c-8431bdf84d70") },
                    { new Guid("f9ceb7cf-0776-4259-ab02-be3cd43c2431"), 2, 2, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("626d2c60-3159-46ac-917f-5d472625ba9a") },
                    { new Guid("f9f60260-eb32-4a2b-9f93-633831917218"), 1, 1, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("21a83ab6-5db5-4c6a-995a-2626ce50125f") },
                    { new Guid("fbbbb79d-f7de-4fc3-9f58-f4c892d98b12"), 4, 4, new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"), new Guid("03e28d8f-b005-4c02-b5df-c9cf7b22f6a0") },
                    { new Guid("fc7be5f5-83f2-4204-827d-a6a4d0850ca9"), 1, 1, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("92f25636-7747-45d6-93c3-8f3a2ea0b363") },
                    { new Guid("fda50145-5ead-4be3-8658-834cbfefe161"), 2, 2, new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"), new Guid("7893f9e2-6e8c-4c03-88d1-689ce811870e") },
                    { new Guid("ffaaeaf6-4d70-4cbf-ae3a-1df1d8244bed"), 1, 1, new Guid("a1662135-3952-4708-80ef-51d55f021e83"), new Guid("7893f9e2-6e8c-4c03-88d1-689ce811870e") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_RoomAssignment_RoomAssignmentId",
                table: "Students",
                column: "RoomAssignmentId",
                principalTable: "RoomAssignment",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_RoomAssignment_RoomAssignmentId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0015e953-052f-47f4-bc85-fa6558ef72c1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("02fe91f9-c0f8-4101-82cf-ba98b0e5b0b0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("062de862-c545-48f7-84cd-4db196d802d6"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("094e2dbc-9cbe-4596-aba8-cb0bcdb0e412"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0bcb3d01-b8d1-4b6d-86fd-88fb6229f94c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0d77fd07-1cf9-4aca-89a8-8bcbb6113ea6"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0ec3466a-a916-4bc7-a2ee-1d74a7f25c4b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1000480b-6940-4658-b1c7-32ec71c58217"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("14384f83-919a-4a03-b923-3f5d794cbf58"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("18f05beb-6946-49b8-a2a8-7fcd60f2c1f8"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("19a8ed80-81e3-4de0-89d3-eb9189b93984"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1c352896-4563-4167-884c-81e93e9611c8"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1c49fc8d-7ec1-4e92-b8c3-ebe3fc6e903c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2433be9d-88f6-4e9a-89b4-5b1d321e53d5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("257a3afa-33ad-4708-8f39-b2531f3bb475"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("258dbe00-635f-495f-8942-ad5b35cff8af"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("26c3534f-9a6a-43b4-90a7-231b658817a7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("277257c0-9574-4acb-9112-d47b3e14347a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2915733e-16fb-4684-974a-b13a7432ca98"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("29552aa1-a0fd-43ca-9866-695f03bc9c76"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2a330599-8978-463b-8e82-36839c4887c3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2cda3a75-2932-40e3-b27f-848a42eec2aa"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2e9d7f0f-1343-4eee-9f31-368ccb8d6c5b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("30152919-6bb6-4fd0-98c6-bc9ee9544dab"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3261a97e-964c-4914-9049-552f4ad37703"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3263004e-353b-459b-82b8-c2e4336f4e84"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3598d902-912b-48f8-9006-7cd727ed2ee5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("35c33383-3faa-485f-80c6-f88d9ed0f6ce"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("35e8a50a-008c-410e-bc7a-331cc8f349cb"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("376423b4-de23-4496-abf3-ebfa097c5cf3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("382b6b6e-6b48-4392-9b23-5e038f5c441a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3af0cb73-b650-412f-a932-67e109dbf811"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3d0c333a-dade-4a16-b658-b08e33372bd5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3dbef502-b762-4daa-a909-8fa9c7fffbc2"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3fe6b4bb-3362-4204-ba2b-4fc04d94e31c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("41b338ad-4248-417b-8360-51d0241b086a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("453a5846-08d6-46df-86d2-3e8557e3701d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4a02a3d4-59a8-4152-926b-dbde361dc12d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4a9d37f9-5c73-4f12-a1cc-6243d3a0146c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4e2dafc0-9169-4344-b466-7b09eb5c4ea0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4e92d905-876c-4e03-abfc-381deee26c3e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4fbae7a6-f4b0-440a-98c2-a112168ca436"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("54cbb559-4d5a-4977-998d-01273e4c2e43"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("55ae6656-28e7-4495-b6a0-e975957c8bed"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("56a1522d-8da9-4aad-99d7-58474be4c428"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("57553f02-d667-47f0-8239-0f61468a6f02"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5afbd348-81d1-4408-bdbc-b5ea7a988272"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5c0d63dc-ca87-42d3-8d3e-bc45e626ef69"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5d39a319-1d0e-412d-9757-97b322b18946"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5ea691b9-8416-46ef-b3fe-61d23e92f9ad"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("60017302-7a2b-4d66-8b37-c5b4db4cd6ac"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("642904e9-e39d-4dd7-bca2-2c0ced90b11f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("65a8547b-bf5f-46ed-855f-2e1ea6ccd7d6"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("65eb320b-75c0-41ba-b067-f1950ae9defa"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("66893851-581d-47a3-ae8b-5b00f96c0ed6"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("670137f0-18d3-4631-a50c-1ad6c3afe831"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("688d0f98-d714-442b-a82b-157366979b9e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("69195ed7-4b73-4ce8-a339-508ad13a5d7d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6943f260-c7f3-470d-b379-48424d8769fa"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("69553340-01bc-42f4-a988-60b240d456e6"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6ae5fe73-9f64-4064-83ef-e420598395ff"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6bc7f7a0-6765-4b3c-a1bc-582b9668f3f7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("713ab835-a123-424c-ada7-99d9e2c34669"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("71b34b9b-d0fb-4f6b-bd14-28627869d0f3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("72cdab94-1227-49d5-abd5-b4ce379d9750"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7471a456-2e64-4dfd-8d3b-072adcc28baa"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("76ddfb79-735a-4c86-a1e5-5890108472ee"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("77e7e70c-793a-42a1-8ac5-b4daad32621a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("78f7f43d-2324-46d0-86d6-6d62e3bfec74"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("795ef5a5-05ed-416d-84e0-e90b9b36cae5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7f877a0f-e4cc-4068-a2b7-1463336abfec"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7faec89d-e34a-41a8-a097-9bcedd96a31a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8293c7ef-bed4-4c3a-a1bb-040228468c4c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("82c9c19a-e442-4a23-a60a-068fcb8ace8a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("84547cfa-ba96-4801-ba58-556e03169293"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("84862751-c5b1-4417-aea9-f1f29007957f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8575d05f-5a4c-4e6a-ba25-5c534b2777e3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8716d581-c411-43a0-9cee-1e94900a3cd1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("87390588-b6b7-4768-8fc4-7e651730ea25"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("88967749-5edc-4bcb-a9e7-b60db2a613b9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("88a03f84-e3f3-4b39-a4bd-16714f1292b7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("89cd54b1-46f8-4b8b-8537-508be725b1a7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8a3642fc-d692-442b-bce9-6e2ef821b41e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8d25ac20-2aa0-4845-abef-eea47e7d5d84"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("92e9610d-f735-4de0-980a-23134f1da52e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9309c2f5-e9f9-4084-a8ce-effddc5e56ae"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9356e455-3244-4a29-98ce-559bff768746"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("936dec68-1b0f-439e-9f6b-c30e5e5c1020"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9576a348-4300-471a-b625-c68b83e779a1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("95a5b99e-384f-48d1-84ac-e25dd4dc734b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("96187699-00fa-4a93-9389-638b2758cb2f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("980a0a35-7124-44ee-9ddd-5e2030daccb5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9a5cace8-2ff0-4217-9be9-dea280e942b9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9bb1dfdd-ed93-4851-9b57-c7fcba64ee5d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a23aaf58-067d-49ff-a06e-4715419cf358"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a38e2253-101c-4590-813c-c4e85a9eb2f9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a6e4bc79-541d-4a54-9676-877fb2de2ca4"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a80464c8-864e-4467-b814-5a41c38fbc3b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ac735216-3dd7-44b3-aee5-452966575097"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ae9ed55a-be61-4882-93cd-bd62dcfe82e6"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b060c64b-34bf-426a-a756-5643a4546aec"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b3038a79-b779-45c6-bf76-8c5634778037"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b3f1c652-9749-4691-843d-b5f11aeb5e10"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b6bd5fc0-d7aa-4e14-8312-78a088498770"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b6f9911f-3c5f-4740-b1a4-3e24d7c7c7c0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b86e32e1-f572-4029-8f3f-f97c7b00b242"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b9dc8512-fbdb-4d77-81a7-8cb7619ca297"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("bdae0a2c-1a78-41c5-bec5-472d26fc5aa1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("be0f7bc8-b223-4275-9928-74be3cd4069c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c5064942-52c3-40c9-8abe-b059b16b5f04"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c6a10b44-b0c2-480f-92cc-139228bb3609"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c9231e45-780f-4de7-bc79-326ff279d083"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("cf137a30-1da4-4b25-aa48-cb8455dd3ea9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d2c4c3c9-ec26-46fe-b1dd-58820783ea2c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d638758d-27a4-46ba-8559-25065bbc7fcc"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d7b37acd-2a79-4d7a-be9b-ebff6700255a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("dac5a9ad-2529-462e-9ff9-0aa22af8df22"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("dcad5db1-aff4-4839-934f-86992a010e75"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("dcb154ea-f134-4672-9bfc-3a043d48d30f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("dcd23fc2-b2f7-4a5d-89e5-7322b1a875dc"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ddf43ccf-98c2-4ae2-a6f7-499b76759843"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e36be619-5f7a-40bc-8771-9183245f843c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e53b5134-a238-4cd9-a401-d0690c0a4971"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e6667b50-c8f3-4374-93d1-f67b54441f7a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e67f85fa-781f-4abf-9263-0b9116f50722"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e6dfcf34-5f21-4152-92a2-4bb1ecd3772f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e87a1229-cd67-409b-a8ff-020f4870a5f8"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e8f504d1-68f5-44fa-bd62-8289e4120018"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ed1df2ba-1f7b-4264-829a-12cf9e396752"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ee28a7ca-ca75-4740-bb99-a60d4160a428"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ee50dee5-3466-451b-91ae-edbf019ba507"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ef33f8a4-d1a2-4fda-9e1b-cbd797e43a71"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ef86e884-89b7-48bb-b891-a6f8ecfb7ce0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f4733132-e9bc-443a-964b-14f88b53a297"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f4bd0f65-f8ea-4988-bb0c-e3162d758722"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f9ceb7cf-0776-4259-ab02-be3cd43c2431"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f9f60260-eb32-4a2b-9f93-633831917218"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("fbbbb79d-f7de-4fc3-9f58-f4c892d98b12"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("fc7be5f5-83f2-4204-827d-a6a4d0850ca9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("fda50145-5ead-4be3-8658-834cbfefe161"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ffaaeaf6-4d70-4cbf-ae3a-1df1d8244bed"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("0680eddf-beb9-4ad8-b78c-6751cddf69a8"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("3b9cd07d-2189-4a9a-b2d7-dbe5cff83e42"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("962da03d-70cc-4e0e-93c8-b14a8f7dd250"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("a1662135-3952-4708-80ef-51d55f021e83"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("afe2cdcb-3e34-43b2-bda8-be01349d0126"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("e27e97b6-97f5-45da-b277-1013adcf7645"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("f4ce42a9-fcb4-40fb-95c0-885f22214fc1"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("03e28d8f-b005-4c02-b5df-c9cf7b22f6a0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0581bcb6-74ff-4cec-b635-8c2795e9a619"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1ede5936-8fb6-44ab-a3bb-07e93373a938"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("21a83ab6-5db5-4c6a-995a-2626ce50125f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2686f8bb-a9ac-49b7-8346-0a9cc4312437"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("28d63794-5d9d-43f2-8e77-223c4954b40a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2b50d070-d2fe-4d59-9b1f-39c8fb5f4c1d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("329aae01-ea68-44a6-8f3f-f1b3cd2c94f6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3778b172-9034-4352-afe4-0bf484f64a38"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3eb80019-24d9-4d16-860f-0e187d8ebab3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("44116861-9320-48d0-983a-ebc34d7db63a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("47d56599-0983-4095-90a0-39da96a977d8"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4944ad1e-d391-4630-b3c1-394a814f81cd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4c365784-45a9-45e9-af48-32486ce91d10"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("506cde12-375b-4c98-add8-a9c556c0cd43"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("539c44f4-db08-4194-909c-8431bdf84d70"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("626d2c60-3159-46ac-917f-5d472625ba9a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7893f9e2-6e8c-4c03-88d1-689ce811870e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("89fa7d8e-3bf3-457a-9e92-19a900c518e6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9095fc58-5eb4-4fea-b82b-14ac4a15f582"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("92f25636-7747-45d6-93c3-8f3a2ea0b363"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9782e598-14fa-4015-8be8-63d28b875535"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9be26fc3-4b33-4695-9e0b-2e755e923c47"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a002fa36-6fc9-4f72-ade2-7368b26f407d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("af1ed84f-3c79-4f9d-9180-92df4137f4f3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b00c9f29-b75d-4cee-b2e9-203ecb31a6dc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b0fb1578-7877-4e78-8f5b-954a48aab2a7"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b62d8ba8-2358-42ad-b651-e26c86bca8d8"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b7995c37-ce6a-4358-8768-535d5e783952"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("beb459cd-e0db-4bbc-b0a6-e2dda75b22b3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c3d4fd42-aa0f-4bb9-82d9-f64f050d2171"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ce1a5122-32dd-401c-ad6b-6bdd8d21784e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("dab16462-6f16-4c73-9912-da66898f6a69"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("dad5f61c-cd47-435b-83c0-cac876c20048"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("dd40ea07-4759-47b1-96e5-150d82b398d6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e4da7945-5ce6-47e9-8425-705727fed8d2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f22cb64e-150c-4b9c-8da1-64a2bac43648"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f7b60c6a-2e0c-49bf-9b4f-5c1c9bdddc83"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f8374008-ab25-48a2-871f-252942d45ea6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fc6a598b-cd61-40ca-bd2a-2bad81868b82"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("116ddfeb-c97a-4722-9be2-ff66809f280a"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("c6f65bed-0026-419d-be86-1aa857feea05"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("d066ad2c-2296-4af8-be7f-8a24c9ec3ec0"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("f6cf68c4-f88a-4c7f-9d11-2f814e86d74d"));

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("33ae80c6-7fc0-42ab-a76b-3cacb05ba055"));

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("501fec76-5f58-4c51-8139-fd588281c5ba"));

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameIndex(
                name: "IX_Students_RoomAssignmentId",
                table: "Student",
                newName: "IX_Student_RoomAssignmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Student_RoomAssignment_RoomAssignmentId",
                table: "Student",
                column: "RoomAssignmentId",
                principalTable: "RoomAssignment",
                principalColumn: "Id");
        }
    }
}

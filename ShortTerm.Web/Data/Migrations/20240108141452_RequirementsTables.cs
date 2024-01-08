using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class RequirementsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductLapsePeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndividualProductID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    LapsePeriod = table.Column<int>(type: "int", nullable: false),
                    MinDurationInForce = table.Column<int>(type: "int", nullable: false),
                    MaxDurationInForce = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLapsePeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductLapsePeriods_IndividualProducts_IndividualProductID",
                        column: x => x.IndividualProductID,
                        principalTable: "IndividualProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequirementTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequirementTypeID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requirements_RequirementTypes_RequirementTypeID",
                        column: x => x.RequirementTypeID,
                        principalTable: "RequirementTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductPolicyRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndividualProductID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    DependentTypeID = table.Column<int>(type: "int", nullable: true),
                    RequirementID = table.Column<int>(type: "int", nullable: true),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPolicyRequirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPolicyRequirements_IndividualProducts_IndividualProductID",
                        column: x => x.IndividualProductID,
                        principalTable: "IndividualProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPolicyRequirements_Requirements_RequirementID",
                        column: x => x.RequirementID,
                        principalTable: "Requirements",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "a2edd5a2-dd51-4152-b009-b044042fbe0b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "985e22d0-dca5-4529-80f3-b722ad79cded");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5103ff8e-19c1-45a6-a5f5-8aa563bd4a19", "AQAAAAEAACcQAAAAEI5j3OvLD11Dy9zZ7Qp6UMB/7De8nS7wcfc/wDi7kC/bCZx37PueoPqkSaD8qBz/iQ==", "adc89c9e-561d-4ed8-9781-0ab2db9ef2fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "495a1ff5-7497-4bf2-a712-5b72533106f4", "AQAAAAEAACcQAAAAEIDbVY8IyJdTxV1bPSrnksWMuVyORDgVrGxsGw2vfQ00rVBA4fe7Z3+h9kKTixhBVg==", "41a71daa-2b2e-4a83-adc4-c16698d1a0b3" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductLapsePeriods_IndividualProductID",
                table: "ProductLapsePeriods",
                column: "IndividualProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPolicyRequirements_IndividualProductID",
                table: "ProductPolicyRequirements",
                column: "IndividualProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPolicyRequirements_RequirementID",
                table: "ProductPolicyRequirements",
                column: "RequirementID");

            migrationBuilder.CreateIndex(
                name: "IX_Requirements_RequirementTypeID",
                table: "Requirements",
                column: "RequirementTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductLapsePeriods");

            migrationBuilder.DropTable(
                name: "ProductPolicyRequirements");

            migrationBuilder.DropTable(
                name: "Requirements");

            migrationBuilder.DropTable(
                name: "RequirementTypes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "ca6eb06d-8da0-46b8-94e5-53cb6234db23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "efb90c4b-5b7a-49f4-8128-081f6f9fb1b4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1c9ddc9-1bd9-49d5-9681-e15a154ae602", "AQAAAAEAACcQAAAAEFIEz0s85zoVoMjdQ6cJZlAlQIMgQRVKZ1zyMYzPDO6j7cuxD0zGO8zaMJGec2MBOA==", "3737e541-5f0f-402f-9075-a0b52ebfe469" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a240662-37d2-441d-b4a8-389174914518", "AQAAAAEAACcQAAAAEFcbIOmNTNBdzk/iV2mQDSGJ7SbrDyfMSdX55PrwmKJWFCz2sJEwJLGCrGUybb+o1g==", "53ac004c-7ad1-4c93-bd8e-6c8786b35641" });
        }
    }
}

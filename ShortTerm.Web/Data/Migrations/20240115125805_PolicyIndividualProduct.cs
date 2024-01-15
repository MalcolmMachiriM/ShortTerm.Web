using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class PolicyIndividualProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Policies_IndividualProducts_ProductGroupId",
                table: "Policies");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Policies",
                newName: "IndividualProductId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "4339e003-2c20-4ca9-a2a0-161135356c5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "83542036-cefd-4697-8127-71621af5508a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c76f167f-ab55-44c0-b18d-9be5a6151944", "AQAAAAEAACcQAAAAEC1f+FV26GrtLsjn9ZVgXcEaUKnnBCcKglwcmEUowPSjcMeFh8uJ1dye6ex+5HsXfA==", "8d89a483-1089-4bf8-a498-e272e975cf20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51240e34-5a77-488c-9007-619f23c4a794", "AQAAAAEAACcQAAAAEGtbyaBsrKI/LvfSxwh5/+PAUY2erjcmWd8+5v8Vd9qYzZnxpIggr6ce0u1Thrk6kg==", "824298e8-cf1a-4371-95e5-02289307d96b" });

            migrationBuilder.CreateIndex(
                name: "IX_Policies_IndividualProductId",
                table: "Policies",
                column: "IndividualProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_IndividualProducts_IndividualProductId",
                table: "Policies",
                column: "IndividualProductId",
                principalTable: "IndividualProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Policies_IndividualProducts_IndividualProductId",
                table: "Policies");

            migrationBuilder.DropIndex(
                name: "IX_Policies_IndividualProductId",
                table: "Policies");

            migrationBuilder.RenameColumn(
                name: "IndividualProductId",
                table: "Policies",
                newName: "ProductId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "0f8f8cb3-6f4d-429e-9d62-76d3efcb696e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "bd4da1a3-3bdf-46c7-ad40-4d2b1985306d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a176262-1245-4371-9569-47d3b7e06097", "AQAAAAEAACcQAAAAELMAWk06ae9BvoWggEFsOWguCgUhmD6Xhh0lTqOSssV0HQAzFzBtn0suOBUzxHzR3g==", "607e8da8-f324-4a03-b03d-8d27641a23fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "713e159d-2fc2-4a5f-a586-97c0eef1877f", "AQAAAAEAACcQAAAAEEsDnWBF5y9XIPv7WTo2TtmjMx63RzFXNIQc5auBNXMG2MMHjpmb4CQ1J9j4j49rxA==", "dace61a3-d317-44d2-a253-962c3f8fd161" });

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_IndividualProducts_ProductGroupId",
                table: "Policies",
                column: "ProductGroupId",
                principalTable: "IndividualProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

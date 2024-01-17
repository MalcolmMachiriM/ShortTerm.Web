using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class PolicySHhhhh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PremiumPaymentFrequency",
                table: "Policies");

            migrationBuilder.DropColumn(
                name: "PremiumPaymentMethod",
                table: "Policies");

            migrationBuilder.AddColumn<int>(
                name: "PaymentFrequencyId",
                table: "Policies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentMethodId",
                table: "Policies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "33917122-d389-49af-b10f-0bf6bac442b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "9cb47be7-2150-473d-8e2d-e06bb7a3dd9a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b284bfb-90e7-4498-9cd6-ef0016fdc3a9", "AQAAAAEAACcQAAAAEBWxuJSwFDIjc1fMRLwAFFTd8W93OAlvAgDR8qHkg6EGeVO2TlKjZewsgT3M6lCK8Q==", "d9af48ce-33fd-410a-9be5-0e049e4fe507" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b6a7c01-3d2a-47fd-acd4-aa39fc09a7e7", "AQAAAAEAACcQAAAAEF1lZHBfmprzxcod2cWf0bAQp6l/6ZgqM9OIepdlB4of6ZiLCh86DO0DkWXcV4oK/Q==", "4fa21317-c73a-47e6-9120-14b5721751ba" });

            migrationBuilder.CreateIndex(
                name: "IX_Policies_PaymentFrequencyId",
                table: "Policies",
                column: "PaymentFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Policies_PaymentMethodId",
                table: "Policies",
                column: "PaymentMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_PaymentFrequencies_PaymentFrequencyId",
                table: "Policies",
                column: "PaymentFrequencyId",
                principalTable: "PaymentFrequencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_PaymentMethods_PaymentMethodId",
                table: "Policies",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Policies_PaymentFrequencies_PaymentFrequencyId",
                table: "Policies");

            migrationBuilder.DropForeignKey(
                name: "FK_Policies_PaymentMethods_PaymentMethodId",
                table: "Policies");

            migrationBuilder.DropIndex(
                name: "IX_Policies_PaymentFrequencyId",
                table: "Policies");

            migrationBuilder.DropIndex(
                name: "IX_Policies_PaymentMethodId",
                table: "Policies");

            migrationBuilder.DropColumn(
                name: "PaymentFrequencyId",
                table: "Policies");

            migrationBuilder.DropColumn(
                name: "PaymentMethodId",
                table: "Policies");

            migrationBuilder.AddColumn<double>(
                name: "PremiumPaymentFrequency",
                table: "Policies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PremiumPaymentMethod",
                table: "Policies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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
        }
    }
}

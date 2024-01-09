using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class ProductPolicyRemovedDependant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DependentTypeID",
                table: "ProductPolicyRequirements");

            migrationBuilder.AlterColumn<bool>(
                name: "IsMandatory",
                table: "ProductPolicyRequirements",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "aabc464c-3ba8-402f-bd13-44b87a1e359a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "0b8b8b20-42d9-446e-9dc4-97c09672a95f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93b20184-edf1-41fb-8282-eaacae0b49b3", "AQAAAAEAACcQAAAAEK8UemnkMcOd95w1kAVq+s5N5xnaw68pecGfCkAumrpxhgnhMNnsT2no8NuGUo29nQ==", "e6f7ace0-2aee-4b69-a472-c3bd2c984b2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "005c887d-4c4c-42c9-8fe1-49c3ee4efdf5", "AQAAAAEAACcQAAAAENZh8j+deRNqExB/2Vcd1meuEL/kLRT7BHc2mhdu3Y/DsDbkg7b5mlanfCpAIGnvKA==", "6a35cbeb-e60d-428e-a8ec-3027e0ddb367" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsMandatory",
                table: "ProductPolicyRequirements",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "DependentTypeID",
                table: "ProductPolicyRequirements",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "26313bec-0aa0-4db8-9f2a-b36a6607e86b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "a54d15ce-ddbd-4582-93a3-27aa36fe4fe6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60baf1c8-7178-4ebb-b622-973acbf6a84d", "AQAAAAEAACcQAAAAEPQxXIFod9gI1AuTszE4c3CyS/G2uhHtiAlcoPqpWXDjEPeS5kyQeiijqacjkKUlWg==", "83daf9fb-272c-4aab-84bd-9162bb3034db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77dec764-273d-472b-be7d-69dc4a2e584d", "AQAAAAEAACcQAAAAEBk4VOPmsyQIXQ3iUUljudVgdvTAQIjnaSBA19pCRejQ/TmUpDOrhIgV8p4Ru6G86w==", "2664d9c5-6eeb-4ac0-a359-44a6c11fb34f" });
        }
    }
}

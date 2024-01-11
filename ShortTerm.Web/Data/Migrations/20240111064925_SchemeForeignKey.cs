using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class SchemeForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "f7c91161-e708-429b-9f3b-6c4c02562a07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "70b972ce-8523-4dd1-a898-5062db2c1bf9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96daa257-6708-4d3a-a4a5-7531c3359a41", "AQAAAAEAACcQAAAAEH2ghJ72wwrGD7qG1I3eRtjyeUjRZTbsANtWPffypCUYqknx2jdwF7PqzRvMvk3Itw==", "b7fcc70f-f2d6-405d-a1d0-4e48af2aa2ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bed0d4a-fecb-4a13-ae46-b89deec76c7e", "AQAAAAEAACcQAAAAEPS53a5LASkVwW8HjipcClU5F/eQ7PDLRYjuTItMC1MRqWccy5lFWb4UtVoZ0SRB7A==", "1d189f61-0784-4131-9b2e-87082d4e43e6" });

            migrationBuilder.CreateIndex(
                name: "IX_Schemes_InstitutionalClientsName",
                table: "Schemes",
                column: "InstitutionalClientsName");

            migrationBuilder.AddForeignKey(
                name: "FK_Schemes_Clients_InstitutionalClientsName",
                table: "Schemes",
                column: "InstitutionalClientsName",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schemes_Clients_InstitutionalClientsName",
                table: "Schemes");

            migrationBuilder.DropIndex(
                name: "IX_Schemes_InstitutionalClientsName",
                table: "Schemes");

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
    }
}

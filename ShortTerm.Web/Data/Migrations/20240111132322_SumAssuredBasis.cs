using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class SumAssuredBasis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SumAssuredBasis",
                table: "IndividualProducts",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "25df4172-8dc8-4987-a6a5-506a1104e199");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "eb1afe1b-cf2c-4eb9-b2ad-8c685a883d1e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "850726d9-c92e-4a33-9d0e-cc083dee9918", "AQAAAAEAACcQAAAAEDMoIh5X7DrNkMNTuBfDbnERkM7NOmw3E86NfF75htiwb0bE+ra0B+z3ZRGWcuErxA==", "4a110a08-8946-4c81-bdbe-c8e12cf7d6e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "723c59cc-07a0-48f8-a973-d346b14010bc", "AQAAAAEAACcQAAAAELDG7pv0270qCfU/3c1ACB2NKGMKpECzvqSofKInDUddL9YIgtpHmbLHXJyzCcJAEg==", "f1d6a4fe-482a-4418-aaad-81961d8ee621" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SumAssuredBasis",
                table: "IndividualProducts",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
        }
    }
}

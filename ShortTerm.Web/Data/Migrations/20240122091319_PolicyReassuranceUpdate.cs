using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShortTerm.Web.Data.Migrations
{
    public partial class PolicyReassuranceUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ReassuranceAmount",
                table: "PolicyReassurances",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "ddd25abb-5ad8-4f16-b63c-d1c0d20d023c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "fccec2da-51b6-4d61-a3a1-b127da91d29b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "874e7e7a-ff1b-4a66-822d-2ccd9ee97229", "AQAAAAEAACcQAAAAEMcJwfaohNumCXJJwfqsxolGFYRdsLNlMev0taOTZOvkTaqIxL2d+z4WP52wv77l6Q==", "dd05e9a8-4852-42c2-9205-fcf48cda9956" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34b067e1-0120-4564-9024-65acd5134d07", "AQAAAAEAACcQAAAAEBU01QVohlCgERpGD3KsE50+mZCFrui8T9U6L8yopd0UMw0vfg6c7NHEo3U6Fg/xHQ==", "c07cc368-94ea-447f-9215-148b3e5dade0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReassuranceAmount",
                table: "PolicyReassurances");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "ed86ee00-60ad-49ae-9bbd-760d8235f7d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "a3ea75f0-2f0a-46b9-bd00-d9f90e569d78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da03085f-9d37-4c55-92ff-11c98795e196", "AQAAAAEAACcQAAAAEGcxH0WN78DjkMAxD/bLT13mRPi1elhRRIlkg1zzjAXhkCyvwJzqbu79jbv/65Rv1g==", "f477c73b-752c-493f-af98-9287c46a4037" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b9bc9c3-b344-419a-88fc-3387b0198af2", "AQAAAAEAACcQAAAAEO4e+C6woOfks8C2hKd2uJa0doHs73bZ9NnVYU/vxaX40dn+EYda77VbD9tdxeCszw==", "e5cc59c9-5c2d-4c0f-9b78-d33b6cf47bc7" });
        }
    }
}

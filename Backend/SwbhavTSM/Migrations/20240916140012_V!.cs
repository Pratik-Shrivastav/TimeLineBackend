using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwbhavTSM.Migrations
{
    /// <inheritdoc />
    public partial class V : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BatchTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubProjectTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubProjectTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimelineTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnLeave = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimelineTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimelineTable_UserTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UserTable",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActivityTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BatchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    Minutes = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimelineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityTable_TimelineTable_TimelineId",
                        column: x => x.TimelineId,
                        principalTable: "TimelineTable",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTable_TimelineId",
                table: "ActivityTable",
                column: "TimelineId");

            migrationBuilder.CreateIndex(
                name: "IX_TimelineTable_UserId",
                table: "TimelineTable",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityTable");

            migrationBuilder.DropTable(
                name: "BatchTable");

            migrationBuilder.DropTable(
                name: "ProjectTable");

            migrationBuilder.DropTable(
                name: "SubProjectTable");

            migrationBuilder.DropTable(
                name: "TimelineTable");

            migrationBuilder.DropTable(
                name: "UserTable");
        }
    }
}

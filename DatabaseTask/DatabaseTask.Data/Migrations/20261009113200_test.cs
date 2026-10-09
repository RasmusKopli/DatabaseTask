using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirlineCompanies",
                columns: table => new
                {
                    AirlineID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirlineCompanies", x => x.AirlineID);
                });

            migrationBuilder.CreateTable(
                name: "Luggages",
                columns: table => new
                {
                    LuggageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LuggageNumber = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    LuggageType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luggages", x => x.LuggageID);
                });

            migrationBuilder.CreateTable(
                name: "Terminals",
                columns: table => new
                {
                    TerminalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TerminalNumber = table.Column<int>(type: "int", nullable: false),
                    TerminalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminals", x => x.TerminalID);
                });

            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    AirportID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlightNumber = table.Column<int>(type: "int", nullable: false),
                    DepartureDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DepartureTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    ArrivalDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ArrivalTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    DepartureAirport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationAirport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.AirportID);
                    table.ForeignKey(
                        name: "FK_Airports_Terminals_TerminalID",
                        column: x => x.TerminalID,
                        principalTable: "Terminals",
                        principalColumn: "TerminalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gates",
                columns: table => new
                {
                    GateID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GateNumber = table.Column<int>(type: "int", nullable: false),
                    GateLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gates", x => x.GateID);
                    table.ForeignKey(
                        name: "FK_Gates_Terminals_TerminalID",
                        column: x => x.TerminalID,
                        principalTable: "Terminals",
                        principalColumn: "TerminalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AirplaneChanges",
                columns: table => new
                {
                    ChangeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AirportID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlightStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChangeTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirplaneChanges", x => x.ChangeID);
                    table.ForeignKey(
                        name: "FK_AirplaneChanges_Airports_AirportID",
                        column: x => x.AirportID,
                        principalTable: "Airports",
                        principalColumn: "AirportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Airplanes",
                columns: table => new
                {
                    AirplaneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
                    ManufacturingDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SpecificFlight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirlineID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AirportID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplanes", x => x.AirplaneID);
                    table.ForeignKey(
                        name: "FK_Airplanes_AirlineCompanies_AirlineID",
                        column: x => x.AirlineID,
                        principalTable: "AirlineCompanies",
                        principalColumn: "AirlineID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Airplanes_Airports_AirportID",
                        column: x => x.AirportID,
                        principalTable: "Airports",
                        principalColumn: "AirportID");
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TicketType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    GateID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TerminalID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                    table.ForeignKey(
                        name: "FK_Tickets_Gates_GateID",
                        column: x => x.GateID,
                        principalTable: "Gates",
                        principalColumn: "GateID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Terminals_TerminalID",
                        column: x => x.TerminalID,
                        principalTable: "Terminals",
                        principalColumn: "TerminalID");
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassengerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    DocumentNumber = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LuggageAmount = table.Column<int>(type: "int", nullable: false),
                    LuggageID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AirportID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassengerID);
                    table.ForeignKey(
                        name: "FK_Passengers_Airports_AirportID",
                        column: x => x.AirportID,
                        principalTable: "Airports",
                        principalColumn: "AirportID");
                    table.ForeignKey(
                        name: "FK_Passengers_Luggages_LuggageID",
                        column: x => x.LuggageID,
                        principalTable: "Luggages",
                        principalColumn: "LuggageID");
                    table.ForeignKey(
                        name: "FK_Passengers_Tickets_TicketID",
                        column: x => x.TicketID,
                        principalTable: "Tickets",
                        principalColumn: "TicketID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirplaneChanges_AirportID",
                table: "AirplaneChanges",
                column: "AirportID");

            migrationBuilder.CreateIndex(
                name: "IX_Airplanes_AirlineID",
                table: "Airplanes",
                column: "AirlineID");

            migrationBuilder.CreateIndex(
                name: "IX_Airplanes_AirportID",
                table: "Airplanes",
                column: "AirportID");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_TerminalID",
                table: "Airports",
                column: "TerminalID");

            migrationBuilder.CreateIndex(
                name: "IX_Gates_TerminalID",
                table: "Gates",
                column: "TerminalID");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_AirportID",
                table: "Passengers",
                column: "AirportID");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_LuggageID",
                table: "Passengers",
                column: "LuggageID");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_TicketID",
                table: "Passengers",
                column: "TicketID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_GateID",
                table: "Tickets",
                column: "GateID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TerminalID",
                table: "Tickets",
                column: "TerminalID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirplaneChanges");

            migrationBuilder.DropTable(
                name: "Airplanes");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "AirlineCompanies");

            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "Luggages");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Gates");

            migrationBuilder.DropTable(
                name: "Terminals");
        }
    }
}

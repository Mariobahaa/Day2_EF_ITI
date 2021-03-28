using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation.Migrations
{
    public partial class colNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Towel",
                table: "Reservations",
                newName: "towel");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Reservations",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Lunch",
                table: "Reservations",
                newName: "lunch");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Reservations",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Dinner",
                table: "Reservations",
                newName: "dinner");

            migrationBuilder.RenameColumn(
                name: "Cleaning",
                table: "Reservations",
                newName: "cleaning");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Reservations",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Reservations",
                newName: "zip_code");

            migrationBuilder.RenameColumn(
                name: "TotalBill",
                table: "Reservations",
                newName: "total_bill");

            migrationBuilder.RenameColumn(
                name: "SupplyStatus",
                table: "Reservations",
                newName: "supply_status");

            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "Reservations",
                newName: "street_address");

            migrationBuilder.RenameColumn(
                name: "SSurprise",
                table: "Reservations",
                newName: "s_surprise");

            migrationBuilder.RenameColumn(
                name: "RoomType",
                table: "Reservations",
                newName: "room_type");

            migrationBuilder.RenameColumn(
                name: "RoomNumber",
                table: "Reservations",
                newName: "room_number");

            migrationBuilder.RenameColumn(
                name: "RoomFloor",
                table: "Reservations",
                newName: "room_floor");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Reservations",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "PaymentType",
                table: "Reservations",
                newName: "payment_type");

            migrationBuilder.RenameColumn(
                name: "NumberGuest",
                table: "Reservations",
                newName: "number_guest");

            migrationBuilder.RenameColumn(
                name: "LeavingTime",
                table: "Reservations",
                newName: "leaving_time");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Reservations",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FoodBill",
                table: "Reservations",
                newName: "food_bill");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Reservations",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Reservations",
                newName: "email_address");

            migrationBuilder.RenameColumn(
                name: "CheckIn",
                table: "Reservations",
                newName: "check_in");

            migrationBuilder.RenameColumn(
                name: "CardType",
                table: "Reservations",
                newName: "card_type");

            migrationBuilder.RenameColumn(
                name: "CardNumber",
                table: "Reservations",
                newName: "card_number");

            migrationBuilder.RenameColumn(
                name: "CardExp",
                table: "Reservations",
                newName: "card_exp");

            migrationBuilder.RenameColumn(
                name: "CardCvc",
                table: "Reservations",
                newName: "card_cvc");

            migrationBuilder.RenameColumn(
                name: "BreakFast",
                table: "Reservations",
                newName: "break_fast");

            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "Reservations",
                newName: "birth_day");

            migrationBuilder.RenameColumn(
                name: "ArrivalTime",
                table: "Reservations",
                newName: "arrival_time");

            migrationBuilder.RenameColumn(
                name: "AptSuite",
                table: "Reservations",
                newName: "apt_suite");

            migrationBuilder.RenameColumn(
                name: "PassWord",
                table: "Kitchens",
                newName: "pass_word");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Kitchens",
                newName: "user_name");

            migrationBuilder.RenameColumn(
                name: "PassWord",
                table: "Frontend",
                newName: "pass_word");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Frontend",
                newName: "user_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "towel",
                table: "Reservations",
                newName: "Towel");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Reservations",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "lunch",
                table: "Reservations",
                newName: "Lunch");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Reservations",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "dinner",
                table: "Reservations",
                newName: "Dinner");

            migrationBuilder.RenameColumn(
                name: "cleaning",
                table: "Reservations",
                newName: "Cleaning");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Reservations",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "zip_code",
                table: "Reservations",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "total_bill",
                table: "Reservations",
                newName: "TotalBill");

            migrationBuilder.RenameColumn(
                name: "supply_status",
                table: "Reservations",
                newName: "SupplyStatus");

            migrationBuilder.RenameColumn(
                name: "street_address",
                table: "Reservations",
                newName: "StreetAddress");

            migrationBuilder.RenameColumn(
                name: "s_surprise",
                table: "Reservations",
                newName: "SSurprise");

            migrationBuilder.RenameColumn(
                name: "room_type",
                table: "Reservations",
                newName: "RoomType");

            migrationBuilder.RenameColumn(
                name: "room_number",
                table: "Reservations",
                newName: "RoomNumber");

            migrationBuilder.RenameColumn(
                name: "room_floor",
                table: "Reservations",
                newName: "RoomFloor");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "Reservations",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "payment_type",
                table: "Reservations",
                newName: "PaymentType");

            migrationBuilder.RenameColumn(
                name: "number_guest",
                table: "Reservations",
                newName: "NumberGuest");

            migrationBuilder.RenameColumn(
                name: "leaving_time",
                table: "Reservations",
                newName: "LeavingTime");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Reservations",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "food_bill",
                table: "Reservations",
                newName: "FoodBill");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Reservations",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "email_address",
                table: "Reservations",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "check_in",
                table: "Reservations",
                newName: "CheckIn");

            migrationBuilder.RenameColumn(
                name: "card_type",
                table: "Reservations",
                newName: "CardType");

            migrationBuilder.RenameColumn(
                name: "card_number",
                table: "Reservations",
                newName: "CardNumber");

            migrationBuilder.RenameColumn(
                name: "card_exp",
                table: "Reservations",
                newName: "CardExp");

            migrationBuilder.RenameColumn(
                name: "card_cvc",
                table: "Reservations",
                newName: "CardCvc");

            migrationBuilder.RenameColumn(
                name: "break_fast",
                table: "Reservations",
                newName: "BreakFast");

            migrationBuilder.RenameColumn(
                name: "birth_day",
                table: "Reservations",
                newName: "BirthDay");

            migrationBuilder.RenameColumn(
                name: "arrival_time",
                table: "Reservations",
                newName: "ArrivalTime");

            migrationBuilder.RenameColumn(
                name: "apt_suite",
                table: "Reservations",
                newName: "AptSuite");

            migrationBuilder.RenameColumn(
                name: "pass_word",
                table: "Kitchens",
                newName: "PassWord");

            migrationBuilder.RenameColumn(
                name: "user_name",
                table: "Kitchens",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "pass_word",
                table: "Frontend",
                newName: "PassWord");

            migrationBuilder.RenameColumn(
                name: "user_name",
                table: "Frontend",
                newName: "UserName");
        }
    }
}

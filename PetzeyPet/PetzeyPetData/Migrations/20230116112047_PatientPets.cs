using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetzeyPetData.Migrations
{
    /// <inheritdoc />
    public partial class PatientPets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "status",
                table: "Patients",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "ownerPhoneNo",
                table: "Patients",
                newName: "OwnerPhoneNo");

            migrationBuilder.RenameColumn(
                name: "ownerEmail",
                table: "Patients",
                newName: "OwnerEmail");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Patients",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "avatar",
                table: "Patients",
                newName: "Avatar");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Patients",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "petId",
                table: "Patients",
                newName: "PetId");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Patients",
                newName: "ShortBiography");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Patients",
                newName: "PetName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Patients",
                newName: "PetBreed");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Patients",
                newName: "PetAge");

            migrationBuilder.AddColumn<string>(
                name: "OwnerFirstName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerLastName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerFirstName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "OwnerLastName",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Patients",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "OwnerPhoneNo",
                table: "Patients",
                newName: "ownerPhoneNo");

            migrationBuilder.RenameColumn(
                name: "OwnerEmail",
                table: "Patients",
                newName: "ownerEmail");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Patients",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Avatar",
                table: "Patients",
                newName: "avatar");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Patients",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "PetId",
                table: "Patients",
                newName: "petId");

            migrationBuilder.RenameColumn(
                name: "ShortBiography",
                table: "Patients",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "PetName",
                table: "Patients",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "PetBreed",
                table: "Patients",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "PetAge",
                table: "Patients",
                newName: "age");
        }
    }
}

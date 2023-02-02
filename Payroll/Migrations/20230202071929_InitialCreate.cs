using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IBAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JOPPD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxRate = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Retired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContributionsModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Retired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContributionsModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deductible",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Base = table.Column<float>(type: "real", nullable: false),
                    Personal = table.Column<float>(type: "real", nullable: false),
                    Dependent = table.Column<float>(type: "real", nullable: false),
                    DisabledDependentPartial = table.Column<float>(type: "real", nullable: false),
                    DisabledDependentFull = table.Column<float>(type: "real", nullable: false),
                    FirstChild = table.Column<float>(type: "real", nullable: false),
                    SecondChild = table.Column<float>(type: "real", nullable: false),
                    ThirdChild = table.Column<float>(type: "real", nullable: false),
                    FourthChild = table.Column<float>(type: "real", nullable: false),
                    FifthChild = table.Column<float>(type: "real", nullable: false),
                    SixthChild = table.Column<float>(type: "real", nullable: false),
                    SeventhChild = table.Column<float>(type: "real", nullable: false),
                    EighthChild = table.Column<float>(type: "real", nullable: false),
                    NinthChild = table.Column<float>(type: "real", nullable: false),
                    MultiplicationCoefficient = table.Column<float>(type: "real", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deductible", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoursFund",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoursFund", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HourType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Retired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reimbursement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Retired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reimbursement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WageParameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinBase = table.Column<float>(type: "real", nullable: false),
                    MaxBase = table.Column<float>(type: "real", nullable: false),
                    MinWage = table.Column<float>(type: "real", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WageParameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workplace",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false),
                    Retired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workplace", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HourTypeCoefficient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HourTypeId = table.Column<int>(type: "int", nullable: false),
                    Coefficient = table.Column<float>(type: "real", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourTypeCoefficient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HourTypeCoefficient_HourType_HourTypeId",
                        column: x => x.HourTypeId,
                        principalTable: "HourType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReimbursementValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReimbursementId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReimbursementValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReimbursementValue_Reimbursement_ReimbursementId",
                        column: x => x.ReimbursementId,
                        principalTable: "Reimbursement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxBracket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LowerBound = table.Column<float>(type: "real", nullable: false),
                    UpperBound = table.Column<float>(type: "real", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: false),
                    TaxModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxBracket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxBracket_TaxModel_TaxModelId",
                        column: x => x.TaxModelId,
                        principalTable: "TaxModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coefficient = table.Column<float>(type: "real", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractTypeId = table.Column<int>(type: "int", nullable: false),
                    WorkplaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contract_ContractType_ContractTypeId",
                        column: x => x.ContractTypeId,
                        principalTable: "ContractType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contract_Workplace_WorkplaceId",
                        column: x => x.WorkplaceId,
                        principalTable: "Workplace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IBAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bank_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HRVI = table.Column<bool>(type: "bit", nullable: false),
                    IBAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    ProtectedIBAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProtectedBankId = table.Column<int>(type: "int", nullable: true),
                    FirstEmployment = table.Column<bool>(type: "bit", nullable: false),
                    FirstEmploymentWithCompany = table.Column<bool>(type: "bit", nullable: false),
                    ContributionsModelId = table.Column<int>(type: "int", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: false),
                    PID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Disability = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Bank_ProtectedBankId",
                        column: x => x.ProtectedBankId,
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employee_Contract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_ContributionsModel_ContributionsModelId",
                        column: x => x.ContributionsModelId,
                        principalTable: "ContributionsModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dependent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChildInLine = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dependent_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Labour",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Labour_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxBreak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: false),
                    Retired = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxBreak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxBreak_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HourTypeAmount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HourTypeId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    LabourId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourTypeAmount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HourTypeAmount_HourType_HourTypeId",
                        column: x => x.HourTypeId,
                        principalTable: "HourType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HourTypeAmount_Labour_LabourId",
                        column: x => x.LabourId,
                        principalTable: "Labour",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payroll",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    AccountingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LabourId = table.Column<int>(type: "int", nullable: false),
                    Wage = table.Column<float>(type: "real", nullable: false),
                    GrossSalary = table.Column<float>(type: "real", nullable: false),
                    ContributionsBase = table.Column<float>(type: "real", nullable: false),
                    ContributionsFromPay = table.Column<float>(type: "real", nullable: false),
                    ContributionsOther = table.Column<float>(type: "real", nullable: false),
                    Income = table.Column<float>(type: "real", nullable: false),
                    PersonalDeductible = table.Column<float>(type: "real", nullable: false),
                    DependentsDeductible = table.Column<float>(type: "real", nullable: false),
                    DependentsDisabledPartialDeductible = table.Column<float>(type: "real", nullable: false),
                    DependentsDisabledFullDeductible = table.Column<float>(type: "real", nullable: false),
                    DependentsChildrenDeductible = table.Column<float>(type: "real", nullable: false),
                    TaxBase = table.Column<float>(type: "real", nullable: false),
                    IncomeTaxAmount = table.Column<float>(type: "real", nullable: false),
                    CityTaxAmount = table.Column<float>(type: "real", nullable: false),
                    TaxAmount = table.Column<float>(type: "real", nullable: false),
                    NetSalary = table.Column<float>(type: "real", nullable: false),
                    ReimbursementsAmount = table.Column<float>(type: "real", nullable: false),
                    LabourCost = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payroll", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payroll_Labour_LabourId",
                        column: x => x.LabourId,
                        principalTable: "Labour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contribution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromPay = table.Column<bool>(type: "bit", nullable: false),
                    Retired = table.Column<bool>(type: "bit", nullable: false),
                    PayrollId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contribution", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contribution_Payroll_PayrollId",
                        column: x => x.PayrollId,
                        principalTable: "Payroll",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReimbursementAmount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReimbursementId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    PayrollId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReimbursementAmount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReimbursementAmount_Payroll_PayrollId",
                        column: x => x.PayrollId,
                        principalTable: "Payroll",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReimbursementAmount_Reimbursement_ReimbursementId",
                        column: x => x.ReimbursementId,
                        principalTable: "Reimbursement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContributionAmount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContributionId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    PayrollId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContributionAmount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContributionAmount_Contribution_ContributionId",
                        column: x => x.ContributionId,
                        principalTable: "Contribution",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContributionAmount_Payroll_PayrollId",
                        column: x => x.PayrollId,
                        principalTable: "Payroll",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContributionRate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContributionId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContributionsModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContributionRate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContributionRate_Contribution_ContributionId",
                        column: x => x.ContributionId,
                        principalTable: "Contribution",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContributionRate_ContributionsModel_ContributionsModelId",
                        column: x => x.ContributionsModelId,
                        principalTable: "ContributionsModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_CityId",
                table: "Address",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_AddressId",
                table: "Bank",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_ContractTypeId",
                table: "Contract",
                column: "ContractTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_WorkplaceId",
                table: "Contract",
                column: "WorkplaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Contribution_PayrollId",
                table: "Contribution",
                column: "PayrollId");

            migrationBuilder.CreateIndex(
                name: "IX_ContributionAmount_ContributionId",
                table: "ContributionAmount",
                column: "ContributionId");

            migrationBuilder.CreateIndex(
                name: "IX_ContributionAmount_PayrollId",
                table: "ContributionAmount",
                column: "PayrollId");

            migrationBuilder.CreateIndex(
                name: "IX_ContributionRate_ContributionId",
                table: "ContributionRate",
                column: "ContributionId");

            migrationBuilder.CreateIndex(
                name: "IX_ContributionRate_ContributionsModelId",
                table: "ContributionRate",
                column: "ContributionsModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Dependent_EmployeeId",
                table: "Dependent",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BankId",
                table: "Employee",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ContractId",
                table: "Employee",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ContributionsModelId",
                table: "Employee",
                column: "ContributionsModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ProtectedBankId",
                table: "Employee",
                column: "ProtectedBankId");

            migrationBuilder.CreateIndex(
                name: "IX_HourTypeAmount_HourTypeId",
                table: "HourTypeAmount",
                column: "HourTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HourTypeAmount_LabourId",
                table: "HourTypeAmount",
                column: "LabourId");

            migrationBuilder.CreateIndex(
                name: "IX_HourTypeCoefficient_HourTypeId",
                table: "HourTypeCoefficient",
                column: "HourTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Labour_EmployeeId",
                table: "Labour",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payroll_LabourId",
                table: "Payroll",
                column: "LabourId");

            migrationBuilder.CreateIndex(
                name: "IX_ReimbursementAmount_PayrollId",
                table: "ReimbursementAmount",
                column: "PayrollId");

            migrationBuilder.CreateIndex(
                name: "IX_ReimbursementAmount_ReimbursementId",
                table: "ReimbursementAmount",
                column: "ReimbursementId");

            migrationBuilder.CreateIndex(
                name: "IX_ReimbursementValue_ReimbursementId",
                table: "ReimbursementValue",
                column: "ReimbursementId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxBracket_TaxModelId",
                table: "TaxBracket",
                column: "TaxModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxBreak_EmployeeId",
                table: "TaxBreak",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContributionAmount");

            migrationBuilder.DropTable(
                name: "ContributionRate");

            migrationBuilder.DropTable(
                name: "Deductible");

            migrationBuilder.DropTable(
                name: "Dependent");

            migrationBuilder.DropTable(
                name: "HoursFund");

            migrationBuilder.DropTable(
                name: "HourTypeAmount");

            migrationBuilder.DropTable(
                name: "HourTypeCoefficient");

            migrationBuilder.DropTable(
                name: "ReimbursementAmount");

            migrationBuilder.DropTable(
                name: "ReimbursementValue");

            migrationBuilder.DropTable(
                name: "TaxBracket");

            migrationBuilder.DropTable(
                name: "TaxBreak");

            migrationBuilder.DropTable(
                name: "WageParameters");

            migrationBuilder.DropTable(
                name: "Contribution");

            migrationBuilder.DropTable(
                name: "HourType");

            migrationBuilder.DropTable(
                name: "Reimbursement");

            migrationBuilder.DropTable(
                name: "TaxModel");

            migrationBuilder.DropTable(
                name: "Payroll");

            migrationBuilder.DropTable(
                name: "Labour");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "ContributionsModel");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "ContractType");

            migrationBuilder.DropTable(
                name: "Workplace");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}

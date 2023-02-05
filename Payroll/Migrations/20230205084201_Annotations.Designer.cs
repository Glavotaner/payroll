﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PayrollApp.Data;

#nullable disable

namespace PayrollApp.Migrations
{
    [DbContext(typeof(PayrollContext))]
    [Migration("20230205084201_Annotations")]
    partial class Annotations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PayrollApp.Areas.CalculationData.Models.Contribution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("FromPay")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PayrollId")
                        .HasColumnType("int");

                    b.Property<bool>("Retired")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PayrollId");

                    b.ToTable("Contribution");
                });

            modelBuilder.Entity("PayrollApp.Areas.CalculationData.Models.ContributionRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContributionId")
                        .HasColumnType("int");

                    b.Property<int?>("ContributionsModelId")
                        .HasColumnType("int");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ContributionId");

                    b.HasIndex("ContributionsModelId");

                    b.ToTable("ContributionRate");
                });

            modelBuilder.Entity("PayrollApp.Areas.CalculationData.Models.ContributionsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Retired")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ContributionsModel");
                });

            modelBuilder.Entity("PayrollApp.Areas.EmploymentData.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Coefficient")
                        .HasColumnType("real");

                    b.Property<int>("ContractTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkplaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContractTypeId");

                    b.HasIndex("WorkplaceId");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("PayrollApp.Areas.EmploymentData.Models.ContractType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Retired")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ContractType");
                });

            modelBuilder.Entity("PayrollApp.Areas.EmploymentData.Models.Workplace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Retired")
                        .HasColumnType("bit");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Workplace");
                });

            modelBuilder.Entity("PayrollApp.Areas.HoursData.Models.HourType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Retired")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("HourType");
                });

            modelBuilder.Entity("PayrollApp.Areas.HoursData.Models.HourTypeCoefficient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Coefficient")
                        .HasColumnType("real");

                    b.Property<int>("HourTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HourTypeId");

                    b.ToTable("HourTypeCoefficient");
                });

            modelBuilder.Entity("PayrollApp.Areas.HoursData.Models.HoursFund", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HoursFund");
                });

            modelBuilder.Entity("PayrollApp.Areas.PayrollData.Models.ContributionAmount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<int>("ContributionId")
                        .HasColumnType("int");

                    b.Property<int?>("PayrollId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContributionId");

                    b.HasIndex("PayrollId");

                    b.ToTable("ContributionAmount");
                });

            modelBuilder.Entity("PayrollApp.Areas.PayrollData.Models.HourTypeAmount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<int>("HourTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("LabourId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HourTypeId");

                    b.HasIndex("LabourId");

                    b.ToTable("HourTypeAmount");
                });

            modelBuilder.Entity("PayrollApp.Areas.PayrollData.Models.Labour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Labour");
                });

            modelBuilder.Entity("PayrollApp.Areas.PayrollData.Models.Payroll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AccountingDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("CityTaxAmount")
                        .HasColumnType("real");

                    b.Property<float>("ContributionsBase")
                        .HasColumnType("real");

                    b.Property<float>("ContributionsFromPay")
                        .HasColumnType("real");

                    b.Property<float>("ContributionsOther")
                        .HasColumnType("real");

                    b.Property<int>("Counter")
                        .HasColumnType("int");

                    b.Property<float>("DependentsChildrenDeductible")
                        .HasColumnType("real");

                    b.Property<float>("DependentsDeductible")
                        .HasColumnType("real");

                    b.Property<float>("DependentsDisabledFullDeductible")
                        .HasColumnType("real");

                    b.Property<float>("DependentsDisabledPartialDeductible")
                        .HasColumnType("real");

                    b.Property<float>("GrossSalary")
                        .HasColumnType("real");

                    b.Property<float>("Income")
                        .HasColumnType("real");

                    b.Property<float>("IncomeTaxAmount")
                        .HasColumnType("real");

                    b.Property<float>("LabourCost")
                        .HasColumnType("real");

                    b.Property<int>("LabourId")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<float>("NetSalary")
                        .HasColumnType("real");

                    b.Property<float>("PersonalDeductible")
                        .HasColumnType("real");

                    b.Property<float>("ReimbursementsAmount")
                        .HasColumnType("real");

                    b.Property<float>("TaxAmount")
                        .HasColumnType("real");

                    b.Property<float>("TaxBase")
                        .HasColumnType("real");

                    b.Property<float>("Wage")
                        .HasColumnType("real");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LabourId");

                    b.ToTable("Payroll");
                });

            modelBuilder.Entity("PayrollApp.Areas.PayrollData.Models.ReimbursementAmount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<int?>("PayrollId")
                        .HasColumnType("int");

                    b.Property<int>("ReimbursementId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PayrollId");

                    b.HasIndex("ReimbursementId");

                    b.ToTable("ReimbursementAmount");
                });

            modelBuilder.Entity("PayrollApp.Areas.PayrollData.Models.WageParameters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("MaxBase")
                        .HasColumnType("real");

                    b.Property<float>("MinBase")
                        .HasColumnType("real");

                    b.Property<float>("MinWage")
                        .HasColumnType("real");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("WageParameters");
                });

            modelBuilder.Entity("PayrollApp.Areas.PersonData.Models.Dependent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChildInLine")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Dependent");
                });

            modelBuilder.Entity("PayrollApp.Areas.PersonData.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<int>("ContributionsModelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("Disability")
                        .HasColumnType("int");

                    b.Property<bool>("FirstEmployment")
                        .HasColumnType("bit");

                    b.Property<bool>("FirstEmploymentWithCompany")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HRVI")
                        .HasColumnType("bit");

                    b.Property<string>("IBAN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PID")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int?>("ProtectedBankId")
                        .HasColumnType("int");

                    b.Property<string>("ProtectedIBAN")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("ContractId");

                    b.HasIndex("ContributionsModelId");

                    b.HasIndex("ProtectedBankId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("PayrollApp.Areas.ReimbursementsData.Models.Deductibles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Base")
                        .HasColumnType("real");

                    b.Property<float>("Dependent")
                        .HasColumnType("real");

                    b.Property<float>("DisabledDependentFull")
                        .HasColumnType("real");

                    b.Property<float>("DisabledDependentPartial")
                        .HasColumnType("real");

                    b.Property<float>("EighthChild")
                        .HasColumnType("real");

                    b.Property<float>("FifthChild")
                        .HasColumnType("real");

                    b.Property<float>("FirstChild")
                        .HasColumnType("real");

                    b.Property<float>("FourthChild")
                        .HasColumnType("real");

                    b.Property<float>("MultiplicationCoefficient")
                        .HasColumnType("real");

                    b.Property<float>("NinthChild")
                        .HasColumnType("real");

                    b.Property<float>("PersonalCoefficient")
                        .HasColumnType("real");

                    b.Property<float>("SecondChild")
                        .HasColumnType("real");

                    b.Property<float>("SeventhChild")
                        .HasColumnType("real");

                    b.Property<float>("SixthChild")
                        .HasColumnType("real");

                    b.Property<float>("ThirdChild")
                        .HasColumnType("real");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Deductible");
                });

            modelBuilder.Entity("PayrollApp.Areas.ReimbursementsData.Models.Reimbursement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Retired")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Reimbursement");
                });

            modelBuilder.Entity("PayrollApp.Areas.ReimbursementsData.Models.ReimbursementValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ReimbursementId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ReimbursementId");

                    b.ToTable("ReimbursementValue");
                });

            modelBuilder.Entity("PayrollApp.Areas.TaxData.Models.TaxBracket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("LowerBound")
                        .HasColumnType("real");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.Property<int?>("TaxModelId")
                        .HasColumnType("int");

                    b.Property<float?>("UpperBound")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("TaxModelId");

                    b.ToTable("TaxBracket");
                });

            modelBuilder.Entity("PayrollApp.Areas.TaxData.Models.TaxBreak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.Property<bool>("Retired")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("TaxBreak");
                });

            modelBuilder.Entity("PayrollApp.Areas.TaxData.Models.TaxModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TaxModel");
                });

            modelBuilder.Entity("PayrollApp.Areas.ThirdParties.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("PayrollApp.Areas.ThirdParties.Models.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("IBAN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("PayrollApp.Areas.ThirdParties.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IBAN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JOPPD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<float>("TaxRate")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("PayrollApp.Areas.CalculationData.Models.Contribution", b =>
                {
                    b.HasOne("PayrollApp.Areas.PayrollData.Models.Payroll", null)
                        .WithMany("Contributions")
                        .HasForeignKey("PayrollId");
                });

            modelBuilder.Entity("PayrollApp.Areas.CalculationData.Models.ContributionRate", b =>
                {
                    b.HasOne("PayrollApp.Areas.CalculationData.Models.Contribution", "Contribution")
                        .WithMany()
                        .HasForeignKey("ContributionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollApp.Areas.CalculationData.Models.ContributionsModel", null)
                        .WithMany("ContributionRates")
                        .HasForeignKey("ContributionsModelId");

                    b.Navigation("Contribution");
                });

            modelBuilder.Entity("PayrollApp.Areas.EmploymentData.Models.Contract", b =>
                {
                    b.HasOne("PayrollApp.Areas.EmploymentData.Models.ContractType", "ContractType")
                        .WithMany()
                        .HasForeignKey("ContractTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollApp.Areas.EmploymentData.Models.Workplace", "Workplace")
                        .WithMany()
                        .HasForeignKey("WorkplaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContractType");

                    b.Navigation("Workplace");
                });

            modelBuilder.Entity("PayrollApp.Areas.HoursData.Models.HourTypeCoefficient", b =>
                {
                    b.HasOne("PayrollApp.Areas.HoursData.Models.HourType", "HourType")
                        .WithMany()
                        .HasForeignKey("HourTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HourType");
                });

            modelBuilder.Entity("PayrollApp.Areas.PayrollData.Models.ContributionAmount", b =>
                {
                    b.HasOne("PayrollApp.Areas.CalculationData.Models.Contribution", "Contribution")
                        .WithMany()
                        .HasForeignKey("ContributionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollApp.Areas.PayrollData.Models.Payroll", null)
                        .WithMany("ContributionAmounts")
                        .HasForeignKey("PayrollId");

                    b.Navigation("Contribution");
                });

            modelBuilder.Entity("PayrollApp.Areas.PayrollData.Models.HourTypeAmount", b =>
                {
                    b.HasOne("PayrollApp.Areas.HoursData.Models.HourType", "HourType")
                        .WithMany()
                        .HasForeignKey("HourTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollApp.Areas.PayrollData.Models.Labour", null)
                        .WithMany("HourTypeAmounts")
                        .HasForeignKey("LabourId");

                    b.Navigation("HourType");
                });

            modelBuilder.Entity("PayrollApp.Areas.PayrollData.Models.Labour", b =>
                {
                    b.HasOne("PayrollApp.Areas.PersonData.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("PayrollApp.Areas.PayrollData.Models.Payroll", b =>
                {
                    b.HasOne("PayrollApp.Areas.PayrollData.Models.Labour", "Labour")
                        .WithMany()
                        .HasForeignKey("LabourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Labour");
                });

            modelBuilder.Entity("PayrollApp.Areas.PayrollData.Models.ReimbursementAmount", b =>
                {
                    b.HasOne("PayrollApp.Areas.PayrollData.Models.Payroll", null)
                        .WithMany("ReimbursementAmounts")
                        .HasForeignKey("PayrollId");

                    b.HasOne("PayrollApp.Areas.ReimbursementsData.Models.Reimbursement", "Reimbursement")
                        .WithMany()
                        .HasForeignKey("ReimbursementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reimbursement");
                });

            modelBuilder.Entity("PayrollApp.Areas.PersonData.Models.Dependent", b =>
                {
                    b.HasOne("PayrollApp.Areas.PersonData.Models.Employee", null)
                        .WithMany("Dependents")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("PayrollApp.Areas.PersonData.Models.Employee", b =>
                {
                    b.HasOne("PayrollApp.Areas.ThirdParties.Models.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollApp.Areas.EmploymentData.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollApp.Areas.CalculationData.Models.ContributionsModel", "ContributionsModel")
                        .WithMany()
                        .HasForeignKey("ContributionsModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollApp.Areas.ThirdParties.Models.Bank", "ProtectedBank")
                        .WithMany()
                        .HasForeignKey("ProtectedBankId");

                    b.Navigation("Bank");

                    b.Navigation("Contract");

                    b.Navigation("ContributionsModel");

                    b.Navigation("ProtectedBank");
                });

            modelBuilder.Entity("PayrollApp.Areas.ReimbursementsData.Models.ReimbursementValue", b =>
                {
                    b.HasOne("PayrollApp.Areas.ReimbursementsData.Models.Reimbursement", "Reimbursement")
                        .WithMany()
                        .HasForeignKey("ReimbursementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reimbursement");
                });

            modelBuilder.Entity("PayrollApp.Areas.TaxData.Models.TaxBracket", b =>
                {
                    b.HasOne("PayrollApp.Areas.TaxData.Models.TaxModel", null)
                        .WithMany("TaxBrackets")
                        .HasForeignKey("TaxModelId");
                });

            modelBuilder.Entity("PayrollApp.Areas.TaxData.Models.TaxBreak", b =>
                {
                    b.HasOne("PayrollApp.Areas.PersonData.Models.Employee", null)
                        .WithMany("TaxBreaks")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("PayrollApp.Areas.ThirdParties.Models.Address", b =>
                {
                    b.HasOne("PayrollApp.Areas.ThirdParties.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("PayrollApp.Areas.ThirdParties.Models.Bank", b =>
                {
                    b.HasOne("PayrollApp.Areas.ThirdParties.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("PayrollApp.Areas.CalculationData.Models.ContributionsModel", b =>
                {
                    b.Navigation("ContributionRates");
                });

            modelBuilder.Entity("PayrollApp.Areas.PayrollData.Models.Labour", b =>
                {
                    b.Navigation("HourTypeAmounts");
                });

            modelBuilder.Entity("PayrollApp.Areas.PayrollData.Models.Payroll", b =>
                {
                    b.Navigation("ContributionAmounts");

                    b.Navigation("Contributions");

                    b.Navigation("ReimbursementAmounts");
                });

            modelBuilder.Entity("PayrollApp.Areas.PersonData.Models.Employee", b =>
                {
                    b.Navigation("Dependents");

                    b.Navigation("TaxBreaks");
                });

            modelBuilder.Entity("PayrollApp.Areas.TaxData.Models.TaxModel", b =>
                {
                    b.Navigation("TaxBrackets");
                });
#pragma warning restore 612, 618
        }
    }
}
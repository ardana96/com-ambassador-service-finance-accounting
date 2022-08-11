﻿// <auto-generated />
using System;
using Com.Ambassador.Service.Finance.Accounting.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.Migrations
{
    [DbContext(typeof(FinanceDbContext))]
    [Migration("20190418082710_RemoveEndAndBeginLockDate")]
    partial class RemoveEndAndBeginLockDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.CreditorAccount.CreditorAccountModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<double>("BankExpenditureNoteDPP");

                    b.Property<DateTimeOffset?>("BankExpenditureNoteDate");

                    b.Property<int>("BankExpenditureNoteId");

                    b.Property<double>("BankExpenditureNoteMutation");

                    b.Property<string>("BankExpenditureNoteNo");

                    b.Property<double>("BankExpenditureNotePPN");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("CurrencyCode");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<double>("FinalBalance");

                    b.Property<string>("InvoiceNo");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<double>("MemoDPP");

                    b.Property<DateTimeOffset?>("MemoDate");

                    b.Property<double>("MemoMutation");

                    b.Property<string>("MemoNo");

                    b.Property<double>("MemoPPN");

                    b.Property<string>("Products");

                    b.Property<string>("SupplierCode");

                    b.Property<string>("SupplierName");

                    b.Property<double>("UnitReceiptMutation");

                    b.Property<double>("UnitReceiptNoteDPP");

                    b.Property<DateTimeOffset?>("UnitReceiptNoteDate");

                    b.Property<string>("UnitReceiptNoteNo");

                    b.Property<double>("UnitReceiptNotePPN");

                    b.HasKey("Id");

                    b.ToTable("CreditorAccounts");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.DailyBankTransaction.BankTransactionMonthlyBalanceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountBankId")
                        .HasMaxLength(50);

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<double>("InitialBalance");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<int>("Month");

                    b.Property<double>("RemainingBalance");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("BankTransactionMonthlyBalances");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.DailyBankTransaction.DailyBankTransactionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountBankAccountName")
                        .HasMaxLength(100);

                    b.Property<string>("AccountBankAccountNumber")
                        .HasMaxLength(100);

                    b.Property<string>("AccountBankCode")
                        .HasMaxLength(25);

                    b.Property<string>("AccountBankCurrencyCode")
                        .HasMaxLength(100);

                    b.Property<string>("AccountBankCurrencyId")
                        .HasMaxLength(50);

                    b.Property<string>("AccountBankCurrencySymbol")
                        .HasMaxLength(100);

                    b.Property<string>("AccountBankId")
                        .HasMaxLength(50);

                    b.Property<string>("AccountBankName")
                        .HasMaxLength(100);

                    b.Property<bool>("Active");

                    b.Property<double>("AfterNominal");

                    b.Property<double>("BeforeNominal");

                    b.Property<string>("BuyerCode")
                        .HasMaxLength(25);

                    b.Property<string>("BuyerId")
                        .HasMaxLength(50);

                    b.Property<string>("BuyerName")
                        .HasMaxLength(150);

                    b.Property<string>("Code")
                        .HasMaxLength(25);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<double>("Nominal");

                    b.Property<string>("ReferenceNo")
                        .HasMaxLength(50);

                    b.Property<string>("ReferenceType")
                        .HasMaxLength(50);

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<string>("SourceType")
                        .HasMaxLength(50);

                    b.Property<string>("Status")
                        .HasMaxLength(50);

                    b.Property<string>("SupplierCode")
                        .HasMaxLength(100);

                    b.Property<string>("SupplierId")
                        .HasMaxLength(50);

                    b.Property<string>("SupplierName")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("DailyBankTransactions");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.JournalTransaction.JournalTransactionItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int>("COAId");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<double>("Credit");

                    b.Property<double>("Debit");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("JournalTransactionId");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Remark");

                    b.HasKey("Id");

                    b.HasIndex("COAId");

                    b.HasIndex("JournalTransactionId");

                    b.ToTable("JournalTransactionItems");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.JournalTransaction.JournalTransactionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("Description");

                    b.Property<string>("DocumentNo")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsReversed");

                    b.Property<bool>("IsReverser");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("ReferenceNo")
                        .HasMaxLength(250);

                    b.Property<string>("Status")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("JournalTransactions");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.JournalTransaction.JournalTransactionNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<int>("Division");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<int>("Month");

                    b.Property<int>("Number");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("JournalTransactionNumbers");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.LockTransaction.LockTransactionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActiveStatus");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<DateTimeOffset>("LockDate");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("LockTransactions");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.MasterCOA.COAModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CashAccount");

                    b.Property<string>("Code");

                    b.Property<string>("Code1");

                    b.Property<string>("Code2");

                    b.Property<string>("Code3");

                    b.Property<string>("Code4");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("Header");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Name");

                    b.Property<string>("Nature");

                    b.Property<string>("Path");

                    b.Property<string>("ReportType");

                    b.Property<string>("Subheader");

                    b.HasKey("Id");

                    b.ToTable("ChartsOfAccounts");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.PaymentDispositionNote.PaymentDispositionNoteDetailModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("EPOId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<int>("PaymentDispositionNoteItemId");

                    b.Property<double>("Price");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(255);

                    b.Property<int>("ProductId");

                    b.Property<string>("ProductName")
                        .HasMaxLength(255);

                    b.Property<int>("PurchasingDispositionDetailId");

                    b.Property<int>("PurchasingDispositionExpeditionItemId");

                    b.Property<double>("Quantity");

                    b.Property<string>("UnitCode")
                        .HasMaxLength(255);

                    b.Property<int>("UnitId");

                    b.Property<string>("UnitName")
                        .HasMaxLength(255);

                    b.Property<int>("UomId");

                    b.Property<string>("UomUnit")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("PaymentDispositionNoteItemId");

                    b.ToTable("PaymentDispositionNoteDetails");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.PaymentDispositionNote.PaymentDispositionNoteItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CategoryCode")
                        .HasMaxLength(255);

                    b.Property<int>("CategoryId");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<double>("DPP");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<DateTimeOffset>("DispositionDate");

                    b.Property<int>("DispositionId");

                    b.Property<string>("DispositionNo")
                        .HasMaxLength(255);

                    b.Property<string>("DivisionCode")
                        .HasMaxLength(255);

                    b.Property<int>("DivisionId");

                    b.Property<string>("DivisionName")
                        .HasMaxLength(500);

                    b.Property<double>("IncomeTaxValue");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<double>("PayToSupplier");

                    b.Property<int>("PaymentDispositionNoteId");

                    b.Property<DateTimeOffset>("PaymentDueDate");

                    b.Property<string>("ProformaNo")
                        .HasMaxLength(255);

                    b.Property<int>("PurchasingDispositionExpeditionId");

                    b.Property<double>("TotalPaid");

                    b.Property<double>("VatValue");

                    b.HasKey("Id");

                    b.HasIndex("PaymentDispositionNoteId");

                    b.ToTable("PaymentDispositionNoteItems");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.PaymentDispositionNote.PaymentDispositionNoteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<double>("Amount");

                    b.Property<string>("BGCheckNumber")
                        .HasMaxLength(255);

                    b.Property<string>("BankAccountCOA");

                    b.Property<string>("BankAccountName")
                        .HasMaxLength(1000);

                    b.Property<string>("BankAccountNumber")
                        .HasMaxLength(255);

                    b.Property<string>("BankCode")
                        .HasMaxLength(255);

                    b.Property<string>("BankCurrencyCode")
                        .HasMaxLength(255);

                    b.Property<int>("BankCurrencyId");

                    b.Property<double>("BankCurrencyRate");

                    b.Property<int>("BankId");

                    b.Property<string>("BankName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<DateTimeOffset>("PaymentDate");

                    b.Property<string>("PaymentDispositionNo")
                        .HasMaxLength(255);

                    b.Property<string>("SupplierCode")
                        .HasMaxLength(255);

                    b.Property<int>("SupplierId");

                    b.Property<bool>("SupplierImport");

                    b.Property<string>("SupplierName")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("PaymentDispositionNotes");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.PurchasingDispositionExpedition.PurchasingDispositionExpeditionItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("EPOId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<double>("Price");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(255);

                    b.Property<string>("ProductId")
                        .HasMaxLength(50);

                    b.Property<string>("ProductName")
                        .HasMaxLength(255);

                    b.Property<int>("PurchasingDispositionDetailId");

                    b.Property<int>("PurchasingDispositionExpeditionId");

                    b.Property<double>("Quantity");

                    b.Property<string>("UnitCode")
                        .HasMaxLength(255);

                    b.Property<string>("UnitId")
                        .HasMaxLength(50);

                    b.Property<string>("UnitName")
                        .HasMaxLength(255);

                    b.Property<string>("UomId");

                    b.Property<string>("UomUnit");

                    b.HasKey("Id");

                    b.HasIndex("PurchasingDispositionExpeditionId");

                    b.ToTable("PurchasingDispositionExpeditionItems");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.PurchasingDispositionExpedition.PurchasingDispositionExpeditionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<DateTimeOffset?>("BankExpenditureNoteDate");

                    b.Property<string>("BankExpenditureNoteNo");

                    b.Property<DateTimeOffset?>("BankExpenditureNotePPHDate");

                    b.Property<string>("BankExpenditureNotePPHNo");

                    b.Property<string>("CashierDivisionBy");

                    b.Property<DateTimeOffset?>("CashierDivisionDate");

                    b.Property<string>("CategoryCode")
                        .HasMaxLength(255);

                    b.Property<string>("CategoryId")
                        .HasMaxLength(255);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("CurrencyCode")
                        .HasMaxLength(255);

                    b.Property<string>("CurrencyId")
                        .HasMaxLength(50);

                    b.Property<double>("DPP");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<DateTimeOffset>("DispositionDate");

                    b.Property<string>("DispositionId");

                    b.Property<string>("DispositionNo");

                    b.Property<string>("DivisionCode")
                        .HasMaxLength(255);

                    b.Property<string>("DivisionId")
                        .HasMaxLength(255);

                    b.Property<string>("DivisionName")
                        .HasMaxLength(255);

                    b.Property<string>("IncomeTaxId");

                    b.Property<string>("IncomeTaxName");

                    b.Property<double>("IncomeTaxRate");

                    b.Property<double>("IncomeTaxValue");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsPaid");

                    b.Property<bool>("IsPaidPPH");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("NotVerifiedReason");

                    b.Property<double>("PayToSupplier");

                    b.Property<DateTimeOffset>("PaymentDueDate");

                    b.Property<string>("PaymentMethod");

                    b.Property<int>("Position");

                    b.Property<string>("ProformaNo");

                    b.Property<string>("SendToCashierDivisionBy");

                    b.Property<DateTimeOffset?>("SendToCashierDivisionDate");

                    b.Property<string>("SendToPurchasingDivisionBy");

                    b.Property<DateTimeOffset?>("SendToPurchasingDivisionDate");

                    b.Property<string>("SupplierCode")
                        .HasMaxLength(255);

                    b.Property<string>("SupplierId")
                        .HasMaxLength(255);

                    b.Property<string>("SupplierName")
                        .HasMaxLength(255);

                    b.Property<double>("TotalPaid");

                    b.Property<bool>("UseIncomeTax");

                    b.Property<bool>("UseVat");

                    b.Property<double>("VatValue");

                    b.Property<string>("VerificationDivisionBy");

                    b.Property<DateTimeOffset?>("VerificationDivisionDate");

                    b.Property<DateTimeOffset?>("VerifyDate");

                    b.HasKey("Id");

                    b.ToTable("PurchasingDispositionExpeditions");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.JournalTransaction.JournalTransactionItemModel", b =>
                {
                    b.HasOne("Com.Ambassador.Service.Finance.Accounting.Lib.Models.MasterCOA.COAModel", "COA")
                        .WithMany()
                        .HasForeignKey("COAId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Com.Ambassador.Service.Finance.Accounting.Lib.Models.JournalTransaction.JournalTransactionModel", "JournalTransaction")
                        .WithMany("Items")
                        .HasForeignKey("JournalTransactionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.PaymentDispositionNote.PaymentDispositionNoteDetailModel", b =>
                {
                    b.HasOne("Com.Ambassador.Service.Finance.Accounting.Lib.Models.PaymentDispositionNote.PaymentDispositionNoteItemModel", "PaymentDispositionNoteItem")
                        .WithMany("Details")
                        .HasForeignKey("PaymentDispositionNoteItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.PaymentDispositionNote.PaymentDispositionNoteItemModel", b =>
                {
                    b.HasOne("Com.Ambassador.Service.Finance.Accounting.Lib.Models.PaymentDispositionNote.PaymentDispositionNoteModel", "PaymentDispositionNote")
                        .WithMany("Items")
                        .HasForeignKey("PaymentDispositionNoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Ambassador.Service.Finance.Accounting.Lib.Models.PurchasingDispositionExpedition.PurchasingDispositionExpeditionItemModel", b =>
                {
                    b.HasOne("Com.Ambassador.Service.Finance.Accounting.Lib.Models.PurchasingDispositionExpedition.PurchasingDispositionExpeditionModel", "PurchasingDispositionExpedition")
                        .WithMany("Items")
                        .HasForeignKey("PurchasingDispositionExpeditionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

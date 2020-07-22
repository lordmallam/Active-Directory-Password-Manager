using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ADPasswordManager.Models
{
    public partial class NJCLegalMailContext : DbContext
    {
        public NJCLegalMailContext()
        {
        }

        public NJCLegalMailContext(DbContextOptions<NJCLegalMailContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<Approvers> Approvers { get; set; }
        public virtual DbSet<Audits> Audits { get; set; }
        public virtual DbSet<BackUpLawyer2> BackUpLawyer2 { get; set; }
        public virtual DbSet<BackupPostLawyer> BackupPostLawyer { get; set; }
        public virtual DbSet<ChamberCronJobs> ChamberCronJobs { get; set; }
        public virtual DbSet<DocumentTypes> DocumentTypes { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<FirmDocuments> FirmDocuments { get; set; }
        public virtual DbSet<FirmLawyers> FirmLawyers { get; set; }
        public virtual DbSet<Firms> Firms { get; set; }
        public virtual DbSet<LawFirm> LawFirm { get; set; }
        public virtual DbSet<Lawyers> Lawyers { get; set; }
        public virtual DbSet<MemberCronJobs> MemberCronJobs { get; set; }
        public virtual DbSet<Migrations> Migrations { get; set; }
        public virtual DbSet<PasswordResets> PasswordResets { get; set; }
        public virtual DbSet<Postlawyers> Postlawyers { get; set; }
        public virtual DbSet<Sheet1> Sheet1 { get; set; }
        public virtual DbSet<Stagings> Stagings { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VerifiedLists> VerifiedLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=52.166.197.173;Initial Catalog=NJCLegalMail;Integrated Security=False;User ID=testlogin;Password=Word_pass1;MultipleActiveResultSets=True;Connect Timeout=30;Application Name=EntityFramework");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admins>(entity =>
            {
                entity.ToTable("admins");

                entity.HasIndex(e => e.Email)
                    .HasName("admins_email_unique")
                    .IsUnique();

                entity.HasIndex(e => e.Uuid)
                    .HasName("admins_uuid_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.CountdownOtp).HasColumnName("countdown_otp");

                entity.Property(e => e.CountdownPass).HasColumnName("countdown_pass");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailVerifiedAt)
                    .HasColumnName("email_verified_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LastSeen).HasColumnName("last_seen");

                entity.Property(e => e.Otp)
                    .HasColumnName("otp")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(255);

                entity.Property(e => e.RememberToken)
                    .HasColumnName("remember_token")
                    .HasMaxLength(100);

                entity.Property(e => e.ThemeType)
                    .HasColumnName("theme_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Uuid).HasColumnName("uuid");

                entity.Property(e => e.Who).HasColumnName("who");
            });

            modelBuilder.Entity<Applications>(entity =>
            {
                entity.Property(e => e.ActivationCode).HasMaxLength(250);

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Adid).HasColumnName("ADID");

                entity.Property(e => e.AlternativeEmail)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AlternativePhone).HasMaxLength(12);

                entity.Property(e => e.ApprovedBy).HasMaxLength(250);

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(250);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.EmployeeEndDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeStartDate).HasColumnType("datetime");

                entity.Property(e => e.EnrollmentNumber).HasMaxLength(20);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ImgUrl).HasMaxLength(250);

                entity.Property(e => e.Initials).HasMaxLength(50);

                entity.Property(e => e.IsSan).HasColumnName("IsSAN");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.MailCreated).HasColumnType("datetime");

                entity.Property(e => e.MobilePhone).HasMaxLength(12);

                entity.Property(e => e.Nbanumber)
                    .HasColumnName("NBANumber")
                    .HasMaxLength(20);

                entity.Property(e => e.OfficeName).HasMaxLength(250);

                entity.Property(e => e.OfficePhone).HasMaxLength(12);

                entity.Property(e => e.Otp)
                    .HasColumnName("OTP")
                    .HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.PostOfficeBox).HasMaxLength(250);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.PreviousName).HasMaxLength(250);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(50);

                entity.Property(e => e.StateOfOrigin).HasMaxLength(150);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(250);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_Applications_States");
            });

            modelBuilder.Entity<Approvers>(entity =>
            {
                entity.Property(e => e.Adid)
                    .IsRequired()
                    .HasColumnName("ADID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).IsRequired();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Type).IsRequired();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Approvers)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StateApprover");
            });

            modelBuilder.Entity<Audits>(entity =>
            {
                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Entity)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasColumnName("ItemID")
                    .HasMaxLength(250);

                entity.Property(e => e.NewValues).HasColumnName("New_Values");

                entity.Property(e => e.OldValues)
                    .IsRequired()
                    .HasColumnName("Old_Values");

                entity.Property(e => e.PerformedBy)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<BackUpLawyer2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActivationCode).HasMaxLength(250);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Adid).HasColumnName("ADID");

                entity.Property(e => e.AlternativeEmail)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AlternativePhone).HasMaxLength(12);

                entity.Property(e => e.ApprovedBy).HasMaxLength(250);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(250);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.EmployeeEndDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeStartDate).HasColumnType("datetime");

                entity.Property(e => e.EnrollmentNumber).HasMaxLength(20);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Initials).HasMaxLength(50);

                entity.Property(e => e.IsSan).HasColumnName("IsSAN");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.MailCreated).HasColumnType("datetime");

                entity.Property(e => e.MobilePhone)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Nbanumber)
                    .HasColumnName("NBANumber")
                    .HasMaxLength(20);

                entity.Property(e => e.OfficeName).HasMaxLength(250);

                entity.Property(e => e.OfficePhone).HasMaxLength(12);

                entity.Property(e => e.Otp)
                    .HasColumnName("OTP")
                    .HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.Photo).IsRequired();

                entity.Property(e => e.PostOfficeBox).HasMaxLength(250);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.PreviousName).HasMaxLength(250);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateOfOrigin)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(250);
            });

            modelBuilder.Entity<BackupPostLawyer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActivationCode).HasMaxLength(250);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Adid).HasColumnName("ADID");

                entity.Property(e => e.AlternativeEmail)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AlternativePhone).HasMaxLength(12);

                entity.Property(e => e.ApprovedBy).HasMaxLength(250);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(250);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.EmployeeEndDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeStartDate).HasColumnType("datetime");

                entity.Property(e => e.EnrollmentNumber).HasMaxLength(20);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Initials).HasMaxLength(50);

                entity.Property(e => e.IsSan).HasColumnName("IsSAN");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.MailCreated).HasColumnType("datetime");

                entity.Property(e => e.MobilePhone)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Nbanumber)
                    .HasColumnName("NBANumber")
                    .HasMaxLength(20);

                entity.Property(e => e.OfficeName).HasMaxLength(250);

                entity.Property(e => e.OfficePhone).HasMaxLength(12);

                entity.Property(e => e.Otp)
                    .HasColumnName("OTP")
                    .HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.PostOfficeBox).HasMaxLength(250);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.PreviousName).HasMaxLength(250);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateOfOrigin)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(250);
            });

            modelBuilder.Entity<ChamberCronJobs>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Lawyer)
                    .WithMany(p => p.ChamberCronJobs)
                    .HasForeignKey(d => d.LawyerId)
                    .HasConstraintName("FK_ChamberCronJobs_Lawyers");
            });

            modelBuilder.Entity<DocumentTypes>(entity =>
            {
                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.File).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentTypeDocument");

                entity.HasOne(d => d.Lawyer)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.LawyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LawyerDocument");
            });

            modelBuilder.Entity<FirmDocuments>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.File).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.FirmDocuments)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentTypeFirmDocument");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.FirmDocuments)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FirmFirmDocument");
            });

            modelBuilder.Entity<FirmLawyers>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.FirmLawyers)
                    .HasForeignKey(d => d.FirmId)
                    .HasConstraintName("FK_FirmLawyers_Firms");

                entity.HasOne(d => d.Lawyer)
                    .WithMany(p => p.FirmLawyers)
                    .HasForeignKey(d => d.LawyerId)
                    .HasConstraintName("FK_Lawyers_FirmLawyers");
            });

            modelBuilder.Entity<Firms>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.LocationState)
                    .WithMany(p => p.FirmsLocationState)
                    .HasForeignKey(d => d.LocationStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StateFirm");

                entity.HasOne(d => d.RegisteredState)
                    .WithMany(p => p.FirmsRegisteredState)
                    .HasForeignKey(d => d.RegisteredStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StateFirm1");
            });

            modelBuilder.Entity<LawFirm>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AlternetiveEmail)
                    .HasColumnName("Alternetive Email")
                    .HasMaxLength(150);

                entity.Property(e => e.ChamberAddress)
                    .HasColumnName("Chamber Address")
                    .HasMaxLength(150);

                entity.Property(e => e.ChamberName)
                    .HasColumnName("Chamber Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.DisplayName).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(50);
            });

            modelBuilder.Entity<Lawyers>(entity =>
            {
                entity.Property(e => e.ActivationCode).HasMaxLength(250);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Adid).HasColumnName("ADID");

                entity.Property(e => e.AlternativeEmail)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AlternativePhone).HasMaxLength(12);

                entity.Property(e => e.ApprovedBy).HasMaxLength(250);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(250);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.EmployeeEndDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeStartDate).HasColumnType("datetime");

                entity.Property(e => e.EnrollmentNumber).HasMaxLength(20);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ImgUrl).HasMaxLength(250);

                entity.Property(e => e.Initials).HasMaxLength(50);

                entity.Property(e => e.IsSan).HasColumnName("IsSAN");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.MailCreated).HasColumnType("datetime");

                entity.Property(e => e.MobilePhone)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Nbanumber)
                    .HasColumnName("NBANumber")
                    .HasMaxLength(20);

                entity.Property(e => e.OfficeName).HasMaxLength(250);

                entity.Property(e => e.OfficePhone).HasMaxLength(12);

                entity.Property(e => e.Otp)
                    .HasColumnName("OTP")
                    .HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.PostOfficeBox).HasMaxLength(250);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.PreviousName).HasMaxLength(250);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateOfOrigin)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(250);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Lawyers)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StateLawyer");
            });

            modelBuilder.Entity<MemberCronJobs>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ChamberEmail)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.LawyerEmail)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.MemberCronJobs)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberCronJobs_Firms");

                entity.HasOne(d => d.Lawyer)
                    .WithMany(p => p.MemberCronJobs)
                    .HasForeignKey(d => d.LawyerId)
                    .HasConstraintName("FK_MemberCronJobs_Lawyers");
            });

            modelBuilder.Entity<Migrations>(entity =>
            {
                entity.ToTable("migrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Migration)
                    .IsRequired()
                    .HasColumnName("migration")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PasswordResets>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("password_resets");

                entity.HasIndex(e => e.Email)
                    .HasName("password_resets_email_index");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Postlawyers>(entity =>
            {
                entity.Property(e => e.ActivationCode).HasMaxLength(250);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Adid).HasColumnName("ADID");

                entity.Property(e => e.AlternativeEmail)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AlternativePhone).HasMaxLength(12);

                entity.Property(e => e.ApprovedBy).HasMaxLength(250);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(250);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.EmployeeEndDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeStartDate).HasColumnType("datetime");

                entity.Property(e => e.EnrollmentNumber).HasMaxLength(20);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Initials).HasMaxLength(50);

                entity.Property(e => e.IsSan).HasColumnName("IsSAN");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.MailCreated).HasColumnType("datetime");

                entity.Property(e => e.MobilePhone)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Nbanumber)
                    .HasColumnName("NBANumber")
                    .HasMaxLength(20);

                entity.Property(e => e.OfficeName).HasMaxLength(250);

                entity.Property(e => e.OfficePhone).HasMaxLength(12);

                entity.Property(e => e.Otp)
                    .HasColumnName("OTP")
                    .HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.PostOfficeBox).HasMaxLength(250);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.PreviousName).HasMaxLength(250);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateOfOrigin)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(250);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Postlawyers)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Postlawyers");
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet1$");

                entity.Property(e => e.ActivationCode).HasMaxLength(255);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Adid)
                    .HasColumnName("ADID")
                    .HasMaxLength(255);

                entity.Property(e => e.AlternativeEmail).HasMaxLength(255);

                entity.Property(e => e.AlternativePhone).HasMaxLength(255);

                entity.Property(e => e.ApprovedBy).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Created).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmployeeEndDate).HasMaxLength(255);

                entity.Property(e => e.EmployeeStartDate).HasColumnType("datetime");

                entity.Property(e => e.EnrollmentNumber).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Initials).HasMaxLength(255);

                entity.Property(e => e.IsSan).HasColumnName("IsSAN");

                entity.Property(e => e.LastLogin).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.LastUpdated).HasMaxLength(255);

                entity.Property(e => e.MailCreated).HasMaxLength(255);

                entity.Property(e => e.Nbanumber)
                    .HasColumnName("NBANumber")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeName).HasMaxLength(255);

                entity.Property(e => e.OfficePhone).HasMaxLength(255);

                entity.Property(e => e.Otp)
                    .HasColumnName("OTP")
                    .HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasDefaultValueSql("(0x)");

                entity.Property(e => e.PostOfficeBox).HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasMaxLength(255);

                entity.Property(e => e.PreviousName).HasMaxLength(255);

                entity.Property(e => e.Sex).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.Username).HasMaxLength(255);
            });

            modelBuilder.Entity<Stagings>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.AlternativeEmail).HasMaxLength(250);

                entity.Property(e => e.CallToBar).HasColumnType("smalldatetime");

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.EnrollmentNumber).HasMaxLength(20);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Initials).HasMaxLength(50);

                entity.Property(e => e.IsSan).HasColumnName("IsSAN");

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.MobilePhone).HasMaxLength(100);

                entity.Property(e => e.Nbanumber)
                    .HasColumnName("NBANumber")
                    .HasMaxLength(20);

                entity.Property(e => e.OfficeName).HasMaxLength(250);

                entity.Property(e => e.PreviousName).HasMaxLength(250);

                entity.Property(e => e.Sex).HasMaxLength(50);

                entity.Property(e => e.StateOfOrigin).HasMaxLength(150);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Submitted).HasColumnType("datetime");

                entity.Property(e => e.SubmittedBy).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Email)
                    .HasName("users_email_unique")
                    .IsUnique();

                entity.HasIndex(e => e.Uuid)
                    .HasName("users_uuid_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.CountdownOtp).HasColumnName("countdown_otp");

                entity.Property(e => e.CountdownPass).HasColumnName("countdown_pass");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailVerifiedAt)
                    .HasColumnName("email_verified_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LastSeen).HasColumnName("last_seen");

                entity.Property(e => e.Otp)
                    .HasColumnName("otp")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(255);

                entity.Property(e => e.RememberToken)
                    .HasColumnName("remember_token")
                    .HasMaxLength(100);

                entity.Property(e => e.ThemeType)
                    .HasColumnName("theme_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Uuid).HasColumnName("uuid");
            });

            modelBuilder.Entity<VerifiedLists>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Branch).HasMaxLength(250);

                entity.Property(e => e.DoB).HasMaxLength(250);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.EnrollmentNo).HasMaxLength(250);

                entity.Property(e => e.NameChange).HasMaxLength(250);

                entity.Property(e => e.Names).HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(250);

                entity.Property(e => e.Section).HasMaxLength(250);

                entity.Property(e => e.Sex).HasMaxLength(20);

                entity.Property(e => e.StateOfOrigin).HasMaxLength(250);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

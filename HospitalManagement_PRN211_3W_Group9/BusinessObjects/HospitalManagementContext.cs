using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace BusinessObjects
{
    public partial class HospitalManagementContext : DbContext
    {
        public HospitalManagementContext()
        {
        }

        public HospitalManagementContext(DbContextOptions<HospitalManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<HospitalBill> HospitalBills { get; set; }
        public virtual DbSet<MedicineStorage> MedicineStorages { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PrescriptionDetail> PrescriptionDetails { get; set; }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
            var strConn = config["ConnectionStrings:HospitalManagement"];
            return strConn;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.HasIndex(e => e.DoctorId, "appointment_doctorid_index");

                entity.HasIndex(e => e.PatientId, "appointment_patientid_index");

                entity.Property(e => e.AppointmentId).HasColumnName("appointmentID");

                entity.Property(e => e.AppointedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("appointedDate");

                entity.Property(e => e.DoctorId).HasColumnName("doctorID");

                entity.Property(e => e.PatientId).HasColumnName("patientID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appointment_doctorid_foreign");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appointment_patientid_foreign");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("Doctor");

                entity.HasIndex(e => e.AccountId, "doctor_accountid_index");

                entity.Property(e => e.DoctorId).HasColumnName("doctorID");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.DoctorName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("doctorName");

                entity.Property(e => e.DoctorSpecialization)
                    .HasMaxLength(255)
                    .HasColumnName("doctorSpecialization");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctor_accountid_foreign");
            });

            modelBuilder.Entity<HospitalBill>(entity =>
            {
                entity.HasKey(e => e.BillId)
                    .HasName("hospital bill_billid_primary");

                entity.ToTable("Hospital Bill");

                entity.HasIndex(e => e.AppointmentId, "hospital bill_appointmentid_index");

                entity.Property(e => e.BillId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("billID");

                entity.Property(e => e.AppointmentId).HasColumnName("appointmentID");

                entity.Property(e => e.BillDate)
                    .HasColumnType("date")
                    .HasColumnName("billDate");

                entity.Property(e => e.TotalPrice).HasColumnName("totalPrice");

                entity.HasOne(d => d.Bill)
                    .WithOne(p => p.HospitalBill)
                    .HasForeignKey<HospitalBill>(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("hospital bill_billid_foreign");
            });

            modelBuilder.Entity<MedicineStorage>(entity =>
            {
                entity.HasKey(e => e.MedicineId)
                    .HasName("medicine storage_medicineid_primary");

                entity.ToTable("Medicine Storage");

                entity.Property(e => e.MedicineId).HasColumnName("medicineID");

                entity.Property(e => e.MedicineAmount).HasColumnName("medicineAmount");

                entity.Property(e => e.MedicineName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("medicineName");

                entity.Property(e => e.MedicinePrice).HasColumnName("medicinePrice");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.HasIndex(e => e.AccountId, "patient_accountid_index");

                entity.Property(e => e.PatientId).HasColumnName("patientID");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("dateOfBirth");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("patientName");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patient_accountid_foreign");
            });

            modelBuilder.Entity<PrescriptionDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Prescription Detail");

                entity.HasIndex(e => e.BillId, "prescription detail_billid_index");

                entity.HasIndex(e => e.MedicineId, "prescription detail_medicineid_index");

                entity.Property(e => e.BillId).HasColumnName("billID");

                entity.Property(e => e.MedicineId).HasColumnName("medicineID");

                entity.Property(e => e.PrescriptedAmount).HasColumnName("prescriptedAmount");

                entity.Property(e => e.PrescriptedDose)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prescriptedDose");

                entity.Property(e => e.PrescriptionDescription)
                    .HasMaxLength(255)
                    .HasColumnName("prescriptionDescription");

                entity.HasOne(d => d.Bill)
                    .WithMany()
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prescription detail_billid_foreign");

                entity.HasOne(d => d.Medicine)
                    .WithMany()
                    .HasForeignKey(d => d.MedicineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prescription detail_medicineid_foreign");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

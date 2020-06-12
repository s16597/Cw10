using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cw10.Models
{
    public partial class s16597Context : DbContext
    {
        public s16597Context()
        {
        }

        public s16597Context(DbContextOptions<s16597Context> options)
            : base(options)
        {
        }

        public static string ConnectionString
        {
            get;
            set;
        }

        public virtual DbSet<Dept> Dept { get; set; }
        public virtual DbSet<Emp> Emp { get; set; }
        public virtual DbSet<Enrollment> Enrollment { get; set; }
        public virtual DbSet<Mechanik> Mechanik { get; set; }
        public virtual DbSet<Obsluga> Obsluga { get; set; }
        public virtual DbSet<Osoba> Osoba { get; set; }
        public virtual DbSet<Pasazer> Pasazer { get; set; }
        public virtual DbSet<Pilot> Pilot { get; set; }
        public virtual DbSet<PilotTypSamolotu> PilotTypSamolotu { get; set; }
        public virtual DbSet<Przydzial> Przydzial { get; set; }
        public virtual DbSet<RejsLotniczy> RejsLotniczy { get; set; }
        public virtual DbSet<Rezerwacja> Rezerwacja { get; set; }
        public virtual DbSet<Salgrade> Salgrade { get; set; }
        public virtual DbSet<Samolot> Samolot { get; set; }
        public virtual DbSet<Serwis> Serwis { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Studies> Studies { get; set; }
        public virtual DbSet<TypSamolot> TypSamolot { get; set; }
        public virtual DbSet<Zaloga> Zaloga { get; set; }
        public virtual DbSet<ZalogaObsluga> ZalogaObsluga { get; set; }
        public virtual DbSet<ZalogaPilot> ZalogaPilot { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s16597;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEPT");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Dname)
                    .HasColumnName("DNAME")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Loc)
                    .HasColumnName("LOC")
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMP");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Empno).HasColumnName("EMPNO");

                entity.Property(e => e.Ename)
                    .HasColumnName("ENAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hiredate)
                    .HasColumnName("HIREDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Job)
                    .HasColumnName("JOB")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal).HasColumnName("SAL");
            });

            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasKey(e => e.IdEnrollment)
                    .HasName("Enrollment_pk");

                entity.Property(e => e.IdEnrollment).ValueGeneratedNever();

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.IdStudyNavigation)
                    .WithMany(p => p.Enrollment)
                    .HasForeignKey(d => d.IdStudy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Enrollment_Studies");
            });

            modelBuilder.Entity<Mechanik>(entity =>
            {
                entity.HasKey(e => e.IdMechanik)
                    .HasName("Mechanik_pk");

                entity.Property(e => e.IdMechanik)
                    .HasColumnName("Id_Mechanik")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.IdMechanikNavigation)
                    .WithOne(p => p.Mechanik)
                    .HasForeignKey<Mechanik>(d => d.IdMechanik)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Mechanik_Osoba");
            });

            modelBuilder.Entity<Obsluga>(entity =>
            {
                entity.HasKey(e => e.IdObsluga)
                    .HasName("Obsługa_pk");

                entity.Property(e => e.IdObsluga)
                    .HasColumnName("Id_Obsluga")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.IdObslugaNavigation)
                    .WithOne(p => p.Obsluga)
                    .HasForeignKey<Obsluga>(d => d.IdObsluga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Obsługa_Osoba");
            });

            modelBuilder.Entity<Osoba>(entity =>
            {
                entity.HasKey(e => e.IdOsoba)
                    .HasName("Osoba_pk");

                entity.Property(e => e.IdOsoba)
                    .HasColumnName("Id_Osoba")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adres)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pasazer>(entity =>
            {
                entity.HasKey(e => e.IdPasazer)
                    .HasName("Pasazer_pk");

                entity.Property(e => e.IdPasazer)
                    .HasColumnName("Id_Pasazer")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.IdPasazerNavigation)
                    .WithOne(p => p.Pasazer)
                    .HasForeignKey<Pasazer>(d => d.IdPasazer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Pasażer_Osoba");
            });

            modelBuilder.Entity<Pilot>(entity =>
            {
                entity.HasKey(e => e.IdPilot)
                    .HasName("Pilot_pk");

                entity.Property(e => e.IdPilot)
                    .HasColumnName("Id_Pilot")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdPilotKapitan).HasColumnName("Id_Pilot_Kapitan");

                entity.HasOne(d => d.IdPilotNavigation)
                    .WithOne(p => p.Pilot)
                    .HasForeignKey<Pilot>(d => d.IdPilot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Pilot_Osoba");

                entity.HasOne(d => d.IdPilotKapitanNavigation)
                    .WithMany(p => p.InverseIdPilotKapitanNavigation)
                    .HasForeignKey(d => d.IdPilotKapitan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Pilot_Pilot");
            });

            modelBuilder.Entity<PilotTypSamolotu>(entity =>
            {
                entity.HasKey(e => e.IdPilotTypSamolotu)
                    .HasName("Pilot_TypSamolotu_pk");

                entity.ToTable("Pilot_TypSamolotu");

                entity.Property(e => e.IdPilotTypSamolotu)
                    .HasColumnName("Id_PilotTypSamolotu")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdPilot).HasColumnName("Id_Pilot");

                entity.Property(e => e.IdTypSamolotu).HasColumnName("Id_TypSamolotu");

                entity.HasOne(d => d.IdPilotNavigation)
                    .WithMany(p => p.PilotTypSamolotu)
                    .HasForeignKey(d => d.IdPilot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Samolot_Pilot_Pilot");

                entity.HasOne(d => d.IdTypSamolotuNavigation)
                    .WithMany(p => p.PilotTypSamolotu)
                    .HasForeignKey(d => d.IdTypSamolotu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Samolot_Pilot_TypSamolotu");
            });

            modelBuilder.Entity<Przydzial>(entity =>
            {
                entity.HasKey(e => e.IdPrzydzial)
                    .HasName("Przydzial_pk");

                entity.Property(e => e.IdPrzydzial)
                    .HasColumnName("Id_Przydzial")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdRejsLotniczy).HasColumnName("Id_RejsLotniczy");

                entity.Property(e => e.IdZaloga).HasColumnName("Id_Zaloga");

                entity.HasOne(d => d.IdRejsLotniczyNavigation)
                    .WithMany(p => p.Przydzial)
                    .HasForeignKey(d => d.IdRejsLotniczy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Przydział_Odlot");

                entity.HasOne(d => d.IdZalogaNavigation)
                    .WithMany(p => p.Przydzial)
                    .HasForeignKey(d => d.IdZaloga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Przydział_Załoga");
            });

            modelBuilder.Entity<RejsLotniczy>(entity =>
            {
                entity.HasKey(e => e.IdRejsLotniczy)
                    .HasName("RejsLotniczy_pk");

                entity.Property(e => e.IdRejsLotniczy)
                    .HasColumnName("Id_RejsLotniczy")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataOdlotu).HasColumnType("date");

                entity.Property(e => e.Dokad)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GodzinaOdlotu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdSamolot).HasColumnName("Id_Samolot");

                entity.Property(e => e.NumerBramki)
                    .IsRequired()
                    .HasColumnName("Numer_bramki")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Skad)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSamolotNavigation)
                    .WithMany(p => p.RejsLotniczy)
                    .HasForeignKey(d => d.IdSamolot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RejsLotniczy_Samolot");
            });

            modelBuilder.Entity<Rezerwacja>(entity =>
            {
                entity.HasKey(e => e.IdRezerwacji)
                    .HasName("Rezerwacja_pk");

                entity.Property(e => e.IdRezerwacji)
                    .HasColumnName("Id_Rezerwacji")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdPasazer).HasColumnName("Id_Pasazer");

                entity.Property(e => e.IdRejsLotniczy).HasColumnName("Id_RejsLotniczy");

                entity.HasOne(d => d.IdPasazerNavigation)
                    .WithMany(p => p.Rezerwacja)
                    .HasForeignKey(d => d.IdPasazer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rezerwacja_Pasażer");

                entity.HasOne(d => d.IdRejsLotniczyNavigation)
                    .WithMany(p => p.Rezerwacja)
                    .HasForeignKey(d => d.IdRejsLotniczy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rezerwacja_Odlot");
            });

            modelBuilder.Entity<Salgrade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SALGRADE");

                entity.Property(e => e.Grade).HasColumnName("GRADE");

                entity.Property(e => e.Hisal).HasColumnName("HISAL");

                entity.Property(e => e.Losal).HasColumnName("LOSAL");
            });

            modelBuilder.Entity<Samolot>(entity =>
            {
                entity.HasKey(e => e.IdSamolot)
                    .HasName("Samolot_pk");

                entity.Property(e => e.IdSamolot)
                    .HasColumnName("Id_Samolot")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataProdukcji)
                    .HasColumnName("Data_Produkcji")
                    .HasColumnType("date");

                entity.Property(e => e.IdTypSamolotu).HasColumnName("Id_TypSamolotu");

                entity.HasOne(d => d.IdTypSamolotuNavigation)
                    .WithMany(p => p.Samolot)
                    .HasForeignKey(d => d.IdTypSamolotu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Samolot_TypSamolotu");
            });

            modelBuilder.Entity<Serwis>(entity =>
            {
                entity.HasKey(e => e.IdSerwis)
                    .HasName("Serwis_pk");

                entity.Property(e => e.IdSerwis)
                    .HasColumnName("Id_Serwis")
                    .ValueGeneratedNever();

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.IdMechanik).HasColumnName("Id_Mechanik");

                entity.Property(e => e.IdSamolot).HasColumnName("Id_Samolot");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Typ)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMechanikNavigation)
                    .WithMany(p => p.Serwis)
                    .HasForeignKey(d => d.IdMechanik)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Serwis_Mechanik");

                entity.HasOne(d => d.IdSamolotNavigation)
                    .WithMany(p => p.Serwis)
                    .HasForeignKey(d => d.IdSamolot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Serwis_Samolot");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.IndexNumber)
                    .HasName("Student_pk");

                entity.Property(e => e.IndexNumber).HasMaxLength(100);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RefreshToken)
                    .HasColumnName("Refresh_Token")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Salt).HasMaxLength(32);

                entity.HasOne(d => d.IdEnrollmentNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.IdEnrollment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Student_Enrollment");
            });

            modelBuilder.Entity<Studies>(entity =>
            {
                entity.HasKey(e => e.IdStudy)
                    .HasName("Studies_pk");

                entity.Property(e => e.IdStudy).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TypSamolot>(entity =>
            {
                entity.HasKey(e => e.IdTypSamolot)
                    .HasName("TypSamolot_pk");

                entity.Property(e => e.IdTypSamolot)
                    .HasColumnName("Id_TypSamolot")
                    .ValueGeneratedNever();

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Producent)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zaloga>(entity =>
            {
                entity.HasKey(e => e.IdZaloga)
                    .HasName("Zaloga_pk");

                entity.Property(e => e.IdZaloga)
                    .HasColumnName("Id_Zaloga")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ZalogaObsluga>(entity =>
            {
                entity.HasKey(e => e.IdZalogaObsluga)
                    .HasName("Zaloga_Obsluga_pk");

                entity.ToTable("Zaloga_Obsluga");

                entity.Property(e => e.IdZalogaObsluga)
                    .HasColumnName("Id_ZalogaObsluga")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdObsluga).HasColumnName("Id_Obsluga");

                entity.Property(e => e.IdZaloga).HasColumnName("Id_Zaloga");

                entity.HasOne(d => d.IdObslugaNavigation)
                    .WithMany(p => p.ZalogaObsluga)
                    .HasForeignKey(d => d.IdObsluga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Zaloga_Obsluga_Obsługa");

                entity.HasOne(d => d.IdZalogaNavigation)
                    .WithMany(p => p.ZalogaObsluga)
                    .HasForeignKey(d => d.IdZaloga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Zaloga_Obsluga_Zaloga");
            });

            modelBuilder.Entity<ZalogaPilot>(entity =>
            {
                entity.HasKey(e => e.IdZalogaPilot)
                    .HasName("Zaloga_Pilot_pk");

                entity.ToTable("Zaloga_Pilot");

                entity.Property(e => e.IdZalogaPilot)
                    .HasColumnName("Id_ZalogaPilot")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdPilot).HasColumnName("Id_Pilot");

                entity.Property(e => e.IdZaloga).HasColumnName("Id_Zaloga");

                entity.HasOne(d => d.IdPilotNavigation)
                    .WithMany(p => p.ZalogaPilot)
                    .HasForeignKey(d => d.IdPilot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Zaloga_Pilot_Pilot");

                entity.HasOne(d => d.IdZalogaNavigation)
                    .WithMany(p => p.ZalogaPilot)
                    .HasForeignKey(d => d.IdZaloga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Zaloga_Pilot_Zaloga");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

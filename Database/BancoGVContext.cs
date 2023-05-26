using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BancoGV.Database
{
    public partial class BancoGVContext : DbContext
    {
        public BancoGVContext()
        {
        }

        public BancoGVContext(DbContextOptions<BancoGVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Lancamento> Lancamento { get; set; } = null!;
        public virtual DbSet<LancamentoTipo> LancamentoTipos { get; set; } = null!;
        public virtual DbSet<LancamentoTipoNatureza> LancamentoTipoNaturezas { get; set; } = null!;
        public virtual DbSet<Operador> Operador { get; set; } = null!;
        public virtual DbSet<Titular> Titular { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=168.138.149.235;Database=BancoGV;Trusted_Connection=False;UID=bancogv;PWD=bancogv");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lancamento>(entity =>
            {
                entity.ToTable("Lancamentos");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.DataCriacao).HasColumnType("date");

                entity.Property(e => e.DataModificacao).HasColumnType("date");

                entity.Property(e => e.Nome).HasMaxLength(130);

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.HasOne(d => d.CriadoPorNavigation)
                    .WithMany(p => p.LancamentoCriadoPorNavigations)
                    .HasForeignKey(d => d.CriadoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lancamentos_Operadores");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.LancamentoModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lancamentos_Operadores1");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Lancamentos)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lancamentos_LancamentosTipo");

                entity.HasOne(d => d.TitularNavigation)
                    .WithMany(p => p.Lancamentos)
                    .HasForeignKey(d => d.Titular)
                    .HasConstraintName("FK_Lancamentos_Titulares");
            });

            modelBuilder.Entity<LancamentoTipo>(entity =>
            {
                entity.ToTable("LancamentosTipo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DataCriacao).HasColumnType("date");

                entity.Property(e => e.DataModificacao).HasColumnType("date");

                entity.Property(e => e.Natureza).ValueGeneratedOnAdd();

                entity.Property(e => e.Nome).HasMaxLength(130);

                entity.HasOne(d => d.CriadoPorNavigation)
                    .WithMany(p => p.LancamentosTipoCriadoPorNavigations)
                    .HasForeignKey(d => d.CriadoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LancamentosTipo_Operadores");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.LancamentosTipoModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LancamentosTipo_Operadores1");

                entity.HasOne(d => d.NaturezaNavigation)
                    .WithMany(p => p.LancamentosTipos)
                    .HasForeignKey(d => d.Natureza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LancamentosTipo_LancamentosTipoNatureza");
            });

            modelBuilder.Entity<LancamentoTipoNatureza>(entity =>
            {
                entity.ToTable("LancamentosTipoNatureza");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataCriacao).HasColumnType("date");

                entity.Property(e => e.DataModificacao).HasColumnType("date");

                entity.Property(e => e.Nome).HasMaxLength(130);

                entity.Property(e => e.SimboloOperacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CriadoPorNavigation)
                    .WithMany(p => p.LancamentosTipoNaturezaCriadoPorNavigations)
                    .HasForeignKey(d => d.CriadoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LancamentosTipoNatureza_Operadores");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.LancamentosTipoNaturezaModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LancamentosTipoNatureza_Operadores1");
            });

            modelBuilder.Entity<Operador>(entity =>
            {
                entity.ToTable("Operadores");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataCriacao).HasColumnType("date");

                entity.Property(e => e.DataModificacao).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CriadoPorNavigation)
                    .WithMany(p => p.InverseCriadoPorNavigation)
                    .HasForeignKey(d => d.CriadoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Operadores_Operadores");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.InverseModificadoPorNavigation)
                    .HasForeignKey(d => d.ModificadoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Operadores_Operadores1");
            });

            modelBuilder.Entity<Titular>(entity =>
            {
                entity.ToTable("Titulares");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cpfcnpj)
                    .HasMaxLength(11)
                    .HasColumnName("CPFCNPJ");

                entity.Property(e => e.DataCriacao).HasColumnType("date");

                entity.Property(e => e.DataModificacao).HasColumnType("date");

                entity.Property(e => e.Nome).HasMaxLength(40);

                entity.Property(e => e.Sobrenome).HasMaxLength(100);

                entity.HasOne(d => d.CriadoPorNavigation)
                    .WithMany(p => p.TitulareCriadoPorNavigations)
                    .HasForeignKey(d => d.CriadoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Titulares_Operadores");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.TitulareModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Titulares_Operadores1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using System.Collections.Generic;
using ConsoleAppDBFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppDBFirst.Infra;

public partial class FormationOumdinAcademyContext : DbContext
{
    public FormationOumdinAcademyContext()
    {
    }

    public FormationOumdinAcademyContext(DbContextOptions<FormationOumdinAcademyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TBonCommande> TBonCommandes { get; set; }

    public virtual DbSet<TCategorie> TCategories { get; set; }

    public virtual DbSet<TClient> TClients { get; set; }

    public virtual DbSet<TDetailCommande> TDetailCommandes { get; set; }

    public virtual DbSet<TProduit> TProduits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=FormationOumdinAcademy;User Id=sa;Password=Pass123@;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TBonCommande>(entity =>
        {
            entity.ToTable("T_BonCommande");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCommande).HasColumnName("dateCommande");
            entity.Property(e => e.EtatCommande).HasColumnName("etatCommande");
            entity.Property(e => e.IdClient).HasColumnName("_idClient");

            entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.TBonCommandes)
                .HasForeignKey(d => d.IdClient)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_T_BonCommande_T_Client");
        });

        modelBuilder.Entity<TCategorie>(entity =>
        {
            entity.ToTable("T_Categorie");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categorie)
                .HasMaxLength(50)
                .HasColumnName("categorie");
        });

        modelBuilder.Entity<TClient>(entity =>
        {
            entity.ToTable("T_Client");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Adresse)
                .HasMaxLength(50)
                .HasColumnName("adresse");
            entity.Property(e => e.Client)
                .HasMaxLength(50)
                .HasColumnName("client");
        });

        modelBuilder.Entity<TDetailCommande>(entity =>
        {
            entity.ToTable("T_DetailCommande");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdCommande).HasColumnName("_idCommande");
            entity.Property(e => e.IdProduit).HasColumnName("_idProduit");
            entity.Property(e => e.PrixUnitaire)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prixUnitaire");
            entity.Property(e => e.Qnt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("qnt");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.IdCommandeNavigation).WithMany(p => p.TDetailCommandes)
                .HasForeignKey(d => d.IdCommande)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_T_DetailCommande_T_BonCommande");

            entity.HasOne(d => d.IdProduitNavigation).WithMany(p => p.TDetailCommandes)
                .HasForeignKey(d => d.IdProduit)
                .HasConstraintName("FK_T_DetailCommande_T_Produit");
        });

        modelBuilder.Entity<TProduit>(entity =>
        {
            entity.ToTable("T_Produit");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeProduit)
                .HasMaxLength(50)
                .HasColumnName("codeProduit");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.IdCategorie).HasColumnName("_idCategorie");
            entity.Property(e => e.PrixUnitaire)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prixUnitaire");

            entity.HasOne(d => d.IdCategorieNavigation).WithMany(p => p.TProduits)
                .HasForeignKey(d => d.IdCategorie)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_T_Produit_T_Categorie");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

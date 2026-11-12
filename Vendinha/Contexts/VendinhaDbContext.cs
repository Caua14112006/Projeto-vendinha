using System;
using System.Collections.Generic;
using System.Text;
using Vendinha.Model;
using Microsoft.EntityFrameworkCore;

namespace Vendinha.Contexts
{
    public class VendinhaDbContext : DbContext 
    {
        private string? connectionString;

        public VendinhaDbContext(string? connString = null)
        {
            this.connectionString = connString;
        }

        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<Divida> Dividas => Set<Divida>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entityCliente = modelBuilder.Entity<Cliente>();
            //Mapeamento
            entityCliente.ToTable("clientes");
            entityCliente.Property(c => c.Codigo).HasColumnName("codigo");
            entityCliente.Property(c => c.Nome).HasColumnName("nome");
            entityCliente.Property(c => c.DataNascimento).HasColumnName("datanascimento");
            entityCliente.Property(c => c.Cpf).HasColumnName("cpf");
            entityCliente.Property(c => c.Email).HasColumnName("email");
            entityCliente.HasKey(c => c.Codigo);

            var entityDivida = modelBuilder.Entity<Divida>();
            entityDivida.ToTable("dividas");
            entityDivida.HasKey(d => d.Codigo);
            entityDivida.Property(d => d.Codigo).HasColumnName("codigo");
            entityDivida.Property(d => d.ClienteCodigo).HasColumnName("clientecodigo");
            entityDivida.Property(d => d.Valor).HasColumnName("valor");
            entityDivida.Property(d => d.Paga).HasColumnName("paga");
            entityDivida.Property(d => d.DataCriacao).HasColumnName("datacriacao");
            entityDivida.Property(d => d.DataPagamento).HasColumnName("datapagamento");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(connectionString))
            {
                optionsBuilder.UseNpgsql(connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

    }
}

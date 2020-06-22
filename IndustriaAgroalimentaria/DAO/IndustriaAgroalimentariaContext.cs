using IndustriaAgroalimentaria.Modelos;
using IndustriaAgroalimentaria.Modelos.ProductosCongelados;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriaAgroalimentaria.DAO
{
    class IndustriaAgroalimentariaContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=IndustriaAgroalimentaria;user=root;password=");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductoCongelado>().HasBaseType<Producto>();
            modelBuilder.Entity<ProductoFresco>().HasBaseType<Producto>();
            modelBuilder.Entity<ProductoRefrigerado>().HasBaseType<Producto>();
            modelBuilder.Entity<ProductoCongeladoAgua>().HasBaseType<ProductoCongelado>();
            modelBuilder.Entity<ProductoCongeladoAire>().HasBaseType<ProductoCongelado>();
            modelBuilder.Entity<ProductoCongeladoNitrogeno>().HasBaseType<ProductoCongelado>();

        }
    }
}

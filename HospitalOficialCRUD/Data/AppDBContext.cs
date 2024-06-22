using Microsoft.EntityFrameworkCore;
using HospitalOficialCRUD.Models;

namespace HospitalOficialCRUD.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        // Creacion de tablas:
        public DbSet<Pacientes> Pacientes { get; set; }

        // Especificacion de atributos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnConfiguring(optionsBuilder);

            modelBuilder.Entity<Pacientes>(table =>
            {
                table.HasKey(columna => columna.IdPaciente);

                table.Property(columna => columna.IdPaciente)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                table.Property(columna => columna.RutPaciente).HasMaxLength(15);
                table.Property(columna => columna.NombrePaciente).HasMaxLength(20);
                table.Property(columna => columna.ApellidoPaciente).HasMaxLength(20);
                //table.Property(columna => columna.NombrePaciente).HasMaxLength(20);
                //table.Property(columna => columna.NombrePaciente).HasMaxLength(20);

            });

            modelBuilder.Entity<Pacientes>().ToTable("Pacientes");
        }

    }
}

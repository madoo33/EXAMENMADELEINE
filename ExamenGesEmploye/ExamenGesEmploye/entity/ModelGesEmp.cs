namespace ExamenGesEmploye.entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelGesEmp : DbContext
    {
        public ModelGesEmp()
            : base("name=ModelGesEmp")
        {
        }

        public virtual DbSet<Employe> Employe { get; set; }
        public virtual DbSet<Service> Service { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employe>()
                .Property(e => e.NbreEnfants)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employe>()
                .Property(e => e.Ancienneté)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employe>()
                .HasOptional(e => e.Employe1)
                .WithRequired(e => e.Employe2);

            modelBuilder.Entity<Service>()
                .Property(e => e.Code)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Employe)
                .WithOptional(e => e.Service1)
                .HasForeignKey(e => e.Id_Service);
        }
    }
}

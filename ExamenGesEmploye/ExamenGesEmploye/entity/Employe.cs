namespace ExamenGesEmploye.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employe")]
    public partial class Employe
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Matricule { get; set; }

        [StringLength(50)]
        public string Prenom { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(50)]
        public string Sexe { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NbreEnfants { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Ancienneté { get; set; }

        public double? SalBase { get; set; }

        [StringLength(50)]
        public string Statut { get; set; }

        public double? PrimeSpecial { get; set; }

        public double? Prime { get; set; }

        public double? Ipres { get; set; }

        [StringLength(50)]
        public string Service { get; set; }

        public int? Id_Service { get; set; }

        public virtual Employe Employe1 { get; set; }

        public virtual Employe Employe2 { get; set; }

        public virtual Service Service1 { get; set; }
    }
}

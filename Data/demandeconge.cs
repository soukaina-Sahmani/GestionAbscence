//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionAbscences.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class demandeconge
    {
        [Required]
        public int idDemandeConge { get; set; }
        [Required]
        public Nullable<System.DateTime> DateDebut { get; set; }
        [Required]
        public Nullable<System.DateTime> DateFin { get; set; }
        [Required]
        public Nullable<System.DateTime> DateDC { get; set; }
        [Required]
        public string ValidationN1 { get; set; }
        [Required]
        public string ValidationN2 { get; set; }
        [Required]
        public int IdEmploye { get; set; }
        [Required]
        public int IdtypeConge { get; set; }
        [Required]

        public virtual employe employe { get; set; }
        [Required]
        public virtual typeconge typeconge { get; set; }
    }
}

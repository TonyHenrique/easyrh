//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinRH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Conhecimento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conhecimento()
        {
            this.Nota = 0;
        }
    
        public int id_Conhecimento { get; set; }
        public string Nome { get; set; }
        public int Nota { get; set; }

        
        [Column("Talento_id_Talento")]
        public int Talento_id_Talento { get; set; }
        public bool IsImportante { get; set; }

        [ForeignKey("Talento_id_Talento")]
        public virtual Talento Talento { get; set; }
    }
}

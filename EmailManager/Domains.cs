//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmailManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Domains
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Domains()
        {
            this.EmailDomains = new HashSet<EmailDomains>();
        }
    
        public int DomainID { get; set; }
        public string DomainName { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailDomains> EmailDomains { get; set; }
    }
}

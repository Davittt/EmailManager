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
    
    public partial class EmailRecipients
    {
        public int ID { get; set; }
        public Nullable<int> EmailID { get; set; }
        public Nullable<long> EmailHeaderID { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
    
        public virtual EmailHeader EmailHeader { get; set; }
        public virtual Emails Emails { get; set; }
    }
}
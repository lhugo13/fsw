//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SyC.CGRyF.AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPuucContadorPublico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPuucContadorPublico()
        {
            this.tblPuucContribuyentes = new HashSet<tblPuucContribuyente>();
        }
    
        public long id { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string rfc { get; set; }
        public string curp { get; set; }
        public string empresaRepresentada { get; set; }
        public Nullable<long> idDomicilio { get; set; }
        public string numeroRegistroCP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPuucContribuyente> tblPuucContribuyentes { get; set; }
    }
}

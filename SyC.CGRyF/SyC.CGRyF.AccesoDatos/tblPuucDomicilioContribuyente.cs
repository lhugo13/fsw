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
    
    public partial class tblPuucDomicilioContribuyente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPuucDomicilioContribuyente()
        {
            this.tblPuucRelDomicilioContribuyentes = new HashSet<tblPuucRelDomicilioContribuyente>();
        }
    
        public long id { get; set; }
        public long idAsentamientoHumano { get; set; }
        public Nullable<long> idCamino { get; set; }
        public Nullable<long> idCarretera { get; set; }
        public string descripcion { get; set; }
        public string numeroExterior1 { get; set; }
        public string numeroExterior2 { get; set; }
        public bool viaComunicacion { get; set; }
        public string vialidad { get; set; }
        public string vialidadPosterior { get; set; }
        public Nullable<long> tipoDomicilio { get; set; }
        public string entreVialidad1 { get; set; }
        public string entreVialidad2 { get; set; }
        public Nullable<long> idContribuyente { get; set; }
        public Nullable<int> tipoVialidad { get; set; }
        public string numeroInterior { get; set; }
        public Nullable<int> mismoDomicilio { get; set; }
        public Nullable<long> idLocalidadINEGI { get; set; }
    
        public virtual tblLocalidadINEGI tblLocalidadINEGI { get; set; }
        public virtual tblPuucContribuyente tblPuucContribuyente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPuucRelDomicilioContribuyente> tblPuucRelDomicilioContribuyentes { get; set; }
    }
}

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
    
    public partial class tblPuucContribuyente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPuucContribuyente()
        {
            this.tblACAsistencias = new HashSet<tblACAsistencia>();
            this.tblPuucDomicilioContribuyentes = new HashSet<tblPuucDomicilioContribuyente>();
            this.tblPuucRelContribuyenteCorreos = new HashSet<tblPuucRelContribuyenteCorreo>();
            this.tblPuucRelContribuyenteTelefonos = new HashSet<tblPuucRelContribuyenteTelefono>();
            this.tblPuucRelDomicilioContribuyentes = new HashSet<tblPuucRelDomicilioContribuyente>();
        }
    
        public long id { get; set; }
        public Nullable<long> idContadorPublico { get; set; }
        public string cuenta { get; set; }
        public bool estatus { get; set; }
        public bool granContribuyenteOrParaestatal { get; set; }
        public string nombreComercial { get; set; }
        public long tipoPersona { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string rfc { get; set; }
        public string curp { get; set; }
        public Nullable<long> idRepresentanteLegal { get; set; }
        public Nullable<long> idSubSector { get; set; }
        public Nullable<System.DateTime> fechaRegistro { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<bool> isInscritoREPDA { get; set; }
        public Nullable<bool> tieneFiel { get; set; }
        public string actividadPreponderante { get; set; }
        public Nullable<long> idSubRama { get; set; }
        public Nullable<bool> esCPR { get; set; }
        public Nullable<long> identificador { get; set; }
        public Nullable<int> preguntaSecreta { get; set; }
        public Nullable<bool> esRepresentante { get; set; }
        public string grupoEmpresarial { get; set; }
        public Nullable<long> countEnTramite { get; set; }
        public Nullable<long> countSinTitulo { get; set; }
        public Nullable<bool> privilegioEnvio { get; set; }
        public string nombreCompleto { get; set; }
        public Nullable<bool> aplicaFortamun { get; set; }
        public Nullable<bool> isCFE { get; set; }
        public string alias { get; set; }
        public Nullable<long> idSubTipoPersona { get; set; }
        public Nullable<bool> beneficiarioFiscal { get; set; }
        public string observaciones { get; set; }
        public Nullable<long> idClase { get; set; }
        public Nullable<long> idWallet { get; set; }
        public Nullable<bool> isMunicipal { get; set; }
        public bool validadoSAT { get; set; }
        public Nullable<long> idTipoSociedad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblACAsistencia> tblACAsistencias { get; set; }
        public virtual tblPuucContadorPublico tblPuucContadorPublico { get; set; }
        public virtual tblPuucRepresentanteLegal tblPuucRepresentanteLegal { get; set; }
        public virtual tblSubRama tblSubRama { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPuucDomicilioContribuyente> tblPuucDomicilioContribuyentes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPuucRelContribuyenteCorreo> tblPuucRelContribuyenteCorreos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPuucRelContribuyenteTelefono> tblPuucRelContribuyenteTelefonos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPuucRelDomicilioContribuyente> tblPuucRelDomicilioContribuyentes { get; set; }
    }
}

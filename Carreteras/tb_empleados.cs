//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Carreteras
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_empleados()
        {
            this.tb_empleadosXusuarios = new HashSet<tb_empleadosXusuarios>();
        }
    
        public string emp_id { get; set; }
        public string emp_nombre { get; set; }
        public Nullable<int> emp_edad { get; set; }
        public string emp_telefono { get; set; }
        public string ciu_id { get; set; }
        public string emp_usuario_crea { get; set; }
        public Nullable<System.DateTime> emp_fecha_crea { get; set; }
        public string emp_usuario_modifica { get; set; }
        public Nullable<System.DateTime> emp_fecha_modifica { get; set; }
        public Nullable<bool> emp_estado { get; set; }
    
        public virtual tb_ciudades tb_ciudades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_empleadosXusuarios> tb_empleadosXusuarios { get; set; }
        public virtual tb_usuarios tb_usuarios { get; set; }
        public virtual tb_usuarios tb_usuarios1 { get; set; }
    }
}

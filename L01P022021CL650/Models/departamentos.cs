using System.ComponentModel.DataAnnotations;

namespace L01P022021CL650.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Departamentos")]
        public string? departamento { get; set; }
        
    }
}

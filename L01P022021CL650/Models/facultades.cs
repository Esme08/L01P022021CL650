using System.ComponentModel.DataAnnotations;


namespace L01P022021CL650.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Facultad")]
        public string? facultad { get; set; }
    }
}

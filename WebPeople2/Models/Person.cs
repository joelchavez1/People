using System.ComponentModel.DataAnnotations;

namespace WebPeople2.Models
{
    public enum SexType
    {
      Female = 0,
      Male =1,
    }
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [StringLength(60, MinimumLength = 5, ErrorMessage ="El nombre debe contener entre 5 a 60 caracteres")]
        [Display(Name="Nombre completo de la persona")]
        public string Name { get; set; }
        [Required]
        [Display(Name= "Sexo")]
        public SexType Sex { get; set; }
        [Display(Name= "Pasatiempos")]
        public string Hobbie { get; set; }
 
    }
}

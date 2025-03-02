using System.ComponentModel.DataAnnotations;

namespace DesignPatternAsp.Models.ViewModels
{
    public class FormBeerViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public required string Name { get; set; }

        [Display(Name = "Marca")]
        public Guid? BrandId { get; set; }

        [Display(Name = "Otra Brand")]
        public string? OtherBrand { get; set; }  
    }
}

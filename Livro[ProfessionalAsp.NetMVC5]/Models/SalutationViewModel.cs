using System.ComponentModel.DataAnnotations;

namespace Livro_ProfessionalAsp.NetMVC5_.Models
{
    public class SalutationViewModel
    {
        [UIHint("Enum-radio")]
        public Salutation Salutation { get; set; }
    }
}
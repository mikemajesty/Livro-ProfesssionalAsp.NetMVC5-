using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Livro_ProfessionalAsp.NetMVC5_.Models
{
    public enum Salutation
    {
        [Display(Name = "Senhor")]
        Sr,
        [Display(Name = "Senhorita")]
        Srs,
        [Display(Name ="Tiozinho")]
        Tio
    }
}
using Livro_ProfessionalAsp.NetMVC5_.Properties;
using Livro_ProfessionalAsp.NetMVC5_.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Livro_ProfessionalAsp.NetMVC5_.Models
{
    public class Order : IValidatableObject
    {
        [Key]      
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        [Remote("CheckUserName", "Order", ErrorMessage = "Usuário já esta cadastrado no banco")]
        public string Username { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(maximumLength: 160, MinimumLength = 3)]
        [Display(Name = "First Name", Order = 15000)]
        public string FirstName { get; set; }
        [StringLength(maximumLength: 160, MinimumLength = 3)]
        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "Last Name", Order = 15001)]
        public string LastName { get; set; }
        [Required(ErrorMessageResourceType = typeof(Properties.Resources),
        ErrorMessageResourceName = "ErrorMessages")]
        [StringLength(160, ErrorMessageResourceType = typeof(Properties.Resources),
        ErrorMessageResourceName = "LastNameRequired")]
        public string Address { get; set; }
        [MaxWords(10)]
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        public decimal Total { get; set; }
        [NotMapped]
        [ScaffoldColumn(false)]
        public List<OrderDetail> OrderDetails { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (LastName != null &&LastName.Length > 10)
            {
                yield return new ValidationResult("The last name has too many words!",
                                                 new[] { "LastName" });
            }
        }

        //[Range(35,44)]  /////////////// Exemplo de validação de valores inteiros.
        //public int Age { get; set; ///

        //[Range(typeof(decimal), "0.00", "49.99")]/// exemplo com valores decimais.
        //public decimal Price { get; set; }/////////

        //[Range(typeof(DateTime), "10/10/2014", "10/10/2015")]// exemplo com datas.
        //public DateTime Date { get; set; }////////////////////

        //[Range(typeof(double), "0.00", "150.00")]// exemplo com datas.
        //public double Bargain { get; set; }////////////////////

        //[Range(typeof(char), "a", "c")]// exemplo com datas.
        //public decimal Price { get; set; }////////////////////

    }
}
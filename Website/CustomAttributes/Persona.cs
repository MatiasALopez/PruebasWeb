using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Website.CustomAttributes
{
    public class Persona : IValidatableObject
    {
        public int PersonaId { get; set; }

        [MiValidacion]
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        
        [Required,CUIT(ErrorMessage="CUIT inválido.")]
        public string CUIT { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //  por ahora nada
            return new List<ValidationResult>();
        }

        public void Validar()
        {
            var res = new List<ValidationResult>();
            if (!Validator.TryValidateObject(this, new ValidationContext(this), res))
                throw new Exception(string.Join(Environment.NewLine, res.Select(v => v.ErrorMessage)));
        }
    }

    public sealed class MiValidacionAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return base.IsValid(value);
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }
    }
}
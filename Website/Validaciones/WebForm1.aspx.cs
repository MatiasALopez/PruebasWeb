using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website.Validaciones
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private List<ValidationResult> Validar(Persona persona)
        {
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(persona, new ValidationContext(persona), results, true);
            return results;
        }

        public void fvPersona_InsertItem()
        {
            var ahora = DateTime.Now;
            string usuario = "usuario";
            var item = new Persona 
            { 
                Id = Guid.NewGuid(), 
                Creado = ahora, 
                CreadoPor = usuario,
                Modificado = ahora
            };
            
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                //
            }
        }
    }

    public class Persona
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Debe especificar el nombre de la persona.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "El nombre de la persona debe tener entre 1 y 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe especificar el apellido de la persona.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "El apellido de la persona debe tener entre 1 y 100 caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Debe especificar la fecha de nacimiento de la persona.")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Debe especificar el nivel de la persona.")]
        [Range(1, 10, ErrorMessage = "El nivel de la persona debe ser un entero entre 1 y 10.")]
        public int Nivel { get; set; }

        [Required(ErrorMessage = "Debe especificar si la persona está activa o no.")]
        public bool EstaActivo { get; set; }

        [Required(ErrorMessage = "Debe especificar la fecha de creación de la persona.")]
        public DateTime Creado { get; set; }

        [Required(ErrorMessage = "Debe especificar el usuario que creó la persona.")]
        public string CreadoPor { get; set; }

        [Required(ErrorMessage = "Debe especificar la fecha de la última modificación de la persona.")]
        public DateTime Modificado { get; set; }

        public DateTime? Eliminado { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "El nombre del usuario que eliminó la persona debe tener entre 1 y 50 caracteres.")]
        public string EliminadoPor { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var ahora = DateTime.Now;
            if (Creado > ahora)
                yield return new ValidationResult("La fecha/hora de creación de la persona no puede ser posterior a la fecha/hora actual.", new string[] { "Creado" });

            if (Modificado > ahora)
                yield return new ValidationResult("La fecha/hora de la última modificación de la persona no puede ser posterior a la fecha/hora actual.", new string[] { "Modificado" });

            if (Eliminado > ahora)
                yield return new ValidationResult("La fecha/hora de eliminación de la persona no puede ser posterior a la fecha/hora actual.", new string[] { "Eliminado" });

            if (Modificado < Creado)
                yield return new ValidationResult("La fecha/hora de modificación de la persona no puede ser posterior a la fecha/hora de creación.", new string[] { "Modificado", "Creado" });

            if (Eliminado < Creado)
                yield return new ValidationResult("La fecha/hora de eliminación de la persona no puede ser posterior a la fecha/hora de creación.", new string[] { "Eliminado", "Creado" });

            if (Eliminado.HasValue && string.IsNullOrWhiteSpace(EliminadoPor))
                yield return new ValidationResult("Ha especificado la fecha/hora de eliminación pero no el usuario que lo eliminó.", new string[] { "Eliminado", "EliminadoPor" });

            if (!Eliminado.HasValue && !string.IsNullOrWhiteSpace(EliminadoPor))
                yield return new ValidationResult("Ha especificado el usuario que eliminó el usuario pero no la fecha/hora de eliminación.", new string[] { "Eliminado", "EliminadoPor" });
        }
    }
}
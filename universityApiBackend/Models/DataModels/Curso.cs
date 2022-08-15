using System.ComponentModel.DataAnnotations;

namespace universityApiBackend.Models.DataModels
{
    public class Curso
    {
        public enum Niveles  {Basico = 0, Intermedio = 1, Avanzado = 2};

        [Required, StringLength(int.MaxValue)]
        public string Nombre { get; set; } = string.Empty; 

        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;
        
        [Required]
        public string PublicoObjetivo { get; set; } = string.Empty;
        
        [Required]
        public string Objetivos { get; set; } = string.Empty;
        
        [Required]
        public string Requisitos { get; set; } = string.Empty;

        [Required]
        public Niveles Nivel { get; set; } = Niveles.Basico;

    }
}

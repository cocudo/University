using System.ComponentModel.DataAnnotations;

namespace universityApiBackend.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = String.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } =  string.Empty;
        public DateTime? UpdatedDate { get; set; }
        public string DeletedBy { get; set; } = String.Empty;
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}

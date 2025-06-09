using System.ComponentModel.DataAnnotations;

namespace Day8.Models
{
    public class QdhEmployee
    {
        [Key]
        public int QdhId { get; set; }

        [Required]
        [StringLength(100)]
        public string QdhName { get; set; }

        [DataType(DataType.Date)]
        public DateTime QdhBirthDay { get; set; }

        [EmailAddress]
        public string QdhEmail { get; set; }

        [Phone]
        public string QdhPhone { get; set; }

        [Range(0, double.MaxValue)]
        public decimal QdhSalay { get; set; }

        public bool QdhStatus { get; set; }
    }
}

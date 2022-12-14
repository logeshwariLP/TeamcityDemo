using System.ComponentModel.DataAnnotations;

namespace GenerateCifApi.Models
{
    public class CifUser
    {
        [Key]
        public int CifId { get; set; }
        [Required]
        public string emailId { get; set; }
    }
}

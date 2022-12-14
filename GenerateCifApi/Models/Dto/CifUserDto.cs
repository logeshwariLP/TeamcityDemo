using System.ComponentModel.DataAnnotations;

namespace GenerateCifApi.Models.Dto
{
    public class CifUserDto
    {       
        public int CifId { get; set; }
        
        public string emailId { get; set; }
    }
}

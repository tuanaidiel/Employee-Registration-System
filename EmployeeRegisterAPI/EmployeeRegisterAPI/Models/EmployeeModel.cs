using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace EmployeeRegisterAPI.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeID { get; set; }


        [Required]
        [Column (TypeName = "nvarchar(50)")]
        public string? EmployeeName {get; set; }


        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string? Occupation { get; set; }


        [Required]
        [Column(TypeName = "decimal(3,2)")]
        public decimal CGPA { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string? ImageName { get; set; }


      



        [NotMapped] // Prevents this from being mapped to the database
        public IFormFile? ImageFile { get; set; }

        [NotMapped]
        public string? ImageSrc { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace EFLibrary.Entity
{
    public class Person:BaseEntity
    {
        [Required]
        [StringLength(10, ErrorMessage = "字数不能超过10个字符")]
        public string Name { get; set; }

        [Required]
        public string EnglishName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
}

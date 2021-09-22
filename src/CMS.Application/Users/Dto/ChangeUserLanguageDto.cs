using System.ComponentModel.DataAnnotations;

namespace CMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}